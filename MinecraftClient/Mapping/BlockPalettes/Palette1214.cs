using System.Collections.Generic;

namespace MinecraftClient.Mapping.BlockPalettes
{
    public class Palette1214 : BlockPalette
    {
        private static readonly Dictionary<int, Material> materials = new();

        static Palette1214()
        {
            for (int i = 9482; i <= 9505; i++)
                materials[i] = Material.AcaciaButton;
            for (int i = 12963; i <= 13026; i++)
                materials[i] = Material.AcaciaDoor;
            for (int i = 12579; i <= 12610; i++)
                materials[i] = Material.AcaciaFence;
            for (int i = 12291; i <= 12322; i++)
                materials[i] = Material.AcaciaFenceGate;
            for (int i = 5121; i <= 5184; i++)
                materials[i] = Material.AcaciaHangingSign;
            for (int i = 364; i <= 391; i++)
                materials[i] = Material.AcaciaLeaves;
            for (int i = 148; i <= 150; i++)
                materials[i] = Material.AcaciaLog;
            materials[19] = Material.AcaciaPlanks;
            for (int i = 5891; i <= 5892; i++)
                materials[i] = Material.AcaciaPressurePlate;
            for (int i = 37; i <= 38; i++)
                materials[i] = Material.AcaciaSapling;
            for (int i = 4453; i <= 4484; i++)
                materials[i] = Material.AcaciaSign;
            for (int i = 12065; i <= 12070; i++)
                materials[i] = Material.AcaciaSlab;
            for (int i = 10683; i <= 10762; i++)
                materials[i] = Material.AcaciaStairs;
            for (int i = 6386; i <= 6449; i++)
                materials[i] = Material.AcaciaTrapdoor;
            for (int i = 5721; i <= 5728; i++)
                materials[i] = Material.AcaciaWallHangingSign;
            for (int i = 4873; i <= 4880; i++)
                materials[i] = Material.AcaciaWallSign;
            for (int i = 213; i <= 215; i++)
                materials[i] = Material.AcaciaWood;
            for (int i = 10119; i <= 10142; i++)
                materials[i] = Material.ActivatorRail;
            materials[0] = Material.Air;
            materials[2122] = Material.Allium;
            materials[22044] = Material.AmethystBlock;
            for (int i = 22046; i <= 22057; i++)
                materials[i] = Material.AmethystCluster;
            materials[20461] = Material.AncientDebris;
            materials[6] = Material.Andesite;
            for (int i = 15149; i <= 15154; i++)
                materials[i] = Material.AndesiteSlab;
            for (int i = 14775; i <= 14854; i++)
                materials[i] = Material.AndesiteStairs;
            for (int i = 17765; i <= 18088; i++)
                materials[i] = Material.AndesiteWall;
            for (int i = 9906; i <= 9909; i++)
                materials[i] = Material.Anvil;
            for (int i = 7050; i <= 7053; i++)
                materials[i] = Material.AttachedMelonStem;
            for (int i = 7046; i <= 7049; i++)
                materials[i] = Material.AttachedPumpkinStem;
            materials[25837] = Material.Azalea;
            for (int i = 504; i <= 531; i++)
                materials[i] = Material.AzaleaLeaves;
            materials[2123] = Material.AzureBluet;
            for (int i = 13958; i <= 13969; i++)
                materials[i] = Material.Bamboo;
            for (int i = 168; i <= 170; i++)
                materials[i] = Material.BambooBlock;
            for (int i = 9602; i <= 9625; i++)
                materials[i] = Material.BambooButton;
            for (int i = 13283; i <= 13346; i++)
                materials[i] = Material.BambooDoor;
            for (int i = 12739; i <= 12770; i++)
                materials[i] = Material.BambooFence;
            for (int i = 12451; i <= 12482; i++)
                materials[i] = Material.BambooFenceGate;
            for (int i = 5633; i <= 5696; i++)
                materials[i] = Material.BambooHangingSign;
            materials[28] = Material.BambooMosaic;
            for (int i = 12101; i <= 12106; i++)
                materials[i] = Material.BambooMosaicSlab;
            for (int i = 11163; i <= 11242; i++)
                materials[i] = Material.BambooMosaicStairs;
            materials[27] = Material.BambooPlanks;
            for (int i = 5901; i <= 5902; i++)
                materials[i] = Material.BambooPressurePlate;
            materials[13957] = Material.BambooSapling;
            for (int i = 4645; i <= 4676; i++)
                materials[i] = Material.BambooSign;
            for (int i = 12095; i <= 12100; i++)
                materials[i] = Material.BambooSlab;
            for (int i = 11083; i <= 11162; i++)
                materials[i] = Material.BambooStairs;
            for (int i = 6706; i <= 6769; i++)
                materials[i] = Material.BambooTrapdoor;
            for (int i = 5785; i <= 5792; i++)
                materials[i] = Material.BambooWallHangingSign;
            for (int i = 4921; i <= 4928; i++)
                materials[i] = Material.BambooWallSign;
            for (int i = 19421; i <= 19432; i++)
                materials[i] = Material.Barrel;
            for (int i = 11244; i <= 11245; i++)
                materials[i] = Material.Barrier;
            for (int i = 6021; i <= 6023; i++)
                materials[i] = Material.Basalt;
            materials[8692] = Material.Beacon;
            materials[85] = Material.Bedrock;
            for (int i = 20410; i <= 20433; i++)
                materials[i] = Material.BeeNest;
            for (int i = 20434; i <= 20457; i++)
                materials[i] = Material.Beehive;
            for (int i = 13522; i <= 13525; i++)
                materials[i] = Material.Beetroots;
            for (int i = 19484; i <= 19515; i++)
                materials[i] = Material.Bell;
            for (int i = 25857; i <= 25888; i++)
                materials[i] = Material.BigDripleaf;
            for (int i = 25889; i <= 25896; i++)
                materials[i] = Material.BigDripleafStem;
            for (int i = 9434; i <= 9457; i++)
                materials[i] = Material.BirchButton;
            for (int i = 12835; i <= 12898; i++)
                materials[i] = Material.BirchDoor;
            for (int i = 12515; i <= 12546; i++)
                materials[i] = Material.BirchFence;
            for (int i = 12227; i <= 12258; i++)
                materials[i] = Material.BirchFenceGate;
            for (int i = 5057; i <= 5120; i++)
                materials[i] = Material.BirchHangingSign;
            for (int i = 308; i <= 335; i++)
                materials[i] = Material.BirchLeaves;
            for (int i = 142; i <= 144; i++)
                materials[i] = Material.BirchLog;
            materials[17] = Material.BirchPlanks;
            for (int i = 5887; i <= 5888; i++)
                materials[i] = Material.BirchPressurePlate;
            for (int i = 33; i <= 34; i++)
                materials[i] = Material.BirchSapling;
            for (int i = 4421; i <= 4452; i++)
                materials[i] = Material.BirchSign;
            for (int i = 12053; i <= 12058; i++)
                materials[i] = Material.BirchSlab;
            for (int i = 8520; i <= 8599; i++)
                materials[i] = Material.BirchStairs;
            for (int i = 6258; i <= 6321; i++)
                materials[i] = Material.BirchTrapdoor;
            for (int i = 5713; i <= 5720; i++)
                materials[i] = Material.BirchWallHangingSign;
            for (int i = 4865; i <= 4872; i++)
                materials[i] = Material.BirchWallSign;
            for (int i = 207; i <= 209; i++)
                materials[i] = Material.BirchWood;
            for (int i = 11878; i <= 11893; i++)
                materials[i] = Material.BlackBanner;
            for (int i = 1971; i <= 1986; i++)
                materials[i] = Material.BlackBed;
            for (int i = 21994; i <= 22009; i++)
                materials[i] = Material.BlackCandle;
            for (int i = 22042; i <= 22043; i++)
                materials[i] = Material.BlackCandleCake;
            materials[11622] = Material.BlackCarpet;
            materials[13756] = Material.BlackConcrete;
            materials[13772] = Material.BlackConcretePowder;
            for (int i = 13737; i <= 13740; i++)
                materials[i] = Material.BlackGlazedTerracotta;
            for (int i = 13671; i <= 13676; i++)
                materials[i] = Material.BlackShulkerBox;
            materials[6129] = Material.BlackStainedGlass;
            for (int i = 10651; i <= 10682; i++)
                materials[i] = Material.BlackStainedGlassPane;
            materials[10170] = Material.BlackTerracotta;
            for (int i = 11954; i <= 11957; i++)
                materials[i] = Material.BlackWallBanner;
            materials[2105] = Material.BlackWool;
            materials[20473] = Material.Blackstone;
            for (int i = 20878; i <= 20883; i++)
                materials[i] = Material.BlackstoneSlab;
            for (int i = 20474; i <= 20553; i++)
                materials[i] = Material.BlackstoneStairs;
            for (int i = 20554; i <= 20877; i++)
                materials[i] = Material.BlackstoneWall;
            for (int i = 19441; i <= 19448; i++)
                materials[i] = Material.BlastFurnace;
            for (int i = 11814; i <= 11829; i++)
                materials[i] = Material.BlueBanner;
            for (int i = 1907; i <= 1922; i++)
                materials[i] = Material.BlueBed;
            for (int i = 21930; i <= 21945; i++)
                materials[i] = Material.BlueCandle;
            for (int i = 22034; i <= 22035; i++)
                materials[i] = Material.BlueCandleCake;
            materials[11618] = Material.BlueCarpet;
            materials[13752] = Material.BlueConcrete;
            materials[13768] = Material.BlueConcretePowder;
            for (int i = 13721; i <= 13724; i++)
                materials[i] = Material.BlueGlazedTerracotta;
            materials[13954] = Material.BlueIce;
            materials[2121] = Material.BlueOrchid;
            for (int i = 13647; i <= 13652; i++)
                materials[i] = Material.BlueShulkerBox;
            materials[6125] = Material.BlueStainedGlass;
            for (int i = 10523; i <= 10554; i++)
                materials[i] = Material.BlueStainedGlassPane;
            materials[10166] = Material.BlueTerracotta;
            for (int i = 11938; i <= 11941; i++)
                materials[i] = Material.BlueWallBanner;
            materials[2101] = Material.BlueWool;
            for (int i = 13559; i <= 13561; i++)
                materials[i] = Material.BoneBlock;
            materials[2139] = Material.Bookshelf;
            for (int i = 13838; i <= 13839; i++)
                materials[i] = Material.BrainCoral;
            materials[13822] = Material.BrainCoralBlock;
            for (int i = 13858; i <= 13859; i++)
                materials[i] = Material.BrainCoralFan;
            for (int i = 13914; i <= 13921; i++)
                materials[i] = Material.BrainCoralWallFan;
            for (int i = 8164; i <= 8171; i++)
                materials[i] = Material.BrewingStand;
            for (int i = 12143; i <= 12148; i++)
                materials[i] = Material.BrickSlab;
            for (int i = 7390; i <= 7469; i++)
                materials[i] = Material.BrickStairs;
            for (int i = 15173; i <= 15496; i++)
                materials[i] = Material.BrickWall;
            materials[2136] = Material.Bricks;
            for (int i = 11830; i <= 11845; i++)
                materials[i] = Material.BrownBanner;
            for (int i = 1923; i <= 1938; i++)
                materials[i] = Material.BrownBed;
            for (int i = 21946; i <= 21961; i++)
                materials[i] = Material.BrownCandle;
            for (int i = 22036; i <= 22037; i++)
                materials[i] = Material.BrownCandleCake;
            materials[11619] = Material.BrownCarpet;
            materials[13753] = Material.BrownConcrete;
            materials[13769] = Material.BrownConcretePowder;
            for (int i = 13725; i <= 13728; i++)
                materials[i] = Material.BrownGlazedTerracotta;
            materials[2132] = Material.BrownMushroom;
            for (int i = 6782; i <= 6845; i++)
                materials[i] = Material.BrownMushroomBlock;
            for (int i = 13653; i <= 13658; i++)
                materials[i] = Material.BrownShulkerBox;
            materials[6126] = Material.BrownStainedGlass;
            for (int i = 10555; i <= 10586; i++)
                materials[i] = Material.BrownStainedGlassPane;
            materials[10167] = Material.BrownTerracotta;
            for (int i = 11942; i <= 11945; i++)
                materials[i] = Material.BrownWallBanner;
            materials[2102] = Material.BrownWool;
            for (int i = 13973; i <= 13974; i++)
                materials[i] = Material.BubbleColumn;
            for (int i = 13840; i <= 13841; i++)
                materials[i] = Material.BubbleCoral;
            materials[13823] = Material.BubbleCoralBlock;
            for (int i = 13860; i <= 13861; i++)
                materials[i] = Material.BubbleCoralFan;
            for (int i = 13922; i <= 13929; i++)
                materials[i] = Material.BubbleCoralWallFan;
            materials[22045] = Material.BuddingAmethyst;
            for (int i = 5951; i <= 5966; i++)
                materials[i] = Material.Cactus;
            for (int i = 6043; i <= 6049; i++)
                materials[i] = Material.Cake;
            materials[23329] = Material.Calcite;
            for (int i = 23428; i <= 23811; i++)
                materials[i] = Material.CalibratedSculkSensor;
            for (int i = 19524; i <= 19555; i++)
                materials[i] = Material.Campfire;
            for (int i = 21738; i <= 21753; i++)
                materials[i] = Material.Candle;
            for (int i = 22010; i <= 22011; i++)
                materials[i] = Material.CandleCake;
            for (int i = 9370; i <= 9377; i++)
                materials[i] = Material.Carrots;
            materials[19449] = Material.CartographyTable;
            for (int i = 6035; i <= 6038; i++)
                materials[i] = Material.CarvedPumpkin;
            materials[8172] = Material.Cauldron;
            materials[13972] = Material.CaveAir;
            for (int i = 25782; i <= 25833; i++)
                materials[i] = Material.CaveVines;
            for (int i = 25834; i <= 25835; i++)
                materials[i] = Material.CaveVinesPlant;
            for (int i = 7006; i <= 7011; i++)
                materials[i] = Material.Chain;
            for (int i = 13540; i <= 13551; i++)
                materials[i] = Material.ChainCommandBlock;
            for (int i = 9506; i <= 9529; i++)
                materials[i] = Material.CherryButton;
            for (int i = 13027; i <= 13090; i++)
                materials[i] = Material.CherryDoor;
            for (int i = 12611; i <= 12642; i++)
                materials[i] = Material.CherryFence;
            for (int i = 12323; i <= 12354; i++)
                materials[i] = Material.CherryFenceGate;
            for (int i = 5185; i <= 5248; i++)
                materials[i] = Material.CherryHangingSign;
            for (int i = 392; i <= 419; i++)
                materials[i] = Material.CherryLeaves;
            for (int i = 151; i <= 153; i++)
                materials[i] = Material.CherryLog;
            materials[20] = Material.CherryPlanks;
            for (int i = 5893; i <= 5894; i++)
                materials[i] = Material.CherryPressurePlate;
            for (int i = 39; i <= 40; i++)
                materials[i] = Material.CherrySapling;
            for (int i = 4485; i <= 4516; i++)
                materials[i] = Material.CherrySign;
            for (int i = 12071; i <= 12076; i++)
                materials[i] = Material.CherrySlab;
            for (int i = 10763; i <= 10842; i++)
                materials[i] = Material.CherryStairs;
            for (int i = 6450; i <= 6513; i++)
                materials[i] = Material.CherryTrapdoor;
            for (int i = 5729; i <= 5736; i++)
                materials[i] = Material.CherryWallHangingSign;
            for (int i = 4881; i <= 4888; i++)
                materials[i] = Material.CherryWallSign;
            for (int i = 216; i <= 218; i++)
                materials[i] = Material.CherryWood;
            for (int i = 3009; i <= 3032; i++)
                materials[i] = Material.Chest;
            for (int i = 9910; i <= 9913; i++)
                materials[i] = Material.ChippedAnvil;
            for (int i = 2140; i <= 2395; i++)
                materials[i] = Material.ChiseledBookshelf;
            materials[23964] = Material.ChiseledCopper;
            materials[27564] = Material.ChiseledDeepslate;
            materials[21735] = Material.ChiseledNetherBricks;
            materials[20887] = Material.ChiseledPolishedBlackstone;
            materials[10035] = Material.ChiseledQuartzBlock;
            materials[11959] = Material.ChiseledRedSandstone;
            materials[8045] = Material.ChiseledResinBricks;
            materials[579] = Material.ChiseledSandstone;
            materials[6773] = Material.ChiseledStoneBricks;
            materials[22916] = Material.ChiseledTuff;
            materials[23328] = Material.ChiseledTuffBricks;
            for (int i = 13417; i <= 13422; i++)
                materials[i] = Material.ChorusFlower;
            for (int i = 13353; i <= 13416; i++)
                materials[i] = Material.ChorusPlant;
            materials[5967] = Material.Clay;
            materials[27863] = Material.ClosedEyeblossom;
            materials[11624] = Material.CoalBlock;
            materials[133] = Material.CoalOre;
            materials[11] = Material.CoarseDirt;
            materials[25920] = Material.CobbledDeepslate;
            for (int i = 26001; i <= 26006; i++)
                materials[i] = Material.CobbledDeepslateSlab;
            for (int i = 25921; i <= 26000; i++)
                materials[i] = Material.CobbledDeepslateStairs;
            for (int i = 26007; i <= 26330; i++)
                materials[i] = Material.CobbledDeepslateWall;
            materials[14] = Material.Cobblestone;
            for (int i = 12137; i <= 12142; i++)
                materials[i] = Material.CobblestoneSlab;
            for (int i = 4769; i <= 4848; i++)
                materials[i] = Material.CobblestoneStairs;
            for (int i = 8693; i <= 9016; i++)
                materials[i] = Material.CobblestoneWall;
            materials[2047] = Material.Cobweb;
            for (int i = 8193; i <= 8204; i++)
                materials[i] = Material.Cocoa;
            for (int i = 8680; i <= 8691; i++)
                materials[i] = Material.CommandBlock;
            for (int i = 9974; i <= 9989; i++)
                materials[i] = Material.Comparator;
            for (int i = 20385; i <= 20393; i++)
                materials[i] = Material.Composter;
            for (int i = 13955; i <= 13956; i++)
                materials[i] = Material.Conduit;
            materials[23951] = Material.CopperBlock;
            for (int i = 25705; i <= 25708; i++)
                materials[i] = Material.CopperBulb;
            for (int i = 24665; i <= 24728; i++)
                materials[i] = Material.CopperDoor;
            for (int i = 25689; i <= 25690; i++)
                materials[i] = Material.CopperGrate;
            materials[23955] = Material.CopperOre;
            for (int i = 25177; i <= 25240; i++)
                materials[i] = Material.CopperTrapdoor;
            materials[2129] = Material.Cornflower;
            materials[27565] = Material.CrackedDeepslateBricks;
            materials[27566] = Material.CrackedDeepslateTiles;
            materials[21736] = Material.CrackedNetherBricks;
            materials[20886] = Material.CrackedPolishedBlackstoneBricks;
            materials[6772] = Material.CrackedStoneBricks;
            for (int i = 27603; i <= 27650; i++)
                materials[i] = Material.Crafter;
            materials[4332] = Material.CraftingTable;
            for (int i = 2917; i <= 2928; i++)
                materials[i] = Material.CreakingHeart;
            for (int i = 9786; i <= 9817; i++)
                materials[i] = Material.CreeperHead;
            for (int i = 9818; i <= 9825; i++)
                materials[i] = Material.CreeperWallHead;
            for (int i = 20113; i <= 20136; i++)
                materials[i] = Material.CrimsonButton;
            for (int i = 20161; i <= 20224; i++)
                materials[i] = Material.CrimsonDoor;
            for (int i = 19697; i <= 19728; i++)
                materials[i] = Material.CrimsonFence;
            for (int i = 19889; i <= 19920; i++)
                materials[i] = Material.CrimsonFenceGate;
            materials[19622] = Material.CrimsonFungus;
            for (int i = 5441; i <= 5504; i++)
                materials[i] = Material.CrimsonHangingSign;
            for (int i = 19615; i <= 19617; i++)
                materials[i] = Material.CrimsonHyphae;
            materials[19621] = Material.CrimsonNylium;
            materials[19679] = Material.CrimsonPlanks;
            for (int i = 19693; i <= 19694; i++)
                materials[i] = Material.CrimsonPressurePlate;
            materials[19678] = Material.CrimsonRoots;
            for (int i = 20289; i <= 20320; i++)
                materials[i] = Material.CrimsonSign;
            for (int i = 19681; i <= 19686; i++)
                materials[i] = Material.CrimsonSlab;
            for (int i = 19953; i <= 20032; i++)
                materials[i] = Material.CrimsonStairs;
            for (int i = 19609; i <= 19611; i++)
                materials[i] = Material.CrimsonStem;
            for (int i = 19761; i <= 19824; i++)
                materials[i] = Material.CrimsonTrapdoor;
            for (int i = 5769; i <= 5776; i++)
                materials[i] = Material.CrimsonWallHangingSign;
            for (int i = 20353; i <= 20360; i++)
                materials[i] = Material.CrimsonWallSign;
            materials[20462] = Material.CryingObsidian;
            materials[23960] = Material.CutCopper;
            for (int i = 24307; i <= 24312; i++)
                materials[i] = Material.CutCopperSlab;
            for (int i = 24209; i <= 24288; i++)
                materials[i] = Material.CutCopperStairs;
            materials[11960] = Material.CutRedSandstone;
            for (int i = 12179; i <= 12184; i++)
                materials[i] = Material.CutRedSandstoneSlab;
            materials[580] = Material.CutSandstone;
            for (int i = 12125; i <= 12130; i++)
                materials[i] = Material.CutSandstoneSlab;
            for (int i = 11782; i <= 11797; i++)
                materials[i] = Material.CyanBanner;
            for (int i = 1875; i <= 1890; i++)
                materials[i] = Material.CyanBed;
            for (int i = 21898; i <= 21913; i++)
                materials[i] = Material.CyanCandle;
            for (int i = 22030; i <= 22031; i++)
                materials[i] = Material.CyanCandleCake;
            materials[11616] = Material.CyanCarpet;
            materials[13750] = Material.CyanConcrete;
            materials[13766] = Material.CyanConcretePowder;
            for (int i = 13713; i <= 13716; i++)
                materials[i] = Material.CyanGlazedTerracotta;
            for (int i = 13635; i <= 13640; i++)
                materials[i] = Material.CyanShulkerBox;
            materials[6123] = Material.CyanStainedGlass;
            for (int i = 10459; i <= 10490; i++)
                materials[i] = Material.CyanStainedGlassPane;
            materials[10164] = Material.CyanTerracotta;
            for (int i = 11930; i <= 11933; i++)
                materials[i] = Material.CyanWallBanner;
            materials[2099] = Material.CyanWool;
            for (int i = 9914; i <= 9917; i++)
                materials[i] = Material.DamagedAnvil;
            materials[2118] = Material.Dandelion;
            for (int i = 9530; i <= 9553; i++)
                materials[i] = Material.DarkOakButton;
            for (int i = 13091; i <= 13154; i++)
                materials[i] = Material.DarkOakDoor;
            for (int i = 12643; i <= 12674; i++)
                materials[i] = Material.DarkOakFence;
            for (int i = 12355; i <= 12386; i++)
                materials[i] = Material.DarkOakFenceGate;
            for (int i = 5313; i <= 5376; i++)
                materials[i] = Material.DarkOakHangingSign;
            for (int i = 420; i <= 447; i++)
                materials[i] = Material.DarkOakLeaves;
            for (int i = 154; i <= 156; i++)
                materials[i] = Material.DarkOakLog;
            materials[21] = Material.DarkOakPlanks;
            for (int i = 5895; i <= 5896; i++)
                materials[i] = Material.DarkOakPressurePlate;
            for (int i = 41; i <= 42; i++)
                materials[i] = Material.DarkOakSapling;
            for (int i = 4549; i <= 4580; i++)
                materials[i] = Material.DarkOakSign;
            for (int i = 12077; i <= 12082; i++)
                materials[i] = Material.DarkOakSlab;
            for (int i = 10843; i <= 10922; i++)
                materials[i] = Material.DarkOakStairs;
            for (int i = 6514; i <= 6577; i++)
                materials[i] = Material.DarkOakTrapdoor;
            for (int i = 5745; i <= 5752; i++)
                materials[i] = Material.DarkOakWallHangingSign;
            for (int i = 4897; i <= 4904; i++)
                materials[i] = Material.DarkOakWallSign;
            for (int i = 219; i <= 221; i++)
                materials[i] = Material.DarkOakWood;
            materials[11344] = Material.DarkPrismarine;
            for (int i = 11597; i <= 11602; i++)
                materials[i] = Material.DarkPrismarineSlab;
            for (int i = 11505; i <= 11584; i++)
                materials[i] = Material.DarkPrismarineStairs;
            for (int i = 9990; i <= 10021; i++)
                materials[i] = Material.DaylightDetector;
            for (int i = 13828; i <= 13829; i++)
                materials[i] = Material.DeadBrainCoral;
            materials[13817] = Material.DeadBrainCoralBlock;
            for (int i = 13848; i <= 13849; i++)
                materials[i] = Material.DeadBrainCoralFan;
            for (int i = 13874; i <= 13881; i++)
                materials[i] = Material.DeadBrainCoralWallFan;
            for (int i = 13830; i <= 13831; i++)
                materials[i] = Material.DeadBubbleCoral;
            materials[13818] = Material.DeadBubbleCoralBlock;
            for (int i = 13850; i <= 13851; i++)
                materials[i] = Material.DeadBubbleCoralFan;
            for (int i = 13882; i <= 13889; i++)
                materials[i] = Material.DeadBubbleCoralWallFan;
            materials[2050] = Material.DeadBush;
            for (int i = 13832; i <= 13833; i++)
                materials[i] = Material.DeadFireCoral;
            materials[13819] = Material.DeadFireCoralBlock;
            for (int i = 13852; i <= 13853; i++)
                materials[i] = Material.DeadFireCoralFan;
            for (int i = 13890; i <= 13897; i++)
                materials[i] = Material.DeadFireCoralWallFan;
            for (int i = 13834; i <= 13835; i++)
                materials[i] = Material.DeadHornCoral;
            materials[13820] = Material.DeadHornCoralBlock;
            for (int i = 13854; i <= 13855; i++)
                materials[i] = Material.DeadHornCoralFan;
            for (int i = 13898; i <= 13905; i++)
                materials[i] = Material.DeadHornCoralWallFan;
            for (int i = 13826; i <= 13827; i++)
                materials[i] = Material.DeadTubeCoral;
            materials[13816] = Material.DeadTubeCoralBlock;
            for (int i = 13846; i <= 13847; i++)
                materials[i] = Material.DeadTubeCoralFan;
            for (int i = 13866; i <= 13873; i++)
                materials[i] = Material.DeadTubeCoralWallFan;
            for (int i = 27587; i <= 27602; i++)
                materials[i] = Material.DecoratedPot;
            for (int i = 25917; i <= 25919; i++)
                materials[i] = Material.Deepslate;
            for (int i = 27234; i <= 27239; i++)
                materials[i] = Material.DeepslateBrickSlab;
            for (int i = 27154; i <= 27233; i++)
                materials[i] = Material.DeepslateBrickStairs;
            for (int i = 27240; i <= 27563; i++)
                materials[i] = Material.DeepslateBrickWall;
            materials[27153] = Material.DeepslateBricks;
            materials[134] = Material.DeepslateCoalOre;
            materials[23956] = Material.DeepslateCopperOre;
            materials[4330] = Material.DeepslateDiamondOre;
            materials[8286] = Material.DeepslateEmeraldOre;
            materials[130] = Material.DeepslateGoldOre;
            materials[132] = Material.DeepslateIronOre;
            materials[564] = Material.DeepslateLapisOre;
            for (int i = 5905; i <= 5906; i++)
                materials[i] = Material.DeepslateRedstoneOre;
            for (int i = 26823; i <= 26828; i++)
                materials[i] = Material.DeepslateTileSlab;
            for (int i = 26743; i <= 26822; i++)
                materials[i] = Material.DeepslateTileStairs;
            for (int i = 26829; i <= 27152; i++)
                materials[i] = Material.DeepslateTileWall;
            materials[26742] = Material.DeepslateTiles;
            for (int i = 2011; i <= 2034; i++)
                materials[i] = Material.DetectorRail;
            materials[4331] = Material.DiamondBlock;
            materials[4329] = Material.DiamondOre;
            materials[4] = Material.Diorite;
            for (int i = 15167; i <= 15172; i++)
                materials[i] = Material.DioriteSlab;
            for (int i = 15015; i <= 15094; i++)
                materials[i] = Material.DioriteStairs;
            for (int i = 19061; i <= 19384; i++)
                materials[i] = Material.DioriteWall;
            materials[10] = Material.Dirt;
            materials[13526] = Material.DirtPath;
            for (int i = 566; i <= 577; i++)
                materials[i] = Material.Dispenser;
            materials[8190] = Material.DragonEgg;
            for (int i = 9826; i <= 9857; i++)
                materials[i] = Material.DragonHead;
            for (int i = 9858; i <= 9865; i++)
                materials[i] = Material.DragonWallHead;
            materials[13800] = Material.DriedKelpBlock;
            materials[25781] = Material.DripstoneBlock;
            for (int i = 10143; i <= 10154; i++)
                materials[i] = Material.Dropper;
            materials[8439] = Material.EmeraldBlock;
            materials[8285] = Material.EmeraldOre;
            materials[8163] = Material.EnchantingTable;
            materials[13527] = Material.EndGateway;
            materials[8180] = Material.EndPortal;
            for (int i = 8181; i <= 8188; i++)
                materials[i] = Material.EndPortalFrame;
            for (int i = 13347; i <= 13352; i++)
                materials[i] = Material.EndRod;
            materials[8189] = Material.EndStone;
            for (int i = 15125; i <= 15130; i++)
                materials[i] = Material.EndStoneBrickSlab;
            for (int i = 14375; i <= 14454; i++)
                materials[i] = Material.EndStoneBrickStairs;
            for (int i = 18737; i <= 19060; i++)
                materials[i] = Material.EndStoneBrickWall;
            materials[13507] = Material.EndStoneBricks;
            for (int i = 8287; i <= 8294; i++)
                materials[i] = Material.EnderChest;
            materials[23963] = Material.ExposedChiseledCopper;
            materials[23952] = Material.ExposedCopper;
            for (int i = 25709; i <= 25712; i++)
                materials[i] = Material.ExposedCopperBulb;
            for (int i = 24729; i <= 24792; i++)
                materials[i] = Material.ExposedCopperDoor;
            for (int i = 25691; i <= 25692; i++)
                materials[i] = Material.ExposedCopperGrate;
            for (int i = 25241; i <= 25304; i++)
                materials[i] = Material.ExposedCopperTrapdoor;
            materials[23959] = Material.ExposedCutCopper;
            for (int i = 24301; i <= 24306; i++)
                materials[i] = Material.ExposedCutCopperSlab;
            for (int i = 24129; i <= 24208; i++)
                materials[i] = Material.ExposedCutCopperStairs;
            for (int i = 4341; i <= 4348; i++)
                materials[i] = Material.Farmland;
            materials[2049] = Material.Fern;
            for (int i = 2403; i <= 2914; i++)
                materials[i] = Material.Fire;
            for (int i = 13842; i <= 13843; i++)
                materials[i] = Material.FireCoral;
            materials[13824] = Material.FireCoralBlock;
            for (int i = 13862; i <= 13863; i++)
                materials[i] = Material.FireCoralFan;
            for (int i = 13930; i <= 13937; i++)
                materials[i] = Material.FireCoralWallFan;
            materials[19450] = Material.FletchingTable;
            materials[9341] = Material.FlowerPot;
            materials[25838] = Material.FloweringAzalea;
            for (int i = 532; i <= 559; i++)
                materials[i] = Material.FloweringAzaleaLeaves;
            materials[27585] = Material.Frogspawn;
            for (int i = 13552; i <= 13555; i++)
                materials[i] = Material.FrostedIce;
            for (int i = 4349; i <= 4356; i++)
                materials[i] = Material.Furnace;
            materials[21298] = Material.GildedBlackstone;
            materials[562] = Material.Glass;
            for (int i = 7012; i <= 7043; i++)
                materials[i] = Material.GlassPane;
            for (int i = 7102; i <= 7229; i++)
                materials[i] = Material.GlowLichen;
            materials[6032] = Material.Glowstone;
            materials[2134] = Material.GoldBlock;
            materials[129] = Material.GoldOre;
            materials[2] = Material.Granite;
            for (int i = 15143; i <= 15148; i++)
                materials[i] = Material.GraniteSlab;
            for (int i = 14695; i <= 14774; i++)
                materials[i] = Material.GraniteStairs;
            for (int i = 16469; i <= 16792; i++)
                materials[i] = Material.GraniteWall;
            for (int i = 8; i <= 9; i++)
                materials[i] = Material.GrassBlock;
            materials[124] = Material.Gravel;
            for (int i = 11750; i <= 11765; i++)
                materials[i] = Material.GrayBanner;
            for (int i = 1843; i <= 1858; i++)
                materials[i] = Material.GrayBed;
            for (int i = 21866; i <= 21881; i++)
                materials[i] = Material.GrayCandle;
            for (int i = 22026; i <= 22027; i++)
                materials[i] = Material.GrayCandleCake;
            materials[11614] = Material.GrayCarpet;
            materials[13748] = Material.GrayConcrete;
            materials[13764] = Material.GrayConcretePowder;
            for (int i = 13705; i <= 13708; i++)
                materials[i] = Material.GrayGlazedTerracotta;
            for (int i = 13623; i <= 13628; i++)
                materials[i] = Material.GrayShulkerBox;
            materials[6121] = Material.GrayStainedGlass;
            for (int i = 10395; i <= 10426; i++)
                materials[i] = Material.GrayStainedGlassPane;
            materials[10162] = Material.GrayTerracotta;
            for (int i = 11922; i <= 11925; i++)
                materials[i] = Material.GrayWallBanner;
            materials[2097] = Material.GrayWool;
            for (int i = 11846; i <= 11861; i++)
                materials[i] = Material.GreenBanner;
            for (int i = 1939; i <= 1954; i++)
                materials[i] = Material.GreenBed;
            for (int i = 21962; i <= 21977; i++)
                materials[i] = Material.GreenCandle;
            for (int i = 22038; i <= 22039; i++)
                materials[i] = Material.GreenCandleCake;
            materials[11620] = Material.GreenCarpet;
            materials[13754] = Material.GreenConcrete;
            materials[13770] = Material.GreenConcretePowder;
            for (int i = 13729; i <= 13732; i++)
                materials[i] = Material.GreenGlazedTerracotta;
            for (int i = 13659; i <= 13664; i++)
                materials[i] = Material.GreenShulkerBox;
            materials[6127] = Material.GreenStainedGlass;
            for (int i = 10587; i <= 10618; i++)
                materials[i] = Material.GreenStainedGlassPane;
            materials[10168] = Material.GreenTerracotta;
            for (int i = 11946; i <= 11949; i++)
                materials[i] = Material.GreenWallBanner;
            materials[2103] = Material.GreenWool;
            for (int i = 19451; i <= 19462; i++)
                materials[i] = Material.Grindstone;
            for (int i = 25913; i <= 25914; i++)
                materials[i] = Material.HangingRoots;
            for (int i = 11604; i <= 11606; i++)
                materials[i] = Material.HayBlock;
            for (int i = 27695; i <= 27696; i++)
                materials[i] = Material.HeavyCore;
            for (int i = 9958; i <= 9973; i++)
                materials[i] = Material.HeavyWeightedPressurePlate;
            materials[20458] = Material.HoneyBlock;
            materials[20459] = Material.HoneycombBlock;
            for (int i = 10024; i <= 10033; i++)
                materials[i] = Material.Hopper;
            for (int i = 13844; i <= 13845; i++)
                materials[i] = Material.HornCoral;
            materials[13825] = Material.HornCoralBlock;
            for (int i = 13864; i <= 13865; i++)
                materials[i] = Material.HornCoralFan;
            for (int i = 13938; i <= 13945; i++)
                materials[i] = Material.HornCoralWallFan;
            materials[5949] = Material.Ice;
            materials[6781] = Material.InfestedChiseledStoneBricks;
            materials[6777] = Material.InfestedCobblestone;
            materials[6780] = Material.InfestedCrackedStoneBricks;
            for (int i = 27567; i <= 27569; i++)
                materials[i] = Material.InfestedDeepslate;
            materials[6779] = Material.InfestedMossyStoneBricks;
            materials[6776] = Material.InfestedStone;
            materials[6778] = Material.InfestedStoneBricks;
            for (int i = 6974; i <= 7005; i++)
                materials[i] = Material.IronBars;
            materials[2135] = Material.IronBlock;
            for (int i = 5819; i <= 5882; i++)
                materials[i] = Material.IronDoor;
            materials[131] = Material.IronOre;
            for (int i = 11278; i <= 11341; i++)
                materials[i] = Material.IronTrapdoor;
            for (int i = 6039; i <= 6042; i++)
                materials[i] = Material.JackOLantern;
            for (int i = 20373; i <= 20384; i++)
                materials[i] = Material.Jigsaw;
            for (int i = 5984; i <= 5985; i++)
                materials[i] = Material.Jukebox;
            for (int i = 9458; i <= 9481; i++)
                materials[i] = Material.JungleButton;
            for (int i = 12899; i <= 12962; i++)
                materials[i] = Material.JungleDoor;
            for (int i = 12547; i <= 12578; i++)
                materials[i] = Material.JungleFence;
            for (int i = 12259; i <= 12290; i++)
                materials[i] = Material.JungleFenceGate;
            for (int i = 5249; i <= 5312; i++)
                materials[i] = Material.JungleHangingSign;
            for (int i = 336; i <= 363; i++)
                materials[i] = Material.JungleLeaves;
            for (int i = 145; i <= 147; i++)
                materials[i] = Material.JungleLog;
            materials[18] = Material.JunglePlanks;
            for (int i = 5889; i <= 5890; i++)
                materials[i] = Material.JunglePressurePlate;
            for (int i = 35; i <= 36; i++)
                materials[i] = Material.JungleSapling;
            for (int i = 4517; i <= 4548; i++)
                materials[i] = Material.JungleSign;
            for (int i = 12059; i <= 12064; i++)
                materials[i] = Material.JungleSlab;
            for (int i = 8600; i <= 8679; i++)
                materials[i] = Material.JungleStairs;
            for (int i = 6322; i <= 6385; i++)
                materials[i] = Material.JungleTrapdoor;
            for (int i = 5737; i <= 5744; i++)
                materials[i] = Material.JungleWallHangingSign;
            for (int i = 4889; i <= 4896; i++)
                materials[i] = Material.JungleWallSign;
            for (int i = 210; i <= 212; i++)
                materials[i] = Material.JungleWood;
            for (int i = 13773; i <= 13798; i++)
                materials[i] = Material.Kelp;
            materials[13799] = Material.KelpPlant;
            for (int i = 4741; i <= 4748; i++)
                materials[i] = Material.Ladder;
            for (int i = 19516; i <= 19519; i++)
                materials[i] = Material.Lantern;
            materials[565] = Material.LapisBlock;
            materials[563] = Material.LapisOre;
            for (int i = 22058; i <= 22069; i++)
                materials[i] = Material.LargeAmethystBud;
            for (int i = 11636; i <= 11637; i++)
                materials[i] = Material.LargeFern;
            for (int i = 102; i <= 117; i++)
                materials[i] = Material.Lava;
            materials[8176] = Material.LavaCauldron;
            for (int i = 19463; i <= 19478; i++)
                materials[i] = Material.Lectern;
            for (int i = 5793; i <= 5816; i++)
                materials[i] = Material.Lever;
            for (int i = 11246; i <= 11277; i++)
                materials[i] = Material.Light;
            for (int i = 11686; i <= 11701; i++)
                materials[i] = Material.LightBlueBanner;
            for (int i = 1779; i <= 1794; i++)
                materials[i] = Material.LightBlueBed;
            for (int i = 21802; i <= 21817; i++)
                materials[i] = Material.LightBlueCandle;
            for (int i = 22018; i <= 22019; i++)
                materials[i] = Material.LightBlueCandleCake;
            materials[11610] = Material.LightBlueCarpet;
            materials[13744] = Material.LightBlueConcrete;
            materials[13760] = Material.LightBlueConcretePowder;
            for (int i = 13689; i <= 13692; i++)
                materials[i] = Material.LightBlueGlazedTerracotta;
            for (int i = 13599; i <= 13604; i++)
                materials[i] = Material.LightBlueShulkerBox;
            materials[6117] = Material.LightBlueStainedGlass;
            for (int i = 10267; i <= 10298; i++)
                materials[i] = Material.LightBlueStainedGlassPane;
            materials[10158] = Material.LightBlueTerracotta;
            for (int i = 11906; i <= 11909; i++)
                materials[i] = Material.LightBlueWallBanner;
            materials[2093] = Material.LightBlueWool;
            for (int i = 11766; i <= 11781; i++)
                materials[i] = Material.LightGrayBanner;
            for (int i = 1859; i <= 1874; i++)
                materials[i] = Material.LightGrayBed;
            for (int i = 21882; i <= 21897; i++)
                materials[i] = Material.LightGrayCandle;
            for (int i = 22028; i <= 22029; i++)
                materials[i] = Material.LightGrayCandleCake;
            materials[11615] = Material.LightGrayCarpet;
            materials[13749] = Material.LightGrayConcrete;
            materials[13765] = Material.LightGrayConcretePowder;
            for (int i = 13709; i <= 13712; i++)
                materials[i] = Material.LightGrayGlazedTerracotta;
            for (int i = 13629; i <= 13634; i++)
                materials[i] = Material.LightGrayShulkerBox;
            materials[6122] = Material.LightGrayStainedGlass;
            for (int i = 10427; i <= 10458; i++)
                materials[i] = Material.LightGrayStainedGlassPane;
            materials[10163] = Material.LightGrayTerracotta;
            for (int i = 11926; i <= 11929; i++)
                materials[i] = Material.LightGrayWallBanner;
            materials[2098] = Material.LightGrayWool;
            for (int i = 9942; i <= 9957; i++)
                materials[i] = Material.LightWeightedPressurePlate;
            for (int i = 25737; i <= 25760; i++)
                materials[i] = Material.LightningRod;
            for (int i = 11628; i <= 11629; i++)
                materials[i] = Material.Lilac;
            materials[2131] = Material.LilyOfTheValley;
            materials[7632] = Material.LilyPad;
            for (int i = 11718; i <= 11733; i++)
                materials[i] = Material.LimeBanner;
            for (int i = 1811; i <= 1826; i++)
                materials[i] = Material.LimeBed;
            for (int i = 21834; i <= 21849; i++)
                materials[i] = Material.LimeCandle;
            for (int i = 22022; i <= 22023; i++)
                materials[i] = Material.LimeCandleCake;
            materials[11612] = Material.LimeCarpet;
            materials[13746] = Material.LimeConcrete;
            materials[13762] = Material.LimeConcretePowder;
            for (int i = 13697; i <= 13700; i++)
                materials[i] = Material.LimeGlazedTerracotta;
            for (int i = 13611; i <= 13616; i++)
                materials[i] = Material.LimeShulkerBox;
            materials[6119] = Material.LimeStainedGlass;
            for (int i = 10331; i <= 10362; i++)
                materials[i] = Material.LimeStainedGlassPane;
            materials[10160] = Material.LimeTerracotta;
            for (int i = 11914; i <= 11917; i++)
                materials[i] = Material.LimeWallBanner;
            materials[2095] = Material.LimeWool;
            materials[20472] = Material.Lodestone;
            for (int i = 19417; i <= 19420; i++)
                materials[i] = Material.Loom;
            for (int i = 11670; i <= 11685; i++)
                materials[i] = Material.MagentaBanner;
            for (int i = 1763; i <= 1778; i++)
                materials[i] = Material.MagentaBed;
            for (int i = 21786; i <= 21801; i++)
                materials[i] = Material.MagentaCandle;
            for (int i = 22016; i <= 22017; i++)
                materials[i] = Material.MagentaCandleCake;
            materials[11609] = Material.MagentaCarpet;
            materials[13743] = Material.MagentaConcrete;
            materials[13759] = Material.MagentaConcretePowder;
            for (int i = 13685; i <= 13688; i++)
                materials[i] = Material.MagentaGlazedTerracotta;
            for (int i = 13593; i <= 13598; i++)
                materials[i] = Material.MagentaShulkerBox;
            materials[6116] = Material.MagentaStainedGlass;
            for (int i = 10235; i <= 10266; i++)
                materials[i] = Material.MagentaStainedGlassPane;
            materials[10157] = Material.MagentaTerracotta;
            for (int i = 11902; i <= 11905; i++)
                materials[i] = Material.MagentaWallBanner;
            materials[2092] = Material.MagentaWool;
            materials[13556] = Material.MagmaBlock;
            for (int i = 9578; i <= 9601; i++)
                materials[i] = Material.MangroveButton;
            for (int i = 13219; i <= 13282; i++)
                materials[i] = Material.MangroveDoor;
            for (int i = 12707; i <= 12738; i++)
                materials[i] = Material.MangroveFence;
            for (int i = 12419; i <= 12450; i++)
                materials[i] = Material.MangroveFenceGate;
            for (int i = 5569; i <= 5632; i++)
                materials[i] = Material.MangroveHangingSign;
            for (int i = 476; i <= 503; i++)
                materials[i] = Material.MangroveLeaves;
            for (int i = 160; i <= 162; i++)
                materials[i] = Material.MangroveLog;
            materials[26] = Material.MangrovePlanks;
            for (int i = 5899; i <= 5900; i++)
                materials[i] = Material.MangrovePressurePlate;
            for (int i = 45; i <= 84; i++)
                materials[i] = Material.MangrovePropagule;
            for (int i = 163; i <= 164; i++)
                materials[i] = Material.MangroveRoots;
            for (int i = 4613; i <= 4644; i++)
                materials[i] = Material.MangroveSign;
            for (int i = 12089; i <= 12094; i++)
                materials[i] = Material.MangroveSlab;
            for (int i = 11003; i <= 11082; i++)
                materials[i] = Material.MangroveStairs;
            for (int i = 6642; i <= 6705; i++)
                materials[i] = Material.MangroveTrapdoor;
            for (int i = 5761; i <= 5768; i++)
                materials[i] = Material.MangroveWallHangingSign;
            for (int i = 4913; i <= 4920; i++)
                materials[i] = Material.MangroveWallSign;
            for (int i = 222; i <= 224; i++)
                materials[i] = Material.MangroveWood;
            for (int i = 22070; i <= 22081; i++)
                materials[i] = Material.MediumAmethystBud;
            materials[7045] = Material.Melon;
            for (int i = 7062; i <= 7069; i++)
                materials[i] = Material.MelonStem;
            materials[25856] = Material.MossBlock;
            materials[25839] = Material.MossCarpet;
            materials[2396] = Material.MossyCobblestone;
            for (int i = 15119; i <= 15124; i++)
                materials[i] = Material.MossyCobblestoneSlab;
            for (int i = 14295; i <= 14374; i++)
                materials[i] = Material.MossyCobblestoneStairs;
            for (int i = 9017; i <= 9340; i++)
                materials[i] = Material.MossyCobblestoneWall;
            for (int i = 15107; i <= 15112; i++)
                materials[i] = Material.MossyStoneBrickSlab;
            for (int i = 14135; i <= 14214; i++)
                materials[i] = Material.MossyStoneBrickStairs;
            for (int i = 16145; i <= 16468; i++)
                materials[i] = Material.MossyStoneBrickWall;
            materials[6771] = Material.MossyStoneBricks;
            for (int i = 2106; i <= 2117; i++)
                materials[i] = Material.MovingPiston;
            materials[25916] = Material.Mud;
            for (int i = 12155; i <= 12160; i++)
                materials[i] = Material.MudBrickSlab;
            for (int i = 7550; i <= 7629; i++)
                materials[i] = Material.MudBrickStairs;
            for (int i = 17117; i <= 17440; i++)
                materials[i] = Material.MudBrickWall;
            materials[6775] = Material.MudBricks;
            for (int i = 165; i <= 167; i++)
                materials[i] = Material.MuddyMangroveRoots;
            for (int i = 6910; i <= 6973; i++)
                materials[i] = Material.MushroomStem;
            for (int i = 7630; i <= 7631; i++)
                materials[i] = Material.Mycelium;
            for (int i = 8047; i <= 8078; i++)
                materials[i] = Material.NetherBrickFence;
            for (int i = 12161; i <= 12166; i++)
                materials[i] = Material.NetherBrickSlab;
            for (int i = 8079; i <= 8158; i++)
                materials[i] = Material.NetherBrickStairs;
            for (int i = 17441; i <= 17764; i++)
                materials[i] = Material.NetherBrickWall;
            materials[8046] = Material.NetherBricks;
            materials[135] = Material.NetherGoldOre;
            for (int i = 6033; i <= 6034; i++)
                materials[i] = Material.NetherPortal;
            materials[10023] = Material.NetherQuartzOre;
            materials[19608] = Material.NetherSprouts;
            for (int i = 8159; i <= 8162; i++)
                materials[i] = Material.NetherWart;
            materials[13557] = Material.NetherWartBlock;
            materials[20460] = Material.NetheriteBlock;
            materials[6018] = Material.Netherrack;
            for (int i = 581; i <= 1730; i++)
                materials[i] = Material.NoteBlock;
            for (int i = 9386; i <= 9409; i++)
                materials[i] = Material.OakButton;
            for (int i = 4677; i <= 4740; i++)
                materials[i] = Material.OakDoor;
            for (int i = 5986; i <= 6017; i++)
                materials[i] = Material.OakFence;
            for (int i = 7358; i <= 7389; i++)
                materials[i] = Material.OakFenceGate;
            for (int i = 4929; i <= 4992; i++)
                materials[i] = Material.OakHangingSign;
            for (int i = 252; i <= 279; i++)
                materials[i] = Material.OakLeaves;
            for (int i = 136; i <= 138; i++)
                materials[i] = Material.OakLog;
            materials[15] = Material.OakPlanks;
            for (int i = 5883; i <= 5884; i++)
                materials[i] = Material.OakPressurePlate;
            for (int i = 29; i <= 30; i++)
                materials[i] = Material.OakSapling;
            for (int i = 4357; i <= 4388; i++)
                materials[i] = Material.OakSign;
            for (int i = 12041; i <= 12046; i++)
                materials[i] = Material.OakSlab;
            for (int i = 2929; i <= 3008; i++)
                materials[i] = Material.OakStairs;
            for (int i = 6130; i <= 6193; i++)
                materials[i] = Material.OakTrapdoor;
            for (int i = 5697; i <= 5704; i++)
                materials[i] = Material.OakWallHangingSign;
            for (int i = 4849; i <= 4856; i++)
                materials[i] = Material.OakWallSign;
            for (int i = 201; i <= 203; i++)
                materials[i] = Material.OakWood;
            for (int i = 13563; i <= 13574; i++)
                materials[i] = Material.Observer;
            materials[2397] = Material.Obsidian;
            for (int i = 27576; i <= 27578; i++)
                materials[i] = Material.OchreFroglight;
            materials[27862] = Material.OpenEyeblossom;
            for (int i = 11654; i <= 11669; i++)
                materials[i] = Material.OrangeBanner;
            for (int i = 1747; i <= 1762; i++)
                materials[i] = Material.OrangeBed;
            for (int i = 21770; i <= 21785; i++)
                materials[i] = Material.OrangeCandle;
            for (int i = 22014; i <= 22015; i++)
                materials[i] = Material.OrangeCandleCake;
            materials[11608] = Material.OrangeCarpet;
            materials[13742] = Material.OrangeConcrete;
            materials[13758] = Material.OrangeConcretePowder;
            for (int i = 13681; i <= 13684; i++)
                materials[i] = Material.OrangeGlazedTerracotta;
            for (int i = 13587; i <= 13592; i++)
                materials[i] = Material.OrangeShulkerBox;
            materials[6115] = Material.OrangeStainedGlass;
            for (int i = 10203; i <= 10234; i++)
                materials[i] = Material.OrangeStainedGlassPane;
            materials[10156] = Material.OrangeTerracotta;
            materials[2125] = Material.OrangeTulip;
            for (int i = 11898; i <= 11901; i++)
                materials[i] = Material.OrangeWallBanner;
            materials[2091] = Material.OrangeWool;
            materials[2128] = Material.OxeyeDaisy;
            materials[23961] = Material.OxidizedChiseledCopper;
            materials[23954] = Material.OxidizedCopper;
            for (int i = 25717; i <= 25720; i++)
                materials[i] = Material.OxidizedCopperBulb;
            for (int i = 24793; i <= 24856; i++)
                materials[i] = Material.OxidizedCopperDoor;
            for (int i = 25695; i <= 25696; i++)
                materials[i] = Material.OxidizedCopperGrate;
            for (int i = 25305; i <= 25368; i++)
                materials[i] = Material.OxidizedCopperTrapdoor;
            materials[23957] = Material.OxidizedCutCopper;
            for (int i = 24289; i <= 24294; i++)
                materials[i] = Material.OxidizedCutCopperSlab;
            for (int i = 23969; i <= 24048; i++)
                materials[i] = Material.OxidizedCutCopperStairs;
            materials[11625] = Material.PackedIce;
            materials[6774] = Material.PackedMud;
            for (int i = 27860; i <= 27861; i++)
                materials[i] = Material.PaleHangingMoss;
            materials[27697] = Material.PaleMossBlock;
            for (int i = 27698; i <= 27859; i++)
                materials[i] = Material.PaleMossCarpet;
            for (int i = 9554; i <= 9577; i++)
                materials[i] = Material.PaleOakButton;
            for (int i = 13155; i <= 13218; i++)
                materials[i] = Material.PaleOakDoor;
            for (int i = 12675; i <= 12706; i++)
                materials[i] = Material.PaleOakFence;
            for (int i = 12387; i <= 12418; i++)
                materials[i] = Material.PaleOakFenceGate;
            for (int i = 5377; i <= 5440; i++)
                materials[i] = Material.PaleOakHangingSign;
            for (int i = 448; i <= 475; i++)
                materials[i] = Material.PaleOakLeaves;
            for (int i = 157; i <= 159; i++)
                materials[i] = Material.PaleOakLog;
            materials[25] = Material.PaleOakPlanks;
            for (int i = 5897; i <= 5898; i++)
                materials[i] = Material.PaleOakPressurePlate;
            for (int i = 43; i <= 44; i++)
                materials[i] = Material.PaleOakSapling;
            for (int i = 4581; i <= 4612; i++)
                materials[i] = Material.PaleOakSign;
            for (int i = 12083; i <= 12088; i++)
                materials[i] = Material.PaleOakSlab;
            for (int i = 10923; i <= 11002; i++)
                materials[i] = Material.PaleOakStairs;
            for (int i = 6578; i <= 6641; i++)
                materials[i] = Material.PaleOakTrapdoor;
            for (int i = 5753; i <= 5760; i++)
                materials[i] = Material.PaleOakWallHangingSign;
            for (int i = 4905; i <= 4912; i++)
                materials[i] = Material.PaleOakWallSign;
            for (int i = 22; i <= 24; i++)
                materials[i] = Material.PaleOakWood;
            for (int i = 27582; i <= 27584; i++)
                materials[i] = Material.PearlescentFroglight;
            for (int i = 11632; i <= 11633; i++)
                materials[i] = Material.Peony;
            for (int i = 12131; i <= 12136; i++)
                materials[i] = Material.PetrifiedOakSlab;
            for (int i = 9866; i <= 9897; i++)
                materials[i] = Material.PiglinHead;
            for (int i = 9898; i <= 9905; i++)
                materials[i] = Material.PiglinWallHead;
            for (int i = 11734; i <= 11749; i++)
                materials[i] = Material.PinkBanner;
            for (int i = 1827; i <= 1842; i++)
                materials[i] = Material.PinkBed;
            for (int i = 21850; i <= 21865; i++)
                materials[i] = Material.PinkCandle;
            for (int i = 22024; i <= 22025; i++)
                materials[i] = Material.PinkCandleCake;
            materials[11613] = Material.PinkCarpet;
            materials[13747] = Material.PinkConcrete;
            materials[13763] = Material.PinkConcretePowder;
            for (int i = 13701; i <= 13704; i++)
                materials[i] = Material.PinkGlazedTerracotta;
            for (int i = 25840; i <= 25855; i++)
                materials[i] = Material.PinkPetals;
            for (int i = 13617; i <= 13622; i++)
                materials[i] = Material.PinkShulkerBox;
            materials[6120] = Material.PinkStainedGlass;
            for (int i = 10363; i <= 10394; i++)
                materials[i] = Material.PinkStainedGlassPane;
            materials[10161] = Material.PinkTerracotta;
            materials[2127] = Material.PinkTulip;
            for (int i = 11918; i <= 11921; i++)
                materials[i] = Material.PinkWallBanner;
            materials[2096] = Material.PinkWool;
            for (int i = 2054; i <= 2065; i++)
                materials[i] = Material.Piston;
            for (int i = 2066; i <= 2089; i++)
                materials[i] = Material.PistonHead;
            for (int i = 13510; i <= 13519; i++)
                materials[i] = Material.PitcherCrop;
            for (int i = 13520; i <= 13521; i++)
                materials[i] = Material.PitcherPlant;
            for (int i = 9746; i <= 9777; i++)
                materials[i] = Material.PlayerHead;
            for (int i = 9778; i <= 9785; i++)
                materials[i] = Material.PlayerWallHead;
            for (int i = 12; i <= 13; i++)
                materials[i] = Material.Podzol;
            for (int i = 25761; i <= 25780; i++)
                materials[i] = Material.PointedDripstone;
            materials[7] = Material.PolishedAndesite;
            for (int i = 15161; i <= 15166; i++)
                materials[i] = Material.PolishedAndesiteSlab;
            for (int i = 14935; i <= 15014; i++)
                materials[i] = Material.PolishedAndesiteStairs;
            for (int i = 6024; i <= 6026; i++)
                materials[i] = Material.PolishedBasalt;
            materials[20884] = Material.PolishedBlackstone;
            for (int i = 20888; i <= 20893; i++)
                materials[i] = Material.PolishedBlackstoneBrickSlab;
            for (int i = 20894; i <= 20973; i++)
                materials[i] = Material.PolishedBlackstoneBrickStairs;
            for (int i = 20974; i <= 21297; i++)
                materials[i] = Material.PolishedBlackstoneBrickWall;
            materials[20885] = Material.PolishedBlackstoneBricks;
            for (int i = 21387; i <= 21410; i++)
                materials[i] = Material.PolishedBlackstoneButton;
            for (int i = 21385; i <= 21386; i++)
                materials[i] = Material.PolishedBlackstonePressurePlate;
            for (int i = 21379; i <= 21384; i++)
                materials[i] = Material.PolishedBlackstoneSlab;
            for (int i = 21299; i <= 21378; i++)
                materials[i] = Material.PolishedBlackstoneStairs;
            for (int i = 21411; i <= 21734; i++)
                materials[i] = Material.PolishedBlackstoneWall;
            materials[26331] = Material.PolishedDeepslate;
            for (int i = 26412; i <= 26417; i++)
                materials[i] = Material.PolishedDeepslateSlab;
            for (int i = 26332; i <= 26411; i++)
                materials[i] = Material.PolishedDeepslateStairs;
            for (int i = 26418; i <= 26741; i++)
                materials[i] = Material.PolishedDeepslateWall;
            materials[5] = Material.PolishedDiorite;
            for (int i = 15113; i <= 15118; i++)
                materials[i] = Material.PolishedDioriteSlab;
            for (int i = 14215; i <= 14294; i++)
                materials[i] = Material.PolishedDioriteStairs;
            materials[3] = Material.PolishedGranite;
            for (int i = 15095; i <= 15100; i++)
                materials[i] = Material.PolishedGraniteSlab;
            for (int i = 13975; i <= 14054; i++)
                materials[i] = Material.PolishedGraniteStairs;
            materials[22505] = Material.PolishedTuff;
            for (int i = 22506; i <= 22511; i++)
                materials[i] = Material.PolishedTuffSlab;
            for (int i = 22512; i <= 22591; i++)
                materials[i] = Material.PolishedTuffStairs;
            for (int i = 22592; i <= 22915; i++)
                materials[i] = Material.PolishedTuffWall;
            materials[2120] = Material.Poppy;
            for (int i = 9378; i <= 9385; i++)
                materials[i] = Material.Potatoes;
            materials[9347] = Material.PottedAcaciaSapling;
            materials[9356] = Material.PottedAllium;
            materials[27574] = Material.PottedAzaleaBush;
            materials[9357] = Material.PottedAzureBluet;
            materials[13970] = Material.PottedBamboo;
            materials[9345] = Material.PottedBirchSapling;
            materials[9355] = Material.PottedBlueOrchid;
            materials[9367] = Material.PottedBrownMushroom;
            materials[9369] = Material.PottedCactus;
            materials[9348] = Material.PottedCherrySapling;
            materials[27865] = Material.PottedClosedEyeblossom;
            materials[9363] = Material.PottedCornflower;
            materials[20468] = Material.PottedCrimsonFungus;
            materials[20470] = Material.PottedCrimsonRoots;
            materials[9353] = Material.PottedDandelion;
            materials[9349] = Material.PottedDarkOakSapling;
            materials[9368] = Material.PottedDeadBush;
            materials[9352] = Material.PottedFern;
            materials[27575] = Material.PottedFloweringAzaleaBush;
            materials[9346] = Material.PottedJungleSapling;
            materials[9364] = Material.PottedLilyOfTheValley;
            materials[9351] = Material.PottedMangrovePropagule;
            materials[9343] = Material.PottedOakSapling;
            materials[27864] = Material.PottedOpenEyeblossom;
            materials[9359] = Material.PottedOrangeTulip;
            materials[9362] = Material.PottedOxeyeDaisy;
            materials[9350] = Material.PottedPaleOakSapling;
            materials[9361] = Material.PottedPinkTulip;
            materials[9354] = Material.PottedPoppy;
            materials[9366] = Material.PottedRedMushroom;
            materials[9358] = Material.PottedRedTulip;
            materials[9344] = Material.PottedSpruceSapling;
            materials[9342] = Material.PottedTorchflower;
            materials[20469] = Material.PottedWarpedFungus;
            materials[20471] = Material.PottedWarpedRoots;
            materials[9360] = Material.PottedWhiteTulip;
            materials[9365] = Material.PottedWitherRose;
            materials[23331] = Material.PowderSnow;
            for (int i = 8177; i <= 8179; i++)
                materials[i] = Material.PowderSnowCauldron;
            for (int i = 1987; i <= 2010; i++)
                materials[i] = Material.PoweredRail;
            materials[11342] = Material.Prismarine;
            for (int i = 11591; i <= 11596; i++)
                materials[i] = Material.PrismarineBrickSlab;
            for (int i = 11425; i <= 11504; i++)
                materials[i] = Material.PrismarineBrickStairs;
            materials[11343] = Material.PrismarineBricks;
            for (int i = 11585; i <= 11590; i++)
                materials[i] = Material.PrismarineSlab;
            for (int i = 11345; i <= 11424; i++)
                materials[i] = Material.PrismarineStairs;
            for (int i = 15497; i <= 15820; i++)
                materials[i] = Material.PrismarineWall;
            materials[7044] = Material.Pumpkin;
            for (int i = 7054; i <= 7061; i++)
                materials[i] = Material.PumpkinStem;
            for (int i = 11798; i <= 11813; i++)
                materials[i] = Material.PurpleBanner;
            for (int i = 1891; i <= 1906; i++)
                materials[i] = Material.PurpleBed;
            for (int i = 21914; i <= 21929; i++)
                materials[i] = Material.PurpleCandle;
            for (int i = 22032; i <= 22033; i++)
                materials[i] = Material.PurpleCandleCake;
            materials[11617] = Material.PurpleCarpet;
            materials[13751] = Material.PurpleConcrete;
            materials[13767] = Material.PurpleConcretePowder;
            for (int i = 13717; i <= 13720; i++)
                materials[i] = Material.PurpleGlazedTerracotta;
            for (int i = 13641; i <= 13646; i++)
                materials[i] = Material.PurpleShulkerBox;
            materials[6124] = Material.PurpleStainedGlass;
            for (int i = 10491; i <= 10522; i++)
                materials[i] = Material.PurpleStainedGlassPane;
            materials[10165] = Material.PurpleTerracotta;
            for (int i = 11934; i <= 11937; i++)
                materials[i] = Material.PurpleWallBanner;
            materials[2100] = Material.PurpleWool;
            materials[13423] = Material.PurpurBlock;
            for (int i = 13424; i <= 13426; i++)
                materials[i] = Material.PurpurPillar;
            for (int i = 12185; i <= 12190; i++)
                materials[i] = Material.PurpurSlab;
            for (int i = 13427; i <= 13506; i++)
                materials[i] = Material.PurpurStairs;
            materials[10034] = Material.QuartzBlock;
            materials[21737] = Material.QuartzBricks;
            for (int i = 10036; i <= 10038; i++)
                materials[i] = Material.QuartzPillar;
            for (int i = 12167; i <= 12172; i++)
                materials[i] = Material.QuartzSlab;
            for (int i = 10039; i <= 10118; i++)
                materials[i] = Material.QuartzStairs;
            for (int i = 4749; i <= 4768; i++)
                materials[i] = Material.Rail;
            materials[27572] = Material.RawCopperBlock;
            materials[27573] = Material.RawGoldBlock;
            materials[27571] = Material.RawIronBlock;
            for (int i = 11862; i <= 11877; i++)
                materials[i] = Material.RedBanner;
            for (int i = 1955; i <= 1970; i++)
                materials[i] = Material.RedBed;
            for (int i = 21978; i <= 21993; i++)
                materials[i] = Material.RedCandle;
            for (int i = 22040; i <= 22041; i++)
                materials[i] = Material.RedCandleCake;
            materials[11621] = Material.RedCarpet;
            materials[13755] = Material.RedConcrete;
            materials[13771] = Material.RedConcretePowder;
            for (int i = 13733; i <= 13736; i++)
                materials[i] = Material.RedGlazedTerracotta;
            materials[2133] = Material.RedMushroom;
            for (int i = 6846; i <= 6909; i++)
                materials[i] = Material.RedMushroomBlock;
            for (int i = 15155; i <= 15160; i++)
                materials[i] = Material.RedNetherBrickSlab;
            for (int i = 14855; i <= 14934; i++)
                materials[i] = Material.RedNetherBrickStairs;
            for (int i = 18089; i <= 18412; i++)
                materials[i] = Material.RedNetherBrickWall;
            materials[13558] = Material.RedNetherBricks;
            materials[123] = Material.RedSand;
            materials[11958] = Material.RedSandstone;
            for (int i = 12173; i <= 12178; i++)
                materials[i] = Material.RedSandstoneSlab;
            for (int i = 11961; i <= 12040; i++)
                materials[i] = Material.RedSandstoneStairs;
            for (int i = 15821; i <= 16144; i++)
                materials[i] = Material.RedSandstoneWall;
            for (int i = 13665; i <= 13670; i++)
                materials[i] = Material.RedShulkerBox;
            materials[6128] = Material.RedStainedGlass;
            for (int i = 10619; i <= 10650; i++)
                materials[i] = Material.RedStainedGlassPane;
            materials[10169] = Material.RedTerracotta;
            materials[2124] = Material.RedTulip;
            for (int i = 11950; i <= 11953; i++)
                materials[i] = Material.RedWallBanner;
            materials[2104] = Material.RedWool;
            materials[10022] = Material.RedstoneBlock;
            for (int i = 8191; i <= 8192; i++)
                materials[i] = Material.RedstoneLamp;
            for (int i = 5903; i <= 5904; i++)
                materials[i] = Material.RedstoneOre;
            for (int i = 5907; i <= 5908; i++)
                materials[i] = Material.RedstoneTorch;
            for (int i = 5909; i <= 5916; i++)
                materials[i] = Material.RedstoneWallTorch;
            for (int i = 3033; i <= 4328; i++)
                materials[i] = Material.RedstoneWire;
            materials[27586] = Material.ReinforcedDeepslate;
            for (int i = 6050; i <= 6113; i++)
                materials[i] = Material.Repeater;
            for (int i = 13528; i <= 13539; i++)
                materials[i] = Material.RepeatingCommandBlock;
            materials[7633] = Material.ResinBlock;
            for (int i = 7715; i <= 7720; i++)
                materials[i] = Material.ResinBrickSlab;
            for (int i = 7635; i <= 7714; i++)
                materials[i] = Material.ResinBrickStairs;
            for (int i = 7721; i <= 8044; i++)
                materials[i] = Material.ResinBrickWall;
            materials[7634] = Material.ResinBricks;
            for (int i = 7230; i <= 7357; i++)
                materials[i] = Material.ResinClump;
            for (int i = 20463; i <= 20467; i++)
                materials[i] = Material.RespawnAnchor;
            materials[25915] = Material.RootedDirt;
            for (int i = 11630; i <= 11631; i++)
                materials[i] = Material.RoseBush;
            materials[118] = Material.Sand;
            materials[578] = Material.Sandstone;
            for (int i = 12119; i <= 12124; i++)
                materials[i] = Material.SandstoneSlab;
            for (int i = 8205; i <= 8284; i++)
                materials[i] = Material.SandstoneStairs;
            for (int i = 18413; i <= 18736; i++)
                materials[i] = Material.SandstoneWall;
            for (int i = 19385; i <= 19416; i++)
                materials[i] = Material.Scaffolding;
            materials[23812] = Material.Sculk;
            for (int i = 23941; i <= 23942; i++)
                materials[i] = Material.SculkCatalyst;
            for (int i = 23332; i <= 23427; i++)
                materials[i] = Material.SculkSensor;
            for (int i = 23943; i <= 23950; i++)
                materials[i] = Material.SculkShrieker;
            for (int i = 23813; i <= 23940; i++)
                materials[i] = Material.SculkVein;
            materials[11603] = Material.SeaLantern;
            for (int i = 13946; i <= 13953; i++)
                materials[i] = Material.SeaPickle;
            materials[2051] = Material.Seagrass;
            materials[2048] = Material.ShortGrass;
            materials[19623] = Material.Shroomlight;
            for (int i = 13575; i <= 13580; i++)
                materials[i] = Material.ShulkerBox;
            for (int i = 9626; i <= 9657; i++)
                materials[i] = Material.SkeletonSkull;
            for (int i = 9658; i <= 9665; i++)
                materials[i] = Material.SkeletonWallSkull;
            materials[11243] = Material.SlimeBlock;
            for (int i = 22082; i <= 22093; i++)
                materials[i] = Material.SmallAmethystBud;
            for (int i = 25897; i <= 25912; i++)
                materials[i] = Material.SmallDripleaf;
            materials[19479] = Material.SmithingTable;
            for (int i = 19433; i <= 19440; i++)
                materials[i] = Material.Smoker;
            materials[27570] = Material.SmoothBasalt;
            materials[12193] = Material.SmoothQuartz;
            for (int i = 15137; i <= 15142; i++)
                materials[i] = Material.SmoothQuartzSlab;
            for (int i = 14615; i <= 14694; i++)
                materials[i] = Material.SmoothQuartzStairs;
            materials[12194] = Material.SmoothRedSandstone;
            for (int i = 15101; i <= 15106; i++)
                materials[i] = Material.SmoothRedSandstoneSlab;
            for (int i = 14055; i <= 14134; i++)
                materials[i] = Material.SmoothRedSandstoneStairs;
            materials[12192] = Material.SmoothSandstone;
            for (int i = 15131; i <= 15136; i++)
                materials[i] = Material.SmoothSandstoneSlab;
            for (int i = 14535; i <= 14614; i++)
                materials[i] = Material.SmoothSandstoneStairs;
            materials[12191] = Material.SmoothStone;
            for (int i = 12113; i <= 12118; i++)
                materials[i] = Material.SmoothStoneSlab;
            for (int i = 13813; i <= 13815; i++)
                materials[i] = Material.SnifferEgg;
            for (int i = 5941; i <= 5948; i++)
                materials[i] = Material.Snow;
            materials[5950] = Material.SnowBlock;
            for (int i = 19556; i <= 19587; i++)
                materials[i] = Material.SoulCampfire;
            materials[2915] = Material.SoulFire;
            for (int i = 19520; i <= 19523; i++)
                materials[i] = Material.SoulLantern;
            materials[6019] = Material.SoulSand;
            materials[6020] = Material.SoulSoil;
            materials[6027] = Material.SoulTorch;
            for (int i = 6028; i <= 6031; i++)
                materials[i] = Material.SoulWallTorch;
            materials[2916] = Material.Spawner;
            materials[560] = Material.Sponge;
            materials[25836] = Material.SporeBlossom;
            for (int i = 9410; i <= 9433; i++)
                materials[i] = Material.SpruceButton;
            for (int i = 12771; i <= 12834; i++)
                materials[i] = Material.SpruceDoor;
            for (int i = 12483; i <= 12514; i++)
                materials[i] = Material.SpruceFence;
            for (int i = 12195; i <= 12226; i++)
                materials[i] = Material.SpruceFenceGate;
            for (int i = 4993; i <= 5056; i++)
                materials[i] = Material.SpruceHangingSign;
            for (int i = 280; i <= 307; i++)
                materials[i] = Material.SpruceLeaves;
            for (int i = 139; i <= 141; i++)
                materials[i] = Material.SpruceLog;
            materials[16] = Material.SprucePlanks;
            for (int i = 5885; i <= 5886; i++)
                materials[i] = Material.SprucePressurePlate;
            for (int i = 31; i <= 32; i++)
                materials[i] = Material.SpruceSapling;
            for (int i = 4389; i <= 4420; i++)
                materials[i] = Material.SpruceSign;
            for (int i = 12047; i <= 12052; i++)
                materials[i] = Material.SpruceSlab;
            for (int i = 8440; i <= 8519; i++)
                materials[i] = Material.SpruceStairs;
            for (int i = 6194; i <= 6257; i++)
                materials[i] = Material.SpruceTrapdoor;
            for (int i = 5705; i <= 5712; i++)
                materials[i] = Material.SpruceWallHangingSign;
            for (int i = 4857; i <= 4864; i++)
                materials[i] = Material.SpruceWallSign;
            for (int i = 204; i <= 206; i++)
                materials[i] = Material.SpruceWood;
            for (int i = 2035; i <= 2046; i++)
                materials[i] = Material.StickyPiston;
            materials[1] = Material.Stone;
            for (int i = 12149; i <= 12154; i++)
                materials[i] = Material.StoneBrickSlab;
            for (int i = 7470; i <= 7549; i++)
                materials[i] = Material.StoneBrickStairs;
            for (int i = 16793; i <= 17116; i++)
                materials[i] = Material.StoneBrickWall;
            materials[6770] = Material.StoneBricks;
            for (int i = 5917; i <= 5940; i++)
                materials[i] = Material.StoneButton;
            for (int i = 5817; i <= 5818; i++)
                materials[i] = Material.StonePressurePlate;
            for (int i = 12107; i <= 12112; i++)
                materials[i] = Material.StoneSlab;
            for (int i = 14455; i <= 14534; i++)
                materials[i] = Material.StoneStairs;
            for (int i = 19480; i <= 19483; i++)
                materials[i] = Material.Stonecutter;
            for (int i = 180; i <= 182; i++)
                materials[i] = Material.StrippedAcaciaLog;
            for (int i = 237; i <= 239; i++)
                materials[i] = Material.StrippedAcaciaWood;
            for (int i = 198; i <= 200; i++)
                materials[i] = Material.StrippedBambooBlock;
            for (int i = 174; i <= 176; i++)
                materials[i] = Material.StrippedBirchLog;
            for (int i = 231; i <= 233; i++)
                materials[i] = Material.StrippedBirchWood;
            for (int i = 183; i <= 185; i++)
                materials[i] = Material.StrippedCherryLog;
            for (int i = 240; i <= 242; i++)
                materials[i] = Material.StrippedCherryWood;
            for (int i = 19618; i <= 19620; i++)
                materials[i] = Material.StrippedCrimsonHyphae;
            for (int i = 19612; i <= 19614; i++)
                materials[i] = Material.StrippedCrimsonStem;
            for (int i = 186; i <= 188; i++)
                materials[i] = Material.StrippedDarkOakLog;
            for (int i = 243; i <= 245; i++)
                materials[i] = Material.StrippedDarkOakWood;
            for (int i = 177; i <= 179; i++)
                materials[i] = Material.StrippedJungleLog;
            for (int i = 234; i <= 236; i++)
                materials[i] = Material.StrippedJungleWood;
            for (int i = 195; i <= 197; i++)
                materials[i] = Material.StrippedMangroveLog;
            for (int i = 249; i <= 251; i++)
                materials[i] = Material.StrippedMangroveWood;
            for (int i = 192; i <= 194; i++)
                materials[i] = Material.StrippedOakLog;
            for (int i = 225; i <= 227; i++)
                materials[i] = Material.StrippedOakWood;
            for (int i = 189; i <= 191; i++)
                materials[i] = Material.StrippedPaleOakLog;
            for (int i = 246; i <= 248; i++)
                materials[i] = Material.StrippedPaleOakWood;
            for (int i = 171; i <= 173; i++)
                materials[i] = Material.StrippedSpruceLog;
            for (int i = 228; i <= 230; i++)
                materials[i] = Material.StrippedSpruceWood;
            for (int i = 19601; i <= 19603; i++)
                materials[i] = Material.StrippedWarpedHyphae;
            for (int i = 19595; i <= 19597; i++)
                materials[i] = Material.StrippedWarpedStem;
            for (int i = 20369; i <= 20372; i++)
                materials[i] = Material.StructureBlock;
            materials[13562] = Material.StructureVoid;
            for (int i = 5968; i <= 5983; i++)
                materials[i] = Material.SugarCane;
            for (int i = 11626; i <= 11627; i++)
                materials[i] = Material.Sunflower;
            for (int i = 125; i <= 128; i++)
                materials[i] = Material.SuspiciousGravel;
            for (int i = 119; i <= 122; i++)
                materials[i] = Material.SuspiciousSand;
            for (int i = 19588; i <= 19591; i++)
                materials[i] = Material.SweetBerryBush;
            for (int i = 11634; i <= 11635; i++)
                materials[i] = Material.TallGrass;
            for (int i = 2052; i <= 2053; i++)
                materials[i] = Material.TallSeagrass;
            for (int i = 20394; i <= 20409; i++)
                materials[i] = Material.Target;
            materials[11623] = Material.Terracotta;
            materials[23330] = Material.TintedGlass;
            for (int i = 2137; i <= 2138; i++)
                materials[i] = Material.Tnt;
            materials[2398] = Material.Torch;
            materials[2119] = Material.Torchflower;
            for (int i = 13508; i <= 13509; i++)
                materials[i] = Material.TorchflowerCrop;
            for (int i = 9918; i <= 9941; i++)
                materials[i] = Material.TrappedChest;
            for (int i = 27651; i <= 27662; i++)
                materials[i] = Material.TrialSpawner;
            for (int i = 8311; i <= 8438; i++)
                materials[i] = Material.Tripwire;
            for (int i = 8295; i <= 8310; i++)
                materials[i] = Material.TripwireHook;
            for (int i = 13836; i <= 13837; i++)
                materials[i] = Material.TubeCoral;
            materials[13821] = Material.TubeCoralBlock;
            for (int i = 13856; i <= 13857; i++)
                materials[i] = Material.TubeCoralFan;
            for (int i = 13906; i <= 13913; i++)
                materials[i] = Material.TubeCoralWallFan;
            materials[22094] = Material.Tuff;
            for (int i = 22918; i <= 22923; i++)
                materials[i] = Material.TuffBrickSlab;
            for (int i = 22924; i <= 23003; i++)
                materials[i] = Material.TuffBrickStairs;
            for (int i = 23004; i <= 23327; i++)
                materials[i] = Material.TuffBrickWall;
            materials[22917] = Material.TuffBricks;
            for (int i = 22095; i <= 22100; i++)
                materials[i] = Material.TuffSlab;
            for (int i = 22101; i <= 22180; i++)
                materials[i] = Material.TuffStairs;
            for (int i = 22181; i <= 22504; i++)
                materials[i] = Material.TuffWall;
            for (int i = 13801; i <= 13812; i++)
                materials[i] = Material.TurtleEgg;
            for (int i = 19651; i <= 19676; i++)
                materials[i] = Material.TwistingVines;
            materials[19677] = Material.TwistingVinesPlant;
            for (int i = 27663; i <= 27694; i++)
                materials[i] = Material.Vault;
            for (int i = 27579; i <= 27581; i++)
                materials[i] = Material.VerdantFroglight;
            for (int i = 7070; i <= 7101; i++)
                materials[i] = Material.Vine;
            materials[13971] = Material.VoidAir;
            for (int i = 2399; i <= 2402; i++)
                materials[i] = Material.WallTorch;
            for (int i = 20137; i <= 20160; i++)
                materials[i] = Material.WarpedButton;
            for (int i = 20225; i <= 20288; i++)
                materials[i] = Material.WarpedDoor;
            for (int i = 19729; i <= 19760; i++)
                materials[i] = Material.WarpedFence;
            for (int i = 19921; i <= 19952; i++)
                materials[i] = Material.WarpedFenceGate;
            materials[19605] = Material.WarpedFungus;
            for (int i = 5505; i <= 5568; i++)
                materials[i] = Material.WarpedHangingSign;
            for (int i = 19598; i <= 19600; i++)
                materials[i] = Material.WarpedHyphae;
            materials[19604] = Material.WarpedNylium;
            materials[19680] = Material.WarpedPlanks;
            for (int i = 19695; i <= 19696; i++)
                materials[i] = Material.WarpedPressurePlate;
            materials[19607] = Material.WarpedRoots;
            for (int i = 20321; i <= 20352; i++)
                materials[i] = Material.WarpedSign;
            for (int i = 19687; i <= 19692; i++)
                materials[i] = Material.WarpedSlab;
            for (int i = 20033; i <= 20112; i++)
                materials[i] = Material.WarpedStairs;
            for (int i = 19592; i <= 19594; i++)
                materials[i] = Material.WarpedStem;
            for (int i = 19825; i <= 19888; i++)
                materials[i] = Material.WarpedTrapdoor;
            for (int i = 5777; i <= 5784; i++)
                materials[i] = Material.WarpedWallHangingSign;
            for (int i = 20361; i <= 20368; i++)
                materials[i] = Material.WarpedWallSign;
            materials[19606] = Material.WarpedWartBlock;
            for (int i = 86; i <= 101; i++)
                materials[i] = Material.Water;
            for (int i = 8173; i <= 8175; i++)
                materials[i] = Material.WaterCauldron;
            materials[23968] = Material.WaxedChiseledCopper;
            materials[24313] = Material.WaxedCopperBlock;
            for (int i = 25721; i <= 25724; i++)
                materials[i] = Material.WaxedCopperBulb;
            for (int i = 24921; i <= 24984; i++)
                materials[i] = Material.WaxedCopperDoor;
            for (int i = 25697; i <= 25698; i++)
                materials[i] = Material.WaxedCopperGrate;
            for (int i = 25433; i <= 25496; i++)
                materials[i] = Material.WaxedCopperTrapdoor;
            materials[24320] = Material.WaxedCutCopper;
            for (int i = 24659; i <= 24664; i++)
                materials[i] = Material.WaxedCutCopperSlab;
            for (int i = 24561; i <= 24640; i++)
                materials[i] = Material.WaxedCutCopperStairs;
            materials[23967] = Material.WaxedExposedChiseledCopper;
            materials[24315] = Material.WaxedExposedCopper;
            for (int i = 25725; i <= 25728; i++)
                materials[i] = Material.WaxedExposedCopperBulb;
            for (int i = 24985; i <= 25048; i++)
                materials[i] = Material.WaxedExposedCopperDoor;
            for (int i = 25699; i <= 25700; i++)
                materials[i] = Material.WaxedExposedCopperGrate;
            for (int i = 25497; i <= 25560; i++)
                materials[i] = Material.WaxedExposedCopperTrapdoor;
            materials[24319] = Material.WaxedExposedCutCopper;
            for (int i = 24653; i <= 24658; i++)
                materials[i] = Material.WaxedExposedCutCopperSlab;
            for (int i = 24481; i <= 24560; i++)
                materials[i] = Material.WaxedExposedCutCopperStairs;
            materials[23965] = Material.WaxedOxidizedChiseledCopper;
            materials[24316] = Material.WaxedOxidizedCopper;
            for (int i = 25733; i <= 25736; i++)
                materials[i] = Material.WaxedOxidizedCopperBulb;
            for (int i = 25049; i <= 25112; i++)
                materials[i] = Material.WaxedOxidizedCopperDoor;
            for (int i = 25703; i <= 25704; i++)
                materials[i] = Material.WaxedOxidizedCopperGrate;
            for (int i = 25561; i <= 25624; i++)
                materials[i] = Material.WaxedOxidizedCopperTrapdoor;
            materials[24317] = Material.WaxedOxidizedCutCopper;
            for (int i = 24641; i <= 24646; i++)
                materials[i] = Material.WaxedOxidizedCutCopperSlab;
            for (int i = 24321; i <= 24400; i++)
                materials[i] = Material.WaxedOxidizedCutCopperStairs;
            materials[23966] = Material.WaxedWeatheredChiseledCopper;
            materials[24314] = Material.WaxedWeatheredCopper;
            for (int i = 25729; i <= 25732; i++)
                materials[i] = Material.WaxedWeatheredCopperBulb;
            for (int i = 25113; i <= 25176; i++)
                materials[i] = Material.WaxedWeatheredCopperDoor;
            for (int i = 25701; i <= 25702; i++)
                materials[i] = Material.WaxedWeatheredCopperGrate;
            for (int i = 25625; i <= 25688; i++)
                materials[i] = Material.WaxedWeatheredCopperTrapdoor;
            materials[24318] = Material.WaxedWeatheredCutCopper;
            for (int i = 24647; i <= 24652; i++)
                materials[i] = Material.WaxedWeatheredCutCopperSlab;
            for (int i = 24401; i <= 24480; i++)
                materials[i] = Material.WaxedWeatheredCutCopperStairs;
            materials[23962] = Material.WeatheredChiseledCopper;
            materials[23953] = Material.WeatheredCopper;
            for (int i = 25713; i <= 25716; i++)
                materials[i] = Material.WeatheredCopperBulb;
            for (int i = 24857; i <= 24920; i++)
                materials[i] = Material.WeatheredCopperDoor;
            for (int i = 25693; i <= 25694; i++)
                materials[i] = Material.WeatheredCopperGrate;
            for (int i = 25369; i <= 25432; i++)
                materials[i] = Material.WeatheredCopperTrapdoor;
            materials[23958] = Material.WeatheredCutCopper;
            for (int i = 24295; i <= 24300; i++)
                materials[i] = Material.WeatheredCutCopperSlab;
            for (int i = 24049; i <= 24128; i++)
                materials[i] = Material.WeatheredCutCopperStairs;
            for (int i = 19624; i <= 19649; i++)
                materials[i] = Material.WeepingVines;
            materials[19650] = Material.WeepingVinesPlant;
            materials[561] = Material.WetSponge;
            for (int i = 4333; i <= 4340; i++)
                materials[i] = Material.Wheat;
            for (int i = 11638; i <= 11653; i++)
                materials[i] = Material.WhiteBanner;
            for (int i = 1731; i <= 1746; i++)
                materials[i] = Material.WhiteBed;
            for (int i = 21754; i <= 21769; i++)
                materials[i] = Material.WhiteCandle;
            for (int i = 22012; i <= 22013; i++)
                materials[i] = Material.WhiteCandleCake;
            materials[11607] = Material.WhiteCarpet;
            materials[13741] = Material.WhiteConcrete;
            materials[13757] = Material.WhiteConcretePowder;
            for (int i = 13677; i <= 13680; i++)
                materials[i] = Material.WhiteGlazedTerracotta;
            for (int i = 13581; i <= 13586; i++)
                materials[i] = Material.WhiteShulkerBox;
            materials[6114] = Material.WhiteStainedGlass;
            for (int i = 10171; i <= 10202; i++)
                materials[i] = Material.WhiteStainedGlassPane;
            materials[10155] = Material.WhiteTerracotta;
            materials[2126] = Material.WhiteTulip;
            for (int i = 11894; i <= 11897; i++)
                materials[i] = Material.WhiteWallBanner;
            materials[2090] = Material.WhiteWool;
            materials[2130] = Material.WitherRose;
            for (int i = 9666; i <= 9697; i++)
                materials[i] = Material.WitherSkeletonSkull;
            for (int i = 9698; i <= 9705; i++)
                materials[i] = Material.WitherSkeletonWallSkull;
            for (int i = 11702; i <= 11717; i++)
                materials[i] = Material.YellowBanner;
            for (int i = 1795; i <= 1810; i++)
                materials[i] = Material.YellowBed;
            for (int i = 21818; i <= 21833; i++)
                materials[i] = Material.YellowCandle;
            for (int i = 22020; i <= 22021; i++)
                materials[i] = Material.YellowCandleCake;
            materials[11611] = Material.YellowCarpet;
            materials[13745] = Material.YellowConcrete;
            materials[13761] = Material.YellowConcretePowder;
            for (int i = 13693; i <= 13696; i++)
                materials[i] = Material.YellowGlazedTerracotta;
            for (int i = 13605; i <= 13610; i++)
                materials[i] = Material.YellowShulkerBox;
            materials[6118] = Material.YellowStainedGlass;
            for (int i = 10299; i <= 10330; i++)
                materials[i] = Material.YellowStainedGlassPane;
            materials[10159] = Material.YellowTerracotta;
            for (int i = 11910; i <= 11913; i++)
                materials[i] = Material.YellowWallBanner;
            materials[2094] = Material.YellowWool;
            for (int i = 9706; i <= 9737; i++)
                materials[i] = Material.ZombieHead;
            for (int i = 9738; i <= 9745; i++)
                materials[i] = Material.ZombieWallHead;
        }

