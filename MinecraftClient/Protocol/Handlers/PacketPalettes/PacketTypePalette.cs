using System.Collections.Frozen;
using System.Collections.Generic;

namespace MinecraftClient.Protocol.Handlers.PacketPalettes
{
    /// <summary>
    /// Packet type palette
    /// </summary>
    /// <remarks>
    /// Steps for implementing palette for new Minecraft version:
    /// 1. Check out https://wiki.vg/Pre-release_protocol to see if there is any packet got added/removed
    /// 2. Add new packet type to PacketTypesIn.cs and PacketTypesOut.cs (if any)
    /// 3. Create a new PacketPaletteXXX.cs by copying the latest version of existing PacketPaletteXXX.cs (could reduce massive works on writing a brand new one)
    /// 4. Apply change to the copied PacketPaletteXXX.cs by either:
    ///     - Inserting new packet type to the correct position
    ///     - Removing packet type that got deleted
    ///    OR
    ///     - Changing the packet IDs manually
    /// 5. Use PacketPaletteHelper to generate a code snippet and copy the generated code snippet back to PacketPaletteXXX.cs
    ///     - Use UpdatePacketPositionToAscending() if you changed the packet IDs manually
    ///     - Use UpdatePacketIdByItemPosition() if you inserted some packet type into the dictionary
    ///    Simply add the method call in Program.cs and run the program once. The code snippet will be generated
    /// 
    /// 
    /// The way how Mojang change the packet ID is simple: 
    ///  * Either adding/removing a packet from middle and cause packet ID below it get shifted
    ///  * Append a new packet at the end (but this is rare)
    /// </remarks>
    public abstract class PacketTypePalette
    {
        protected abstract Dictionary<int, PacketTypesIn> GetListIn();
        protected abstract Dictionary<int, PacketTypesOut> GetListOut();
        protected abstract Dictionary<int, ConfigurationPacketTypesIn> GetConfigurationListIn();
        protected abstract Dictionary<int, ConfigurationPacketTypesOut> GetConfigurationListOut();

        // Frozen for optimal read performance on per-packet lookup paths
        private readonly FrozenDictionary<int, PacketTypesIn> frozenListIn;
        private readonly FrozenDictionary<int, PacketTypesOut> frozenListOut;
        private readonly FrozenDictionary<int, ConfigurationPacketTypesIn> frozenConfigListIn;
        private readonly FrozenDictionary<int, ConfigurationPacketTypesOut> frozenConfigListOut;

        private readonly FrozenDictionary<PacketTypesIn, int> reverseMappingIn;
        private readonly FrozenDictionary<PacketTypesOut, int> reverseMappingOut;
        private readonly FrozenDictionary<ConfigurationPacketTypesIn, int> configurationReverseMappingIn;
        private readonly FrozenDictionary<ConfigurationPacketTypesOut, int> configurationReverseMappingOut;

        private bool forgeEnabled = false;

        public PacketTypePalette()
        {
            // Freeze forward-lookup dictionaries for per-packet hot-path reads
            frozenListIn = GetListIn().ToFrozenDictionary();
            frozenListOut = GetListOut().ToFrozenDictionary();
            frozenConfigListIn = GetConfigurationListIn().ToFrozenDictionary();
            frozenConfigListOut = GetConfigurationListOut().ToFrozenDictionary();

            // Build and freeze reverse mappings
            var revIn = new Dictionary<PacketTypesIn, int>();
            foreach (var p in GetListIn())
                revIn.Add(p.Value, p.Key);

            var revOut = new Dictionary<PacketTypesOut, int>();
            foreach (var p in GetListOut())
                revOut.Add(p.Value, p.Key);

            var revConfigIn = new Dictionary<ConfigurationPacketTypesIn, int>();
            foreach (var p in GetConfigurationListIn())
                revConfigIn.Add(p.Value, p.Key);

            var revConfigOut = new Dictionary<ConfigurationPacketTypesOut, int>();
            foreach (var p in GetConfigurationListOut())
                revConfigOut.Add(p.Value, p.Key);

            reverseMappingIn = revIn.ToFrozenDictionary();
            reverseMappingOut = revOut.ToFrozenDictionary();
            configurationReverseMappingIn = revConfigIn.ToFrozenDictionary();
            configurationReverseMappingOut = revConfigOut.ToFrozenDictionary();
        }

        /// <summary>
        /// Get incoming packet type by packet ID
        /// </summary>
        /// <param name="packetId">packet ID</param>
        /// <returns>Packet type</returns>
        public PacketTypesIn GetIncomingTypeById(int packetId)
        {
            if (frozenListIn.TryGetValue(packetId, out var p))
            {
                return p;
            }
            else if (forgeEnabled)
            {
                if (Settings.Config.Logging.DebugMessages)
                    ConsoleIO.WriteLogLine("Ignoring unknown packet ID of 0x" + packetId.ToString("X2"));
                return PacketTypesIn.Unknown;
            }
            else
                throw new KeyNotFoundException("Packet ID of 0x" + packetId.ToString("X2") + " doesn't exist!");
        }

