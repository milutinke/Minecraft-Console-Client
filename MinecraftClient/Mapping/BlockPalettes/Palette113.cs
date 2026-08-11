using System.Collections.Generic;

namespace MinecraftClient.Mapping.BlockPalettes
{
    /// <summary>
    /// Defines mappings for Minecraft 1.13.
    /// Automatically generated using BlockPaletteGenerator.cs
    /// </summary>
    public class Palette113 : BlockPalette
    {
        private static readonly Dictionary<int, Material> materials = new();

        static Palette113()
        {
            materials[0] = Material.Air;
            materials[1] = Material.Stone;
            materials[2] = Material.Granite;
            materials[3] = Material.PolishedGranite;
            materials[4] = Material.Diorite;
            materials[5] = Material.PolishedDiorite;
            materials[6] = Material.Andesite;
            materials[7] = Material.PolishedAndesite;
            for (int i = 8; i <= 9; i++)
                materials[i] = Material.GrassBlock;
            materials[10] = Material.Dirt;
            materials[11] = Material.CoarseDirt;
            for (int i = 12; i <= 13; i++)
                materials[i] = Material.Podzol;
            materials[14] = Material.Cobblestone;
            materials[15] = Material.OakPlanks;
            materials[16] = Material.SprucePlanks;
            materials[17] = Material.BirchPlanks;
            materials[18] = Material.JunglePlanks;
            materials[19] = Material.AcaciaPlanks;
            materials[20] = Material.DarkOakPlanks;
            for (int i = 21; i <= 22; i++)
                materials[i] = Material.OakSapling;
            for (int i = 23; i <= 24; i++)
                materials[i] = Material.SpruceSapling;
            for (int i = 25; i <= 26; i++)
                materials[i] = Material.BirchSapling;
            for (int i = 27; i <= 28; i++)
                materials[i] = Material.JungleSapling;
            for (int i = 29; i <= 30; i++)
                materials[i] = Material.AcaciaSapling;
            for (int i = 31; i <= 32; i++)
                materials[i] = Material.DarkOakSapling;
            materials[33] = Material.Bedrock;
            for (int i = 34; i <= 49; i++)
                materials[i] = Material.Water;
            for (int i = 50; i <= 65; i++)
                materials[i] = Material.Lava;
            materials[66] = Material.Sand;
            materials[67] = Material.RedSand;
            materials[68] = Material.Gravel;
            materials[69] = Material.GoldOre;
            materials[70] = Material.IronOre;
            materials[71] = Material.CoalOre;
            for (int i = 72; i <= 74; i++)
                materials[i] = Material.OakLog;
            for (int i = 75; i <= 77; i++)
                materials[i] = Material.SpruceLog;
            for (int i = 78; i <= 80; i++)
                materials[i] = Material.BirchLog;
            for (int i = 81; i <= 83; i++)
                materials[i] = Material.JungleLog;
            for (int i = 84; i <= 86; i++)
                materials[i] = Material.AcaciaLog;
            for (int i = 87; i <= 89; i++)
                materials[i] = Material.DarkOakLog;
            for (int i = 90; i <= 92; i++)
                materials[i] = Material.StrippedSpruceLog;
            for (int i = 93; i <= 95; i++)
                materials[i] = Material.StrippedBirchLog;
            for (int i = 96; i <= 98; i++)
                materials[i] = Material.StrippedJungleLog;
            for (int i = 99; i <= 101; i++)
                materials[i] = Material.StrippedAcaciaLog;
            for (int i = 102; i <= 104; i++)
                materials[i] = Material.StrippedDarkOakLog;
            for (int i = 105; i <= 107; i++)
                materials[i] = Material.StrippedOakLog;
            for (int i = 108; i <= 110; i++)
                materials[i] = Material.OakWood;
            for (int i = 111; i <= 113; i++)
                materials[i] = Material.SpruceWood;
            for (int i = 114; i <= 116; i++)
                materials[i] = Material.BirchWood;
            for (int i = 117; i <= 119; i++)
                materials[i] = Material.JungleWood;
            for (int i = 120; i <= 122; i++)
                materials[i] = Material.AcaciaWood;
            for (int i = 123; i <= 125; i++)
                materials[i] = Material.DarkOakWood;
            for (int i = 126; i <= 128; i++)
                materials[i] = Material.StrippedOakWood;
            for (int i = 129; i <= 131; i++)
                materials[i] = Material.StrippedSpruceWood;
            for (int i = 132; i <= 134; i++)
                materials[i] = Material.StrippedBirchWood;
            for (int i = 135; i <= 137; i++)
                materials[i] = Material.StrippedJungleWood;
            for (int i = 138; i <= 140; i++)
                materials[i] = Material.StrippedAcaciaWood;
            for (int i = 141; i <= 143; i++)
                materials[i] = Material.StrippedDarkOakWood;
            for (int i = 144; i <= 157; i++)
                materials[i] = Material.OakLeaves;
            for (int i = 158; i <= 171; i++)
                materials[i] = Material.SpruceLeaves;
            for (int i = 172; i <= 185; i++)
                materials[i] = Material.BirchLeaves;
            for (int i = 186; i <= 199; i++)
                materials[i] = Material.JungleLeaves;
            for (int i = 200; i <= 213; i++)
                materials[i] = Material.AcaciaLeaves;
            for (int i = 214; i <= 227; i++)
                materials[i] = Material.DarkOakLeaves;
            materials[228] = Material.Sponge;
            materials[229] = Material.WetSponge;
            materials[230] = Material.Glass;
            materials[231] = Material.LapisOre;
            materials[232] = Material.LapisBlock;
            for (int i = 233; i <= 244; i++)
                materials[i] = Material.Dispenser;
            materials[245] = Material.Sandstone;
            materials[246] = Material.ChiseledSandstone;
            materials[247] = Material.CutSandstone;
            for (int i = 248; i <= 747; i++)
                materials[i] = Material.NoteBlock;
            for (int i = 748; i <= 763; i++)
                materials[i] = Material.WhiteBed;
            for (int i = 764; i <= 779; i++)
                materials[i] = Material.OrangeBed;
            for (int i = 780; i <= 795; i++)
                materials[i] = Material.MagentaBed;
            for (int i = 796; i <= 811; i++)
                materials[i] = Material.LightBlueBed;
            for (int i = 812; i <= 827; i++)
                materials[i] = Material.YellowBed;
            for (int i = 828; i <= 843; i++)
                materials[i] = Material.LimeBed;
            for (int i = 844; i <= 859; i++)
                materials[i] = Material.PinkBed;
            for (int i = 860; i <= 875; i++)
                materials[i] = Material.GrayBed;
            for (int i = 876; i <= 891; i++)
                materials[i] = Material.LightGrayBed;
            for (int i = 892; i <= 907; i++)
                materials[i] = Material.CyanBed;
            for (int i = 908; i <= 923; i++)
                materials[i] = Material.PurpleBed;
            for (int i = 924; i <= 939; i++)
                materials[i] = Material.BlueBed;
            for (int i = 940; i <= 955; i++)
                materials[i] = Material.BrownBed;
            for (int i = 956; i <= 971; i++)
                materials[i] = Material.GreenBed;
            for (int i = 972; i <= 987; i++)
                materials[i] = Material.RedBed;
            for (int i = 988; i <= 1003; i++)
                materials[i] = Material.BlackBed;
            for (int i = 1004; i <= 1015; i++)
                materials[i] = Material.PoweredRail;
            for (int i = 1016; i <= 1027; i++)
                materials[i] = Material.DetectorRail;
            for (int i = 1028; i <= 1039; i++)
                materials[i] = Material.StickyPiston;
            materials[1040] = Material.Cobweb;
            materials[1041] = Material.ShortGrass;
            materials[1042] = Material.Fern;
            materials[1043] = Material.DeadBush;
            materials[1044] = Material.Seagrass;
            for (int i = 1045; i <= 1046; i++)
                materials[i] = Material.TallSeagrass;
            for (int i = 1047; i <= 1058; i++)
                materials[i] = Material.Piston;
            for (int i = 1059; i <= 1082; i++)
                materials[i] = Material.PistonHead;
            materials[1083] = Material.WhiteWool;
            materials[1084] = Material.OrangeWool;
            materials[1085] = Material.MagentaWool;
            materials[1086] = Material.LightBlueWool;
            materials[1087] = Material.YellowWool;
            materials[1088] = Material.LimeWool;
            materials[1089] = Material.PinkWool;
            materials[1090] = Material.GrayWool;
            materials[1091] = Material.LightGrayWool;
            materials[1092] = Material.CyanWool;
            materials[1093] = Material.PurpleWool;
            materials[1094] = Material.BlueWool;
            materials[1095] = Material.BrownWool;
            materials[1096] = Material.GreenWool;
            materials[1097] = Material.RedWool;
            materials[1098] = Material.BlackWool;
            for (int i = 1099; i <= 1110; i++)
                materials[i] = Material.MovingPiston;
            materials[1111] = Material.Dandelion;
            materials[1112] = Material.Poppy;
            materials[1113] = Material.BlueOrchid;
            materials[1114] = Material.Allium;
            materials[1115] = Material.AzureBluet;
            materials[1116] = Material.RedTulip;
            materials[1117] = Material.OrangeTulip;
            materials[1118] = Material.WhiteTulip;
            materials[1119] = Material.PinkTulip;
            materials[1120] = Material.OxeyeDaisy;
            materials[1121] = Material.BrownMushroom;
            materials[1122] = Material.RedMushroom;
            materials[1123] = Material.GoldBlock;
            materials[1124] = Material.IronBlock;
            materials[1125] = Material.Bricks;
            for (int i = 1126; i <= 1127; i++)
                materials[i] = Material.Tnt;
            materials[1128] = Material.Bookshelf;
            materials[1129] = Material.MossyCobblestone;
            materials[1130] = Material.Obsidian;
            materials[1131] = Material.Torch;
            for (int i = 1132; i <= 1135; i++)
                materials[i] = Material.WallTorch;
            for (int i = 1136; i <= 1647; i++)
                materials[i] = Material.Fire;
            materials[1648] = Material.Spawner;
            for (int i = 1649; i <= 1728; i++)
                materials[i] = Material.OakStairs;
            for (int i = 1729; i <= 1752; i++)
                materials[i] = Material.Chest;
            for (int i = 1753; i <= 3048; i++)
                materials[i] = Material.RedstoneWire;
            materials[3049] = Material.DiamondOre;
            materials[3050] = Material.DiamondBlock;
            materials[3051] = Material.CraftingTable;
            for (int i = 3052; i <= 3059; i++)
                materials[i] = Material.Wheat;
            for (int i = 3060; i <= 3067; i++)
                materials[i] = Material.Farmland;
            for (int i = 3068; i <= 3075; i++)
                materials[i] = Material.Furnace;
            for (int i = 3076; i <= 3107; i++)
                materials[i] = Material.OakSign;
            for (int i = 3108; i <= 3171; i++)
                materials[i] = Material.OakDoor;
            for (int i = 3172; i <= 3179; i++)
                materials[i] = Material.Ladder;
            for (int i = 3180; i <= 3189; i++)
                materials[i] = Material.Rail;
            for (int i = 3190; i <= 3269; i++)
                materials[i] = Material.CobblestoneStairs;
            for (int i = 3270; i <= 3277; i++)
                materials[i] = Material.OakWallSign;
            for (int i = 3278; i <= 3301; i++)
                materials[i] = Material.Lever;
            for (int i = 3302; i <= 3303; i++)
                materials[i] = Material.StonePressurePlate;
            for (int i = 3304; i <= 3367; i++)
                materials[i] = Material.IronDoor;
            for (int i = 3368; i <= 3369; i++)
                materials[i] = Material.OakPressurePlate;
            for (int i = 3370; i <= 3371; i++)
                materials[i] = Material.SprucePressurePlate;
            for (int i = 3372; i <= 3373; i++)
                materials[i] = Material.BirchPressurePlate;
            for (int i = 3374; i <= 3375; i++)
                materials[i] = Material.JunglePressurePlate;
            for (int i = 3376; i <= 3377; i++)
                materials[i] = Material.AcaciaPressurePlate;
            for (int i = 3378; i <= 3379; i++)
                materials[i] = Material.DarkOakPressurePlate;
            for (int i = 3380; i <= 3381; i++)
                materials[i] = Material.RedstoneOre;
            for (int i = 3382; i <= 3383; i++)
                materials[i] = Material.RedstoneTorch;
            for (int i = 3384; i <= 3391; i++)
                materials[i] = Material.RedstoneWallTorch;
            for (int i = 3392; i <= 3415; i++)
                materials[i] = Material.StoneButton;
            for (int i = 3416; i <= 3423; i++)
                materials[i] = Material.Snow;
            materials[3424] = Material.Ice;
            materials[3425] = Material.SnowBlock;
            for (int i = 3426; i <= 3441; i++)
                materials[i] = Material.Cactus;
            materials[3442] = Material.Clay;
            for (int i = 3443; i <= 3458; i++)
                materials[i] = Material.SugarCane;
            for (int i = 3459; i <= 3460; i++)
                materials[i] = Material.Jukebox;
            for (int i = 3461; i <= 3492; i++)
                materials[i] = Material.OakFence;
            materials[3493] = Material.Pumpkin;
            materials[3494] = Material.Netherrack;
            materials[3495] = Material.SoulSand;
            materials[3496] = Material.Glowstone;
            for (int i = 3497; i <= 3498; i++)
                materials[i] = Material.NetherPortal;
            for (int i = 3499; i <= 3502; i++)
                materials[i] = Material.CarvedPumpkin;
            for (int i = 3503; i <= 3506; i++)
                materials[i] = Material.JackOLantern;
            for (int i = 3507; i <= 3513; i++)
                materials[i] = Material.Cake;
            for (int i = 3514; i <= 3577; i++)
                materials[i] = Material.Repeater;
            materials[3578] = Material.WhiteStainedGlass;
            materials[3579] = Material.OrangeStainedGlass;
            materials[3580] = Material.MagentaStainedGlass;
            materials[3581] = Material.LightBlueStainedGlass;
            materials[3582] = Material.YellowStainedGlass;
            materials[3583] = Material.LimeStainedGlass;
            materials[3584] = Material.PinkStainedGlass;
            materials[3585] = Material.GrayStainedGlass;
            materials[3586] = Material.LightGrayStainedGlass;
            materials[3587] = Material.CyanStainedGlass;
            materials[3588] = Material.PurpleStainedGlass;
            materials[3589] = Material.BlueStainedGlass;
            materials[3590] = Material.BrownStainedGlass;
            materials[3591] = Material.GreenStainedGlass;
            materials[3592] = Material.RedStainedGlass;
            materials[3593] = Material.BlackStainedGlass;
            for (int i = 3594; i <= 3657; i++)
                materials[i] = Material.OakTrapdoor;
            for (int i = 3658; i <= 3721; i++)
                materials[i] = Material.SpruceTrapdoor;
            for (int i = 3722; i <= 3785; i++)
                materials[i] = Material.BirchTrapdoor;
            for (int i = 3786; i <= 3849; i++)
                materials[i] = Material.JungleTrapdoor;
            for (int i = 3850; i <= 3913; i++)
                materials[i] = Material.AcaciaTrapdoor;
            for (int i = 3914; i <= 3977; i++)
                materials[i] = Material.DarkOakTrapdoor;
            materials[3978] = Material.InfestedStone;
            materials[3979] = Material.InfestedCobblestone;
            materials[3980] = Material.InfestedStoneBricks;
            materials[3981] = Material.InfestedMossyStoneBricks;
            materials[3982] = Material.InfestedCrackedStoneBricks;
            materials[3983] = Material.InfestedChiseledStoneBricks;
            materials[3984] = Material.StoneBricks;
            materials[3985] = Material.MossyStoneBricks;
            materials[3986] = Material.CrackedStoneBricks;
            materials[3987] = Material.ChiseledStoneBricks;
            for (int i = 3988; i <= 4051; i++)
                materials[i] = Material.BrownMushroomBlock;
            for (int i = 4052; i <= 4115; i++)
                materials[i] = Material.RedMushroomBlock;
            for (int i = 4116; i <= 4179; i++)
                materials[i] = Material.MushroomStem;
            for (int i = 4180; i <= 4211; i++)
                materials[i] = Material.IronBars;
            for (int i = 4212; i <= 4243; i++)
                materials[i] = Material.GlassPane;
            materials[4244] = Material.Melon;
            for (int i = 4245; i <= 4248; i++)
                materials[i] = Material.AttachedPumpkinStem;
            for (int i = 4249; i <= 4252; i++)
                materials[i] = Material.AttachedMelonStem;
            for (int i = 4253; i <= 4260; i++)
                materials[i] = Material.PumpkinStem;
            for (int i = 4261; i <= 4268; i++)
                materials[i] = Material.MelonStem;
            for (int i = 4269; i <= 4300; i++)
                materials[i] = Material.Vine;
            for (int i = 4301; i <= 4332; i++)
                materials[i] = Material.OakFenceGate;
            for (int i = 4333; i <= 4412; i++)
                materials[i] = Material.BrickStairs;
            for (int i = 4413; i <= 4492; i++)
                materials[i] = Material.StoneBrickStairs;
            for (int i = 4493; i <= 4494; i++)
                materials[i] = Material.Mycelium;
            materials[4495] = Material.LilyPad;
            materials[4496] = Material.NetherBricks;
            for (int i = 4497; i <= 4528; i++)
                materials[i] = Material.NetherBrickFence;
            for (int i = 4529; i <= 4608; i++)
                materials[i] = Material.NetherBrickStairs;
            for (int i = 4609; i <= 4612; i++)
                materials[i] = Material.NetherWart;
            materials[4613] = Material.EnchantingTable;
            for (int i = 4614; i <= 4621; i++)
                materials[i] = Material.BrewingStand;
            for (int i = 4622; i <= 4625; i++)
                materials[i] = Material.Cauldron;
            materials[4626] = Material.EndPortal;
            for (int i = 4627; i <= 4634; i++)
                materials[i] = Material.EndPortalFrame;
            materials[4635] = Material.EndStone;
            materials[4636] = Material.DragonEgg;
            for (int i = 4637; i <= 4638; i++)
                materials[i] = Material.RedstoneLamp;
            for (int i = 4639; i <= 4650; i++)
                materials[i] = Material.Cocoa;
            for (int i = 4651; i <= 4730; i++)
                materials[i] = Material.SandstoneStairs;
            materials[4731] = Material.EmeraldOre;
            for (int i = 4732; i <= 4739; i++)
                materials[i] = Material.EnderChest;
            for (int i = 4740; i <= 4755; i++)
                materials[i] = Material.TripwireHook;
            for (int i = 4756; i <= 4883; i++)
                materials[i] = Material.Tripwire;
            materials[4884] = Material.EmeraldBlock;
            for (int i = 4885; i <= 4964; i++)
                materials[i] = Material.SpruceStairs;
            for (int i = 4965; i <= 5044; i++)
                materials[i] = Material.BirchStairs;
            for (int i = 5045; i <= 5124; i++)
                materials[i] = Material.JungleStairs;
            for (int i = 5125; i <= 5136; i++)
                materials[i] = Material.CommandBlock;
            materials[5137] = Material.Beacon;
            for (int i = 5138; i <= 5201; i++)
                materials[i] = Material.CobblestoneWall;
            for (int i = 5202; i <= 5265; i++)
                materials[i] = Material.MossyCobblestoneWall;
            materials[5266] = Material.FlowerPot;
            materials[5267] = Material.PottedOakSapling;
            materials[5268] = Material.PottedSpruceSapling;
            materials[5269] = Material.PottedBirchSapling;
            materials[5270] = Material.PottedJungleSapling;
            materials[5271] = Material.PottedAcaciaSapling;
            materials[5272] = Material.PottedDarkOakSapling;
            materials[5273] = Material.PottedFern;
            materials[5274] = Material.PottedDandelion;
            materials[5275] = Material.PottedPoppy;
            materials[5276] = Material.PottedBlueOrchid;
            materials[5277] = Material.PottedAllium;
            materials[5278] = Material.PottedAzureBluet;
            materials[5279] = Material.PottedRedTulip;
            materials[5280] = Material.PottedOrangeTulip;
            materials[5281] = Material.PottedWhiteTulip;
            materials[5282] = Material.PottedPinkTulip;
            materials[5283] = Material.PottedOxeyeDaisy;
            materials[5284] = Material.PottedRedMushroom;
            materials[5285] = Material.PottedBrownMushroom;
            materials[5286] = Material.PottedDeadBush;
            materials[5287] = Material.PottedCactus;
            for (int i = 5288; i <= 5295; i++)
                materials[i] = Material.Carrots;
            for (int i = 5296; i <= 5303; i++)
                materials[i] = Material.Potatoes;
            for (int i = 5304; i <= 5327; i++)
                materials[i] = Material.OakButton;
            for (int i = 5328; i <= 5351; i++)
                materials[i] = Material.SpruceButton;
            for (int i = 5352; i <= 5375; i++)
                materials[i] = Material.BirchButton;
            for (int i = 5376; i <= 5399; i++)
                materials[i] = Material.JungleButton;
            for (int i = 5400; i <= 5423; i++)
                materials[i] = Material.AcaciaButton;
            for (int i = 5424; i <= 5447; i++)
                materials[i] = Material.DarkOakButton;
            for (int i = 5448; i <= 5451; i++)
                materials[i] = Material.SkeletonWallSkull;
            for (int i = 5452; i <= 5467; i++)
                materials[i] = Material.SkeletonSkull;
            for (int i = 5468; i <= 5471; i++)
                materials[i] = Material.WitherSkeletonWallSkull;
            for (int i = 5472; i <= 5487; i++)
                materials[i] = Material.WitherSkeletonSkull;
            for (int i = 5488; i <= 5491; i++)
                materials[i] = Material.ZombieWallHead;
            for (int i = 5492; i <= 5507; i++)
                materials[i] = Material.ZombieHead;
            for (int i = 5508; i <= 5511; i++)
                materials[i] = Material.PlayerWallHead;
            for (int i = 5512; i <= 5527; i++)
                materials[i] = Material.PlayerHead;
            for (int i = 5528; i <= 5531; i++)
                materials[i] = Material.CreeperWallHead;
            for (int i = 5532; i <= 5547; i++)
                materials[i] = Material.CreeperHead;
            for (int i = 5548; i <= 5551; i++)
                materials[i] = Material.DragonWallHead;
            for (int i = 5552; i <= 5567; i++)
                materials[i] = Material.DragonHead;
            for (int i = 5568; i <= 5571; i++)
                materials[i] = Material.Anvil;
            for (int i = 5572; i <= 5575; i++)
                materials[i] = Material.ChippedAnvil;
            for (int i = 5576; i <= 5579; i++)
                materials[i] = Material.DamagedAnvil;
            for (int i = 5580; i <= 5603; i++)
                materials[i] = Material.TrappedChest;
            for (int i = 5604; i <= 5619; i++)
                materials[i] = Material.LightWeightedPressurePlate;
            for (int i = 5620; i <= 5635; i++)
                materials[i] = Material.HeavyWeightedPressurePlate;
            for (int i = 5636; i <= 5651; i++)
                materials[i] = Material.Comparator;
            for (int i = 5652; i <= 5683; i++)
                materials[i] = Material.DaylightDetector;
            materials[5684] = Material.RedstoneBlock;
            materials[5685] = Material.NetherQuartzOre;
            for (int i = 5686; i <= 5695; i++)
                materials[i] = Material.Hopper;
            materials[5696] = Material.QuartzBlock;
            materials[5697] = Material.ChiseledQuartzBlock;
            for (int i = 5698; i <= 5700; i++)
                materials[i] = Material.QuartzPillar;
            for (int i = 5701; i <= 5780; i++)
                materials[i] = Material.QuartzStairs;
            for (int i = 5781; i <= 5792; i++)
                materials[i] = Material.ActivatorRail;
            for (int i = 5793; i <= 5804; i++)
                materials[i] = Material.Dropper;
            materials[5805] = Material.WhiteTerracotta;
            materials[5806] = Material.OrangeTerracotta;
            materials[5807] = Material.MagentaTerracotta;
            materials[5808] = Material.LightBlueTerracotta;
            materials[5809] = Material.YellowTerracotta;
            materials[5810] = Material.LimeTerracotta;
            materials[5811] = Material.PinkTerracotta;
            materials[5812] = Material.GrayTerracotta;
            materials[5813] = Material.LightGrayTerracotta;
            materials[5814] = Material.CyanTerracotta;
            materials[5815] = Material.PurpleTerracotta;
            materials[5816] = Material.BlueTerracotta;
            materials[5817] = Material.BrownTerracotta;
            materials[5818] = Material.GreenTerracotta;
            materials[5819] = Material.RedTerracotta;
            materials[5820] = Material.BlackTerracotta;
            for (int i = 5821; i <= 5852; i++)
                materials[i] = Material.WhiteStainedGlassPane;
            for (int i = 5853; i <= 5884; i++)
                materials[i] = Material.OrangeStainedGlassPane;
            for (int i = 5885; i <= 5916; i++)
                materials[i] = Material.MagentaStainedGlassPane;
            for (int i = 5917; i <= 5948; i++)
                materials[i] = Material.LightBlueStainedGlassPane;
            for (int i = 5949; i <= 5980; i++)
                materials[i] = Material.YellowStainedGlassPane;
            for (int i = 5981; i <= 6012; i++)
                materials[i] = Material.LimeStainedGlassPane;
            for (int i = 6013; i <= 6044; i++)
                materials[i] = Material.PinkStainedGlassPane;
            for (int i = 6045; i <= 6076; i++)
                materials[i] = Material.GrayStainedGlassPane;
            for (int i = 6077; i <= 6108; i++)
                materials[i] = Material.LightGrayStainedGlassPane;
            for (int i = 6109; i <= 6140; i++)
                materials[i] = Material.CyanStainedGlassPane;
            for (int i = 6141; i <= 6172; i++)
                materials[i] = Material.PurpleStainedGlassPane;
            for (int i = 6173; i <= 6204; i++)
                materials[i] = Material.BlueStainedGlassPane;
            for (int i = 6205; i <= 6236; i++)
                materials[i] = Material.BrownStainedGlassPane;
            for (int i = 6237; i <= 6268; i++)
                materials[i] = Material.GreenStainedGlassPane;
            for (int i = 6269; i <= 6300; i++)
                materials[i] = Material.RedStainedGlassPane;
            for (int i = 6301; i <= 6332; i++)
                materials[i] = Material.BlackStainedGlassPane;
            for (int i = 6333; i <= 6412; i++)
                materials[i] = Material.AcaciaStairs;
            for (int i = 6413; i <= 6492; i++)
                materials[i] = Material.DarkOakStairs;
            materials[6493] = Material.SlimeBlock;
            materials[6494] = Material.Barrier;
            for (int i = 6495; i <= 6558; i++)
                materials[i] = Material.IronTrapdoor;
            materials[6559] = Material.Prismarine;
            materials[6560] = Material.PrismarineBricks;
            materials[6561] = Material.DarkPrismarine;
            for (int i = 6562; i <= 6641; i++)
                materials[i] = Material.PrismarineStairs;
            for (int i = 6642; i <= 6721; i++)
                materials[i] = Material.PrismarineBrickStairs;
            for (int i = 6722; i <= 6801; i++)
                materials[i] = Material.DarkPrismarineStairs;
            for (int i = 6802; i <= 6807; i++)
                materials[i] = Material.PrismarineSlab;
            for (int i = 6808; i <= 6813; i++)
                materials[i] = Material.PrismarineBrickSlab;
            for (int i = 6814; i <= 6819; i++)
                materials[i] = Material.DarkPrismarineSlab;
            materials[6820] = Material.SeaLantern;
            for (int i = 6821; i <= 6823; i++)
                materials[i] = Material.HayBlock;
            materials[6824] = Material.WhiteCarpet;
            materials[6825] = Material.OrangeCarpet;
            materials[6826] = Material.MagentaCarpet;
            materials[6827] = Material.LightBlueCarpet;
            materials[6828] = Material.YellowCarpet;
            materials[6829] = Material.LimeCarpet;
            materials[6830] = Material.PinkCarpet;
            materials[6831] = Material.GrayCarpet;
            materials[6832] = Material.LightGrayCarpet;
            materials[6833] = Material.CyanCarpet;
            materials[6834] = Material.PurpleCarpet;
            materials[6835] = Material.BlueCarpet;
            materials[6836] = Material.BrownCarpet;
            materials[6837] = Material.GreenCarpet;
            materials[6838] = Material.RedCarpet;
            materials[6839] = Material.BlackCarpet;
            materials[6840] = Material.Terracotta;
            materials[6841] = Material.CoalBlock;
            materials[6842] = Material.PackedIce;
            for (int i = 6843; i <= 6844; i++)
                materials[i] = Material.Sunflower;
            for (int i = 6845; i <= 6846; i++)
                materials[i] = Material.Lilac;
            for (int i = 6847; i <= 6848; i++)
                materials[i] = Material.RoseBush;
            for (int i = 6849; i <= 6850; i++)
                materials[i] = Material.Peony;
            for (int i = 6851; i <= 6852; i++)
                materials[i] = Material.TallGrass;
            for (int i = 6853; i <= 6854; i++)
                materials[i] = Material.LargeFern;
            for (int i = 6855; i <= 6870; i++)
                materials[i] = Material.WhiteBanner;
            for (int i = 6871; i <= 6886; i++)
                materials[i] = Material.OrangeBanner;
            for (int i = 6887; i <= 6902; i++)
                materials[i] = Material.MagentaBanner;
            for (int i = 6903; i <= 6918; i++)
                materials[i] = Material.LightBlueBanner;
            for (int i = 6919; i <= 6934; i++)
                materials[i] = Material.YellowBanner;
            for (int i = 6935; i <= 6950; i++)
                materials[i] = Material.LimeBanner;
            for (int i = 6951; i <= 6966; i++)
                materials[i] = Material.PinkBanner;
            for (int i = 6967; i <= 6982; i++)
                materials[i] = Material.GrayBanner;
            for (int i = 6983; i <= 6998; i++)
                materials[i] = Material.LightGrayBanner;
            for (int i = 6999; i <= 7014; i++)
                materials[i] = Material.CyanBanner;
            for (int i = 7015; i <= 7030; i++)
                materials[i] = Material.PurpleBanner;
            for (int i = 7031; i <= 7046; i++)
                materials[i] = Material.BlueBanner;
            for (int i = 7047; i <= 7062; i++)
                materials[i] = Material.BrownBanner;
            for (int i = 7063; i <= 7078; i++)
                materials[i] = Material.GreenBanner;
            for (int i = 7079; i <= 7094; i++)
                materials[i] = Material.RedBanner;
            for (int i = 7095; i <= 7110; i++)
                materials[i] = Material.BlackBanner;
            for (int i = 7111; i <= 7114; i++)
                materials[i] = Material.WhiteWallBanner;
            for (int i = 7115; i <= 7118; i++)
                materials[i] = Material.OrangeWallBanner;
            for (int i = 7119; i <= 7122; i++)
                materials[i] = Material.MagentaWallBanner;
            for (int i = 7123; i <= 7126; i++)
                materials[i] = Material.LightBlueWallBanner;
            for (int i = 7127; i <= 7130; i++)
                materials[i] = Material.YellowWallBanner;
            for (int i = 7131; i <= 7134; i++)
                materials[i] = Material.LimeWallBanner;
            for (int i = 7135; i <= 7138; i++)
                materials[i] = Material.PinkWallBanner;
            for (int i = 7139; i <= 7142; i++)
                materials[i] = Material.GrayWallBanner;
            for (int i = 7143; i <= 7146; i++)
                materials[i] = Material.LightGrayWallBanner;
            for (int i = 7147; i <= 7150; i++)
                materials[i] = Material.CyanWallBanner;
            for (int i = 7151; i <= 7154; i++)
                materials[i] = Material.PurpleWallBanner;
            for (int i = 7155; i <= 7158; i++)
                materials[i] = Material.BlueWallBanner;
            for (int i = 7159; i <= 7162; i++)
                materials[i] = Material.BrownWallBanner;
            for (int i = 7163; i <= 7166; i++)
                materials[i] = Material.GreenWallBanner;
            for (int i = 7167; i <= 7170; i++)
                materials[i] = Material.RedWallBanner;
            for (int i = 7171; i <= 7174; i++)
                materials[i] = Material.BlackWallBanner;
            materials[7175] = Material.RedSandstone;
            materials[7176] = Material.ChiseledRedSandstone;
            materials[7177] = Material.CutRedSandstone;
            for (int i = 7178; i <= 7257; i++)
                materials[i] = Material.RedSandstoneStairs;
            for (int i = 7258; i <= 7263; i++)
                materials[i] = Material.OakSlab;
            for (int i = 7264; i <= 7269; i++)
                materials[i] = Material.SpruceSlab;
            for (int i = 7270; i <= 7275; i++)
                materials[i] = Material.BirchSlab;
            for (int i = 7276; i <= 7281; i++)
                materials[i] = Material.JungleSlab;
            for (int i = 7282; i <= 7287; i++)
                materials[i] = Material.AcaciaSlab;
            for (int i = 7288; i <= 7293; i++)
                materials[i] = Material.DarkOakSlab;
            for (int i = 7294; i <= 7299; i++)
                materials[i] = Material.StoneSlab;
            for (int i = 7300; i <= 7305; i++)
                materials[i] = Material.SandstoneSlab;
            for (int i = 7306; i <= 7311; i++)
                materials[i] = Material.PetrifiedOakSlab;
            for (int i = 7312; i <= 7317; i++)
                materials[i] = Material.CobblestoneSlab;
            for (int i = 7318; i <= 7323; i++)
                materials[i] = Material.BrickSlab;
            for (int i = 7324; i <= 7329; i++)
                materials[i] = Material.StoneBrickSlab;
            for (int i = 7330; i <= 7335; i++)
                materials[i] = Material.NetherBrickSlab;
            for (int i = 7336; i <= 7341; i++)
                materials[i] = Material.QuartzSlab;
            for (int i = 7342; i <= 7347; i++)
                materials[i] = Material.RedSandstoneSlab;
            for (int i = 7348; i <= 7353; i++)
                materials[i] = Material.PurpurSlab;
            materials[7354] = Material.SmoothStone;
            materials[7355] = Material.SmoothSandstone;
            materials[7356] = Material.SmoothQuartz;
            materials[7357] = Material.SmoothRedSandstone;
            for (int i = 7358; i <= 7389; i++)
                materials[i] = Material.SpruceFenceGate;
            for (int i = 7390; i <= 7421; i++)
                materials[i] = Material.BirchFenceGate;
            for (int i = 7422; i <= 7453; i++)
                materials[i] = Material.JungleFenceGate;
            for (int i = 7454; i <= 7485; i++)
                materials[i] = Material.AcaciaFenceGate;
            for (int i = 7486; i <= 7517; i++)
                materials[i] = Material.DarkOakFenceGate;
            for (int i = 7518; i <= 7549; i++)
                materials[i] = Material.SpruceFence;
            for (int i = 7550; i <= 7581; i++)
                materials[i] = Material.BirchFence;
            for (int i = 7582; i <= 7613; i++)
                materials[i] = Material.JungleFence;
            for (int i = 7614; i <= 7645; i++)
                materials[i] = Material.AcaciaFence;
            for (int i = 7646; i <= 7677; i++)
                materials[i] = Material.DarkOakFence;
            for (int i = 7678; i <= 7741; i++)
                materials[i] = Material.SpruceDoor;
            for (int i = 7742; i <= 7805; i++)
                materials[i] = Material.BirchDoor;
            for (int i = 7806; i <= 7869; i++)
                materials[i] = Material.JungleDoor;
            for (int i = 7870; i <= 7933; i++)
                materials[i] = Material.AcaciaDoor;
            for (int i = 7934; i <= 7997; i++)
                materials[i] = Material.DarkOakDoor;
            for (int i = 7998; i <= 8003; i++)
                materials[i] = Material.EndRod;
            for (int i = 8004; i <= 8067; i++)
                materials[i] = Material.ChorusPlant;
            for (int i = 8068; i <= 8073; i++)
                materials[i] = Material.ChorusFlower;
            materials[8074] = Material.PurpurBlock;
            for (int i = 8075; i <= 8077; i++)
                materials[i] = Material.PurpurPillar;
            for (int i = 8078; i <= 8157; i++)
                materials[i] = Material.PurpurStairs;
            materials[8158] = Material.EndStoneBricks;
            for (int i = 8159; i <= 8162; i++)
                materials[i] = Material.Beetroots;
            materials[8163] = Material.DirtPath;
            materials[8164] = Material.EndGateway;
            for (int i = 8165; i <= 8176; i++)
                materials[i] = Material.RepeatingCommandBlock;
            for (int i = 8177; i <= 8188; i++)
                materials[i] = Material.ChainCommandBlock;
            for (int i = 8189; i <= 8192; i++)
                materials[i] = Material.FrostedIce;
            materials[8193] = Material.MagmaBlock;
            materials[8194] = Material.NetherWartBlock;
            materials[8195] = Material.RedNetherBricks;
            for (int i = 8196; i <= 8198; i++)
                materials[i] = Material.BoneBlock;
            materials[8199] = Material.StructureVoid;
            for (int i = 8200; i <= 8211; i++)
                materials[i] = Material.Observer;
            for (int i = 8212; i <= 8217; i++)
                materials[i] = Material.ShulkerBox;
            for (int i = 8218; i <= 8223; i++)
                materials[i] = Material.WhiteShulkerBox;
            for (int i = 8224; i <= 8229; i++)
                materials[i] = Material.OrangeShulkerBox;
            for (int i = 8230; i <= 8235; i++)
                materials[i] = Material.MagentaShulkerBox;
            for (int i = 8236; i <= 8241; i++)
                materials[i] = Material.LightBlueShulkerBox;
            for (int i = 8242; i <= 8247; i++)
                materials[i] = Material.YellowShulkerBox;
            for (int i = 8248; i <= 8253; i++)
                materials[i] = Material.LimeShulkerBox;
            for (int i = 8254; i <= 8259; i++)
                materials[i] = Material.PinkShulkerBox;
            for (int i = 8260; i <= 8265; i++)
                materials[i] = Material.GrayShulkerBox;
            for (int i = 8266; i <= 8271; i++)
                materials[i] = Material.LightGrayShulkerBox;
            for (int i = 8272; i <= 8277; i++)
                materials[i] = Material.CyanShulkerBox;
            for (int i = 8278; i <= 8283; i++)
                materials[i] = Material.PurpleShulkerBox;
            for (int i = 8284; i <= 8289; i++)
                materials[i] = Material.BlueShulkerBox;
            for (int i = 8290; i <= 8295; i++)
                materials[i] = Material.BrownShulkerBox;
            for (int i = 8296; i <= 8301; i++)
                materials[i] = Material.GreenShulkerBox;
            for (int i = 8302; i <= 8307; i++)
                materials[i] = Material.RedShulkerBox;
            for (int i = 8308; i <= 8313; i++)
                materials[i] = Material.BlackShulkerBox;
            for (int i = 8314; i <= 8317; i++)
                materials[i] = Material.WhiteGlazedTerracotta;
            for (int i = 8318; i <= 8321; i++)
                materials[i] = Material.OrangeGlazedTerracotta;
            for (int i = 8322; i <= 8325; i++)
                materials[i] = Material.MagentaGlazedTerracotta;
            for (int i = 8326; i <= 8329; i++)
                materials[i] = Material.LightBlueGlazedTerracotta;
            for (int i = 8330; i <= 8333; i++)
                materials[i] = Material.YellowGlazedTerracotta;
            for (int i = 8334; i <= 8337; i++)
                materials[i] = Material.LimeGlazedTerracotta;
            for (int i = 8338; i <= 8341; i++)
                materials[i] = Material.PinkGlazedTerracotta;
            for (int i = 8342; i <= 8345; i++)
                materials[i] = Material.GrayGlazedTerracotta;
            for (int i = 8346; i <= 8349; i++)
                materials[i] = Material.LightGrayGlazedTerracotta;
            for (int i = 8350; i <= 8353; i++)
                materials[i] = Material.CyanGlazedTerracotta;
            for (int i = 8354; i <= 8357; i++)
                materials[i] = Material.PurpleGlazedTerracotta;
            for (int i = 8358; i <= 8361; i++)
                materials[i] = Material.BlueGlazedTerracotta;
            for (int i = 8362; i <= 8365; i++)
                materials[i] = Material.BrownGlazedTerracotta;
            for (int i = 8366; i <= 8369; i++)
                materials[i] = Material.GreenGlazedTerracotta;
            for (int i = 8370; i <= 8373; i++)
                materials[i] = Material.RedGlazedTerracotta;
            for (int i = 8374; i <= 8377; i++)
                materials[i] = Material.BlackGlazedTerracotta;
            materials[8378] = Material.WhiteConcrete;
            materials[8379] = Material.OrangeConcrete;
            materials[8380] = Material.MagentaConcrete;
            materials[8381] = Material.LightBlueConcrete;
            materials[8382] = Material.YellowConcrete;
            materials[8383] = Material.LimeConcrete;
            materials[8384] = Material.PinkConcrete;
            materials[8385] = Material.GrayConcrete;
            materials[8386] = Material.LightGrayConcrete;
            materials[8387] = Material.CyanConcrete;
            materials[8388] = Material.PurpleConcrete;
            materials[8389] = Material.BlueConcrete;
            materials[8390] = Material.BrownConcrete;
            materials[8391] = Material.GreenConcrete;
            materials[8392] = Material.RedConcrete;
            materials[8393] = Material.BlackConcrete;
            materials[8394] = Material.WhiteConcretePowder;
            materials[8395] = Material.OrangeConcretePowder;
            materials[8396] = Material.MagentaConcretePowder;
            materials[8397] = Material.LightBlueConcretePowder;
            materials[8398] = Material.YellowConcretePowder;
            materials[8399] = Material.LimeConcretePowder;
            materials[8400] = Material.PinkConcretePowder;
            materials[8401] = Material.GrayConcretePowder;
            materials[8402] = Material.LightGrayConcretePowder;
            materials[8403] = Material.CyanConcretePowder;
            materials[8404] = Material.PurpleConcretePowder;
            materials[8405] = Material.BlueConcretePowder;
            materials[8406] = Material.BrownConcretePowder;
            materials[8407] = Material.GreenConcretePowder;
            materials[8408] = Material.RedConcretePowder;
            materials[8409] = Material.BlackConcretePowder;
            for (int i = 8410; i <= 8435; i++)
                materials[i] = Material.Kelp;
            materials[8436] = Material.KelpPlant;
            materials[8437] = Material.DriedKelpBlock;
            for (int i = 8438; i <= 8449; i++)
                materials[i] = Material.TurtleEgg;
            materials[8450] = Material.DeadTubeCoralBlock;
            materials[8451] = Material.DeadBrainCoralBlock;
            materials[8452] = Material.DeadBubbleCoralBlock;
            materials[8453] = Material.DeadFireCoralBlock;
            materials[8454] = Material.DeadHornCoralBlock;
            materials[8455] = Material.TubeCoralBlock;
            materials[8456] = Material.BrainCoralBlock;
            materials[8457] = Material.BubbleCoralBlock;
            materials[8458] = Material.FireCoralBlock;
            materials[8459] = Material.HornCoralBlock;
            for (int i = 8460; i <= 8461; i++)
                materials[i] = Material.DeadTubeCoral;
            for (int i = 8462; i <= 8463; i++)
                materials[i] = Material.DeadBrainCoral;
            for (int i = 8464; i <= 8465; i++)
                materials[i] = Material.DeadBubbleCoral;
            for (int i = 8466; i <= 8467; i++)
                materials[i] = Material.DeadFireCoral;
            for (int i = 8468; i <= 8469; i++)
                materials[i] = Material.DeadHornCoral;
            for (int i = 8470; i <= 8471; i++)
                materials[i] = Material.TubeCoral;
            for (int i = 8472; i <= 8473; i++)
                materials[i] = Material.BrainCoral;
            for (int i = 8474; i <= 8475; i++)
                materials[i] = Material.BubbleCoral;
            for (int i = 8476; i <= 8477; i++)
                materials[i] = Material.FireCoral;
            for (int i = 8478; i <= 8479; i++)
                materials[i] = Material.HornCoral;
            for (int i = 8480; i <= 8487; i++)
                materials[i] = Material.DeadTubeCoralWallFan;
            for (int i = 8488; i <= 8495; i++)
                materials[i] = Material.DeadBrainCoralWallFan;
            for (int i = 8496; i <= 8503; i++)
                materials[i] = Material.DeadBubbleCoralWallFan;
            for (int i = 8504; i <= 8511; i++)
                materials[i] = Material.DeadFireCoralWallFan;
            for (int i = 8512; i <= 8519; i++)
                materials[i] = Material.DeadHornCoralWallFan;
            for (int i = 8520; i <= 8527; i++)
                materials[i] = Material.TubeCoralWallFan;
            for (int i = 8528; i <= 8535; i++)
                materials[i] = Material.BrainCoralWallFan;
            for (int i = 8536; i <= 8543; i++)
                materials[i] = Material.BubbleCoralWallFan;
            for (int i = 8544; i <= 8551; i++)
                materials[i] = Material.FireCoralWallFan;
            for (int i = 8552; i <= 8559; i++)
                materials[i] = Material.HornCoralWallFan;
            for (int i = 8560; i <= 8561; i++)
                materials[i] = Material.DeadTubeCoralFan;
            for (int i = 8562; i <= 8563; i++)
                materials[i] = Material.DeadBrainCoralFan;
            for (int i = 8564; i <= 8565; i++)
                materials[i] = Material.DeadBubbleCoralFan;
            for (int i = 8566; i <= 8567; i++)
                materials[i] = Material.DeadFireCoralFan;
            for (int i = 8568; i <= 8569; i++)
                materials[i] = Material.DeadHornCoralFan;
            for (int i = 8570; i <= 8571; i++)
                materials[i] = Material.TubeCoralFan;
            for (int i = 8572; i <= 8573; i++)
                materials[i] = Material.BrainCoralFan;
            for (int i = 8574; i <= 8575; i++)
                materials[i] = Material.BubbleCoralFan;
            for (int i = 8576; i <= 8577; i++)
                materials[i] = Material.FireCoralFan;
            for (int i = 8578; i <= 8579; i++)
                materials[i] = Material.HornCoralFan;
            for (int i = 8580; i <= 8587; i++)
                materials[i] = Material.SeaPickle;
            materials[8588] = Material.BlueIce;
            for (int i = 8589; i <= 8590; i++)
                materials[i] = Material.Conduit;
            materials[8591] = Material.VoidAir;
            materials[8592] = Material.CaveAir;
            for (int i = 8593; i <= 8594; i++)
                materials[i] = Material.BubbleColumn;
            for (int i = 8595; i <= 8598; i++)
                materials[i] = Material.StructureBlock;
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
            new(21, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(23, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(25, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(27, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(29, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(31, 2,
            [
                new("stage", ["0", "1"], 1)
            ]),
            new(34, 16,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(50, 16,
            [
                new("level", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(72, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(75, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(78, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(81, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(84, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(87, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(90, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(93, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(96, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(99, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(102, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(105, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(108, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(111, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(114, 3,
            [
                new("axis", ["x", "y", "z"], 1)
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
            new(138, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(141, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(144, 14,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 2),
                new("persistent", ["true", "false"], 1)
            ]),
            new(158, 14,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 2),
                new("persistent", ["true", "false"], 1)
            ]),
            new(172, 14,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 2),
                new("persistent", ["true", "false"], 1)
            ]),
            new(186, 14,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 2),
                new("persistent", ["true", "false"], 1)
            ]),
            new(200, 14,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 2),
                new("persistent", ["true", "false"], 1)
            ]),
            new(214, 14,
            [
                new("distance", ["1", "2", "3", "4", "5", "6", "7"], 2),
                new("persistent", ["true", "false"], 1)
            ]),
            new(233, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("triggered", ["true", "false"], 1)
            ]),
            new(248, 500,
            [
                new("instrument", ["harp", "basedrum", "snare", "hat", "bass", "flute", "bell", "guitar", "chime", "xylophone"], 50),
                new("note", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(748, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(764, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(780, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(796, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(812, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(828, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(844, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(860, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(876, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(892, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(908, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(924, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(940, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(956, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(972, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(988, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("occupied", ["true", "false"], 2),
                new("part", ["head", "foot"], 1)
            ]),
            new(1004, 12,
            [
                new("powered", ["true", "false"], 6),
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south"], 1)
            ]),
            new(1016, 12,
            [
                new("powered", ["true", "false"], 6),
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south"], 1)
            ]),
            new(1028, 12,
            [
                new("extended", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(1045, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(1047, 12,
            [
                new("extended", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(1059, 24,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 4),
                new("short", ["true", "false"], 2),
                new("type", ["normal", "sticky"], 1)
            ]),
            new(1099, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("type", ["normal", "sticky"], 1)
            ]),
            new(1126, 2,
            [
                new("unstable", ["true", "false"], 1)
            ]),
            new(1132, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(1136, 512,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(1649, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(1729, 24,
            [
                new("facing", ["north", "south", "west", "east"], 6),
                new("type", ["single", "left", "right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(1753, 1296,
            [
                new("east", ["up", "side", "none"], 432),
                new("north", ["up", "side", "none"], 144),
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 9),
                new("south", ["up", "side", "none"], 3),
                new("west", ["up", "side", "none"], 1)
            ]),
            new(3052, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(3060, 8,
            [
                new("moisture", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(3068, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(3076, 32,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3108, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(3172, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3180, 10,
            [
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south", "south_east", "south_west", "north_west", "north_east"], 1)
            ]),
            new(3190, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3270, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3278, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(3302, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(3304, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(3368, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(3370, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(3372, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(3374, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(3376, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(3378, 2,
            [
                new("powered", ["true", "false"], 1)
            ]),
            new(3380, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(3382, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(3384, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("lit", ["true", "false"], 1)
            ]),
            new(3392, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(3416, 8,
            [
                new("layers", ["1", "2", "3", "4", "5", "6", "7", "8"], 1)
            ]),
            new(3426, 16,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(3443, 16,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(3459, 2,
            [
                new("has_record", ["true", "false"], 1)
            ]),
            new(3461, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(3497, 2,
            [
                new("axis", ["x", "z"], 1)
            ]),
            new(3499, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(3503, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(3507, 7,
            [
                new("bites", ["0", "1", "2", "3", "4", "5", "6"], 1)
            ]),
            new(3514, 64,
            [
                new("delay", ["1", "2", "3", "4"], 16),
                new("facing", ["north", "south", "west", "east"], 4),
                new("locked", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(3594, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3658, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3722, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3786, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3850, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3914, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(3988, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4052, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4116, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4180, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4212, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4245, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(4249, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(4253, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(4261, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(4269, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4301, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(4333, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4413, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4493, 2,
            [
                new("snowy", ["true", "false"], 1)
            ]),
            new(4497, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4529, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4609, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(4614, 8,
            [
                new("has_bottle_0", ["true", "false"], 4),
                new("has_bottle_1", ["true", "false"], 2),
                new("has_bottle_2", ["true", "false"], 1)
            ]),
            new(4622, 4,
            [
                new("level", ["0", "1", "2", "3"], 1)
            ]),
            new(4627, 8,
            [
                new("eye", ["true", "false"], 4),
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(4637, 2,
            [
                new("lit", ["true", "false"], 1)
            ]),
            new(4639, 12,
            [
                new("age", ["0", "1", "2"], 4),
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(4651, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4732, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4740, 16,
            [
                new("attached", ["true", "false"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(4756, 128,
            [
                new("attached", ["true", "false"], 64),
                new("disarmed", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("powered", ["true", "false"], 4),
                new("south", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(4885, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(4965, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5045, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5125, 12,
            [
                new("conditional", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(5138, 64,
            [
                new("east", ["true", "false"], 32),
                new("north", ["true", "false"], 16),
                new("south", ["true", "false"], 8),
                new("up", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5202, 64,
            [
                new("east", ["true", "false"], 32),
                new("north", ["true", "false"], 16),
                new("south", ["true", "false"], 8),
                new("up", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5288, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(5296, 8,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7"], 1)
            ]),
            new(5304, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5328, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5352, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5376, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5400, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5424, 24,
            [
                new("face", ["floor", "wall", "ceiling"], 8),
                new("facing", ["north", "south", "west", "east"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5448, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5452, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5468, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5472, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5488, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5492, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5508, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5512, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5528, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5532, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5548, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5552, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5568, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5572, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5576, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(5580, 24,
            [
                new("facing", ["north", "south", "west", "east"], 6),
                new("type", ["single", "left", "right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5604, 16,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5620, 16,
            [
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5636, 16,
            [
                new("facing", ["north", "south", "west", "east"], 4),
                new("mode", ["compare", "subtract"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(5652, 32,
            [
                new("inverted", ["true", "false"], 16),
                new("power", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(5686, 10,
            [
                new("enabled", ["true", "false"], 5),
                new("facing", ["down", "north", "south", "west", "east"], 1)
            ]),
            new(5698, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(5701, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(5781, 12,
            [
                new("powered", ["true", "false"], 6),
                new("shape", ["north_south", "east_west", "ascending_east", "ascending_west", "ascending_north", "ascending_south"], 1)
            ]),
            new(5793, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("triggered", ["true", "false"], 1)
            ]),
            new(5821, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5853, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5885, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5917, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5949, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(5981, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6013, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6045, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6077, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6109, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6141, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6173, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6205, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6237, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6269, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6301, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(6333, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6413, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6495, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["top", "bottom"], 8),
                new("open", ["true", "false"], 4),
                new("powered", ["true", "false"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6562, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6642, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6722, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6802, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6808, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6814, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(6821, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(6843, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(6845, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(6847, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(6849, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(6851, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(6853, 2,
            [
                new("half", ["upper", "lower"], 1)
            ]),
            new(6855, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(6871, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(6887, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(6903, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(6919, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(6935, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(6951, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(6967, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(6983, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(6999, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7015, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7031, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7047, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7063, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7079, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7095, 16,
            [
                new("rotation", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"], 1)
            ]),
            new(7111, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7115, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7119, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7123, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7127, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7131, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7135, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7139, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7143, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7147, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7151, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7155, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7159, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7163, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7167, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7171, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(7178, 80,
            [
                new("facing", ["north", "south", "west", "east"], 20),
                new("half", ["top", "bottom"], 10),
                new("shape", ["straight", "inner_left", "inner_right", "outer_left", "outer_right"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7258, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7264, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7270, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7276, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7282, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7288, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7294, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7300, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7306, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7312, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7318, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7324, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7330, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7336, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7342, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7348, 6,
            [
                new("type", ["top", "bottom", "double"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(7358, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7390, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7422, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7454, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7486, 32,
            [
                new("facing", ["north", "south", "west", "east"], 8),
                new("in_wall", ["true", "false"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7518, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7550, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7582, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7614, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7646, 32,
            [
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("waterlogged", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(7678, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7742, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7806, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7870, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7934, 64,
            [
                new("facing", ["north", "south", "west", "east"], 16),
                new("half", ["upper", "lower"], 8),
                new("hinge", ["left", "right"], 4),
                new("open", ["true", "false"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(7998, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8004, 64,
            [
                new("down", ["true", "false"], 32),
                new("east", ["true", "false"], 16),
                new("north", ["true", "false"], 8),
                new("south", ["true", "false"], 4),
                new("up", ["true", "false"], 2),
                new("west", ["true", "false"], 1)
            ]),
            new(8068, 6,
            [
                new("age", ["0", "1", "2", "3", "4", "5"], 1)
            ]),
            new(8075, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(8078, 80,
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
            new(8165, 12,
            [
                new("conditional", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8177, 12,
            [
                new("conditional", ["true", "false"], 6),
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8189, 4,
            [
                new("age", ["0", "1", "2", "3"], 1)
            ]),
            new(8196, 3,
            [
                new("axis", ["x", "y", "z"], 1)
            ]),
            new(8200, 12,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 2),
                new("powered", ["true", "false"], 1)
            ]),
            new(8212, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8218, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8224, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8230, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8236, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8242, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8248, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8254, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8260, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8266, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8272, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8278, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8284, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8290, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8296, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8302, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8308, 6,
            [
                new("facing", ["north", "east", "south", "west", "up", "down"], 1)
            ]),
            new(8314, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8318, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8322, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8326, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8330, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8334, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8338, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8342, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8346, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8350, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8354, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8358, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8362, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8366, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8370, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8374, 4,
            [
                new("facing", ["north", "south", "west", "east"], 1)
            ]),
            new(8410, 26,
            [
                new("age", ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"], 1)
            ]),
            new(8438, 12,
            [
                new("eggs", ["1", "2", "3", "4"], 3),
                new("hatch", ["0", "1", "2"], 1)
            ]),
            new(8460, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8462, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8464, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8466, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8468, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8470, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8472, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8474, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8476, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8478, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8480, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8488, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8496, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8504, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8512, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8520, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8528, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8536, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8544, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8552, 8,
            [
                new("facing", ["north", "south", "west", "east"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8560, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8562, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8564, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8566, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8568, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8570, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8572, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8574, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8576, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8578, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8580, 8,
            [
                new("pickles", ["1", "2", "3", "4"], 2),
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8589, 2,
            [
                new("waterlogged", ["true", "false"], 1)
            ]),
            new(8593, 2,
            [
                new("drag", ["true", "false"], 1)
            ]),
            new(8595, 4,
            [
                new("mode", ["save", "load", "corner", "data"], 1)
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