        // <auto-generated block-state-properties>
        private static readonly BlockStateDefinition[] stateDefinitions =
        [
            new(8, 2,
            [
                new("snowy", ["true", "false"], 1)
            ]),
            new(12, 2,
            [
                new("snowy", ["true", "false"], 1)
            ]),
            new(22, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(29, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(31, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(33, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(35, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(37, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(39, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(41, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(43, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(45, 40,
            [
                new("age", ["0", "1", "2", "3", "4"], 8),
                new("hanging", ["true", "false"], 4),
                new("stage", ["0", "1"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(86, 16,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(102, 16,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(119, 4,
            [
                new("dusted", ["0", "1", "2", "3"], 1)
            ]),
            new(125, 4,
            [
                new("dusted", ["0", "1", "2", "3"], 1)
            ]),
            new(136, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(139, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(142, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(145, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(148, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(151, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(154, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(157, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(160, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(163, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(165, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(168, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(171, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(174, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(177, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(180, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(183, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(186, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(189, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(192, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(195, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(198, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(201, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(204, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(207, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(210, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(213, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(216, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(219, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(222, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(225, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(228, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(231, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(234, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(237, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(240, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(243, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(246, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(249, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(252, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(280, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(308, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(336, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(364, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(392, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(420, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(448, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(476, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(504, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(532, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(566, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("triggered", ["true", "false"], 1)
            ]),
            new(581, 1150,
            [
                new("instrument", ["harp", "basedrum", "snare", "hat", "bass", "flute", "bell", "guitar", "chime", "xylophone", "iron_xylophone", "cow_bell", "didgeridoo", "bit", "banjo", "pling", "zombie", "skeleton", "creeper", "dragon", "wither_skeleton", "piglin", "custom_head"], 50),
                new("note", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(1731, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1747, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1763, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1779, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1795, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1811, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1827, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1843, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1859, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1875, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1891, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1907, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1923, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1939, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1955, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1971, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1987, 24,
            [
                new("powered", ["true", "false"], 12),
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(2011, 24,
            [
                new("powered", ["true", "false"], 12),
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(2035, 12,
            [
                new("extended", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(2052, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(2054, 12,
            [
                new("extended", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(2066, 24,
            [
                new("type", ["normal", "sticky"], 1),
                new("facing", ["north", "east", "south", "west", "up", "down"], 4),
                new("short", ["true", "false"], 2)
            ]),
            new(2106, 12,
            [
                new("type", ["normal", "sticky"], 1),
                new("facing", ["north", "east", "south", "west", "up", "down"], 2)
            ]),
            new(2137, 2,
            [
                new("unstable", ["true", "false"], 1)
            ]),
            new(2140, 256,
            [
                new("facing", ["north", "south", "west", "east"], 64),
                new("slot_0_occupied", ["true", "false"], 32),
                new("slot_1_occupied", ["true", "false"], 16),
                new("slot_2_occupied", ["true", "false"], 8),
                new("slot_3_occupied", ["true", "false"], 4),
                new("slot_4_occupied", ["true", "false"], 2),
                new("slot_5_occupied", ["true", "false"], 1)
            ]),
            new(2399, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(2403, 512,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(2917, 12,
            [
                new("active", ["true", "false"], 6),
                new("axis", ["x", "y", "z"], 2),
                new("natural", ["true", "false"], 1)
            ]),
            new(2929, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3009, 24,
            [
                new("type", ["single", "left", "right"], 2),
                new("facing", ["north", "south", "west", "east"], 6),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3033, 1296,
            [
                new("east", ["up", "side", "none"], 432),
                new("north", ["up", "side", "none"], 144),
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 9),
                new("south", ["up", "side", "none"], 3),
                new("west", ["up", "side", "none"], 1)
            ]),
            new(4333, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(4341, 8,
            [
                new("moisture", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(4349, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(4357, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4389, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4421, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4453, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4485, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4517, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4549, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4581, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4613, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4645, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4677, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(4741, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4749, 20,
            [
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south", "south_east", "south_west", "north_west", "north_east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4769, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4849, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4857, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4865, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4873, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4881, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4889, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4897, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4905, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4913, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4921, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4929, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4993, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5057, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5121, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5185, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5249, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5313, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5377, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5441, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5505, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5569, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5633, 64,
            [
                new("attached", ["true", "false"], 32),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5697, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5705, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5713, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5721, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5729, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5737, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5745, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5753, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5761, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5769, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5777, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5785, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5793, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5817, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5819, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5883, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5885, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5887, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5889, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5891, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5893, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5895, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5897, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5899, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5901, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(5903, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(5905, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(5907, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(5909, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(5917, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5941, 8,
            [
                new("layers", ["1", "2", "3", "4", "5", "6", "7", "8"], 1)
            ]),
            new(5951, 16,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5968, 16,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5984, 2,
            [
                new("has_record", ["true", "false"], 1)
            ]),
            new(5986, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6021, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(6024, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(6028, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(6033, 2,
            [
                new("axis", ["x", "z"], 1)
            ]),
            new(6035, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(6039, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(6043, 7,
            [
                new("bites", ["0", "1", "2", "3", "4", "5", "6"], 1)
            ]),
            new(6050, 64,
            [
                new("delay", ["1", "2", "3", "4"], 16),
                new("facing", ["north", "south", "west", "east"], 4),
                new("locked", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(6130, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6194, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6258, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6322, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6386, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6450, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6514, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6578, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6642, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6706, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6782, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6846, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6910, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6974, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7006, 6,
            [
                new("axis", ["x", "y", "z"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7012, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7046, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7050, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7054, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(7062, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(7070, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7102, 128,
            [
                new("down", ["true", "false"], 64),
                new("east", ["true", "false"], 32),
                new("north", ["true", "false"], 16),
                new("south", ["true", "false"], 8),
                new("up", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7230, 128,
            [
                new("down", ["true", "false"], 64),
                new("east", ["true", "false"], 32),
                new("north", ["true", "false"], 16),
                new("south", ["true", "false"], 8),
                new("up", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7358, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7390, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7470, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7550, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7630, 2,
            [
                new("snowy", ["true", "false"], 1)
            ]),
            new(7635, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7715, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7721, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(8047, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(8079, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8159, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(8164, 8,
            [
                new("has_bottle_0", ["true", "false"], 4),
                new("has_bottle_1", ["true", "false"], 2),
                new("has_bottle_2", ["true", "false"], 1)
            ]),
            new(8173, 3,
            [
                new("level", ["1", "2", "3"], 1)
            ]),
            new(8177, 3,
            [
                new("level", ["1", "2", "3"], 1)
            ]),
            new(8181, 8,
            [
                new("eye", ["true", "false"], 4),
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8191, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(8193, 12,
            [
                new("age", ["0", "1", "2"], 4),
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8205, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8287, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8295, 16,
            [
                new("attached", ["true", "false"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(8311, 128,
            [
                new("attached", ["true", "false"], 64),
                new("disarmed", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("powered", ["true", "false"], 4),
                new("south", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(8440, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8520, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8600, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8680, 12,
            [
                new("conditional", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8693, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(9017, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(9370, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(9378, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(9386, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9410, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9434, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9458, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9482, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9506, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9530, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9554, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9578, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9602, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9626, 32,
            [
                new("powered", ["true", "false"], 16),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(9658, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9666, 32,
            [
                new("powered", ["true", "false"], 16),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(9698, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9706, 32,
            [
                new("powered", ["true", "false"], 16),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(9738, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9746, 32,
            [
                new("powered", ["true", "false"], 16),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(9778, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9786, 32,
            [
                new("powered", ["true", "false"], 16),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(9818, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9826, 32,
            [
                new("powered", ["true", "false"], 16),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(9858, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9866, 32,
            [
                new("powered", ["true", "false"], 16),
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(9898, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9906, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(9910, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(9914, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(9918, 24,
            [
                new("type", ["single", "left", "right"], 2),
                new("facing", ["north", "south", "west", "east"], 6),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9942, 16,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(9958, 16,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(9974, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("mode", ["compare", "subtract"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9990, 32,
            [
                new("inverted", ["true", "false"], 16),
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(10024, 10,
            [
                new("enabled", ["true", "false"], 5),
                new("facing", ["down", "north", "south", "west", "east"], 1)
            ]),
            new(10036, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(10039, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10119, 24,
            [
                new("powered", ["true", "false"], 12),
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10143, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("triggered", ["true", "false"], 1)
            ]),
            new(10171, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10203, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10235, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10267, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10299, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10331, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10363, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10395, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10427, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10459, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10491, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10523, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10555, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10587, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10619, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10651, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10683, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10763, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10843, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10923, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11003, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11083, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11163, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11244, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11246, 32,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11278, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11345, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11425, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11505, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11585, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11591, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11597, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11604, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(11626, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(11628, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(11630, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(11632, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(11634, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(11636, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(11638, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11654, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11670, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11686, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11702, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11718, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11734, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11750, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11766, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11782, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11798, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11814, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11830, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11846, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11862, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11878, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(11894, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11898, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11902, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11906, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11910, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11914, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11918, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11922, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11926, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11930, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11934, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11938, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11942, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11946, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11950, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11954, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(11961, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12041, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12047, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12053, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12059, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12065, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12071, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12077, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12083, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12089, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12095, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12101, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12107, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12113, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12119, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12125, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12131, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12137, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12143, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12149, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12155, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12161, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12167, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12173, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12179, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12185, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(12195, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12227, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12259, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12291, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12323, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12355, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12387, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12419, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12451, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12483, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(12515, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(12547, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(12579, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(12611, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(12643, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(12675, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(12707, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(12739, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(12771, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12835, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12899, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(12963, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(13027, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(13091, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(13155, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(13219, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(13283, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(13347, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13353, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(13417, 6,
            [
                new("age", ["0", "1", "2", "3", "4", "5"], 1)
            ]),
            new(13424, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(13427, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13508, 2,
            [
                new("age", ["0", "1"], 1)
            ]),
            new(13510, 10,
            [
                new("age", ["0", "1", "2", "3", "4"], 2),
                new("half", ["upper", "lower"], 1)
            ]),
            new(13520, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(13522, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(13528, 12,
            [
                new("conditional", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13540, 12,
            [
                new("conditional", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13552, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(13559, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(13563, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(13575, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13581, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13587, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13593, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13599, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13605, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13611, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13617, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13623, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13629, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13635, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13641, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13647, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13653, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13659, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13665, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13671, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(13677, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13681, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13685, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13689, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13693, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13697, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13701, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13705, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13709, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13713, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13717, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13721, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13725, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13729, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13733, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13737, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(13773, 26,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"], 1)
            ]),
            new(13801, 12,
            [
                new("eggs", ["1", "2", "3", "4"], 3),
                new("hatch", ["0", "1", "2"], 1)
            ]),
            new(13813, 3,
            [
                new("hatch", ["0", "1", "2"], 1)
            ]),
            new(13826, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13828, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13830, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13832, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13834, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13836, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13838, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13840, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13842, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13844, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13846, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13848, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13850, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13852, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13854, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13856, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13858, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13860, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13862, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13864, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13866, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13874, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13882, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13890, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13898, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13906, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13914, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13922, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13930, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13938, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13946, 8,
            [
                new("pickles", ["1", "2", "3", "4"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13955, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(13958, 12,
            [
                new("age", ["0", "1"], 6),
                new("leaves", ["none", "small", "large"], 2),
                new("stage", ["0", "1"], 1)
            ]),
            new(13973, 2,
            [
                new("drag", ["true", "false"], 1)
            ]),
            new(13975, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14055, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14135, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14215, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14295, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14375, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14455, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14535, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14615, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14695, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14775, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14855, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(14935, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15015, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15095, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15101, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15107, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15113, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15119, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15125, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15131, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15137, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15143, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15149, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15155, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15161, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15167, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15173, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(15497, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(15821, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(16145, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(16469, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(16793, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(17117, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(17441, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(17765, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(18089, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(18413, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(18737, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(19061, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(19385, 32,
            [
                new("bottom", ["true", "false"], 16),
                new("distance", ["0", "1", "2", "3", "4", "5", "6", "7"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19417, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(19421, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("open", ["true", "false"], 1)
            ]),
            new(19433, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(19441, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(19451, 12,
            [
                new("face", ["floor", "wall", "ceiling"], 4),
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(19463, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("has_book", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(19480, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(19484, 32,
            [
                new("attachment", ["floor", "ceiling", "single_wall", "double_wall"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(19516, 4,
            [
                new("hanging", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19520, 4,
            [
                new("hanging", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19524, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("lit", ["true", "false"], 4),
                new("signal_fire", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19556, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("lit", ["true", "false"], 4),
                new("signal_fire", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19588, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(19592, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(19595, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(19598, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(19601, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(19609, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(19612, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(19615, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(19618, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(19624, 26,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"], 1)
            ]),
            new(19651, 26,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"], 1)
            ]),
            new(19681, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19687, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19693, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(19695, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(19697, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(19729, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(19761, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19825, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19889, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(19921, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(19953, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20033, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20113, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(20137, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(20161, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(20225, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(20289, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20321, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20353, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20361, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20369, 4,
            [
                new("mode", ["save", "load", "corner", "data"], 1)
            ]),
            new(20373, 12,
            [
                new("orientation", ["down_east", "down_north", "down_south", "down_west", "up_east", "up_north", "up_south", "up_west", "west_up", "east_up", "north_up", "south_up"], 1)
            ]),
            new(20385, 9,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8"], 1)
            ]),
            new(20394, 16,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(20410, 24,
            [
                new("facing", ["north", "south", "west", "east"], 6),
                new("honey_level", ["0", "1", "2", "3", "4", "5"], 1)
            ]),
            new(20434, 24,
            [
                new("facing", ["north", "south", "west", "east"], 6),
                new("honey_level", ["0", "1", "2", "3", "4", "5"], 1)
            ]),
            new(20463, 5,
            [
                new("charges", ["0", "1", "2", "3", "4"], 1)
            ]),
            new(20474, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20554, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(20878, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20888, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20894, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20974, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(21299, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21379, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21385, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(21387, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(21411, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(21738, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21754, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21770, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21786, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21802, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21818, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21834, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21850, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21866, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21882, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21898, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21914, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21930, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21946, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21962, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21978, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21994, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22010, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22012, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22014, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22016, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22018, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22020, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22022, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22024, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22026, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22028, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22030, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22032, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22034, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22036, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22038, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22040, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22042, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(22046, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22058, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22070, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22082, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22095, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22101, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22181, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(22506, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22512, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22592, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(22918, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(22924, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(23004, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(23332, 96,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 6),
                new("sculk_sensor_phase", ["inactive", "active", "cooldown"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(23428, 384,
            [
                new("facing", ["north", "south", "west", "east"], 96),
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 6),
                new("sculk_sensor_phase", ["inactive", "active", "cooldown"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(23813, 128,
            [
                new("down", ["true", "false"], 64),
                new("east", ["true", "false"], 32),
                new("north", ["true", "false"], 16),
                new("south", ["true", "false"], 8),
                new("up", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(23941, 2,
            [
                new("bloom", ["true", "false"], 1)
            ]),
            new(23943, 8,
            [
                new("can_summon", ["true", "false"], 4),
                new("shrieking", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(23969, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24049, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24129, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24209, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24289, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24295, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24301, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24307, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24321, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24401, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24481, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24561, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24641, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24647, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24653, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24659, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(24665, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(24729, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(24793, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(24857, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(24921, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(24985, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25049, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25113, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25177, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25241, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25305, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25369, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25433, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25497, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25561, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25625, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25689, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25691, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25693, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25695, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25697, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25699, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25701, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25703, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25705, 4,
            [
                new("lit", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25709, 4,
            [
                new("lit", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25713, 4,
            [
                new("lit", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25717, 4,
            [
                new("lit", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25721, 4,
            [
                new("lit", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25725, 4,
            [
                new("lit", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25729, 4,
            [
                new("lit", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25733, 4,
            [
                new("lit", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(25737, 24,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25761, 20,
            [
                new("thickness", ["tip_merge", "tip", "frustum", "middle", "base"], 4),
                new("vertical_direction", ["up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25782, 52,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"], 2),
                new("berries", ["true", "false"], 1)
            ]),
            new(25834, 2,
            [
                new("berries", ["true", "false"], 1)
            ]),
            new(25840, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("flower_amount", ["1", "2", "3", "4"], 1)
            ]),
            new(25857, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("tilt", ["none", "unstable", "partial", "full"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25889, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25897, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("half", ["upper", "lower"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25913, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(25917, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(25921, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(26001, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(26007, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(26332, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(26412, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(26418, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(26743, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(26823, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(26829, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(27154, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(27234, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(27240, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(27567, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(27576, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(27579, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(27582, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(27587, 16,
            [
                new("cracked", ["true", "false"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(27603, 48,
            [
                new("crafting", ["true", "false"], 24),
                new("orientation", ["down_east", "down_north", "down_south", "down_west", "up_east", "up_north", "up_south", "up_west", "west_up", "east_up", "north_up", "south_up"], 2),
                new("triggered", ["true", "false"], 1)
            ]),
            new(27651, 12,
            [
                new("ominous", ["true", "false"], 6),
                new("trial_spawner_state", ["inactive", "waiting_for_players", "active", "waiting_for_reward_ejection", "ejecting_reward", "cooldown"], 1)
            ]),
            new(27663, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("ominous", ["true", "false"], 4),
                new("vault_state", ["inactive", "active", "unlocking", "ejecting"], 1)
            ]),
            new(27695, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(27698, 162,
            [
                new("bottom", ["true", "false"], 81),
                new("east", ["none", "low", "tall"], 27),
                new("north", ["none", "low", "tall"], 9),
                new("south", ["none", "low", "tall"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(27860, 2,
            [
                new("tip", ["true", "false"], 1)
            ]),
        ];
        // </auto-generated block-state-properties>

        protected override Dictionary<int, Material> GetDict()
        {
            return materials;
        }

        protected override BlockStateDefinition[] GetStateDefinitions()
        {
            return stateDefinitions;
        }
    }
}