        /// <summary>
        /// Get incoming packet ID by packet type
        /// </summary>
        /// <param name="packetType">Packet type</param>
        /// <returns>packet ID</returns>
        public int GetIncomingIdByType(PacketTypesIn packetType) => reverseMappingIn[packetType];

        /// <summary>
        /// Get incoming configuration packet type by packet ID
        /// </summary>
        /// <param name="packetId">packet ID</param>
        /// <returns>Packet type</returns>
        public ConfigurationPacketTypesIn GetIncomingConfigurationTypeById(int packetId)
        {
            if (frozenConfigListIn.TryGetValue(packetId, out var p))
            {
                return p;
            }
            else if (forgeEnabled)
            {
                if (Settings.Config.Logging.DebugMessages)
                    ConsoleIO.WriteLogLine("Ignoring unknown packet ID of 0x" + packetId.ToString("X2"));
                return ConfigurationPacketTypesIn.Unknown;
            }
            else
                throw new KeyNotFoundException("Configuration Packet ID of 0x" + packetId.ToString("X2") +
                                               " doesn't exist!");
        }

        /// <summary>
        /// Get incoming packet ID by packet type for configuration packets
        /// </summary>
        /// <param name="packetType">Packet type</param>
        /// <returns>packet ID</returns>
        public int GetIncomingIdByType(ConfigurationPacketTypesIn packetType) =>
            configurationReverseMappingIn[packetType];

        /// <summary>
        /// Get outgoing packet type by packet ID
        /// </summary>
        /// <param name="packetId">Packet ID</param>
        /// <returns>Packet type</returns>
        public PacketTypesOut GetOutgoingTypeById(int packetId)
        {
            if (frozenListOut.TryGetValue(packetId, out var p))
            {
                return p;
            }
            else if (forgeEnabled)
            {
                if (Settings.Config.Logging.DebugMessages)
                    ConsoleIO.WriteLogLine("Ignoring unknown packet ID of 0x" + packetId.ToString("X2"));
                return PacketTypesOut.Unknown;
            }
            else
                throw new KeyNotFoundException("Packet ID of 0x" + packetId.ToString("X2") + " doesn't exist!");
        }

        /// <summary>
        /// Get outgoing packet ID by packet type
        /// </summary>
        /// <param name="packetType">Packet type</param>
        /// <returns>Packet ID</returns>
        public int GetOutgoingIdByType(PacketTypesOut packetType) => reverseMappingOut[packetType];

        /// <summary>
        /// Get outgoing configuration packet type by packet ID
        /// </summary>
        /// <param name="packetId">Packet ID</param>
        /// <returns>Packet type</returns>
        public ConfigurationPacketTypesOut GetOutgoingConfigurationTypeById(int packetId)
        {
            if (frozenConfigListOut.TryGetValue(packetId, out var p))
            {
                return p;
            }
            else if (forgeEnabled)
            {
                if (Settings.Config.Logging.DebugMessages)
                    ConsoleIO.WriteLogLine("Ignoring unknown packet ID of 0x" + packetId.ToString("X2"));
                return ConfigurationPacketTypesOut.Unknown;
            }
            else
                throw new KeyNotFoundException("Configuration Packet ID of 0x" + packetId.ToString("X2") +
                                               " doesn't exist!");
        }

        /// <summary>
        /// Get outgoing packet ID by packet type for configuration packets
        /// </summary>
        /// <param name="packetType">Packet type</param>
        /// <returns>Packet ID</returns>
        public int GetOutgoingIdByTypeConfiguration(ConfigurationPacketTypesOut packetType) =>
            configurationReverseMappingOut[packetType];

        /// <summary>
        /// Public method for getting the type mapping
        /// </summary>
        /// <returns>PacketTypesIn with packet ID as index</returns>
        public Dictionary<int, PacketTypesIn> GetMappingIn() => GetListIn();

        /// <summary>
        /// Public method for getting the type mapping
        /// </summary>
        /// <returns>PacketTypesOut with packet ID as index</returns>
        public Dictionary<int, PacketTypesOut> GetMappingOut() => GetListOut();

        /// <summary>
        /// Public method for getting the type mapping for configuration packets
        /// </summary>
        /// <returns>PacketTypesIn with packet ID as index</returns>
        public Dictionary<int, ConfigurationPacketTypesIn> GetMappingInConfiguration() => GetConfigurationListIn();

        /// <summary>
        /// Public method for getting the type mapping for configuration packets
        /// </summary>
        /// <returns>PacketTypesOut with packet ID as index</returns>
        public Dictionary<int, ConfigurationPacketTypesOut> GetMappingOutConfiguration() => GetConfigurationListOut();

        /// <summary>
        /// Enable forge or disable forge
        /// </summary>
        /// <remarks>
        /// Have a rare chance that forge mod may modify packet ID.
        /// Ignore packet type not found when forge enabled to
        /// prevent program crash.
        /// </remarks>
        /// <param name="enabled"></param>
        public void SetForgeEnabled(bool enabled)
        {
            forgeEnabled = enabled;
        }
    }
}