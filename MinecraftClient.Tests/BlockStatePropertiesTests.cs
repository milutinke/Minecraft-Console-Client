using MinecraftClient.Mapping;
using MinecraftClient.Mapping.BlockPalettes;

namespace MinecraftClient.Tests;

public sealed class BlockStatePropertiesTests
{
    private readonly Palette262 _palette = new();

    [Theory]
    [InlineData(32162, "north", "true", "inactive")]
    [InlineData(32168, "north", "false", "unlocking")]
    [InlineData(32193, "east", "false", "ejecting")]
    public void VaultStatesExposeAllProperties(
        int stateId,
        string facing,
        string ominous,
        string vaultState)
    {
        IReadOnlyDictionary<string, string> properties = _palette.GetStateProperties(stateId);

        Assert.Equal(facing, properties["facing"]);
        Assert.Equal(ominous, properties["ominous"]);
        Assert.Equal(vaultState, properties["vault_state"]);
    }

    [Fact]
    public void PropertiesUseServerReportedStateStride()
    {
        IReadOnlyDictionary<string, string> properties = _palette.GetStateProperties(3989);

        Assert.Equal("left", properties["type"]);
        Assert.Equal("north", properties["facing"]);
        Assert.Equal("true", properties["waterlogged"]);
    }

    [Fact]
    public void StateWithoutPropertiesReturnsEmptyMap()
    {
        IReadOnlyDictionary<string, string> properties = _palette.GetStateProperties(1);

        Assert.Empty(properties);
    }

    public static TheoryData<string, BlockPalette> ModernPalettes => new()
    {
        { "1.13.2", new Palette113() },
        { "1.14.4", new Palette114() },
        { "1.15.2", new Palette115() },
        { "1.16.5", new Palette116() },
        { "1.17.1", new Palette117() },
        { "1.19.2", new Palette119() },
        { "1.19.3", new Palette1193() },
        { "1.19.4", new Palette1194() },
        { "1.20", new Palette120() },
        { "1.20.4", new Palette1204() },
        { "1.20.6", new Palette1206() },
        { "1.21.2", new Palette1212() },
        { "1.21.4", new Palette1214() },
        { "1.21.5", new Palette1215() },
        { "1.21.6", new Palette1216() },
        { "1.21.9", new Palette1219() },
        { "26.1", new Palette261() },
        { "26.2", new Palette262() }
    };

    [Theory]
    [MemberData(nameof(ModernPalettes))]
    public void EveryModernPaletteExposesOakLogAxis(string version, BlockPalette palette)
    {
        bool foundExpectedState = false;

        for (int stateId = 0; stateId <= ushort.MaxValue; stateId++)
        {
            if (palette.FromId(stateId) != Material.OakLog)
                continue;

            IReadOnlyDictionary<string, string> properties = palette.GetStateProperties(stateId);
            if (properties.TryGetValue("axis", out string? axis) && axis == "x")
            {
                foundExpectedState = true;
                break;
            }
        }

        Assert.True(foundExpectedState, $"Minecraft {version} did not expose oak_log[axis=x]");
    }

    [Fact]
    public void LegacyPaletteExposesPackedMetadata()
    {
        BlockPalette previousPalette = Block.Palette;
        try
        {
            Block.Palette = new Palette112();
            Block block = new(17, 4);

            IReadOnlyDictionary<string, string> properties = block.GetStateProperties();

            Assert.Equal(276, block.StateId);
            Assert.Equal("4", properties["metadata"]);
        }
        finally
        {
            Block.Palette = previousPalette;
        }
    }
}
