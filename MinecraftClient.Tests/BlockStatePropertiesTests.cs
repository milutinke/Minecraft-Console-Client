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
}
