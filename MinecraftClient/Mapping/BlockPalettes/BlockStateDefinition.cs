using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MinecraftClient.Mapping.BlockPalettes
{
    /// <summary>
    /// Compact description of the property combinations in a contiguous block-state range.
    /// </summary>
    public sealed class BlockStateDefinition
    {
        private static readonly IReadOnlyDictionary<string, string> s_emptyProperties =
            new ReadOnlyDictionary<string, string>(new Dictionary<string, string>());

        private readonly BlockStatePropertyDefinition[] _properties;
        public int FirstStateId { get; }
        public int LastStateId { get; }
        public static IReadOnlyDictionary<string, string> EmptyProperties => s_emptyProperties;

        public BlockStateDefinition(int firstStateId, int stateCount, BlockStatePropertyDefinition[] properties)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(firstStateId);
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(stateCount);
            ArgumentNullException.ThrowIfNull(properties);

            FirstStateId = firstStateId;
            LastStateId = checked(firstStateId + stateCount - 1);
            _properties = properties;
        }

        public IReadOnlyDictionary<string, string> GetProperties(int stateId)
        {
            if (stateId < FirstStateId || stateId > LastStateId)
                return EmptyProperties;

            int offset = stateId - FirstStateId;
            Dictionary<string, string> result = new(_properties.Length, StringComparer.Ordinal);
            for (int i = 0; i < _properties.Length; i++)
            {
                BlockStatePropertyDefinition property = _properties[i];
                int valueIndex = (offset / property.Stride) % property.Values.Length;
                result[property.Name] = property.Values[valueIndex];
            }

            return result;
        }
    }

    /// <summary>
    /// Property name and its values in Minecraft's block-state iteration order.
    /// </summary>
    public sealed class BlockStatePropertyDefinition
    {
        public string Name { get; }
        public string[] Values { get; }
        public int Stride { get; }

        public BlockStatePropertyDefinition(string name, string[] values, int stride)
        {
            ArgumentException.ThrowIfNullOrEmpty(name);
            ArgumentNullException.ThrowIfNull(values);
            if (values.Length == 0)
                throw new ArgumentException("A block-state property must define at least one value.", nameof(values));
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(stride);

            Name = name;
            Values = values;
            Stride = stride;
        }
    }
}
