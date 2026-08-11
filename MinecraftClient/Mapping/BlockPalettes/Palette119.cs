using System.Collections.Generic;

namespace MinecraftClient.Mapping.BlockPalettes
{
    public class Palette119 : BlockPalette
    {
        private static readonly Dictionary<int, Material> materials = new();

        static Palette119()
        {
            for (int i = 7035; i <= 7058; i++)
                materials[i] = Material.AcaciaButton;
            for (int i = 9747; i <= 9810; i++)
                materials[i] = Material.AcaciaDoor;
            for (int i = 9459; i <= 9490; i++)
                materials[i] = Material.AcaciaFence;
            for (int i = 9267; i <= 9298; i++)
                materials[i] = Material.AcaciaFenceGate;
            for (int i = 318; i <= 345; i++)
                materials[i] = Material.AcaciaLeaves;
            for (int i = 129; i <= 131; i++)
                materials[i] = Material.AcaciaLog;
            materials[19] = Material.AcaciaPlanks;
            for (int i = 4186; i <= 4187; i++)
                materials[i] = Material.AcaciaPressurePlate;
            for (int i = 30; i <= 31; i++)
                materials[i] = Material.AcaciaSapling;
            for (int i = 3732; i <= 3763; i++)
                materials[i] = Material.AcaciaSign;
            for (int i = 9065; i <= 9070; i++)
                materials[i] = Material.AcaciaSlab;
            for (int i = 8004; i <= 8083; i++)
                materials[i] = Material.AcaciaStairs;
            for (int i = 4676; i <= 4739; i++)
                materials[i] = Material.AcaciaTrapdoor;
            for (int i = 4056; i <= 4063; i++)
                materials[i] = Material.AcaciaWallSign;
            for (int i = 176; i <= 178; i++)
                materials[i] = Material.AcaciaWood;
            for (int i = 7440; i <= 7463; i++)
                materials[i] = Material.ActivatorRail;
            materials[0] = Material.Air;
            materials[1669] = Material.Allium;
            materials[18619] = Material.AmethystBlock;
            for (int i = 18621; i <= 18632; i++)
                materials[i] = Material.AmethystCluster;
            materials[17036] = Material.AncientDebris;
            materials[6] = Material.Andesite;
            for (int i = 11724; i <= 11729; i++)
                materials[i] = Material.AndesiteSlab;
            for (int i = 11350; i <= 11429; i++)
                materials[i] = Material.AndesiteStairs;
            for (int i = 14340; i <= 14663; i++)
                materials[i] = Material.AndesiteWall;
            for (int i = 7227; i <= 7230; i++)
                materials[i] = Material.Anvil;
            for (int i = 5147; i <= 5150; i++)
                materials[i] = Material.AttachedMelonStem;
            for (int i = 5143; i <= 5146; i++)
                materials[i] = Material.AttachedPumpkinStem;
            materials[19714] = Material.Azalea;
            for (int i = 402; i <= 429; i++)
                materials[i] = Material.AzaleaLeaves;
            materials[1670] = Material.AzureBluet;
            for (int i = 10533; i <= 10544; i++)
                materials[i] = Material.Bamboo;
            materials[10532] = Material.BambooSapling;
            for (int i = 15996; i <= 16007; i++)
                materials[i] = Material.Barrel;
            materials[8245] = Material.Barrier;
            for (int i = 4311; i <= 4313; i++)
                materials[i] = Material.Basalt;
            materials[6248] = Material.Beacon;
            materials[74] = Material.Bedrock;
            for (int i = 16985; i <= 17008; i++)
                materials[i] = Material.BeeNest;
            for (int i = 17009; i <= 17032; i++)
                materials[i] = Material.Beehive;
            for (int i = 10100; i <= 10103; i++)
                materials[i] = Material.Beetroots;
            for (int i = 16059; i <= 16090; i++)
                materials[i] = Material.Bell;
            for (int i = 19718; i <= 19749; i++)
                materials[i] = Material.BigDripleaf;
            for (int i = 19750; i <= 19757; i++)
                materials[i] = Material.BigDripleafStem;
            for (int i = 6987; i <= 7010; i++)
                materials[i] = Material.BirchButton;
            for (int i = 9619; i <= 9682; i++)
                materials[i] = Material.BirchDoor;
            for (int i = 9395; i <= 9426; i++)
                materials[i] = Material.BirchFence;
            for (int i = 9203; i <= 9234; i++)
                materials[i] = Material.BirchFenceGate;
            for (int i = 262; i <= 289; i++)
                materials[i] = Material.BirchLeaves;
            for (int i = 123; i <= 125; i++)
                materials[i] = Material.BirchLog;
            materials[17] = Material.BirchPlanks;
            for (int i = 4182; i <= 4183; i++)
                materials[i] = Material.BirchPressurePlate;
            for (int i = 26; i <= 27; i++)
                materials[i] = Material.BirchSapling;
            for (int i = 3700; i <= 3731; i++)
                materials[i] = Material.BirchSign;
            for (int i = 9053; i <= 9058; i++)
                materials[i] = Material.BirchSlab;
            for (int i = 6076; i <= 6155; i++)
                materials[i] = Material.BirchStairs;
            for (int i = 4548; i <= 4611; i++)
                materials[i] = Material.BirchTrapdoor;
            for (int i = 4048; i <= 4055; i++)
                materials[i] = Material.BirchWallSign;
            for (int i = 170; i <= 172; i++)
                materials[i] = Material.BirchWood;
            for (int i = 8878; i <= 8893; i++)
                materials[i] = Material.BlackBanner;
            for (int i = 1519; i <= 1534; i++)
                materials[i] = Material.BlackBed;
            for (int i = 18569; i <= 18584; i++)
                materials[i] = Material.BlackCandle;
            for (int i = 18617; i <= 18618; i++)
                materials[i] = Material.BlackCandleCake;
            materials[8622] = Material.BlackCarpet;
            materials[10334] = Material.BlackConcrete;
            materials[10350] = Material.BlackConcretePowder;
            for (int i = 10315; i <= 10318; i++)
                materials[i] = Material.BlackGlazedTerracotta;
            for (int i = 10249; i <= 10254; i++)
                materials[i] = Material.BlackShulkerBox;
            materials[4419] = Material.BlackStainedGlass;
            for (int i = 7972; i <= 8003; i++)
                materials[i] = Material.BlackStainedGlassPane;
            materials[7491] = Material.BlackTerracotta;
            for (int i = 8954; i <= 8957; i++)
                materials[i] = Material.BlackWallBanner;
            materials[1653] = Material.BlackWool;
            materials[17048] = Material.Blackstone;
            for (int i = 17453; i <= 17458; i++)
                materials[i] = Material.BlackstoneSlab;
            for (int i = 17049; i <= 17128; i++)
                materials[i] = Material.BlackstoneStairs;
            for (int i = 17129; i <= 17452; i++)
                materials[i] = Material.BlackstoneWall;
            for (int i = 16016; i <= 16023; i++)
                materials[i] = Material.BlastFurnace;
            for (int i = 8814; i <= 8829; i++)
                materials[i] = Material.BlueBanner;
            for (int i = 1455; i <= 1470; i++)
                materials[i] = Material.BlueBed;
            for (int i = 18505; i <= 18520; i++)
                materials[i] = Material.BlueCandle;
            for (int i = 18609; i <= 18610; i++)
                materials[i] = Material.BlueCandleCake;
            materials[8618] = Material.BlueCarpet;
            materials[10330] = Material.BlueConcrete;
            materials[10346] = Material.BlueConcretePowder;
            for (int i = 10299; i <= 10302; i++)
                materials[i] = Material.BlueGlazedTerracotta;
            materials[10529] = Material.BlueIce;
            materials[1668] = Material.BlueOrchid;
            for (int i = 10225; i <= 10230; i++)
                materials[i] = Material.BlueShulkerBox;
            materials[4415] = Material.BlueStainedGlass;
            for (int i = 7844; i <= 7875; i++)
                materials[i] = Material.BlueStainedGlassPane;
            materials[7487] = Material.BlueTerracotta;
            for (int i = 8938; i <= 8941; i++)
                materials[i] = Material.BlueWallBanner;
            materials[1649] = Material.BlueWool;
            for (int i = 10137; i <= 10139; i++)
                materials[i] = Material.BoneBlock;
            materials[1686] = Material.Bookshelf;
            for (int i = 10413; i <= 10414; i++)
                materials[i] = Material.BrainCoral;
            materials[10397] = Material.BrainCoralBlock;
            for (int i = 10433; i <= 10434; i++)
                materials[i] = Material.BrainCoralFan;
            for (int i = 10489; i <= 10496; i++)
                materials[i] = Material.BrainCoralWallFan;
            for (int i = 5720; i <= 5727; i++)
                materials[i] = Material.BrewingStand;
            for (int i = 9119; i <= 9124; i++)
                materials[i] = Material.BrickSlab;
            for (int i = 5359; i <= 5438; i++)
                materials[i] = Material.BrickStairs;
            for (int i = 11748; i <= 12071; i++)
                materials[i] = Material.BrickWall;
            materials[1683] = Material.Bricks;
            for (int i = 8830; i <= 8845; i++)
                materials[i] = Material.BrownBanner;
            for (int i = 1471; i <= 1486; i++)
                materials[i] = Material.BrownBed;
            for (int i = 18521; i <= 18536; i++)
                materials[i] = Material.BrownCandle;
            for (int i = 18611; i <= 18612; i++)
                materials[i] = Material.BrownCandleCake;
            materials[8619] = Material.BrownCarpet;
            materials[10331] = Material.BrownConcrete;
            materials[10347] = Material.BrownConcretePowder;
            for (int i = 10303; i <= 10306; i++)
                materials[i] = Material.BrownGlazedTerracotta;
            materials[1679] = Material.BrownMushroom;
            for (int i = 4880; i <= 4943; i++)
                materials[i] = Material.BrownMushroomBlock;
            for (int i = 10231; i <= 10236; i++)
                materials[i] = Material.BrownShulkerBox;
            materials[4416] = Material.BrownStainedGlass;
            for (int i = 7876; i <= 7907; i++)
                materials[i] = Material.BrownStainedGlassPane;
            materials[7488] = Material.BrownTerracotta;
            for (int i = 8942; i <= 8945; i++)
                materials[i] = Material.BrownWallBanner;
            materials[1650] = Material.BrownWool;
            for (int i = 10548; i <= 10549; i++)
                materials[i] = Material.BubbleColumn;
            for (int i = 10415; i <= 10416; i++)
                materials[i] = Material.BubbleCoral;
            materials[10398] = Material.BubbleCoralBlock;
            for (int i = 10435; i <= 10436; i++)
                materials[i] = Material.BubbleCoralFan;
            for (int i = 10497; i <= 10504; i++)
                materials[i] = Material.BubbleCoralWallFan;
            materials[18620] = Material.BuddingAmethyst;
            for (int i = 4240; i <= 4255; i++)
                materials[i] = Material.Cactus;
            for (int i = 4333; i <= 4339; i++)
                materials[i] = Material.Cake;
            materials[18670] = Material.Calcite;
            for (int i = 16099; i <= 16130; i++)
                materials[i] = Material.Campfire;
            for (int i = 18313; i <= 18328; i++)
                materials[i] = Material.Candle;
            for (int i = 18585; i <= 18586; i++)
                materials[i] = Material.CandleCake;
            for (int i = 6923; i <= 6930; i++)
                materials[i] = Material.Carrots;
            materials[16024] = Material.CartographyTable;
            for (int i = 4325; i <= 4328; i++)
                materials[i] = Material.CarvedPumpkin;
            materials[5728] = Material.Cauldron;
            materials[10547] = Material.CaveAir;
            for (int i = 19659; i <= 19710; i++)
                materials[i] = Material.CaveVines;
            for (int i = 19711; i <= 19712; i++)
                materials[i] = Material.CaveVinesPlant;
            for (int i = 5104; i <= 5109; i++)
                materials[i] = Material.Chain;
            for (int i = 10118; i <= 10129; i++)
                materials[i] = Material.ChainCommandBlock;
            for (int i = 2288; i <= 2311; i++)
                materials[i] = Material.Chest;
            for (int i = 7231; i <= 7234; i++)
                materials[i] = Material.ChippedAnvil;
            materials[21425] = Material.ChiseledDeepslate;
            materials[18310] = Material.ChiseledNetherBricks;
            materials[17462] = Material.ChiseledPolishedBlackstone;
            materials[7356] = Material.ChiseledQuartzBlock;
            materials[8959] = Material.ChiseledRedSandstone;
            materials[477] = Material.ChiseledSandstone;
            materials[4871] = Material.ChiseledStoneBricks;
            for (int i = 10009; i <= 10014; i++)
                materials[i] = Material.ChorusFlower;
            for (int i = 9945; i <= 10008; i++)
                materials[i] = Material.ChorusPlant;
            materials[4256] = Material.Clay;
            materials[8624] = Material.CoalBlock;
            materials[114] = Material.CoalOre;
            materials[11] = Material.CoarseDirt;
            materials[19781] = Material.CobbledDeepslate;
            for (int i = 19862; i <= 19867; i++)
                materials[i] = Material.CobbledDeepslateSlab;
            for (int i = 19782; i <= 19861; i++)
                materials[i] = Material.CobbledDeepslateStairs;
            for (int i = 19868; i <= 20191; i++)
                materials[i] = Material.CobbledDeepslateWall;
            materials[14] = Material.Cobblestone;
            for (int i = 9113; i <= 9118; i++)
                materials[i] = Material.CobblestoneSlab;
            for (int i = 3952; i <= 4031; i++)
                materials[i] = Material.CobblestoneStairs;
            for (int i = 6249; i <= 6572; i++)
                materials[i] = Material.CobblestoneWall;
            materials[1595] = Material.Cobweb;
            for (int i = 5749; i <= 5760; i++)
                materials[i] = Material.Cocoa;
            for (int i = 6236; i <= 6247; i++)
                materials[i] = Material.CommandBlock;
            for (int i = 7295; i <= 7310; i++)
                materials[i] = Material.Comparator;
            for (int i = 16960; i <= 16968; i++)
                materials[i] = Material.Composter;
            for (int i = 10530; i <= 10531; i++)
                materials[i] = Material.Conduit;
            materials[18911] = Material.CopperBlock;
            materials[18912] = Material.CopperOre;
            materials[1676] = Material.Cornflower;
            materials[21426] = Material.CrackedDeepslateBricks;
            materials[21427] = Material.CrackedDeepslateTiles;
            materials[18311] = Material.CrackedNetherBricks;
            materials[17461] = Material.CrackedPolishedBlackstoneBricks;
            materials[4870] = Material.CrackedStoneBricks;
            materials[3611] = Material.CraftingTable;
            for (int i = 7187; i <= 7202; i++)
                materials[i] = Material.CreeperHead;
            for (int i = 7203; i <= 7206; i++)
                materials[i] = Material.CreeperWallHead;
            for (int i = 16688; i <= 16711; i++)
                materials[i] = Material.CrimsonButton;
            for (int i = 16736; i <= 16799; i++)
                materials[i] = Material.CrimsonDoor;
            for (int i = 16272; i <= 16303; i++)
                materials[i] = Material.CrimsonFence;
            for (int i = 16464; i <= 16495; i++)
                materials[i] = Material.CrimsonFenceGate;
            materials[16197] = Material.CrimsonFungus;
            for (int i = 16190; i <= 16192; i++)
                materials[i] = Material.CrimsonHyphae;
            materials[16196] = Material.CrimsonNylium;
            materials[16254] = Material.CrimsonPlanks;
            for (int i = 16268; i <= 16269; i++)
                materials[i] = Material.CrimsonPressurePlate;
            materials[16253] = Material.CrimsonRoots;
            for (int i = 16864; i <= 16895; i++)
                materials[i] = Material.CrimsonSign;
            for (int i = 16256; i <= 16261; i++)
                materials[i] = Material.CrimsonSlab;
            for (int i = 16528; i <= 16607; i++)
                materials[i] = Material.CrimsonStairs;
            for (int i = 16184; i <= 16186; i++)
                materials[i] = Material.CrimsonStem;
            for (int i = 16336; i <= 16399; i++)
                materials[i] = Material.CrimsonTrapdoor;
            for (int i = 16928; i <= 16935; i++)
                materials[i] = Material.CrimsonWallSign;
            materials[17037] = Material.CryingObsidian;
            materials[18917] = Material.CutCopper;
            for (int i = 19256; i <= 19261; i++)
                materials[i] = Material.CutCopperSlab;
            for (int i = 19158; i <= 19237; i++)
                materials[i] = Material.CutCopperStairs;
            materials[8960] = Material.CutRedSandstone;
            for (int i = 9155; i <= 9160; i++)
                materials[i] = Material.CutRedSandstoneSlab;
            materials[478] = Material.CutSandstone;
            for (int i = 9101; i <= 9106; i++)
                materials[i] = Material.CutSandstoneSlab;
            for (int i = 8782; i <= 8797; i++)
                materials[i] = Material.CyanBanner;
            for (int i = 1423; i <= 1438; i++)
                materials[i] = Material.CyanBed;
            for (int i = 18473; i <= 18488; i++)
                materials[i] = Material.CyanCandle;
            for (int i = 18605; i <= 18606; i++)
                materials[i] = Material.CyanCandleCake;
            materials[8616] = Material.CyanCarpet;
            materials[10328] = Material.CyanConcrete;
            materials[10344] = Material.CyanConcretePowder;
            for (int i = 10291; i <= 10294; i++)
                materials[i] = Material.CyanGlazedTerracotta;
            for (int i = 10213; i <= 10218; i++)
                materials[i] = Material.CyanShulkerBox;
            materials[4413] = Material.CyanStainedGlass;
            for (int i = 7780; i <= 7811; i++)
                materials[i] = Material.CyanStainedGlassPane;
            materials[7485] = Material.CyanTerracotta;
            for (int i = 8930; i <= 8933; i++)
                materials[i] = Material.CyanWallBanner;
            materials[1647] = Material.CyanWool;
            for (int i = 7235; i <= 7238; i++)
                materials[i] = Material.DamagedAnvil;
            materials[1666] = Material.Dandelion;
            for (int i = 7059; i <= 7082; i++)
                materials[i] = Material.DarkOakButton;
            for (int i = 9811; i <= 9874; i++)
                materials[i] = Material.DarkOakDoor;
            for (int i = 9491; i <= 9522; i++)
                materials[i] = Material.DarkOakFence;
            for (int i = 9299; i <= 9330; i++)
                materials[i] = Material.DarkOakFenceGate;
            for (int i = 346; i <= 373; i++)
                materials[i] = Material.DarkOakLeaves;
            for (int i = 132; i <= 134; i++)
                materials[i] = Material.DarkOakLog;
            materials[20] = Material.DarkOakPlanks;
            for (int i = 4188; i <= 4189; i++)
                materials[i] = Material.DarkOakPressurePlate;
            for (int i = 32; i <= 33; i++)
                materials[i] = Material.DarkOakSapling;
            for (int i = 3796; i <= 3827; i++)
                materials[i] = Material.DarkOakSign;
            for (int i = 9071; i <= 9076; i++)
                materials[i] = Material.DarkOakSlab;
            for (int i = 8084; i <= 8163; i++)
                materials[i] = Material.DarkOakStairs;
            for (int i = 4740; i <= 4803; i++)
                materials[i] = Material.DarkOakTrapdoor;
            for (int i = 4072; i <= 4079; i++)
                materials[i] = Material.DarkOakWallSign;
            for (int i = 179; i <= 181; i++)
                materials[i] = Material.DarkOakWood;
            materials[8344] = Material.DarkPrismarine;
            for (int i = 8597; i <= 8602; i++)
                materials[i] = Material.DarkPrismarineSlab;
            for (int i = 8505; i <= 8584; i++)
                materials[i] = Material.DarkPrismarineStairs;
            for (int i = 7311; i <= 7342; i++)
                materials[i] = Material.DaylightDetector;
            for (int i = 10403; i <= 10404; i++)
                materials[i] = Material.DeadBrainCoral;
            materials[10392] = Material.DeadBrainCoralBlock;
            for (int i = 10423; i <= 10424; i++)
                materials[i] = Material.DeadBrainCoralFan;
            for (int i = 10449; i <= 10456; i++)
                materials[i] = Material.DeadBrainCoralWallFan;
            for (int i = 10405; i <= 10406; i++)
                materials[i] = Material.DeadBubbleCoral;
            materials[10393] = Material.DeadBubbleCoralBlock;
            for (int i = 10425; i <= 10426; i++)
                materials[i] = Material.DeadBubbleCoralFan;
            for (int i = 10457; i <= 10464; i++)
                materials[i] = Material.DeadBubbleCoralWallFan;
            materials[1598] = Material.DeadBush;
            for (int i = 10407; i <= 10408; i++)
                materials[i] = Material.DeadFireCoral;
            materials[10394] = Material.DeadFireCoralBlock;
            for (int i = 10427; i <= 10428; i++)
                materials[i] = Material.DeadFireCoralFan;
            for (int i = 10465; i <= 10472; i++)
                materials[i] = Material.DeadFireCoralWallFan;
            for (int i = 10409; i <= 10410; i++)
                materials[i] = Material.DeadHornCoral;
            materials[10395] = Material.DeadHornCoralBlock;
            for (int i = 10429; i <= 10430; i++)
                materials[i] = Material.DeadHornCoralFan;
            for (int i = 10473; i <= 10480; i++)
                materials[i] = Material.DeadHornCoralWallFan;
            for (int i = 10401; i <= 10402; i++)
                materials[i] = Material.DeadTubeCoral;
            materials[10391] = Material.DeadTubeCoralBlock;
            for (int i = 10421; i <= 10422; i++)
                materials[i] = Material.DeadTubeCoralFan;
            for (int i = 10441; i <= 10448; i++)
                materials[i] = Material.DeadTubeCoralWallFan;
            for (int i = 19778; i <= 19780; i++)
                materials[i] = Material.Deepslate;
            for (int i = 21095; i <= 21100; i++)
                materials[i] = Material.DeepslateBrickSlab;
            for (int i = 21015; i <= 21094; i++)
                materials[i] = Material.DeepslateBrickStairs;
            for (int i = 21101; i <= 21424; i++)
                materials[i] = Material.DeepslateBrickWall;
            materials[21014] = Material.DeepslateBricks;
            materials[115] = Material.DeepslateCoalOre;
            materials[18913] = Material.DeepslateCopperOre;
            materials[3609] = Material.DeepslateDiamondOre;
            materials[5842] = Material.DeepslateEmeraldOre;
            materials[111] = Material.DeepslateGoldOre;
            materials[113] = Material.DeepslateIronOre;
            materials[462] = Material.DeepslateLapisOre;
            for (int i = 4194; i <= 4195; i++)
                materials[i] = Material.DeepslateRedstoneOre;
            for (int i = 20684; i <= 20689; i++)
                materials[i] = Material.DeepslateTileSlab;
            for (int i = 20604; i <= 20683; i++)
                materials[i] = Material.DeepslateTileStairs;
            for (int i = 20690; i <= 21013; i++)
                materials[i] = Material.DeepslateTileWall;
            materials[20603] = Material.DeepslateTiles;
            for (int i = 1559; i <= 1582; i++)
                materials[i] = Material.DetectorRail;
            materials[3610] = Material.DiamondBlock;
            materials[3608] = Material.DiamondOre;
            materials[4] = Material.Diorite;
            for (int i = 11742; i <= 11747; i++)
                materials[i] = Material.DioriteSlab;
            for (int i = 11590; i <= 11669; i++)
                materials[i] = Material.DioriteStairs;
            for (int i = 15636; i <= 15959; i++)
                materials[i] = Material.DioriteWall;
            materials[10] = Material.Dirt;
            materials[10104] = Material.DirtPath;
            for (int i = 464; i <= 475; i++)
                materials[i] = Material.Dispenser;
            materials[5746] = Material.DragonEgg;
            for (int i = 7207; i <= 7222; i++)
                materials[i] = Material.DragonHead;
            for (int i = 7223; i <= 7226; i++)
                materials[i] = Material.DragonWallHead;
            materials[10378] = Material.DriedKelpBlock;
            materials[19658] = Material.DripstoneBlock;
            for (int i = 7464; i <= 7475; i++)
                materials[i] = Material.Dropper;
            materials[5995] = Material.EmeraldBlock;
            materials[5841] = Material.EmeraldOre;
            materials[5719] = Material.EnchantingTable;
            materials[10105] = Material.EndGateway;
            materials[5736] = Material.EndPortal;
            for (int i = 5737; i <= 5744; i++)
                materials[i] = Material.EndPortalFrame;
            for (int i = 9939; i <= 9944; i++)
                materials[i] = Material.EndRod;
            materials[5745] = Material.EndStone;
            for (int i = 11700; i <= 11705; i++)
                materials[i] = Material.EndStoneBrickSlab;
            for (int i = 10950; i <= 11029; i++)
                materials[i] = Material.EndStoneBrickStairs;
            for (int i = 15312; i <= 15635; i++)
                materials[i] = Material.EndStoneBrickWall;
            materials[10099] = Material.EndStoneBricks;
            for (int i = 5843; i <= 5850; i++)
                materials[i] = Material.EnderChest;
            materials[18910] = Material.ExposedCopper;
            materials[18916] = Material.ExposedCutCopper;
            for (int i = 19250; i <= 19255; i++)
                materials[i] = Material.ExposedCutCopperSlab;
            for (int i = 19078; i <= 19157; i++)
                materials[i] = Material.ExposedCutCopperStairs;
            for (int i = 3620; i <= 3627; i++)
                materials[i] = Material.Farmland;
            materials[1597] = Material.Fern;
            for (int i = 1694; i <= 2205; i++)
                materials[i] = Material.Fire;
            for (int i = 10417; i <= 10418; i++)
                materials[i] = Material.FireCoral;
            materials[10399] = Material.FireCoralBlock;
            for (int i = 10437; i <= 10438; i++)
                materials[i] = Material.FireCoralFan;
            for (int i = 10505; i <= 10512; i++)
                materials[i] = Material.FireCoralWallFan;
            materials[16025] = Material.FletchingTable;
            materials[6897] = Material.FlowerPot;
            materials[19715] = Material.FloweringAzalea;
            for (int i = 430; i <= 457; i++)
                materials[i] = Material.FloweringAzaleaLeaves;
            materials[21446] = Material.Frogspawn;
            for (int i = 10130; i <= 10133; i++)
                materials[i] = Material.FrostedIce;
            for (int i = 3628; i <= 3635; i++)
                materials[i] = Material.Furnace;
            materials[17873] = Material.GildedBlackstone;
            materials[460] = Material.Glass;
            for (int i = 5110; i <= 5141; i++)
                materials[i] = Material.GlassPane;
            for (int i = 5199; i <= 5326; i++)
                materials[i] = Material.GlowLichen;
            materials[4322] = Material.Glowstone;
            materials[1681] = Material.GoldBlock;
            materials[110] = Material.GoldOre;
            materials[2] = Material.Granite;
            for (int i = 11718; i <= 11723; i++)
                materials[i] = Material.GraniteSlab;
            for (int i = 11270; i <= 11349; i++)
                materials[i] = Material.GraniteStairs;
            for (int i = 13044; i <= 13367; i++)
                materials[i] = Material.GraniteWall;
            materials[1596] = Material.ShortGrass;
            for (int i = 8; i <= 9; i++)
                materials[i] = Material.GrassBlock;
            materials[109] = Material.Gravel;
            for (int i = 8750; i <= 8765; i++)
                materials[i] = Material.GrayBanner;
            for (int i = 1391; i <= 1406; i++)
                materials[i] = Material.GrayBed;
            for (int i = 18441; i <= 18456; i++)
                materials[i] = Material.GrayCandle;
            for (int i = 18601; i <= 18602; i++)
                materials[i] = Material.GrayCandleCake;
            materials[8614] = Material.GrayCarpet;
            materials[10326] = Material.GrayConcrete;
            materials[10342] = Material.GrayConcretePowder;
            for (int i = 10283; i <= 10286; i++)
                materials[i] = Material.GrayGlazedTerracotta;
            for (int i = 10201; i <= 10206; i++)
                materials[i] = Material.GrayShulkerBox;
            materials[4411] = Material.GrayStainedGlass;
            for (int i = 7716; i <= 7747; i++)
                materials[i] = Material.GrayStainedGlassPane;
            materials[7483] = Material.GrayTerracotta;
            for (int i = 8922; i <= 8925; i++)
                materials[i] = Material.GrayWallBanner;
            materials[1645] = Material.GrayWool;
            for (int i = 8846; i <= 8861; i++)
                materials[i] = Material.GreenBanner;
            for (int i = 1487; i <= 1502; i++)
                materials[i] = Material.GreenBed;
            for (int i = 18537; i <= 18552; i++)
                materials[i] = Material.GreenCandle;
            for (int i = 18613; i <= 18614; i++)
                materials[i] = Material.GreenCandleCake;
            materials[8620] = Material.GreenCarpet;
            materials[10332] = Material.GreenConcrete;
            materials[10348] = Material.GreenConcretePowder;
            for (int i = 10307; i <= 10310; i++)
                materials[i] = Material.GreenGlazedTerracotta;
            for (int i = 10237; i <= 10242; i++)
                materials[i] = Material.GreenShulkerBox;
            materials[4417] = Material.GreenStainedGlass;
            for (int i = 7908; i <= 7939; i++)
                materials[i] = Material.GreenStainedGlassPane;
            materials[7489] = Material.GreenTerracotta;
            for (int i = 8946; i <= 8949; i++)
                materials[i] = Material.GreenWallBanner;
            materials[1651] = Material.GreenWool;
            for (int i = 16026; i <= 16037; i++)
                materials[i] = Material.Grindstone;
            for (int i = 19774; i <= 19775; i++)
                materials[i] = Material.HangingRoots;
            for (int i = 8604; i <= 8606; i++)
                materials[i] = Material.HayBlock;
            for (int i = 7279; i <= 7294; i++)
                materials[i] = Material.HeavyWeightedPressurePlate;
            materials[17033] = Material.HoneyBlock;
            materials[17034] = Material.HoneycombBlock;
            for (int i = 7345; i <= 7354; i++)
                materials[i] = Material.Hopper;
            for (int i = 10419; i <= 10420; i++)
                materials[i] = Material.HornCoral;
            materials[10400] = Material.HornCoralBlock;
            for (int i = 10439; i <= 10440; i++)
                materials[i] = Material.HornCoralFan;
            for (int i = 10513; i <= 10520; i++)
                materials[i] = Material.HornCoralWallFan;
            materials[4238] = Material.Ice;
            materials[4879] = Material.InfestedChiseledStoneBricks;
            materials[4875] = Material.InfestedCobblestone;
            materials[4878] = Material.InfestedCrackedStoneBricks;
            for (int i = 21428; i <= 21430; i++)
                materials[i] = Material.InfestedDeepslate;
            materials[4877] = Material.InfestedMossyStoneBricks;
            materials[4874] = Material.InfestedStone;
            materials[4876] = Material.InfestedStoneBricks;
            for (int i = 5072; i <= 5103; i++)
                materials[i] = Material.IronBars;
            materials[1682] = Material.IronBlock;
            for (int i = 4114; i <= 4177; i++)
                materials[i] = Material.IronDoor;
            materials[112] = Material.IronOre;
            for (int i = 8278; i <= 8341; i++)
                materials[i] = Material.IronTrapdoor;
            for (int i = 4329; i <= 4332; i++)
                materials[i] = Material.JackOLantern;
            for (int i = 16948; i <= 16959; i++)
                materials[i] = Material.Jigsaw;
            for (int i = 4273; i <= 4274; i++)
                materials[i] = Material.Jukebox;
            for (int i = 7011; i <= 7034; i++)
                materials[i] = Material.JungleButton;
            for (int i = 9683; i <= 9746; i++)
                materials[i] = Material.JungleDoor;
            for (int i = 9427; i <= 9458; i++)
                materials[i] = Material.JungleFence;
            for (int i = 9235; i <= 9266; i++)
                materials[i] = Material.JungleFenceGate;
            for (int i = 290; i <= 317; i++)
                materials[i] = Material.JungleLeaves;
            for (int i = 126; i <= 128; i++)
                materials[i] = Material.JungleLog;
            materials[18] = Material.JunglePlanks;
            for (int i = 4184; i <= 4185; i++)
                materials[i] = Material.JunglePressurePlate;
            for (int i = 28; i <= 29; i++)
                materials[i] = Material.JungleSapling;
            for (int i = 3764; i <= 3795; i++)
                materials[i] = Material.JungleSign;
            for (int i = 9059; i <= 9064; i++)
                materials[i] = Material.JungleSlab;
            for (int i = 6156; i <= 6235; i++)
                materials[i] = Material.JungleStairs;
            for (int i = 4612; i <= 4675; i++)
                materials[i] = Material.JungleTrapdoor;
            for (int i = 4064; i <= 4071; i++)
                materials[i] = Material.JungleWallSign;
            for (int i = 173; i <= 175; i++)
                materials[i] = Material.JungleWood;
            for (int i = 10351; i <= 10376; i++)
                materials[i] = Material.Kelp;
            materials[10377] = Material.KelpPlant;
            for (int i = 3924; i <= 3931; i++)
                materials[i] = Material.Ladder;
            for (int i = 16091; i <= 16094; i++)
                materials[i] = Material.Lantern;
            materials[463] = Material.LapisBlock;
            materials[461] = Material.LapisOre;
            for (int i = 18633; i <= 18644; i++)
                materials[i] = Material.LargeAmethystBud;
            for (int i = 8636; i <= 8637; i++)
                materials[i] = Material.LargeFern;
            for (int i = 91; i <= 106; i++)
                materials[i] = Material.Lava;
            materials[5732] = Material.LavaCauldron;
            for (int i = 16038; i <= 16053; i++)
                materials[i] = Material.Lectern;
            for (int i = 4088; i <= 4111; i++)
                materials[i] = Material.Lever;
            for (int i = 8246; i <= 8277; i++)
                materials[i] = Material.Light;
            for (int i = 8686; i <= 8701; i++)
                materials[i] = Material.LightBlueBanner;
            for (int i = 1327; i <= 1342; i++)
                materials[i] = Material.LightBlueBed;
            for (int i = 18377; i <= 18392; i++)
                materials[i] = Material.LightBlueCandle;
            for (int i = 18593; i <= 18594; i++)
                materials[i] = Material.LightBlueCandleCake;
            materials[8610] = Material.LightBlueCarpet;
            materials[10322] = Material.LightBlueConcrete;
            materials[10338] = Material.LightBlueConcretePowder;
            for (int i = 10267; i <= 10270; i++)
                materials[i] = Material.LightBlueGlazedTerracotta;
            for (int i = 10177; i <= 10182; i++)
                materials[i] = Material.LightBlueShulkerBox;
            materials[4407] = Material.LightBlueStainedGlass;
            for (int i = 7588; i <= 7619; i++)
                materials[i] = Material.LightBlueStainedGlassPane;
            materials[7479] = Material.LightBlueTerracotta;
            for (int i = 8906; i <= 8909; i++)
                materials[i] = Material.LightBlueWallBanner;
            materials[1641] = Material.LightBlueWool;
            for (int i = 8766; i <= 8781; i++)
                materials[i] = Material.LightGrayBanner;
            for (int i = 1407; i <= 1422; i++)
                materials[i] = Material.LightGrayBed;
            for (int i = 18457; i <= 18472; i++)
                materials[i] = Material.LightGrayCandle;
            for (int i = 18603; i <= 18604; i++)
                materials[i] = Material.LightGrayCandleCake;
            materials[8615] = Material.LightGrayCarpet;
            materials[10327] = Material.LightGrayConcrete;
            materials[10343] = Material.LightGrayConcretePowder;
            for (int i = 10287; i <= 10290; i++)
                materials[i] = Material.LightGrayGlazedTerracotta;
            for (int i = 10207; i <= 10212; i++)
                materials[i] = Material.LightGrayShulkerBox;
            materials[4412] = Material.LightGrayStainedGlass;
            for (int i = 7748; i <= 7779; i++)
                materials[i] = Material.LightGrayStainedGlassPane;
            materials[7484] = Material.LightGrayTerracotta;
            for (int i = 8926; i <= 8929; i++)
                materials[i] = Material.LightGrayWallBanner;
            materials[1646] = Material.LightGrayWool;
            for (int i = 7263; i <= 7278; i++)
                materials[i] = Material.LightWeightedPressurePlate;
            for (int i = 19614; i <= 19637; i++)
                materials[i] = Material.LightningRod;
            for (int i = 8628; i <= 8629; i++)
                materials[i] = Material.Lilac;
            materials[1678] = Material.LilyOfTheValley;
            materials[5601] = Material.LilyPad;
            for (int i = 8718; i <= 8733; i++)
                materials[i] = Material.LimeBanner;
            for (int i = 1359; i <= 1374; i++)
                materials[i] = Material.LimeBed;
            for (int i = 18409; i <= 18424; i++)
                materials[i] = Material.LimeCandle;
            for (int i = 18597; i <= 18598; i++)
                materials[i] = Material.LimeCandleCake;
            materials[8612] = Material.LimeCarpet;
            materials[10324] = Material.LimeConcrete;
            materials[10340] = Material.LimeConcretePowder;
            for (int i = 10275; i <= 10278; i++)
                materials[i] = Material.LimeGlazedTerracotta;
            for (int i = 10189; i <= 10194; i++)
                materials[i] = Material.LimeShulkerBox;
            materials[4409] = Material.LimeStainedGlass;
            for (int i = 7652; i <= 7683; i++)
                materials[i] = Material.LimeStainedGlassPane;
            materials[7481] = Material.LimeTerracotta;
            for (int i = 8914; i <= 8917; i++)
                materials[i] = Material.LimeWallBanner;
            materials[1643] = Material.LimeWool;
            materials[17047] = Material.Lodestone;
            for (int i = 15992; i <= 15995; i++)
                materials[i] = Material.Loom;
            for (int i = 8670; i <= 8685; i++)
                materials[i] = Material.MagentaBanner;
            for (int i = 1311; i <= 1326; i++)
                materials[i] = Material.MagentaBed;
            for (int i = 18361; i <= 18376; i++)
                materials[i] = Material.MagentaCandle;
            for (int i = 18591; i <= 18592; i++)
                materials[i] = Material.MagentaCandleCake;
            materials[8609] = Material.MagentaCarpet;
            materials[10321] = Material.MagentaConcrete;
            materials[10337] = Material.MagentaConcretePowder;
            for (int i = 10263; i <= 10266; i++)
                materials[i] = Material.MagentaGlazedTerracotta;
            for (int i = 10171; i <= 10176; i++)
                materials[i] = Material.MagentaShulkerBox;
            materials[4406] = Material.MagentaStainedGlass;
            for (int i = 7556; i <= 7587; i++)
                materials[i] = Material.MagentaStainedGlassPane;
            materials[7478] = Material.MagentaTerracotta;
            for (int i = 8902; i <= 8905; i++)
                materials[i] = Material.MagentaWallBanner;
            materials[1640] = Material.MagentaWool;
            materials[10134] = Material.MagmaBlock;
            for (int i = 7083; i <= 7106; i++)
                materials[i] = Material.MangroveButton;
            for (int i = 9875; i <= 9938; i++)
                materials[i] = Material.MangroveDoor;
            for (int i = 9523; i <= 9554; i++)
                materials[i] = Material.MangroveFence;
            for (int i = 9331; i <= 9362; i++)
                materials[i] = Material.MangroveFenceGate;
            for (int i = 374; i <= 401; i++)
                materials[i] = Material.MangroveLeaves;
            for (int i = 135; i <= 137; i++)
                materials[i] = Material.MangroveLog;
            materials[21] = Material.MangrovePlanks;
            for (int i = 4190; i <= 4191; i++)
                materials[i] = Material.MangrovePressurePlate;
            for (int i = 34; i <= 73; i++)
                materials[i] = Material.MangrovePropagule;
            for (int i = 138; i <= 139; i++)
                materials[i] = Material.MangroveRoots;
            for (int i = 3828; i <= 3859; i++)
                materials[i] = Material.MangroveSign;
            for (int i = 9077; i <= 9082; i++)
                materials[i] = Material.MangroveSlab;
            for (int i = 8164; i <= 8243; i++)
                materials[i] = Material.MangroveStairs;
            for (int i = 4804; i <= 4867; i++)
                materials[i] = Material.MangroveTrapdoor;
            for (int i = 4080; i <= 4087; i++)
                materials[i] = Material.MangroveWallSign;
            for (int i = 182; i <= 184; i++)
                materials[i] = Material.MangroveWood;
            for (int i = 18645; i <= 18656; i++)
                materials[i] = Material.MediumAmethystBud;
            materials[5142] = Material.Melon;
            for (int i = 5159; i <= 5166; i++)
                materials[i] = Material.MelonStem;
            materials[19717] = Material.MossBlock;
            materials[19716] = Material.MossCarpet;
            materials[1687] = Material.MossyCobblestone;
            for (int i = 11694; i <= 11699; i++)
                materials[i] = Material.MossyCobblestoneSlab;
            for (int i = 10870; i <= 10949; i++)
                materials[i] = Material.MossyCobblestoneStairs;
            for (int i = 6573; i <= 6896; i++)
                materials[i] = Material.MossyCobblestoneWall;
            for (int i = 11682; i <= 11687; i++)
                materials[i] = Material.MossyStoneBrickSlab;
            for (int i = 10710; i <= 10789; i++)
                materials[i] = Material.MossyStoneBrickStairs;
            for (int i = 12720; i <= 13043; i++)
                materials[i] = Material.MossyStoneBrickWall;
            materials[4869] = Material.MossyStoneBricks;
            for (int i = 1654; i <= 1665; i++)
                materials[i] = Material.MovingPiston;
            materials[19777] = Material.Mud;
            for (int i = 9131; i <= 9136; i++)
                materials[i] = Material.MudBrickSlab;
            for (int i = 5519; i <= 5598; i++)
                materials[i] = Material.MudBrickStairs;
            for (int i = 13692; i <= 14015; i++)
                materials[i] = Material.MudBrickWall;
            materials[4873] = Material.MudBricks;
            for (int i = 140; i <= 142; i++)
                materials[i] = Material.MuddyMangroveRoots;
            for (int i = 5008; i <= 5071; i++)
                materials[i] = Material.MushroomStem;
            for (int i = 5599; i <= 5600; i++)
                materials[i] = Material.Mycelium;
            for (int i = 5603; i <= 5634; i++)
                materials[i] = Material.NetherBrickFence;
            for (int i = 9137; i <= 9142; i++)
                materials[i] = Material.NetherBrickSlab;
            for (int i = 5635; i <= 5714; i++)
                materials[i] = Material.NetherBrickStairs;
            for (int i = 14016; i <= 14339; i++)
                materials[i] = Material.NetherBrickWall;
            materials[5602] = Material.NetherBricks;
            materials[116] = Material.NetherGoldOre;
            for (int i = 4323; i <= 4324; i++)
                materials[i] = Material.NetherPortal;
            materials[7344] = Material.NetherQuartzOre;
            materials[16183] = Material.NetherSprouts;
            for (int i = 5715; i <= 5718; i++)
                materials[i] = Material.NetherWart;
            materials[10135] = Material.NetherWartBlock;
            materials[17035] = Material.NetheriteBlock;
            materials[4308] = Material.Netherrack;
            for (int i = 479; i <= 1278; i++)
                materials[i] = Material.NoteBlock;
            for (int i = 6939; i <= 6962; i++)
                materials[i] = Material.OakButton;
            for (int i = 3860; i <= 3923; i++)
                materials[i] = Material.OakDoor;
            for (int i = 4275; i <= 4306; i++)
                materials[i] = Material.OakFence;
            for (int i = 5327; i <= 5358; i++)
                materials[i] = Material.OakFenceGate;
            for (int i = 206; i <= 233; i++)
                materials[i] = Material.OakLeaves;
            for (int i = 117; i <= 119; i++)
                materials[i] = Material.OakLog;
            materials[15] = Material.OakPlanks;
            for (int i = 4178; i <= 4179; i++)
                materials[i] = Material.OakPressurePlate;
            for (int i = 22; i <= 23; i++)
                materials[i] = Material.OakSapling;
            for (int i = 3636; i <= 3667; i++)
                materials[i] = Material.OakSign;
            for (int i = 9041; i <= 9046; i++)
                materials[i] = Material.OakSlab;
            for (int i = 2208; i <= 2287; i++)
                materials[i] = Material.OakStairs;
            for (int i = 4420; i <= 4483; i++)
                materials[i] = Material.OakTrapdoor;
            for (int i = 4032; i <= 4039; i++)
                materials[i] = Material.OakWallSign;
            for (int i = 164; i <= 166; i++)
                materials[i] = Material.OakWood;
            for (int i = 10141; i <= 10152; i++)
                materials[i] = Material.Observer;
            materials[1688] = Material.Obsidian;
            for (int i = 21437; i <= 21439; i++)
                materials[i] = Material.OchreFroglight;
            for (int i = 8654; i <= 8669; i++)
                materials[i] = Material.OrangeBanner;
            for (int i = 1295; i <= 1310; i++)
                materials[i] = Material.OrangeBed;
            for (int i = 18345; i <= 18360; i++)
                materials[i] = Material.OrangeCandle;
            for (int i = 18589; i <= 18590; i++)
                materials[i] = Material.OrangeCandleCake;
            materials[8608] = Material.OrangeCarpet;
            materials[10320] = Material.OrangeConcrete;
            materials[10336] = Material.OrangeConcretePowder;
            for (int i = 10259; i <= 10262; i++)
                materials[i] = Material.OrangeGlazedTerracotta;
            for (int i = 10165; i <= 10170; i++)
                materials[i] = Material.OrangeShulkerBox;
            materials[4405] = Material.OrangeStainedGlass;
            for (int i = 7524; i <= 7555; i++)
                materials[i] = Material.OrangeStainedGlassPane;
            materials[7477] = Material.OrangeTerracotta;
            materials[1672] = Material.OrangeTulip;
            for (int i = 8898; i <= 8901; i++)
                materials[i] = Material.OrangeWallBanner;
            materials[1639] = Material.OrangeWool;
            materials[1675] = Material.OxeyeDaisy;
            materials[18908] = Material.OxidizedCopper;
            materials[18914] = Material.OxidizedCutCopper;
            for (int i = 19238; i <= 19243; i++)
                materials[i] = Material.OxidizedCutCopperSlab;
            for (int i = 18918; i <= 18997; i++)
                materials[i] = Material.OxidizedCutCopperStairs;
            materials[8625] = Material.PackedIce;
            materials[4872] = Material.PackedMud;
            for (int i = 21443; i <= 21445; i++)
                materials[i] = Material.PearlescentFroglight;
            for (int i = 8632; i <= 8633; i++)
                materials[i] = Material.Peony;
            for (int i = 9107; i <= 9112; i++)
                materials[i] = Material.PetrifiedOakSlab;
            for (int i = 8734; i <= 8749; i++)
                materials[i] = Material.PinkBanner;
            for (int i = 1375; i <= 1390; i++)
                materials[i] = Material.PinkBed;
            for (int i = 18425; i <= 18440; i++)
                materials[i] = Material.PinkCandle;
            for (int i = 18599; i <= 18600; i++)
                materials[i] = Material.PinkCandleCake;
            materials[8613] = Material.PinkCarpet;
            materials[10325] = Material.PinkConcrete;
            materials[10341] = Material.PinkConcretePowder;
            for (int i = 10279; i <= 10282; i++)
                materials[i] = Material.PinkGlazedTerracotta;
            for (int i = 10195; i <= 10200; i++)
                materials[i] = Material.PinkShulkerBox;
            materials[4410] = Material.PinkStainedGlass;
            for (int i = 7684; i <= 7715; i++)
                materials[i] = Material.PinkStainedGlassPane;
            materials[7482] = Material.PinkTerracotta;
            materials[1674] = Material.PinkTulip;
            for (int i = 8918; i <= 8921; i++)
                materials[i] = Material.PinkWallBanner;
            materials[1644] = Material.PinkWool;
            for (int i = 1602; i <= 1613; i++)
                materials[i] = Material.Piston;
            for (int i = 1614; i <= 1637; i++)
                materials[i] = Material.PistonHead;
            for (int i = 7167; i <= 7182; i++)
                materials[i] = Material.PlayerHead;
            for (int i = 7183; i <= 7186; i++)
                materials[i] = Material.PlayerWallHead;
            for (int i = 12; i <= 13; i++)
                materials[i] = Material.Podzol;
            for (int i = 19638; i <= 19657; i++)
                materials[i] = Material.PointedDripstone;
            materials[7] = Material.PolishedAndesite;
            for (int i = 11736; i <= 11741; i++)
                materials[i] = Material.PolishedAndesiteSlab;
            for (int i = 11510; i <= 11589; i++)
                materials[i] = Material.PolishedAndesiteStairs;
            for (int i = 4314; i <= 4316; i++)
                materials[i] = Material.PolishedBasalt;
            materials[17459] = Material.PolishedBlackstone;
            for (int i = 17463; i <= 17468; i++)
                materials[i] = Material.PolishedBlackstoneBrickSlab;
            for (int i = 17469; i <= 17548; i++)
                materials[i] = Material.PolishedBlackstoneBrickStairs;
            for (int i = 17549; i <= 17872; i++)
                materials[i] = Material.PolishedBlackstoneBrickWall;
            materials[17460] = Material.PolishedBlackstoneBricks;
            for (int i = 17962; i <= 17985; i++)
                materials[i] = Material.PolishedBlackstoneButton;
            for (int i = 17960; i <= 17961; i++)
                materials[i] = Material.PolishedBlackstonePressurePlate;
            for (int i = 17954; i <= 17959; i++)
                materials[i] = Material.PolishedBlackstoneSlab;
            for (int i = 17874; i <= 17953; i++)
                materials[i] = Material.PolishedBlackstoneStairs;
            for (int i = 17986; i <= 18309; i++)
                materials[i] = Material.PolishedBlackstoneWall;
            materials[20192] = Material.PolishedDeepslate;
            for (int i = 20273; i <= 20278; i++)
                materials[i] = Material.PolishedDeepslateSlab;
            for (int i = 20193; i <= 20272; i++)
                materials[i] = Material.PolishedDeepslateStairs;
            for (int i = 20279; i <= 20602; i++)
                materials[i] = Material.PolishedDeepslateWall;
            materials[5] = Material.PolishedDiorite;
            for (int i = 11688; i <= 11693; i++)
                materials[i] = Material.PolishedDioriteSlab;
            for (int i = 10790; i <= 10869; i++)
                materials[i] = Material.PolishedDioriteStairs;
            materials[3] = Material.PolishedGranite;
            for (int i = 11670; i <= 11675; i++)
                materials[i] = Material.PolishedGraniteSlab;
            for (int i = 10550; i <= 10629; i++)
                materials[i] = Material.PolishedGraniteStairs;
            materials[1667] = Material.Poppy;
            for (int i = 6931; i <= 6938; i++)
                materials[i] = Material.Potatoes;
            materials[6902] = Material.PottedAcaciaSapling;
            materials[6909] = Material.PottedAllium;
            materials[21435] = Material.PottedAzaleaBush;
            materials[6910] = Material.PottedAzureBluet;
            materials[10545] = Material.PottedBamboo;
            materials[6900] = Material.PottedBirchSapling;
            materials[6908] = Material.PottedBlueOrchid;
            materials[6920] = Material.PottedBrownMushroom;
            materials[6922] = Material.PottedCactus;
            materials[6916] = Material.PottedCornflower;
            materials[17043] = Material.PottedCrimsonFungus;
            materials[17045] = Material.PottedCrimsonRoots;
            materials[6906] = Material.PottedDandelion;
            materials[6903] = Material.PottedDarkOakSapling;
            materials[6921] = Material.PottedDeadBush;
            materials[6905] = Material.PottedFern;
            materials[21436] = Material.PottedFloweringAzaleaBush;
            materials[6901] = Material.PottedJungleSapling;
            materials[6917] = Material.PottedLilyOfTheValley;
            materials[6904] = Material.PottedMangrovePropagule;
            materials[6898] = Material.PottedOakSapling;
            materials[6912] = Material.PottedOrangeTulip;
            materials[6915] = Material.PottedOxeyeDaisy;
            materials[6914] = Material.PottedPinkTulip;
            materials[6907] = Material.PottedPoppy;
            materials[6919] = Material.PottedRedMushroom;
            materials[6911] = Material.PottedRedTulip;
            materials[6899] = Material.PottedSpruceSapling;
            materials[17044] = Material.PottedWarpedFungus;
            materials[17046] = Material.PottedWarpedRoots;
            materials[6913] = Material.PottedWhiteTulip;
            materials[6918] = Material.PottedWitherRose;
            materials[18672] = Material.PowderSnow;
            for (int i = 5733; i <= 5735; i++)
                materials[i] = Material.PowderSnowCauldron;
            for (int i = 1535; i <= 1558; i++)
                materials[i] = Material.PoweredRail;
            materials[8342] = Material.Prismarine;
            for (int i = 8591; i <= 8596; i++)
                materials[i] = Material.PrismarineBrickSlab;
            for (int i = 8425; i <= 8504; i++)
                materials[i] = Material.PrismarineBrickStairs;
            materials[8343] = Material.PrismarineBricks;
            for (int i = 8585; i <= 8590; i++)
                materials[i] = Material.PrismarineSlab;
            for (int i = 8345; i <= 8424; i++)
                materials[i] = Material.PrismarineStairs;
            for (int i = 12072; i <= 12395; i++)
                materials[i] = Material.PrismarineWall;
            materials[4307] = Material.Pumpkin;
            for (int i = 5151; i <= 5158; i++)
                materials[i] = Material.PumpkinStem;
            for (int i = 8798; i <= 8813; i++)
                materials[i] = Material.PurpleBanner;
            for (int i = 1439; i <= 1454; i++)
                materials[i] = Material.PurpleBed;
            for (int i = 18489; i <= 18504; i++)
                materials[i] = Material.PurpleCandle;
            for (int i = 18607; i <= 18608; i++)
                materials[i] = Material.PurpleCandleCake;
            materials[8617] = Material.PurpleCarpet;
            materials[10329] = Material.PurpleConcrete;
            materials[10345] = Material.PurpleConcretePowder;
            for (int i = 10295; i <= 10298; i++)
                materials[i] = Material.PurpleGlazedTerracotta;
            for (int i = 10219; i <= 10224; i++)
                materials[i] = Material.PurpleShulkerBox;
            materials[4414] = Material.PurpleStainedGlass;
            for (int i = 7812; i <= 7843; i++)
                materials[i] = Material.PurpleStainedGlassPane;
            materials[7486] = Material.PurpleTerracotta;
            for (int i = 8934; i <= 8937; i++)
                materials[i] = Material.PurpleWallBanner;
            materials[1648] = Material.PurpleWool;
            materials[10015] = Material.PurpurBlock;
            for (int i = 10016; i <= 10018; i++)
                materials[i] = Material.PurpurPillar;
            for (int i = 9161; i <= 9166; i++)
                materials[i] = Material.PurpurSlab;
            for (int i = 10019; i <= 10098; i++)
                materials[i] = Material.PurpurStairs;
            materials[7355] = Material.QuartzBlock;
            materials[18312] = Material.QuartzBricks;
            for (int i = 7357; i <= 7359; i++)
                materials[i] = Material.QuartzPillar;
            for (int i = 9143; i <= 9148; i++)
                materials[i] = Material.QuartzSlab;
            for (int i = 7360; i <= 7439; i++)
                materials[i] = Material.QuartzStairs;
            for (int i = 3932; i <= 3951; i++)
                materials[i] = Material.Rail;
            materials[21433] = Material.RawCopperBlock;
            materials[21434] = Material.RawGoldBlock;
            materials[21432] = Material.RawIronBlock;
            for (int i = 8862; i <= 8877; i++)
                materials[i] = Material.RedBanner;
            for (int i = 1503; i <= 1518; i++)
                materials[i] = Material.RedBed;
            for (int i = 18553; i <= 18568; i++)
                materials[i] = Material.RedCandle;
            for (int i = 18615; i <= 18616; i++)
                materials[i] = Material.RedCandleCake;
            materials[8621] = Material.RedCarpet;
            materials[10333] = Material.RedConcrete;
            materials[10349] = Material.RedConcretePowder;
            for (int i = 10311; i <= 10314; i++)
                materials[i] = Material.RedGlazedTerracotta;
            materials[1680] = Material.RedMushroom;
            for (int i = 4944; i <= 5007; i++)
                materials[i] = Material.RedMushroomBlock;
            for (int i = 11730; i <= 11735; i++)
                materials[i] = Material.RedNetherBrickSlab;
            for (int i = 11430; i <= 11509; i++)
                materials[i] = Material.RedNetherBrickStairs;
            for (int i = 14664; i <= 14987; i++)
                materials[i] = Material.RedNetherBrickWall;
            materials[10136] = Material.RedNetherBricks;
            materials[108] = Material.RedSand;
            materials[8958] = Material.RedSandstone;
            for (int i = 9149; i <= 9154; i++)
                materials[i] = Material.RedSandstoneSlab;
            for (int i = 8961; i <= 9040; i++)
                materials[i] = Material.RedSandstoneStairs;
            for (int i = 12396; i <= 12719; i++)
                materials[i] = Material.RedSandstoneWall;
            for (int i = 10243; i <= 10248; i++)
                materials[i] = Material.RedShulkerBox;
            materials[4418] = Material.RedStainedGlass;
            for (int i = 7940; i <= 7971; i++)
                materials[i] = Material.RedStainedGlassPane;
            materials[7490] = Material.RedTerracotta;
            materials[1671] = Material.RedTulip;
            for (int i = 8950; i <= 8953; i++)
                materials[i] = Material.RedWallBanner;
            materials[1652] = Material.RedWool;
            materials[7343] = Material.RedstoneBlock;
            for (int i = 5747; i <= 5748; i++)
                materials[i] = Material.RedstoneLamp;
            for (int i = 4192; i <= 4193; i++)
                materials[i] = Material.RedstoneOre;
            for (int i = 4196; i <= 4197; i++)
                materials[i] = Material.RedstoneTorch;
            for (int i = 4198; i <= 4205; i++)
                materials[i] = Material.RedstoneWallTorch;
            for (int i = 2312; i <= 3607; i++)
                materials[i] = Material.RedstoneWire;
            materials[21447] = Material.ReinforcedDeepslate;
            for (int i = 4340; i <= 4403; i++)
                materials[i] = Material.Repeater;
            for (int i = 10106; i <= 10117; i++)
                materials[i] = Material.RepeatingCommandBlock;
            for (int i = 17038; i <= 17042; i++)
                materials[i] = Material.RespawnAnchor;
            materials[19776] = Material.RootedDirt;
            for (int i = 8630; i <= 8631; i++)
                materials[i] = Material.RoseBush;
            materials[107] = Material.Sand;
            materials[476] = Material.Sandstone;
            for (int i = 9095; i <= 9100; i++)
                materials[i] = Material.SandstoneSlab;
            for (int i = 5761; i <= 5840; i++)
                materials[i] = Material.SandstoneStairs;
            for (int i = 14988; i <= 15311; i++)
                materials[i] = Material.SandstoneWall;
            for (int i = 15960; i <= 15991; i++)
                materials[i] = Material.Scaffolding;
            materials[18769] = Material.Sculk;
            for (int i = 18898; i <= 18899; i++)
                materials[i] = Material.SculkCatalyst;
            for (int i = 18673; i <= 18768; i++)
                materials[i] = Material.SculkSensor;
            for (int i = 18900; i <= 18907; i++)
                materials[i] = Material.SculkShrieker;
            for (int i = 18770; i <= 18897; i++)
                materials[i] = Material.SculkVein;
            materials[8603] = Material.SeaLantern;
            for (int i = 10521; i <= 10528; i++)
                materials[i] = Material.SeaPickle;
            materials[1599] = Material.Seagrass;
            materials[16198] = Material.Shroomlight;
            for (int i = 10153; i <= 10158; i++)
                materials[i] = Material.ShulkerBox;
            for (int i = 7107; i <= 7122; i++)
                materials[i] = Material.SkeletonSkull;
            for (int i = 7123; i <= 7126; i++)
                materials[i] = Material.SkeletonWallSkull;
            materials[8244] = Material.SlimeBlock;
            for (int i = 18657; i <= 18668; i++)
                materials[i] = Material.SmallAmethystBud;
            for (int i = 19758; i <= 19773; i++)
                materials[i] = Material.SmallDripleaf;
            materials[16054] = Material.SmithingTable;
            for (int i = 16008; i <= 16015; i++)
                materials[i] = Material.Smoker;
            materials[21431] = Material.SmoothBasalt;
            materials[9169] = Material.SmoothQuartz;
            for (int i = 11712; i <= 11717; i++)
                materials[i] = Material.SmoothQuartzSlab;
            for (int i = 11190; i <= 11269; i++)
                materials[i] = Material.SmoothQuartzStairs;
            materials[9170] = Material.SmoothRedSandstone;
            for (int i = 11676; i <= 11681; i++)
                materials[i] = Material.SmoothRedSandstoneSlab;
            for (int i = 10630; i <= 10709; i++)
                materials[i] = Material.SmoothRedSandstoneStairs;
            materials[9168] = Material.SmoothSandstone;
            for (int i = 11706; i <= 11711; i++)
                materials[i] = Material.SmoothSandstoneSlab;
            for (int i = 11110; i <= 11189; i++)
                materials[i] = Material.SmoothSandstoneStairs;
            materials[9167] = Material.SmoothStone;
            for (int i = 9089; i <= 9094; i++)
                materials[i] = Material.SmoothStoneSlab;
            for (int i = 4230; i <= 4237; i++)
                materials[i] = Material.Snow;
            materials[4239] = Material.SnowBlock;
            for (int i = 16131; i <= 16162; i++)
                materials[i] = Material.SoulCampfire;
            materials[2206] = Material.SoulFire;
            for (int i = 16095; i <= 16098; i++)
                materials[i] = Material.SoulLantern;
            materials[4309] = Material.SoulSand;
            materials[4310] = Material.SoulSoil;
            materials[4317] = Material.SoulTorch;
            for (int i = 4318; i <= 4321; i++)
                materials[i] = Material.SoulWallTorch;
            materials[2207] = Material.Spawner;
            materials[458] = Material.Sponge;
            materials[19713] = Material.SporeBlossom;
            for (int i = 6963; i <= 6986; i++)
                materials[i] = Material.SpruceButton;
            for (int i = 9555; i <= 9618; i++)
                materials[i] = Material.SpruceDoor;
            for (int i = 9363; i <= 9394; i++)
                materials[i] = Material.SpruceFence;
            for (int i = 9171; i <= 9202; i++)
                materials[i] = Material.SpruceFenceGate;
            for (int i = 234; i <= 261; i++)
                materials[i] = Material.SpruceLeaves;
            for (int i = 120; i <= 122; i++)
                materials[i] = Material.SpruceLog;
            materials[16] = Material.SprucePlanks;
            for (int i = 4180; i <= 4181; i++)
                materials[i] = Material.SprucePressurePlate;
            for (int i = 24; i <= 25; i++)
                materials[i] = Material.SpruceSapling;
            for (int i = 3668; i <= 3699; i++)
                materials[i] = Material.SpruceSign;
            for (int i = 9047; i <= 9052; i++)
                materials[i] = Material.SpruceSlab;
            for (int i = 5996; i <= 6075; i++)
                materials[i] = Material.SpruceStairs;
            for (int i = 4484; i <= 4547; i++)
                materials[i] = Material.SpruceTrapdoor;
            for (int i = 4040; i <= 4047; i++)
                materials[i] = Material.SpruceWallSign;
            for (int i = 167; i <= 169; i++)
                materials[i] = Material.SpruceWood;
            for (int i = 1583; i <= 1594; i++)
                materials[i] = Material.StickyPiston;
            materials[1] = Material.Stone;
            for (int i = 9125; i <= 9130; i++)
                materials[i] = Material.StoneBrickSlab;
            for (int i = 5439; i <= 5518; i++)
                materials[i] = Material.StoneBrickStairs;
            for (int i = 13368; i <= 13691; i++)
                materials[i] = Material.StoneBrickWall;
            materials[4868] = Material.StoneBricks;
            for (int i = 4206; i <= 4229; i++)
                materials[i] = Material.StoneButton;
            for (int i = 4112; i <= 4113; i++)
                materials[i] = Material.StonePressurePlate;
            for (int i = 9083; i <= 9088; i++)
                materials[i] = Material.StoneSlab;
            for (int i = 11030; i <= 11109; i++)
                materials[i] = Material.StoneStairs;
            for (int i = 16055; i <= 16058; i++)
                materials[i] = Material.Stonecutter;
            for (int i = 152; i <= 154; i++)
                materials[i] = Material.StrippedAcaciaLog;
            for (int i = 197; i <= 199; i++)
                materials[i] = Material.StrippedAcaciaWood;
            for (int i = 146; i <= 148; i++)
                materials[i] = Material.StrippedBirchLog;
            for (int i = 191; i <= 193; i++)
                materials[i] = Material.StrippedBirchWood;
            for (int i = 16193; i <= 16195; i++)
                materials[i] = Material.StrippedCrimsonHyphae;
            for (int i = 16187; i <= 16189; i++)
                materials[i] = Material.StrippedCrimsonStem;
            for (int i = 155; i <= 157; i++)
                materials[i] = Material.StrippedDarkOakLog;
            for (int i = 200; i <= 202; i++)
                materials[i] = Material.StrippedDarkOakWood;
            for (int i = 149; i <= 151; i++)
                materials[i] = Material.StrippedJungleLog;
            for (int i = 194; i <= 196; i++)
                materials[i] = Material.StrippedJungleWood;
            for (int i = 161; i <= 163; i++)
                materials[i] = Material.StrippedMangroveLog;
            for (int i = 203; i <= 205; i++)
                materials[i] = Material.StrippedMangroveWood;
            for (int i = 158; i <= 160; i++)
                materials[i] = Material.StrippedOakLog;
            for (int i = 185; i <= 187; i++)
                materials[i] = Material.StrippedOakWood;
            for (int i = 143; i <= 145; i++)
                materials[i] = Material.StrippedSpruceLog;
            for (int i = 188; i <= 190; i++)
                materials[i] = Material.StrippedSpruceWood;
            for (int i = 16176; i <= 16178; i++)
                materials[i] = Material.StrippedWarpedHyphae;
            for (int i = 16170; i <= 16172; i++)
                materials[i] = Material.StrippedWarpedStem;
            for (int i = 16944; i <= 16947; i++)
                materials[i] = Material.StructureBlock;
            materials[10140] = Material.StructureVoid;
            for (int i = 4257; i <= 4272; i++)
                materials[i] = Material.SugarCane;
            for (int i = 8626; i <= 8627; i++)
                materials[i] = Material.Sunflower;
            for (int i = 16163; i <= 16166; i++)
                materials[i] = Material.SweetBerryBush;
            for (int i = 8634; i <= 8635; i++)
                materials[i] = Material.TallGrass;
            for (int i = 1600; i <= 1601; i++)
                materials[i] = Material.TallSeagrass;
            for (int i = 16969; i <= 16984; i++)
                materials[i] = Material.Target;
            materials[8623] = Material.Terracotta;
            materials[18671] = Material.TintedGlass;
            for (int i = 1684; i <= 1685; i++)
                materials[i] = Material.Tnt;
            materials[1689] = Material.Torch;
            for (int i = 7239; i <= 7262; i++)
                materials[i] = Material.TrappedChest;
            for (int i = 5867; i <= 5994; i++)
                materials[i] = Material.Tripwire;
            for (int i = 5851; i <= 5866; i++)
                materials[i] = Material.TripwireHook;
            for (int i = 10411; i <= 10412; i++)
                materials[i] = Material.TubeCoral;
            materials[10396] = Material.TubeCoralBlock;
            for (int i = 10431; i <= 10432; i++)
                materials[i] = Material.TubeCoralFan;
            for (int i = 10481; i <= 10488; i++)
                materials[i] = Material.TubeCoralWallFan;
            materials[18669] = Material.Tuff;
            for (int i = 10379; i <= 10390; i++)
                materials[i] = Material.TurtleEgg;
            for (int i = 16226; i <= 16251; i++)
                materials[i] = Material.TwistingVines;
            materials[16252] = Material.TwistingVinesPlant;
            for (int i = 21440; i <= 21442; i++)
                materials[i] = Material.VerdantFroglight;
            for (int i = 5167; i <= 5198; i++)
                materials[i] = Material.Vine;
            materials[10546] = Material.VoidAir;
            for (int i = 1690; i <= 1693; i++)
                materials[i] = Material.WallTorch;
            for (int i = 16712; i <= 16735; i++)
                materials[i] = Material.WarpedButton;
            for (int i = 16800; i <= 16863; i++)
                materials[i] = Material.WarpedDoor;
            for (int i = 16304; i <= 16335; i++)
                materials[i] = Material.WarpedFence;
            for (int i = 16496; i <= 16527; i++)
                materials[i] = Material.WarpedFenceGate;
            materials[16180] = Material.WarpedFungus;
            for (int i = 16173; i <= 16175; i++)
                materials[i] = Material.WarpedHyphae;
            materials[16179] = Material.WarpedNylium;
            materials[16255] = Material.WarpedPlanks;
            for (int i = 16270; i <= 16271; i++)
                materials[i] = Material.WarpedPressurePlate;
            materials[16182] = Material.WarpedRoots;
            for (int i = 16896; i <= 16927; i++)
                materials[i] = Material.WarpedSign;
            for (int i = 16262; i <= 16267; i++)
                materials[i] = Material.WarpedSlab;
            for (int i = 16608; i <= 16687; i++)
                materials[i] = Material.WarpedStairs;
            for (int i = 16167; i <= 16169; i++)
                materials[i] = Material.WarpedStem;
            for (int i = 16400; i <= 16463; i++)
                materials[i] = Material.WarpedTrapdoor;
            for (int i = 16936; i <= 16943; i++)
                materials[i] = Material.WarpedWallSign;
            materials[16181] = Material.WarpedWartBlock;
            for (int i = 75; i <= 90; i++)
                materials[i] = Material.Water;
            for (int i = 5729; i <= 5731; i++)
                materials[i] = Material.WaterCauldron;
            materials[19262] = Material.WaxedCopperBlock;
            materials[19269] = Material.WaxedCutCopper;
            for (int i = 19608; i <= 19613; i++)
                materials[i] = Material.WaxedCutCopperSlab;
            for (int i = 19510; i <= 19589; i++)
                materials[i] = Material.WaxedCutCopperStairs;
            materials[19264] = Material.WaxedExposedCopper;
            materials[19268] = Material.WaxedExposedCutCopper;
            for (int i = 19602; i <= 19607; i++)
                materials[i] = Material.WaxedExposedCutCopperSlab;
            for (int i = 19430; i <= 19509; i++)
                materials[i] = Material.WaxedExposedCutCopperStairs;
            materials[19265] = Material.WaxedOxidizedCopper;
            materials[19266] = Material.WaxedOxidizedCutCopper;
            for (int i = 19590; i <= 19595; i++)
                materials[i] = Material.WaxedOxidizedCutCopperSlab;
            for (int i = 19270; i <= 19349; i++)
                materials[i] = Material.WaxedOxidizedCutCopperStairs;
            materials[19263] = Material.WaxedWeatheredCopper;
            materials[19267] = Material.WaxedWeatheredCutCopper;
            for (int i = 19596; i <= 19601; i++)
                materials[i] = Material.WaxedWeatheredCutCopperSlab;
            for (int i = 19350; i <= 19429; i++)
                materials[i] = Material.WaxedWeatheredCutCopperStairs;
            materials[18909] = Material.WeatheredCopper;
            materials[18915] = Material.WeatheredCutCopper;
            for (int i = 19244; i <= 19249; i++)
                materials[i] = Material.WeatheredCutCopperSlab;
            for (int i = 18998; i <= 19077; i++)
                materials[i] = Material.WeatheredCutCopperStairs;
            for (int i = 16199; i <= 16224; i++)
                materials[i] = Material.WeepingVines;
            materials[16225] = Material.WeepingVinesPlant;
            materials[459] = Material.WetSponge;
            for (int i = 3612; i <= 3619; i++)
                materials[i] = Material.Wheat;
            for (int i = 8638; i <= 8653; i++)
                materials[i] = Material.WhiteBanner;
            for (int i = 1279; i <= 1294; i++)
                materials[i] = Material.WhiteBed;
            for (int i = 18329; i <= 18344; i++)
                materials[i] = Material.WhiteCandle;
            for (int i = 18587; i <= 18588; i++)
                materials[i] = Material.WhiteCandleCake;
            materials[8607] = Material.WhiteCarpet;
            materials[10319] = Material.WhiteConcrete;
            materials[10335] = Material.WhiteConcretePowder;
            for (int i = 10255; i <= 10258; i++)
                materials[i] = Material.WhiteGlazedTerracotta;
            for (int i = 10159; i <= 10164; i++)
                materials[i] = Material.WhiteShulkerBox;
            materials[4404] = Material.WhiteStainedGlass;
            for (int i = 7492; i <= 7523; i++)
                materials[i] = Material.WhiteStainedGlassPane;
            materials[7476] = Material.WhiteTerracotta;
            materials[1673] = Material.WhiteTulip;
            for (int i = 8894; i <= 8897; i++)
                materials[i] = Material.WhiteWallBanner;
            materials[1638] = Material.WhiteWool;
            materials[1677] = Material.WitherRose;
            for (int i = 7127; i <= 7142; i++)
                materials[i] = Material.WitherSkeletonSkull;
            for (int i = 7143; i <= 7146; i++)
                materials[i] = Material.WitherSkeletonWallSkull;
            for (int i = 8702; i <= 8717; i++)
                materials[i] = Material.YellowBanner;
            for (int i = 1343; i <= 1358; i++)
                materials[i] = Material.YellowBed;
            for (int i = 18393; i <= 18408; i++)
                materials[i] = Material.YellowCandle;
            for (int i = 18595; i <= 18596; i++)
                materials[i] = Material.YellowCandleCake;
            materials[8611] = Material.YellowCarpet;
            materials[10323] = Material.YellowConcrete;
            materials[10339] = Material.YellowConcretePowder;
            for (int i = 10271; i <= 10274; i++)
                materials[i] = Material.YellowGlazedTerracotta;
            for (int i = 10183; i <= 10188; i++)
                materials[i] = Material.YellowShulkerBox;
            materials[4408] = Material.YellowStainedGlass;
            for (int i = 7620; i <= 7651; i++)
                materials[i] = Material.YellowStainedGlassPane;
            materials[7480] = Material.YellowTerracotta;
            for (int i = 8910; i <= 8913; i++)
                materials[i] = Material.YellowWallBanner;
            materials[1642] = Material.YellowWool;
            for (int i = 7147; i <= 7162; i++)
                materials[i] = Material.ZombieHead;
            for (int i = 7163; i <= 7166; i++)
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
            new(22, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(24, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(26, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(28, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(30, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(32, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(34, 40,
            [
                new("age", ["0", "1", "2", "3", "4"], 8),
                new("hanging", ["true", "false"], 4),
                new("stage", ["0", "1"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(75, 16,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(91, 16,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(117, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(120, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(123, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(126, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(129, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(132, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(135, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(138, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(140, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(143, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(146, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(149, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(152, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(155, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(158, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(161, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(164, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(167, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(170, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(173, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(176, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(179, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(182, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(185, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(188, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(191, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(194, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(197, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(200, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(203, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(206, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(234, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(262, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(290, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(318, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(346, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(374, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(402, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(430, 28,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 4),
                new("persistent", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(464, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("triggered", ["true", "false"], 1)
            ]),
            new(479, 800,
            [
                new("instrument", ["harp", "basedrum", "snare", "hat", "bass", "flute", "bell", "guitar", "chime", "xylophone", "iron_xylophone", "cow_bell", "didgeridoo", "bit", "banjo", "pling"], 50),
                new("note", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(1279, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1295, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1311, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1327, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1343, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1359, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1375, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1391, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1407, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1423, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1439, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1455, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1471, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1487, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1503, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1519, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1535, 24,
            [
                new("powered", ["true", "false"], 12),
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(1559, 24,
            [
                new("powered", ["true", "false"], 12),
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(1583, 12,
            [
                new("extended", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(1600, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(1602, 12,
            [
                new("extended", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(1614, 24,
            [
                new("type", ["normal", "sticky"], 1),
                new("facing", ["north", "east", "south", "west", "up", "down"], 4),
                new("short", ["true", "false"], 2)
            ]),
            new(1654, 12,
            [
                new("type", ["normal", "sticky"], 1),
                new("facing", ["north", "east", "south", "west", "up", "down"], 2)
            ]),
            new(1684, 2,
            [
                new("unstable", ["true", "false"], 1)
            ]),
            new(1690, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(1694, 512,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(2208, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(2288, 24,
            [
                new("type", ["single", "left", "right"], 2),
                new("facing", ["north", "south", "west", "east"], 6),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(2312, 1296,
            [
                new("east", ["up", "side", "none"], 432),
                new("north", ["up", "side", "none"], 144),
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 9),
                new("south", ["up", "side", "none"], 3),
                new("west", ["up", "side", "none"], 1)
            ]),
            new(3612, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(3620, 8,
            [
                new("moisture", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(3628, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(3636, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3668, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3700, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3732, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3764, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3796, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3828, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3860, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(3924, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3932, 20,
            [
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south", "south_east", "south_west", "north_west", "north_east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3952, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4032, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4040, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4048, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4056, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4064, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4072, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4080, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4088, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(4112, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(4114, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(4178, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(4180, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(4182, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(4184, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(4186, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(4188, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(4190, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(4192, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(4194, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(4196, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(4198, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(4206, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(4230, 8,
            [
                new("layers", ["1", "2", "3", "4", "5", "6", "7", "8"], 1)
            ]),
            new(4240, 16,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(4257, 16,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(4273, 2,
            [
                new("has_record", ["true", "false"], 1)
            ]),
            new(4275, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4311, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(4314, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(4318, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(4323, 2,
            [
                new("axis", ["x", "z"], 1)
            ]),
            new(4325, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(4329, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(4333, 7,
            [
                new("bites", ["0", "1", "2", "3", "4", "5", "6"], 1)
            ]),
            new(4340, 64,
            [
                new("delay", ["1", "2", "3", "4"], 16),
                new("facing", ["north", "south", "west", "east"], 4),
                new("locked", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(4420, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4484, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4548, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4612, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4676, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4740, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4804, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4880, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4944, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5008, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5072, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5104, 6,
            [
                new("axis", ["x", "y", "z"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5110, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5143, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5147, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5151, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(5159, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(5167, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5199, 128,
            [
                new("down", ["true", "false"], 64),
                new("east", ["true", "false"], 32),
                new("north", ["true", "false"], 16),
                new("south", ["true", "false"], 8),
                new("up", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5327, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5359, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5439, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5519, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5599, 2,
            [
                new("snowy", ["true", "false"], 1)
            ]),
            new(5603, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5635, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5715, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(5720, 8,
            [
                new("has_bottle_0", ["true", "false"], 4),
                new("has_bottle_1", ["true", "false"], 2),
                new("has_bottle_2", ["true", "false"], 1)
            ]),
            new(5729, 3,
            [
                new("level", ["1", "2", "3"], 1)
            ]),
            new(5733, 3,
            [
                new("level", ["1", "2", "3"], 1)
            ]),
            new(5737, 8,
            [
                new("eye", ["true", "false"], 4),
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5747, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(5749, 12,
            [
                new("age", ["0", "1", "2"], 4),
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5761, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5843, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5851, 16,
            [
                new("attached", ["true", "false"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5867, 128,
            [
                new("attached", ["true", "false"], 64),
                new("disarmed", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("powered", ["true", "false"], 4),
                new("south", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5996, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6076, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6156, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6236, 12,
            [
                new("conditional", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(6249, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(6573, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(6923, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(6931, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(6939, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(6963, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(6987, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7011, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7035, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7059, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7083, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7107, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7123, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7127, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7143, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7147, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7163, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7167, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7183, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7187, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7203, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7207, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7223, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7227, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7231, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7235, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7239, 24,
            [
                new("type", ["single", "left", "right"], 2),
                new("facing", ["north", "south", "west", "east"], 6),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7263, 16,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7279, 16,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7295, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("mode", ["compare", "subtract"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7311, 32,
            [
                new("inverted", ["true", "false"], 16),
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7345, 10,
            [
                new("enabled", ["true", "false"], 5),
                new("facing", ["down", "north", "south", "west", "east"], 1)
            ]),
            new(7357, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(7360, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7440, 24,
            [
                new("powered", ["true", "false"], 12),
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7464, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("triggered", ["true", "false"], 1)
            ]),
            new(7492, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7524, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7556, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7588, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7620, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7652, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7684, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7716, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7748, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7780, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7812, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7844, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7876, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7908, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7940, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7972, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(8004, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8084, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8164, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8246, 32,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8278, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8345, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8425, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8505, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8585, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8591, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8597, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8604, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(8626, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(8628, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(8630, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(8632, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(8634, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(8636, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(8638, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8654, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8670, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8686, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8702, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8718, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8734, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8750, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8766, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8782, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8798, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8814, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8830, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8846, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8862, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8878, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(8894, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8898, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8902, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8906, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8910, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8914, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8918, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8922, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8926, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8930, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8934, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8938, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8942, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8946, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8950, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8954, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8961, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9041, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9047, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9053, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9059, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9065, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9071, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9077, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9083, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9089, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9095, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9101, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9107, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9113, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9119, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9125, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9131, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9137, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9143, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9149, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9155, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9161, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(9171, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9203, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9235, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9267, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9299, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9331, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9363, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(9395, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(9427, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(9459, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(9491, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(9523, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(9555, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9619, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9683, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9747, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9811, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9875, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(9939, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(9945, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(10009, 6,
            [
                new("age", ["0", "1", "2", "3", "4", "5"], 1)
            ]),
            new(10016, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(10019, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10100, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(10106, 12,
            [
                new("conditional", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10118, 12,
            [
                new("conditional", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10130, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(10137, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(10141, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(10153, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10159, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10165, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10171, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10177, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10183, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10189, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10195, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10201, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10207, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10213, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10219, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10225, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10231, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10237, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10243, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10249, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(10255, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10259, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10263, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10267, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10271, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10275, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10279, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10283, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10287, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10291, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10295, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10299, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10303, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10307, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10311, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10315, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(10351, 26,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"], 1)
            ]),
            new(10379, 12,
            [
                new("eggs", ["1", "2", "3", "4"], 3),
                new("hatch", ["0", "1", "2"], 1)
            ]),
            new(10401, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10403, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10405, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10407, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10409, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10411, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10413, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10415, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10417, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10419, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10421, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10423, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10425, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10427, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10429, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10431, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10433, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10435, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10437, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10439, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10441, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10449, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10457, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10465, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10473, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10481, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10489, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10497, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10505, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10513, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10521, 8,
            [
                new("pickles", ["1", "2", "3", "4"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10530, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10533, 12,
            [
                new("age", ["0", "1"], 6),
                new("leaves", ["none", "small", "large"], 2),
                new("stage", ["0", "1"], 1)
            ]),
            new(10548, 2,
            [
                new("drag", ["true", "false"], 1)
            ]),
            new(10550, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10630, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10710, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10790, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10870, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(10950, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11030, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11110, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11190, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11270, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11350, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11430, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11510, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11590, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11670, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11676, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11682, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11688, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11694, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11700, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11706, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11712, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11718, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11724, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11730, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11736, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11742, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(11748, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(12072, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(12396, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(12720, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(13044, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(13368, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(13692, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(14016, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(14340, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(14664, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(14988, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(15312, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(15636, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(15960, 32,
            [
                new("bottom", ["true", "false"], 16),
                new("distance", ["0", "1", "2", "3", "4", "5", "6", "7"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(15992, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(15996, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("open", ["true", "false"], 1)
            ]),
            new(16008, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(16016, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(16026, 12,
            [
                new("face", ["floor", "wall", "ceiling"], 4),
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(16038, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("has_book", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(16055, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(16059, 32,
            [
                new("attachment", ["floor", "ceiling", "single_wall", "double_wall"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(16091, 4,
            [
                new("hanging", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16095, 4,
            [
                new("hanging", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16099, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("lit", ["true", "false"], 4),
                new("signal_fire", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16131, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("lit", ["true", "false"], 4),
                new("signal_fire", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16163, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(16167, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(16170, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(16173, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(16176, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(16184, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(16187, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(16190, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(16193, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(16199, 26,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"], 1)
            ]),
            new(16226, 26,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"], 1)
            ]),
            new(16256, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16262, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16268, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(16270, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(16272, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(16304, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(16336, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16400, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16464, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(16496, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(16528, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16608, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16688, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(16712, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(16736, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(16800, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(16864, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16896, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16928, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16936, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(16944, 4,
            [
                new("mode", ["save", "load", "corner", "data"], 1)
            ]),
            new(16948, 12,
            [
                new("orientation", ["down_east", "down_north", "down_south", "down_west", "up_east", "up_north", "up_south", "up_west", "west_up", "east_up", "north_up", "south_up"], 1)
            ]),
            new(16960, 9,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8"], 1)
            ]),
            new(16969, 16,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(16985, 24,
            [
                new("facing", ["north", "south", "west", "east"], 6),
                new("honey_level", ["0", "1", "2", "3", "4", "5"], 1)
            ]),
            new(17009, 24,
            [
                new("facing", ["north", "south", "west", "east"], 6),
                new("honey_level", ["0", "1", "2", "3", "4", "5"], 1)
            ]),
            new(17038, 5,
            [
                new("charges", ["0", "1", "2", "3", "4"], 1)
            ]),
            new(17049, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(17129, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(17453, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(17463, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(17469, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(17549, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(17874, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(17954, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(17960, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(17962, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(17986, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(18313, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18329, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18345, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18361, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18377, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18393, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18409, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18425, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18441, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18457, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18473, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18489, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18505, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18521, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18537, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18553, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18569, 16,
            [
                new("candles", ["1", "2", "3", "4"], 4),
                new("lit", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18585, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18587, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18589, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18591, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18593, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18595, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18597, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18599, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18601, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18603, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18605, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18607, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18609, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18611, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18613, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18615, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18617, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(18621, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18633, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18645, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18657, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18673, 96,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 6),
                new("sculk_sensor_phase", ["inactive", "active", "cooldown"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18770, 128,
            [
                new("down", ["true", "false"], 64),
                new("east", ["true", "false"], 32),
                new("north", ["true", "false"], 16),
                new("south", ["true", "false"], 8),
                new("up", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(18898, 2,
            [
                new("bloom", ["true", "false"], 1)
            ]),
            new(18900, 8,
            [
                new("can_summon", ["true", "false"], 4),
                new("shrieking", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18918, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(18998, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19078, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19158, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19238, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19244, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19250, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19256, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19270, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19350, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19430, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19510, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19590, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19596, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19602, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19608, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19614, 24,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19638, 20,
            [
                new("thickness", ["tip_merge", "tip", "frustum", "middle", "base"], 4),
                new("vertical_direction", ["up", "down"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19659, 52,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"], 2),
                new("berries", ["true", "false"], 1)
            ]),
            new(19711, 2,
            [
                new("berries", ["true", "false"], 1)
            ]),
            new(19718, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("tilt", ["none", "unstable", "partial", "full"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19750, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19758, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("half", ["upper", "lower"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19774, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19778, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(19782, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19862, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(19868, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(20193, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20273, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20279, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(20604, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20684, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(20690, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(21015, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21095, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(21101, 324,
            [
                new("east", ["none", "low", "tall"], 108),
                new("north", ["none", "low", "tall"], 36),
                new("south", ["none", "low", "tall"], 12),
                new("up", ["true", "false"], 6),
                new("waterlogged", ["true", "false"], 3),
                new("west", ["none", "low", "tall"], 1)
            ]),
            new(21428, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(21437, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(21440, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(21443, 3,
            [
                new("axis", ["x", "y", "z"], 1)
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
