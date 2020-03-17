﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewerSMBWHookGenerator
{
    public partial class Main : Form
    {
        string[] ActorName = {
            "BOOT",
            "AUTO_SELECT",
            "SELECT",
            "WORLD_MAP",
            "WORLD__DEMO",
            "STAGE",
            "RESTART_CRSIN",
            "CRSIN",
            "MOVIE",
            "GAMEOVER",
            "GAME_SETUP",
            "MULTI_PLAY_COURSE_SELECT",
            "CURSOR",
            "PLAYER",
            "YOSHI",
            "WM_TEST",
            "WM_TEST",
            "BG_GM",
            "CAMERA",
            "YOSHI_FIRE",
            "SLOW_QUICK_TAG",
            "TORIDE_KOKOOPA_DEMO",
            "BOSS_KAMECK_DEMO",
            "BOSS_KOOPA_DEMO",
            "CASTLE_KOKOOPA_DEMO_ST",
            "CASTLE_KOKOOPA_DEMO_ND",
            "BOSS_KOOPA_JR_DEMO",
            "KOOPA_SHIP_FOR_CASTLE_DEMO",
            "KOOPA_JR_FOR_CASTLE_DEMO",
            "PEACH_FOR_CASTLE_DEMO",
            "KAMECK_FOR_CASTLE_DEMO",
            "LEMMY_FOOTHOLD",
            "LEMMY_FOOTHOLD_MAIN",
            "CASTLE_BOSS_DOOR",
            "CASTLE_BOSS_KEY",
            "AC_BATTLE_GAME",
            "AC_BATTLE_KINOPIO",
            "AC_BATTLE_ITEM",
            "AC_ENDING_MAIN",
            "AC_BLOCK_WIND_TAG",
            "AC_GROUPID",
            "KAWANAGARE",
            "RIVER_PAIPO",
            "RIVER_ITEM",
            "RIVER_COIN",
            "RIVER_STARCOIN",
            "RIVER_LIFT",
            "RIVER_BARREL",
            "RIVER_PUKU",
            "RIVER_PAKKUN",
            "RIVER_MGR",
            "EN_KURIBO",
            "EN_PATA_KURIBO",
            "EN_MAME_KURIBO",
            "EN_NOKONOKO",
            "EN_PATAPATA",
            "EN_MET",
            "EN_TOGEZO",
            "EN_SAKASA_TOGEZO",
            "EN_BLOCK",
            "EN_ITEM",
            "EN_STAR_COIN",
            "EN_STAR_COIN_LINE",
            "EN_STAR_COIN_VOLT",
            "AC_FLAGON",
            "AC_SWICHAND",
            "AC_SWICHOR",
            "AC_RANDSWICH",
            "AC_CHNGESWICH",
            "AC_IFSWICH",
            "AC_RNSWICH",
            "EN_BKBLOCK",
            "EN_HNSWICH",
            "EN_PSWICH",
            "EN_QSWICH",
            "EN_BOSS_KOOPA_SWITCH",
            "EN_BOSS_KOOPA_BIG_SWITCH",
            "EN_BLSWICH",
            "EN_BLPSWICH",
            "EN_BLQSWICH",
            "EN_BUBBLE",
            "EN_DOSUN",
            "EN_BIGDOSUN",
            "EN_JUGEM",
            "EN_JUGEM_COIN",
            "EN_EATJUGEM",
            "EN_JUGEM_BODY",
            "EN_TOGEMET",
            "EN_FIREBAR",
            "EN_TOGETEKKYU",
            "EN_BIG_TOGETEKKYU",
            "EN_UP_DOKAN_PAKKUN",
            "EN_DOWN_DOKAN_PAKKUN",
            "EN_RIGHT_DOKAN_PAKKUN",
            "EN_LEFT_DOKAN_PAKKUN",
            "EN_UP_DOKAN_FPAKKUN",
            "EN_DOWN_DOKAN_FPAKKUN",
            "EN_RIGHT_DOKAN_FPAKKUN",
            "EN_LEFT_DOKAN_FPAKKUN",
            "EN_JIMEN_PAKKUN",
            "EN_JIMEN_BIG_PAKKUN",
            "EN_JIMEN_FPAKKUN",
            "EN_JIMEN_BIG_FPAKKUN",
            "EN_WALK_PAKKUN",
            "ICEBALL",
            "PL_FIREBALL",
            "PAKKUN_FIREBALL",
            "BROS_FIREBALL",
            "BOOMERANG",
            "EN_HELPOS",
            "EN_FIREBROS",
            "EN_BOOMERANGBROS",
            "EN_HAMMERBROS",
            "EN_ICEBROS",
            "EN_LIFT_HAMMERBROS",
            "HAMMER",
            "EN_HIMANBROS",
            "MEGA_HAMMER",
            "BROS_ICEBALL",
            "EN_BOYON",
            "EN_REMOCON_TORIMOCHI",
            "TAG_WIND",
            "TAG_THUNDER",
            "TAG_WATER",
            "EN_AUTOSCR",
            "OBJ_GRASS",
            "EN_ENV",
            "EN_KILLER",
            "EN_SEARCH_KILLER",
            "EN_MAGNUM_KILLER",
            "EN_SEARCH_MAGNUM_KILLER",
            "EN_BASABASA",
            "WAKI_PARABOM",
            "EN_BOMHEI",
            "EN_PARA_BOMHEI",
            "EN_MECHA_KOOPA",
            "EN_MOUSE",
            "EN_GHOST_JUGEM",
            "DOKAN_WAKIDASHI",
            "EN_CRASHER",
            "AC_WAKILIFT",
            "EN_BIRIKYU",
            "EN_LINE_BIRIKYU",
            "EN_BIRIKYU_MAKER",
            "EN_CHOROBON",
            "EN_SANBO",
            "EN_SANBO_PARTS",
            "EN_SANBO_EL",
            "EN_GURUGURU",
            "EN_GESSO",
            "EN_BARAMAKI_GESSO",
            "EN_GOALPOLE",
            "EN_GESSO_CHILD",
            "BARNAR_MGR",
            "EN_SYNCRO_BARNAR",
            "EN_BARNAR",
            "EN_LARGE_BARNAR",
            "EN_PUKUPUKU_PARENT",
            "AC_TEAM_PUKUPUKU",
            "EN_PUKUPUKU",
            "EN_TOGEPUKU",
            "EN_MIDDLE_PUKU",
            "EN_PUKUCOIN",
            "EN_KARON",
            "EN_BIGKARON",
            "EN_KARON_HEAD",
            "EN_REVERSE",
            "EN_WAKI_JUGEM",
            "EN_WIRE_TURN",
            "EN_BIG_WIRE_TURN",
            "EN_NET_NOKONOKO_LR",
            "EN_NET_NOKONOKO_UD",
            "BIGHANA_MGR",
            "HANA_MOUNTAIN",
            "EN_HANACHAN",
            "EN_BIG_HANACHAN",
            "EN_TERESA",
            "EN_BIG_TERESA",
            "EN_CROW",
            "EN_BIGPILE_UNDER",
            "EN_BIGPILE_UPPER",
            "EN_BIGPILE_RIGHT",
            "EN_BIGPILE_LEFT",
            "EN_SUPER_BIGPILE_RIGHT",
            "EN_SUPER_BIGPILE_LEFT",
            "EN_GOKUBUTO_BIGPILE_UNDER",
            "EN_GOKUBUTO_BIGPILE_UPPER",
            "EN_MORTON_BIGPILE",
            "EN_YAJIRUSHI",
            "EN_WANWAN",
            "EN_WANWAN_PILE",
            "EN_JUMPPUKU",
            "EN_IGAPUKU",
            "EN_WAKI_IGAPUKU",
            "EN_FIRESNAKE",
            "EN_BOSS_KAMECK",
            "EN_SLIP_PENGUIN",
            "WAKI_SLIP_PENGUIN",
            "EN_SLIP_PENGUIN",
            "SLIP_PENGUIN_GLASSES",
            "EN_IGA_KURIBO",
            "EN_WATERSTREAM",
            "AWA",
            "DUMMY_DOOR_PARENT",
            "DUMMY_DOOR_CHILD",
            "DUMMY_DOOR",
            "NOBORIBOU_OBAKE",
            "UNTEI_ROPE",
            "REMO_DOOR",
            "REMO_SLIDE_DOOR",
            "BRANCH",
            "BG_CENTER",
            "KAMECK_MAGIC",
            "SINKDOKAN_UP",
            "SINKDOKAN_DOWN",
            "SINKDOKAN_LEFT",
            "SINKDOKAN_RIGHT",
            "FLYDOKAN_UP",
            "FLYDOKAN_DOWN",
            "FLYDOKAN_LEFT",
            "FLYDOKAN_RIGHT",
            "EN_HATENA_BALLOON",
            "EN_ONEWAY_GATE",
            "EN_PATABLOCK",
            "EN_KERONPA",
            "KERONPA_FIRE",
            "AC_NEXTGOTO_BLOCK",
            "EN_BAKUBAKU",
            "EN_DOOR",
            "EN_SWITCHDOOR",
            "EN_OBAKEDOOR",
            "EN_TORIDEDOOR",
            "EN_CASTLEDOOR",
            "EN_KOOPADOOR",
            "AC_REVERSEBLOCK",
            "CHUKAN_POINT",
            "EN_MAX_UE_LEFT",
            "EN_MAX_UE_RIGHT",
            "EN_MAX_UE_LEFT",
            "EN_MAX_UE_RIGHT",
            "EN_ZOOM",
            "EN_BOSS_LARRY",
            "EN_BOSS_WENDY",
            "EN_BOSS_IGGY",
            "EN_BOSS_LEMMY",
            "EN_BOSS_MORTON",
            "EN_BOSS_ROY",
            "EN_BOSS_LUDWIG",
            "EN_BOSS_CASTLE_LARRY",
            "EN_BOSS_CASTLE_ROY",
            "EN_BOSS_CASTLE_WENDY",
            "EN_BOSS_CASTLE_IGGY",
            "CASTLE_LEMMY_BALL",
            "EN_BOSS_CASTLE_LEMMY",
            "EN_BOSS_CASTLE_MORTON",
            "OBJ_LUDWIG",
            "EN_BOSS_CASTLE_LUDWIG",
            "EN_BOSS_KOOPA",
            "EN_BOSS_KOOPA_DEMO_KAMECK",
            "EN_BOSS_KOOPA_DEMO_PEACH",
            "AC_WAKI_KOOPA_FIRE",
            "KOOPA_FIRE",
            "LARRY_FIRE",
            "KOKOOPA_RING",
            "KOKOOPA_BALL",
            "KOKOOPA_THREEWAY_BLITZ",
            "LEMMY_BALL",
            "CASTLE_LEMMY_THROW_BALL",
            "OBJ_IGGY_SLED",
            "OBJ_IGGY_WANWAN",
            "OBJ_MORTON",
            "OBJ_ROY",
            "OBJ_LARRY",
            "OBJ_WENDY",
            "AC_BOSS_KOOPA_SCAFFOLD",
            "AC_BOSS_KOOPA_RUBBLE",
            "AC_BOSS_KOOPA_BG_EFFECT",
            "CASTLE_LUDWIG_BLITZ",
            "CASTLE_LUDWIG_BLITZ_MGR",
            "WAKI_KOKOOPA_FIRE",
            "FALL_FIRE",
            "WAKI_FIRE",
            "FIRE_BLITZ",
            "KOKOOPA_SEARCH_FIRE",
            "EN_UNIZOO",
            "EN_UNIRA",
            "EN_KANIBO",
            "EN_KANITAMA",
            "EN_KOPONE",
            "EN_AKOYA",
            "EN_MIDDLE_KURIBO",
            "EN_LARGE_KURIBO",
            "EN_BEANS_KURIBO",
            "AC_STRONGBOX",
            "EN_REMOCON_CANNON",
            "WAKI_TOGETEKKYU",
            "JR_CLOWN_A",
            "JR_CLOWN_B",
            "JR_CLOWN_C",
            "JR_CLOWN_FOR_PLAYER",
            "FLOOR_JR_A",
            "FLOOR_JR_B",
            "FLOOR_JR_C",
            "FLOOR_JR_C_MGR",
            "BOMB_JR_C",
            "EN_BOSS_KOOPA_JR_A",
            "EN_BOSS_KOOPA_JR_B",
            "EN_BOSS_KOOPA_JR_C",
            "JR_FIRE",
            "JR_FLOOR_FIRE",
            "JR_FLOOR_FIRE_MGR",
            "JR_CLOWN_FOR_JR_C_DEMO",
            "KAMECK_FOR_AIRSHIP_DEMO",
            "PEACH_FOR_AIRSHIP_DEMO",
            "KOOPA_SHIP_FOR_AIRSHIP_DEMO",
            "EN_EATCOIN",
            "AC_WAKI_KILLER",
            "WAKI_KERONPA",
            "AC_WAKI_PUKUPUKU",
            "BELT_NEEDLE",
            "INTERMITTENT",
            "MIST_INTERMITTENT",
            "YOGAN_INTERMITTENT",
            "EN_IBARAMUSHI",
            "WAKI_ANKOH",
            "EN_CHOCHIN_ANKOH",
            "EN_MISTMAN",
            "EN_TESTMAN",
            "EN_CLOUD",
            "AC_ITEM_KEY",
            "AC_YOSHI_EGG",
            "EN_WATERPAIPO",
            "EN_WATERPAKKUN",
            "FOO_BALL",
            "MT_HANACHAN",
            "EN_LR_STOP_UP",
            "EN_LR_STOP_DW",
            "EN_ROT_PAKKUN",
            "EN_POLTER",
            "EN_ICICLE",
            "WALLINSECT_MGR",
            "EN_WALLINSECT",
            "EN_LANDBARREL",
            "EN_IWAO",
            "IWAO_ROCK",
            "KAZAN_MGR",
            "KAZAN_ROCK",
            "EN_CANNON_BULLET",
            "EN_CHOROPU",
            "EN_MANHOLE_CHOROPU",
            "CHOROPOO_SHADOW",
            "MINI_GAME_BALLOON",
            "MINI_GAME_BALLOON_STICK",
            "EN_JELLY_FISH",
            "MINI_GAME_WIRE_MESH",
            "MINI_GAME_GUN_BATTERY_MGR",
            "MINI_GAME_GUN_BATTERY_MGR_OBJ",
            "MINI_GAME_WIRE_MESH_MGR",
            "MINI_GAME_WIRE_MESH_MGR_OBJ",
            "PEACH_CASTLE_SEQUENCE_MGR",
            "PEACH_CASTLE_SEQUENCE_MGR_OBJ",
            "PEACH_CASTLE_BLOCK",
            "MINI_GAME_KINOPIO",
            "AC_KANBAN_ARROW",
            "AC_WATER_BUBBLE",
            "EN_BUBBLE_CONTROL",
            "AC_WAKI_WOODBOX",
            "AC_AUTOSCROOL_SWICH",
            "AC_ROTATION_GHOST_PARENT",
            "EN_ROTATION_GHOST",
            "SHIP_WINDOW",
            "EN_MADOPU",
            "SPANA",
            "EN_GABON",
            "GABON_ROCK",
            "MANHOLE",
            "BGM_INTERLOCKING_DUMMY_BLOCK",
            "BGM_INTERLOCKING_DUMMY_BLOCK_MGR",
            "EN_KING_KILLER",
            "EN_WATER_BUBBLE_BULLET",
            "EN_FRUIT",
            "OBJ_SPARKS",
            "OBJ_SNOW",
            "TAG_SCROLL",
            "AC_BLOCK_GROUP",
            "AC_BLOCK_ONEUP",
            "AC_BLOCK_COIN",
            "AC_WAKI_SEARCH_MAGKILLER",
            "EN_TOBIPUKU",
            "AC_WAKI_TOBIPUKU",
            "NEEDLE_FOR_KOOPA_JR_B",
            "TOP_BG_FOR_CASTLE_LUDWIG",
            "MIDDLE_BG_FOR_CASTLE_LUDWIG",
            "BOTTOM_BG_FOR_CASTLE_LUDWIG",
            "MD_ACTOR",
            "MD_CAMERA",
            "EN_CLOUDLT",
            "UNIT_RAIL",
            "UNIT_CHIKUWA",
            "OBJ_SEAWEED",
            "TAG_ENVSOUND",
            "EN_COIN",
            "EN_COIN_JUGEM",
            "EN_COIN_JUMP",
            "EN_COIN_FLOOR",
            "EN_COIN_VOLT",
            "EN_COIN_WIND",
            "EN_BLUE_COIN",
            "EN_COIN_WATER",
            "EN_REDCOIN",
            "EN_GREENCOIN",
            "ICE_ACTOR",
            "AC_LIGHT_BLOCK",
            "AC_PROP_BLOCK",
            "ENEMY_ICE",
            "PLAYER_ICE",
            "SLIDE_BLOCK",
            "POW_BLOCK",
            "BLOCK_TARU",
            "OBJ_CENTER",
            "OBJ_CENTER",
            "EN_LIFT_ROTATION_FULL",
            "LIFT_ROTATION_FULL_CHIKA",
            "LIFT_ROTATION_FULL_KINOKO",
            "LIFT_ROTATION_FULL_COLOR",
            "CAGE_BLOCK",
            "LIFT_ZEN_HAMMER",
            "LIFT_ZEN_SUISYA",
            "LIFT_ZEN_KAITEN_KANAAMI",
            "MOUSE_HOLE",
            "KATAMUKIYUKA",
            "LIFT_TORIDE_ROLL",
            "AC_LIFT_RIDE_HMOVE",
            "AC_LIFT_OBJBG_VMOVE",
            "AC_LIFT_OBJBG_HMOVE",
            "AC_LIFT_OBJBG_HMOVE_BIG",
            "EN_OBJ_POL",
            "EN_OBJ_POL_TORIDE",
            "EN_OBJ_POL_NEEDLE_L",
            "EN_OBJ_POL_NEEDLE_R",
            "EN_OBJ_POL_NEEDLE_LR",
            "EN_OBJ_POL_NEEDLE_U",
            "EN_OBJ_POL_NEEDLE_D",
            "EN_OBJ_POL_NEEDLE_UD",
            "LIFT_ZEN_TOGE",
            "LIFT_ZEN_SHIRO_YOGAN",
            "LIFT_ZEN_KAIHEI",
            "LIFT_DOKAN",
            "EN_PAIR_OBJ_PARENT",
            "EN_PAIR_OBJ_CHILD",
            "LIFT_ZEN_SHIRO",
            "EN_PAIR_OBJ_CHILD_TORIDE",
            "WAKI_ICE_ASHIBA",
            "WAKI_ICE_ASHIBA_WATER",
            "ICE_ASHIBA",
            "ICE_ASHIBA_WATER",
            "ICE_ASHIBA_RAIL",
            "AC_LIFT_RIDE_VMOVE",
            "AC_LIFT_SEESAW",
            "AC_LIFT_FALL",
            "AC_LIFT_REMOCON_SEESAW",
            "EN_LIFT_WHEEL",
            "AC_LIFT_BALANCE",
            "AC_LIFT_REMOCON_BALANCE_CLINCH",
            "AC_LIFT_REMOCON_BALANCE",
            "AC_LIFT_REMOCON_XLINE",
            "EN_LIFT_REMOCON_TRPLN",
            "EN_TRPLN_WALL",
            "EN_CHIKUWA_BLOCK",
            "EN_CLIFF_CHIKUWA_BLOCK",
            "EN_KILLER_HOUDAI",
            "EN_MAGNUM_KILLER_HOUDAI",
            "AC_WAKILIFT_STEP",
            "AC_LINE_LIFT",
            "LINE_SPIN_LIFT",
            "PALM_TREE",
            "NICE_BOAT",
            "LINE_KINOKO_BLOCK",
            "LADDER",
            "TARZAN_TSUTA",
            "TARZAN_IVY",
            "EN_LIFT_ROTATION_HALF",
            "LIFT_HURIKO_CENTER",
            "LIFT_HURIKO",
            "AC_LIFT_RIDEMOVE",
            "EN_LIFT_BURANKO",
            "AC_LIFT_WATERWHEEL",
            "EN_RAIL_POLYGON",
            "EN_RAIL_POLY_ICE",
            "EN_RAIL_POLY_PARENT",
            "EN_RAIL_POLY_CHILD",
            "FREEFALL",
            "EN_GURA_ROCK",
            "EN_GURA_YUKA",
            "EN_KAITEN_HOUDAI",
            "EN_REDRING",
            "EN_BARREL",
            "EN_JUMPDAI",
            "EN_BIG_HNSWICH",
            "EN_BIGBLOCK",
            "EN_SNAKEBLOCK",
            "EN_MARUTA",
            "OBJ_KAMECK",
            "AC_LIFT_SPINROTATION",
            "AC_LIFT_SPINROTATION_SYNC",
            "EN_RULETBLOCK",
            "AC_LIFT_SCALES",
            "AC_LIFT_SCALES_STEP",
            "EN_TARZANROPE",
            "AC_LIFT_BOSS_REMOCON_SEESAW",
            "AC_CHENGE_BLOCK",
            "EN_FIXATION_ICICLE",
            "EN_OBJ_HATENA_BLOCK",
            "EN_OBJ_HATENAB_BLOCK",
            "EN_OBJ_RENGA_BLOCK",
            "EN_OBJ_CLEAR_BLOCK",
            "AC_OBJ_CLEAR_BLOCK",
            "EN_HATENA_BLOCK_LINE",
            "EN_RENGA_BLOCK_LINE",
            "EN_BLOCK_HATENA_WATER",
            "EN_BLOCK_SOROBAN",
            "EN_BLOCK_STAFFROLL",
            "ELASTIC_KINOKO_PARENT",
            "ELASTIC_KINOKO",
            "EN_WHITE_BLOCK",
            "MANTA_MGR",
            "MANTA_MGR",
            "MANTA",
            "AC_LIFT_SLIDE_KINOKO",
            "EN_ROTATION_BLOCK",
            "EN_COIN_ANGLE",
            "ROT_DOKAN",
            "EN_BLOCK_HATENA_ANGLE",
            "EN_BLOCK_RENGA_ANGLE",
            "AC_WIRE_CIRCLE",
            "AC_WIRE_REMOCON",
            "AC_LIFT_ICE_SPRING",
            "ICELUMP",
            "ICECUBE",
            "EN_WOODBOX",
            "EN_PATAMET",
            "EN_BIG_PATAMET",
            "NUT",
            "EN_BIG_MET",
            "EN_GAKE_NOKO",
            "AC_DOKAN_CANNON",
            "AC_SHIP_CANNON",
            "AC_ROT_CANNON",
            "AC_ROT_DOKAN_CANNON",
            "ROT_BARNAR",
            "CIRCLE_RIGHT",
            "BLOCK_LIGHT",
            "HAND_RIGHT",
            "EN_BIG_ICICLE",
            "AC_WATER_BUBBLE_PARENT",
            "AC_WATER_BUBBLE_CANNON",
            "EN_KILLER_HOUDAI_SLIDE",
            "EN_BLACK_PAKKUN",
            "TORCHILIGHT",
            "EN_BLOCK_CLOUD",
            "AC_WIRE_MOVE",
            "OBJ_FRUITTREE",
            "EN_BOUNCE_BALL",
            "EN_BLOCK_HATENA_PLAYER",
            "EN_BLOCK_RENGA_PLAYER",
            "AC_FREEZER",
            "AC_WIRE_FOOTHOLD",
            "EN_ITEM_IVY",
            "TARZAN_ROPE",
            "CANNON_PIPE",
            "KINOKO_LIFT_PARENT",
            "KINOKO_LIFT",
            "OBJ_SPIN_PARENT",
            "OBJ_SPIN_CHILD",
            "OBJ_SPIN_ASHIBA",
            "SPIN_WIRE",
            "WARP_CANNON",
            "OBJ_KINOKO",
            "ZOOM_PIPE",
            "ZOOM_PIPE_DOWN",
            "OBJ_PIPE_UP",
            "OBJ_PIPE_UP_NG",
            "OBJ_PIPE_DOWN",
            "OBJ_PIPE_RIGHT",
            "OBJ_PIPE_LEFT",
            "LIFT_DOWN_ON",
            "OBJ_MOVE_ON_GHOST",
            "LIFT_DOWN_ON_NORMAL",
            "LIFT_RIDE_OFF",
            "LINE_TRAIN",
            "REMO_LINE_LIFT",
            "WATER_LIFT",
            "AC_NICE_COIN",
            "AC_NICE_COIN_REGULAR",
            "EN_BLOCK_HELP",
            "FAR_BG",
            "AC_BG_WATER",
            "AC_BG_LAVA",
            "AC_BG_POISON",
            "AC_BG_SAND",
            "AC_BG_CLOUD",
            "AC_BG_MOYA",
            "AC_WATERALL_RAIL",
            "EN_BLUR",
            "MASK",
            "DTEST",
            "AC_WATER_MOVE",
            "AC_WATER_MOVE_REGULAR",
            "AC_WATER_XINFINITE_MOVE",
            "AC_FLOOR_GYRATION",
            "AC_FLOOR_HOLE_DOKAN",
            "AC_FLOOR_DOKAN_EIGHT",
            "AC_GEAR_GYRATION",
            "AC_SHIP_GEAR",
            "AC_BIGSHELL",
            "EN_BOSS_KOOPA_DEMO_CAGE",
            "AC_STAND",
            "AC_HOUSE_LIGHT",
            "AC_LIGHT_WATER",
            "AC_COPYRIGHT",
            "WII_STRAP",
            "WM_CS_SEQ_MNG",
            "WORLD_CAMERA",
            "WM_MAP",
            "WM_IBARA",
            "WM_ANTLION_MNG",
            "WM_CASTLE",
            "WM_TOWER",
            "WM_PEACH_CASTLE",
            "WM_KILLER",
            "WM_KILLERBULLET",
            "WM_SINKSHIP",
            "WM_SWITCH",
            "WM_START",
            "WM_KINOKO_BASE",
            "WM_KINOKO_RED",
            "WM_KINOKO_UP",
            "WM_KINOKO_STAR",
            "WM_COURSE",
            "WM_STOP",
            "WM_TORIDE",
            "WM_GHOST",
            "WM_DOKAN",
            "WM_CANNON",
            "WM_KOOPASHIP",
            "WM_BOSS_BASE",
            "WM_BOSS_LARRY",
            "WM_BOSS_ROY",
            "WM_BOSS_WENDY",
            "WM_BOSS_IGGY",
            "WM_BOSS_LEMMY",
            "WM_BOSS_MORTON",
            "WM_BOSS_LUDWIG",
            "WM_BOSS_KAMECK",
            "WM_ANTLION",
            "WM_KURIBO",
            "WM_PUKU",
            "WM_PAKKUN",
            "WM_BROS",
            "WM_JUGEM",
            "WM_PLAYER",
            "WM_SUBPLAYER",
            "WM_NOTE",
            "WM_TREASURESHIP",
            "WM_DIRECTOR",
            "WM_GRID",
            "WM_ISLAND",
            "WM_ITEM",
            "WM_CS_W_PALM",
            "WM_SURRENDER",
            "WM_KOOPA_CASTLE",
            "WM_ANCHOR",
            "WM_PAKKUNHEAD",
            "WM_CLOUD",
            "WM_SMALLCLOUD",
            "WM_KOOPAJR",
            "WM_PEACH",
            "WM_BOARD",
            "WM_BUBBLE",
            "WM_KINOBALLOON",
            "WM_SANDPILLAR",
            "WM_YOGANPILLAR",
            "WM_KINOPIO",
            "WM_DANCE_PAKKUN",
            "WM_DOKANROUTE",
            "WM_HANACHAN",
            "WM_TOGEZO",
            "WM_MANTA",
            "WM_TERESA",
            "WORLD_SELECT",
            "WORLD_SELECT_GUIDE",
            "COLLECTION_COIN_BASE",
            "COLLECTION_COIN",
            "COURSE_SELECT_MENU",
            "NUMBER_OF_PEOPLE_CHANGE",
            "STOCK_ITEM",
            "STOCK_ITEM_SHADOW",
            "EASY_PAIRING",
            "WM_D_PLAYER",
            "EVENT_OPENING_TITLE",
            "SELECT_PLAYER",
            "MULTI_COURSE_SELECT",
            "TIME_UP",
            "COURSE_TIME_UP",
            "YES_NO_WINDOW",
            "COURSE_SELECT_MANAGER",
            "FUKIDASHI_MANAGER",
            "SMALL_SCORE_MANAGER",
            "GAMEDISPLAY",
            "OTASUKE_INFO",
            "PAUSEWINDOW",
            "RESULT",
            "POINT_RESULT_MULTI",
            "POINT_RESULT_DATE_FILE",
            "POINT_RESULT_DATE_FILE_FREE",
            "GOAL_MANAGER",
            "COURSE_CLEAR",
            "OTEHON_CLEAR",
            "INFO_WINDOW",
            "SELECT_CURSOR",
            "WARNING_MANAGER",
            "SEQUENCE_BG",
            "GAME_OVER",
            "MODE_SELECT",
            "DATE_FILE",
            "FILE_SELECT",
            "CONTINUE",
            "MINI_GAME_CANNON",
            "MINI_GAME_WIRE",
            "MODEL_PLAY_MANAGER",
            "MODEL_PLAY_BASE",
            "MODEL_PLAY_DATE",
            "MODEL_PLAY_ARROW",
            "MODEL_PLAY_GUIDE",
            "MESSAGE_WINDOW",
            "CHARACTER_CHANGE_SELECT_BASE",
            "CHARACTER_CHANGE_SELECT_CONTENTS",
            "CHARACTER_CHANGE_SELECT_ARROW",
            "CHARACTER_CHANGE_INDICATOR",
            "MULTI_COURSE_SELECT_CONTENTS",
            "COLLECTION_COIN_DATE",
            "CONTROLLER_INFORMATION",
            "DRAW_GAME",
            "STAFF_CREDIT_SCORE",
            "THE_END",
            "DEMO_MESSAGE",
            "LETTER_WINDOW",
            "DUMMY_ACTOR",
            "LASTACTOR_STAGE",
            "LASTACTOR"
        };
        string[] updatespritefileinfotargetvalue = {
            "0x8030a340",
            "0x8030a368",
            "0x8030a390",
            "0x8030a3b8",
            "0x8030a3e0",
            "0x8030a408",
            "0x8030a430",
            "0x8030a458",
            "0x8030a480",
            "0x8030a4a8",
            "0x8030a4d0",
            "0x8030a4f8",
            "0x8030a520",
            "0x8030a548",
            "0x8030a570",
            "0x8030a598",
            "0x8030a5c0",
            "0x8030a5e8",
            "0x8030a610",
            "0x8030a638",
            "0x8030a660",
            "0x8030a688",
            "0x8030a6b0",
            "0x8030a6d8",
            "0x8030a700",
            "0x8030a728",
            "0x8030a750",
            "0x8030a778",
            "0x8030a7a0",
            "0x8030a7c8",
            "0x8030a7f0",
            "0x8030a818",
            "0x8030a840",
            "0x8030a868",
            "0x8030a890",
            "0x8030a8b8",
            "0x8030a8e0",
            "0x8030a908",
            "0x8030a930",
            "0x8030a958",
            "0x8030a980",
            "0x8030a9a8",
            "0x8030a9d0",
            "0x8030a9f8",
            "0x8030aa20",
            "0x8030aa48",
            "0x8030aa70",
            "0x8030aa98",
            "0x8030aac0",
            "0x8030aae8",
            "0x8030ab10",
            "0x8030ab38",
            "0x8030ab60",
            "0x8030ab88",
            "0x8030abb0",
            "0x8030abd8",
            "0x8030ac00",
            "0x8030ac28",
            "0x8030ac50",
            "0x8030ac78",
            "0x8030aca0",
            "0x8030acc8",
            "0x8030acf0",
            "0x8030ad18",
            "0x8030ad40",
            "0x8030ad68",
            "0x8030ad90",
            "0x8030adb8",
            "0x8030ade0",
            "0x8030ae08",
            "0x8030ae30",
            "0x8030ae58",
            "0x8030ae80",
            "0x8030aea8",
            "0x8030aed0",
            "0x8030aef8",
            "0x8030af20",
            "0x8030af48",
            "0x8030af70",
            "0x8030af98",
            "0x8030afc0",
            "0x8030afe8",
            "0x8030b010",
            "0x8030b038",
            "0x8030b060",
            "0x8030b088",
            "0x8030b0b0",
            "0x8030b0d8",
            "0x8030b100",
            "0x8030b128",
            "0x8030b150",
            "0x8030b178",
            "0x8030b1a0",
            "0x8030b1c8",
            "0x8030b1f0",
            "0x8030b218",
            "0x8030b240",
            "0x8030b268",
            "0x8030b290",
            "0x8030b2b8",
            "0x8030b2e0",
            "0x8030b308",
            "0x8030b330",
            "0x8030b358",
            "0x8030b380",
            "0x8030b3a8",
            "0x8030b3d0",
            "0x8030b3f8",
            "0x8030b420",
            "0x8030b448",
            "0x8030b470",
            "0x8030b498",
            "0x8030b4c0",
            "0x8030b4e8",
            "0x8030b510",
            "0x8030b538",
            "0x8030b560",
            "0x8030b588",
            "0x8030b5b0",
            "0x8030b5d8",
            "0x8030b600",
            "0x8030b628",
            "0x8030b650",
            "0x8030b678",
            "0x8030b6a0",
            "0x8030b6c8",
            "0x8030b6f0",
            "0x8030b718",
            "0x8030b740",
            "0x8030b768",
            "0x8030b790",
            "0x8030b7b8",
            "0x8030b7e0",
            "0x8030b808",
            "0x8030b830",
            "0x8030b858",
            "0x8030b880",
            "0x8030b8a8",
            "0x8030b8d0",
            "0x8030b8f8",
            "0x8030b920",
            "0x8030b948",
            "0x8030b970",
            "0x8030b998",
            "0x8030b9c0",
            "0x8030b9e8",
            "0x8030ba10",
            "0x8030ba38",
            "0x8030ba60",
            "0x8030ba88",
            "0x8030bab0",
            "0x8030bad8",
            "0x8030bb00",
            "0x8030bb28",
            "0x8030bb50",
            "0x8030bb78",
            "0x8030bba0",
            "0x8030bbc8",
            "0x8030bbf0",
            "0x8030bc18",
            "0x8030bc40",
            "0x8030bc68",
            "0x8030bc90",
            "0x8030bcb8",
            "0x8030bce0",
            "0x8030bd08",
            "0x8030bd30",
            "0x8030bd58",
            "0x8030bd80",
            "0x8030bda8",
            "0x8030bdd0",
            "0x8030bdf8",
            "0x8030be20",
            "0x8030be48",
            "0x8030be70",
            "0x8030be98",
            "0x8030bec0",
            "0x8030bee8",
            "0x8030bf10",
            "0x8030bf38",
            "0x8030bf60",
            "0x8030bf88",
            "0x8030bfb0",
            "0x8030bfd8",
            "0x8030c000",
            "0x8030c028",
            "0x8030c050",
            "0x8030c078",
            "0x8030c0a0",
            "0x8030c0c8",
            "0x8030c0f0",
            "0x8030c118",
            "0x8030c140",
            "0x8030c168",
            "0x8030c190",
            "0x8030c1b8",
            "0x8030c1e0",
            "0x8030c208",
            "0x8030c230",
            "0x8030c258",
            "0x8030c280",
            "0x8030c2a8",
            "0x8030c2d0",
            "0x8030c2f8",
            "0x8030c320",
            "0x8030c348",
            "0x8030c370",
            "0x8030c398",
            "0x8030c3c0",
            "0x8030c3e8",
            "0x8030c410",
            "0x8030c438",
            "0x8030c460",
            "0x8030c488",
            "0x8030c4b0",
            "0x8030c4d8",
            "0x8030c500",
            "0x8030c528",
            "0x8030c550",
            "0x8030c578",
            "0x8030c5a0",
            "0x8030c5c8",
            "0x8030c5f0",
            "0x8030c618",
            "0x8030c640",
            "0x8030c668",
            "0x8030c690",
            "0x8030c6b8",
            "0x8030c6e0",
            "0x8030c708",
            "0x8030c730",
            "0x8030c758",
            "0x8030c780",
            "0x8030c7a8",
            "0x8030c7d0",
            "0x8030c7f8",
            "0x8030c820",
            "0x8030c848",
            "0x8030c870",
            "0x8030c898",
            "0x8030c8c0",
            "0x8030c8e8",
            "0x8030c910",
            "0x8030c938",
            "0x8030c960",
            "0x8030c988",
            "0x8030c9b0",
            "0x8030c9d8",
            "0x8030ca00",
            "0x8030ca28",
            "0x8030ca50",
            "0x8030ca78",
            "0x8030caa0",
            "0x8030cac8",
            "0x8030caf0",
            "0x8030cb18",
            "0x8030cb40",
            "0x8030cb68",
            "0x8030cb90",
            "0x8030cbb8",
            "0x8030cbe0",
            "0x8030cc08",
            "0x8030cc30",
            "0x8030cc58",
            "0x8030cc80",
            "0x8030cca8",
            "0x8030ccd0",
            "0x8030ccf8",
            "0x8030cd20",
            "0x8030cd48",
            "0x8030cd70",
            "0x8030cd98",
            "0x8030cdc0",
            "0x8030cde8",
            "0x8030ce10",
            "0x8030ce38",
            "0x8030ce60",
            "0x8030ce88",
            "0x8030ceb0",
            "0x8030ced8",
            "0x8030cf00",
            "0x8030cf28",
            "0x8030cf50",
            "0x8030cf78",
            "0x8030cfa0",
            "0x8030cfc8",
            "0x8030cff0",
            "0x8030d018",
            "0x8030d040",
            "0x8030d068",
            "0x8030d090",
            "0x8030d0b8",
            "0x8030d0e0",
            "0x8030d108",
            "0x8030d130",
            "0x8030d158",
            "0x8030d180",
            "0x8030d1a8",
            "0x8030d1d0",
            "0x8030d1f8",
            "0x8030d220",
            "0x8030d248",
            "0x8030d270",
            "0x8030d298",
            "0x8030d2c0",
            "0x8030d2e8",
            "0x8030d310",
            "0x8030d338",
            "0x8030d360",
            "0x8030d388",
            "0x8030d3b0",
            "0x8030d3d8",
            "0x8030d400",
            "0x8030d428",
            "0x8030d450",
            "0x8030d478",
            "0x8030d4a0",
            "0x8030d4c8",
            "0x8030d4f0",
            "0x8030d518",
            "0x8030d540",
            "0x8030d568",
            "0x8030d590",
            "0x8030d5b8",
            "0x8030d5e0",
            "0x8030d608",
            "0x8030d630",
            "0x8030d658",
            "0x8030d680",
            "0x8030d6a8",
            "0x8030d6d0",
            "0x8030d6f8",
            "0x8030d720",
            "0x8030d748",
            "0x8030d770",
            "0x8030d798",
            "0x8030d7c0",
            "0x8030d7e8",
            "0x8030d810",
            "0x8030d838",
            "0x8030d860",
            "0x8030d888",
            "0x8030d8b0",
            "0x8030d8d8",
            "0x8030d900",
            "0x8030d928",
            "0x8030d950",
            "0x8030d978",
            "0x8030d9a0",
            "0x8030d9c8",
            "0x8030d9f0",
            "0x8030da18",
            "0x8030da40",
            "0x8030da68",
            "0x8030da90",
            "0x8030dab8",
            "0x8030dae0",
            "0x8030db08",
            "0x8030db30",
            "0x8030db58",
            "0x8030db80",
            "0x8030dba8",
            "0x8030dbd0",
            "0x8030dbf8",
            "0x8030dc20",
            "0x8030dc48",
            "0x8030dc70",
            "0x8030dc98",
            "0x8030dcc0",
            "0x8030dce8",
            "0x8030dd10",
            "0x8030dd38",
            "0x8030dd60",
            "0x8030dd88",
            "0x8030ddb0",
            "0x8030ddd8",
            "0x8030de00",
            "0x8030de28",
            "0x8030de50",
            "0x8030de78",
            "0x8030dea0",
            "0x8030dec8",
            "0x8030def0",
            "0x8030df18",
            "0x8030df40",
            "0x8030df68",
            "0x8030df90",
            "0x8030dfb8",
            "0x8030dfe0",
            "0x8030e008",
            "0x8030e030",
            "0x8030e058",
            "0x8030e080",
            "0x8030e0a8",
            "0x8030e0d0",
            "0x8030e0f8",
            "0x8030e120",
            "0x8030e148",
            "0x8030e170",
            "0x8030e198",
            "0x8030e1c0",
            "0x8030e1e8",
            "0x8030e210",
            "0x8030e238",
            "0x8030e260",
            "0x8030e288",
            "0x8030e2b0",
            "0x8030e2d8",
            "0x8030e300",
            "0x8030e328",
            "0x8030e350",
            "0x8030e378",
            "0x8030e3a0",
            "0x8030e3c8",
            "0x8030e3f0",
            "0x8030e418",
            "0x8030e440",
            "0x8030e468",
            "0x8030e490",
            "0x8030e4b8",
            "0x8030e4e0",
            "0x8030e508",
            "0x8030e530",
            "0x8030e558",
            "0x8030e580",
            "0x8030e5a8",
            "0x8030e5d0",
            "0x8030e5f8",
            "0x8030e620",
            "0x8030e648",
            "0x8030e670",
            "0x8030e698",
            "0x8030e6c0",
            "0x8030e6e8",
            "0x8030e710",
            "0x8030e738",
            "0x8030e760",
            "0x8030e788",
            "0x8030e7b0",
            "0x8030e7d8",
            "0x8030e800",
            "0x8030e828",
            "0x8030e850",
            "0x8030e878",
            "0x8030e8a0",
            "0x8030e8c8",
            "0x8030e8f0",
            "0x8030e918",
            "0x8030e940",
            "0x8030e968",
            "0x8030e990",
            "0x8030e9b8",
            "0x8030e9e0",
            "0x8030ea08",
            "0x8030ea30",
            "0x8030ea58",
            "0x8030ea80",
            "0x8030eaa8",
            "0x8030ead0",
            "0x8030eaf8",
            "0x8030eb20",
            "0x8030eb48",
            "0x8030eb70",
            "0x8030eb98",
            "0x8030ebc0",
            "0x8030ebe8",
            "0x8030ec10",
            "0x8030ec38",
            "0x8030ec60",
            "0x8030ec88",
            "0x8030ecb0",
            "0x8030ecd8",
            "0x8030ed00",
            "0x8030ed28",
            "0x8030ed50",
            "0x8030ed78",
            "0x8030eda0",
            "0x8030edc8",
            "0x8030edf0",
            "0x8030ee18",
            "0x8030ee40",
            "0x8030ee68",
            "0x8030ee90"
        };
        string[] spritefileinfotargetvalue = {
            "0x8031ab4c",
            "0x8031ab50",
            "0x8031ab54",
            "0x8031ab58",
            "0x8031ab5c",
            "0x8031ab60",
            "0x8031ab64",
            "0x8031ab68",
            "0x8031ab6c",
            "0x8031ab70",
            "0x8031ab74",
            "0x8031ab78",
            "0x8031ab7c",
            "0x8031ab80",
            "0x8031ab84",
            "0x8031ab88",
            "0x8031ab8c",
            "0x8031ab90",
            "0x8031ab94",
            "0x8031ab98",
            "0x8031ab9c",
            "0x8031aba0",
            "0x8031aba4",
            "0x8031aba8",
            "0x8031abac",
            "0x8031abb0",
            "0x8031abb4",
            "0x8031abb8",
            "0x8031abbc",
            "0x8031abc0",
            "0x8031abc4",
            "0x8031abc8",
            "0x8031abcc",
            "0x8031abd0",
            "0x8031abd4",
            "0x8031abd8",
            "0x8031abdc",
            "0x8031abe0",
            "0x8031abe4",
            "0x8031abe8",
            "0x8031abec",
            "0x8031abf0",
            "0x8031abf4",
            "0x8031abf8",
            "0x8031abfc",
            "0x8031ac00",
            "0x8031ac04",
            "0x8031ac08",
            "0x8031ac0c",
            "0x8031ac10",
            "0x8031ac14",
            "0x8031ac18",
            "0x8031ac1c",
            "0x8031ac20",
            "0x8031ac24",
            "0x8031ac28",
            "0x8031ac2c",
            "0x8031ac30",
            "0x8031ac34",
            "0x8031ac38",
            "0x8031ac3c",
            "0x8031ac40",
            "0x8031ac44",
            "0x8031ac48",
            "0x8031ac4c",
            "0x8031ac50",
            "0x8031ac54",
            "0x8031ac58",
            "0x8031ac5c",
            "0x8031ac60",
            "0x8031ac64",
            "0x8031ac68",
            "0x8031ac6c",
            "0x8031ac70",
            "0x8031ac74",
            "0x8031ac78",
            "0x8031ac7c",
            "0x8031ac80",
            "0x8031ac84",
            "0x8031ac88",
            "0x8031ac8c",
            "0x8031ac90",
            "0x8031ac94",
            "0x8031ac98",
            "0x8031ac9c",
            "0x8031aca0",
            "0x8031aca4",
            "0x8031aca8",
            "0x8031acac",
            "0x8031acb0",
            "0x8031acb4",
            "0x8031acb8",
            "0x8031acbc",
            "0x8031acc0",
            "0x8031acc4",
            "0x8031acc8",
            "0x8031accc",
            "0x8031acd0",
            "0x8031acd4",
            "0x8031acd8",
            "0x8031acdc",
            "0x8031ace0",
            "0x8031ace4",
            "0x8031ace8",
            "0x8031acec",
            "0x8031acf0",
            "0x8031acf4",
            "0x8031acf8",
            "0x8031acfc",
            "0x8031ad00",
            "0x8031ad04",
            "0x8031ad08",
            "0x8031ad0c",
            "0x8031ad10",
            "0x8031ad14",
            "0x8031ad18",
            "0x8031ad1c",
            "0x8031ad20",
            "0x8031ad24",
            "0x8031ad28",
            "0x8031ad2c",
            "0x8031ad30",
            "0x8031ad34",
            "0x8031ad38",
            "0x8031ad3c",
            "0x8031ad40",
            "0x8031ad44",
            "0x8031ad48",
            "0x8031ad4c",
            "0x8031ad50",
            "0x8031ad54",
            "0x8031ad58",
            "0x8031ad5c",
            "0x8031ad60",
            "0x8031ad64",
            "0x8031ad68",
            "0x8031ad6c",
            "0x8031ad70",
            "0x8031ad74",
            "0x8031ad78",
            "0x8031ad7c",
            "0x8031ad80",
            "0x8031ad84",
            "0x8031ad88",
            "0x8031ad8c",
            "0x8031ad90",
            "0x8031ad94",
            "0x8031ad98",
            "0x8031ad9c",
            "0x8031ada0",
            "0x8031ada4",
            "0x8031ada8",
            "0x8031adac",
            "0x8031adb0",
            "0x8031adb4",
            "0x8031adb8",
            "0x8031adbc",
            "0x8031adc0",
            "0x8031adc4",
            "0x8031adc8",
            "0x8031adcc",
            "0x8031add0",
            "0x8031add4",
            "0x8031add8",
            "0x8031addc",
            "0x8031ade0",
            "0x8031ade4",
            "0x8031ade8",
            "0x8031adec",
            "0x8031adf0",
            "0x8031adf4",
            "0x8031adf8",
            "0x8031adfc",
            "0x8031ae00",
            "0x8031ae04",
            "0x8031ae08",
            "0x8031ae0c",
            "0x8031ae10",
            "0x8031ae14",
            "0x8031ae18",
            "0x8031ae1c",
            "0x8031ae20",
            "0x8031ae24",
            "0x8031ae28",
            "0x8031ae2c",
            "0x8031ae30",
            "0x8031ae34",
            "0x8031ae38",
            "0x8031ae3c",
            "0x8031ae40",
            "0x8031ae44",
            "0x8031ae48",
            "0x8031ae4c",
            "0x8031ae50",
            "0x8031ae54",
            "0x8031ae58",
            "0x8031ae5c",
            "0x8031ae60",
            "0x8031ae64",
            "0x8031ae68",
            "0x8031ae6c",
            "0x8031ae70",
            "0x8031ae74",
            "0x8031ae78",
            "0x8031ae7c",
            "0x8031ae80",
            "0x8031ae84",
            "0x8031ae88",
            "0x8031ae8c",
            "0x8031ae90",
            "0x8031ae94",
            "0x8031ae98",
            "0x8031ae9c",
            "0x8031aea0",
            "0x8031aea4",
            "0x8031aea8",
            "0x8031aeac",
            "0x8031aeb0",
            "0x8031aeb4",
            "0x8031aeb8",
            "0x8031aebc",
            "0x8031aec0",
            "0x8031aec4",
            "0x8031aec8",
            "0x8031aecc",
            "0x8031aed0",
            "0x8031aed4",
            "0x8031aed8",
            "0x8031aedc",
            "0x8031aee0",
            "0x8031aee4",
            "0x8031aee8",
            "0x8031aeec",
            "0x8031aef0",
            "0x8031aef4",
            "0x8031aef8",
            "0x8031aefc",
            "0x8031af00",
            "0x8031af04",
            "0x8031af08",
            "0x8031af0c",
            "0x8031af10",
            "0x8031af14",
            "0x8031af18",
            "0x8031af1c",
            "0x8031af20",
            "0x8031af24",
            "0x8031af28",
            "0x8031af2c",
            "0x8031af30",
            "0x8031af34",
            "0x8031af38",
            "0x8031af3c",
            "0x8031af40",
            "0x8031af44",
            "0x8031af48",
            "0x8031af4c",
            "0x8031af50",
            "0x8031af54",
            "0x8031af58",
            "0x8031af5c",
            "0x8031af60",
            "0x8031af64",
            "0x8031af68",
            "0x8031af6c",
            "0x8031af70",
            "0x8031af74",
            "0x8031af78",
            "0x8031af7c",
            "0x8031af80",
            "0x8031af84",
            "0x8031af88",
            "0x8031af8c",
            "0x8031af90",
            "0x8031af94",
            "0x8031af98",
            "0x8031af9c",
            "0x8031afa0",
            "0x8031afa4",
            "0x8031afa8",
            "0x8031afac",
            "0x8031afb0",
            "0x8031afb4",
            "0x8031afb8",
            "0x8031afbc",
            "0x8031afc0",
            "0x8031afc4",
            "0x8031afc8",
            "0x8031afcc",
            "0x8031afd0",
            "0x8031afd4",
            "0x8031afd8",
            "0x8031afdc",
            "0x8031afe0",
            "0x8031afe4",
            "0x8031afe8",
            "0x8031afec",
            "0x8031aff0",
            "0x8031aff4",
            "0x8031aff8",
            "0x8031affc",
            "0x8031b000",
            "0x8031b004",
            "0x8031b008",
            "0x8031b00c",
            "0x8031b010",
            "0x8031b014",
            "0x8031b018",
            "0x8031b01c",
            "0x8031b020",
            "0x8031b024",
            "0x8031b028",
            "0x8031b02c",
            "0x8031b030",
            "0x8031b034",
            "0x8031b038",
            "0x8031b03c",
            "0x8031b040",
            "0x8031b044",
            "0x8031b048",
            "0x8031b04c",
            "0x8031b050",
            "0x8031b054",
            "0x8031b058",
            "0x8031b05c",
            "0x8031b060",
            "0x8031b064",
            "0x8031b068",
            "0x8031b06c",
            "0x8031b070",
            "0x8031b074",
            "0x8031b078",
            "0x8031b07c",
            "0x8031b080",
            "0x8031b084",
            "0x8031b088",
            "0x8031b08c",
            "0x8031b090",
            "0x8031b094",
            "0x8031b098",
            "0x8031b09c",
            "0x8031b0a0",
            "0x8031b0a4",
            "0x8031b0a8",
            "0x8031b0ac",
            "0x8031b0b0",
            "0x8031b0b4",
            "0x8031b0b8",
            "0x8031b0bc",
            "0x8031b0c0",
            "0x8031b0c4",
            "0x8031b0c8",
            "0x8031b0cc",
            "0x8031b0d0",
            "0x8031b0d4",
            "0x8031b0d8",
            "0x8031b0dc",
            "0x8031b0e0",
            "0x8031b0e4",
            "0x8031b0e8",
            "0x8031b0ec",
            "0x8031b0f0",
            "0x8031b0f4",
            "0x8031b0f8",
            "0x8031b0fc",
            "0x8031b100",
            "0x8031b104",
            "0x8031b108",
            "0x8031b10c",
            "0x8031b110",
            "0x8031b114",
            "0x8031b118",
            "0x8031b11c",
            "0x8031b120",
            "0x8031b124",
            "0x8031b128",
            "0x8031b12c",
            "0x8031b130",
            "0x8031b134",
            "0x8031b138",
            "0x8031b13c",
            "0x8031b140",
            "0x8031b144",
            "0x8031b148",
            "0x8031b14c",
            "0x8031b150",
            "0x8031b154",
            "0x8031b158",
            "0x8031b15c",
            "0x8031b160",
            "0x8031b164",
            "0x8031b168",
            "0x8031b16c",
            "0x8031b170",
            "0x8031b174",
            "0x8031b178",
            "0x8031b17c",
            "0x8031b180",
            "0x8031b184",
            "0x8031b188",
            "0x8031b18c",
            "0x8031b190",
            "0x8031b194",
            "0x8031b198",
            "0x8031b19c",
            "0x8031b1a0",
            "0x8031b1a4",
            "0x8031b1a8",
            "0x8031b1ac",
            "0x8031b1b0",
            "0x8031b1b4",
            "0x8031b1b8",
            "0x8031b1bc",
            "0x8031b1c0",
            "0x8031b1c4",
            "0x8031b1c8",
            "0x8031b1cc",
            "0x8031b1d0",
            "0x8031b1d4",
            "0x8031b1d8",
            "0x8031b1dc",
            "0x8031b1e0",
            "0x8031b1e4",
            "0x8031b1e8",
            "0x8031b1ec",
            "0x8031b1f0",
            "0x8031b1f4",
            "0x8031b1f8",
            "0x8031b1fc",
            "0x8031b200",
            "0x8031b204",
            "0x8031b208",
            "0x8031b20c",
            "0x8031b210",
            "0x8031b214",
            "0x8031b218",
            "0x8031b21c",
            "0x8031b220",
            "0x8031b224",
            "0x8031b228",
            "0x8031b22c",
            "0x8031b230",
            "0x8031b234",
            "0x8031b238",
            "0x8031b23c",
            "0x8031b240",
            "0x8031b244",
            "0x8031b248",
            "0x8031b24c",
            "0x8031b250",
            "0x8031b254",
            "0x8031b258",
            "0x8031b25c",
            "0x8031b260",
            "0x8031b264",
            "0x8031b268",
            "0x8031b26c",
            "0x8031b270",
            "0x8031b274",
            "0x8031b278",
            "0x8031b27c",
            "0x8031b280",
            "0x8031b284",
            "0x8031b288",
            "0x8031b28c",
            "0x8031b290",
            "0x8031b294",
            "0x8031b298",
            "0x8031b29c",
            "0x8031b2a0",
            "0x8031b2a4",
            "0x8031b2a8",
            "0x8031b2ac",
            "0x8031b2b0",
            "0x8031b2b4",
            "0x8031b2b8",
            "0x8031b2bc",
            "0x8031b2c0",
            "0x8031b2c4",
            "0x8031b2c8",
            "0x8031b2cc",
            "0x8031b2d0",
            "0x8031b2d4",
            "NotPossible"
        };
        long[] spritenumber = {
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            251,
            363,
            427,
            431,
            407,
            408,
            409,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            454,
            483,
            483,
            468,
            284,
            236,
            250,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            244,
            020,
            021,
            483,
            057,
            058,
            024,
            025,
            026,
            483,
            483,
            032,
            155,
            389,
            033,
            034,
            035,
            036,
            037,
            038,
            039,
            483,
            040,
            041,
            042,
            478,
            479,
            043,
            044,
            045,
            046,
            047,
            048,
            054,
            483,
            483,
            483,
            060,
            062,
            063,
            098,
            065,
            066,
            067,
            068,
            069,
            070,
            071,
            072,
            073,
            074,
            075,
            076,
            264,
            483,
            483,
            483,
            483,
            483,
            079,
            080,
            094,
            095,
            272,
            308,
            483,
            120,
            483,
            483,
            088,
            089,
            090,
            246,
            243,
            091,
            483,
            110,
            483,
            483,
            483,
            483,
            100,
            270,
            101,
            269,
            232,
            271,
            322,
            099,
            102,
            103,
            104,
            483,
            108,
            343,
            105,
            483,
            483,
            109,
            111,
            112,
            113,
            483,
            307,
            309,
            114,
            117,
            247,
            335,
            115,
            395,
            334,
            116,
            118,
            119,
            483,
            121,
            124,
            127,
            128,
            125,
            126,
            241,
            245,
            130,
            240,
            131,
            061,
            134,
            137,
            140,
            141,
            142,
            398,
            400,
            401,
            404,
            480,
            143,
            483,
            146,
            150,
            151,
            154,
            158,
            383,
            169,
            384,
            369,
            483,
            170,
            161,
            483,
            350,
            351,
            421,
            437,
            440,
            319,
            320,
            213,
            436,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            171,
            174,
            175,
            177,
            483,
            179,
            180,
            259,
            182,
            276,
            277,
            278,
            452,
            186,
            188,
            162,
            163,
            164,
            165,
            206,
            189,
            336,
            337,
            340,
            344,
            347,
            348,
            192,
            364,
            375,
            372,
            483,
            381,
            349,
            483,
            365,
            419,
            439,
            445,
            449,
            483,
            483,
            413,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            456,
            481,
            482,
            483,
            483,
            392,
            483,
            426,
            483,
            483,
            193,
            194,
            195,
            483,
            196,
            197,
            198,
            199,
            200,
            203,
            202,
            204,
            483,
            483,
            483,
            013,
            483,
            483,
            483,
            483,
            483,
            211,
            405,
            406,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            215,
            217,
            220,
            222,
            229,
            239,
            268,
            230,
            258,
            233,
            238,
            415,
            234,
            077,
            483,
            483,
            263,
            483,
            483,
            248,
            249,
            483,
            262,
            265,
            283,
            282,
            288,
            290,
            483,
            293,
            483,
            483,
            303,
            352,
            483,
            411,
            412,
            425,
            428,
            429,
            483,
            430,
            483,
            442,
            483,
            443,
            432,
            310,
            314,
            317,
            318,
            321,
            323,
            483,
            324,
            483,
            476,
            414,
            483,
            483,
            483,
            474,
            326,
            483,
            357,
            358,
            374,
            399,
            410,
            416,
            417,
            418,
            483,
            181,
            483,
            483,
            483,
            483,
            483,
            483,
            446,
            483,
            483,
            453,
            465,
            147,
            483,
            483,
            371,
            390,
            483,
            237,
            225,
            144,
            185,
            483,
            391,
            393,
            483,
            483,
            385,
            386,
            388,
            096,
            149,
            097,
            361,
            366,
            362,
            438,
            455,
            457,
            458,
            451,
            331,
            332,
            023,
            027,
            028,
            029,
            030,
            356,
            081,
            082,
            083,
            084,
            085,
            086,
            462,
            466,
            467,
            471,
            260,
            261,
            460,
            354,
            472,
            473,
            483,
            483,
            475,
            031,
            049,
            050,
            051,
            052,
            055,
            281,
            056,
            059,
            078,
            087,
            483,
            242,
            092,
            093,
            483,
            106,
            327,
            424,
            368,
            367,
            330,
            444,
            464,
            107,
            345,
            346,
            122,
            123,
            129,
            132,
            287,
            159,
            160,
            214,
            133,
            135,
            136,
            156,
            145,
            148,
            153,
            157,
            166,
            173,
            483,
            172,
            382,
            176,
            178,
            483,
            183,
            190,
            191,
            201,
            207,
            208,
            209,
            221,
            218,
            402,
            403,
            433,
            187,
            483,
            312,
            219,
            223,
            235,
            483,
            224,
            228,
            252,
            253,
            254,
            255,
            256,
            266,
            267,
            279,
            280,
            294,
            289,
            291,
            292,
            295,
            296,
            302,
            298,
            299,
            300,
            301,
            304,
            305,
            420,
            306,
            311,
            329,
            328,
            338,
            342,
            359,
            370,
            376,
            387,
            394,
            422,
            423,
            483,
            448,
            483,
            210,
            227,
            313,
            231,
            315,
            316,
            469,
            470,
            434,
            441,
            339,
            353,
            377,
            450,
            378,
            379,
            380,
            257,
            397,
            396,
            275,
            297,
            333,
            483,
            459,
            461,
            477,
            483,
            138,
            139,
            216,
            053,
            064,
            435,
            373,
            152,
            184,
            483,
            205,
            226,
            285,
            212,
            355,
            360,
            274,
            286,
            341,
            483,
            325,
            463,
            447,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            017,
            015,
            483,
            483,
            483,
            483,
            483,
            483,
            022,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            018,
            483,
            483,
            483,
            483,
            014,
            012,
            019,
            483,
            483,
            483,
            483,
            483,
            483,
            167,
            483,
            319,
            483,
            483,
            483,
            483,
            011,
            010,
            483,
            016,
            483,
            483,
            483,
            483,
            168,
            273,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483,
            483
        };
        string[] ActorBuildPointer = {
            "0x804296E8", "0x8098C220", "0x8098D428", "0x8098DCF0", "0x8098BCB8", "0x8098D4B8", "0x8098D3D0", "0x8098C278", "0x8098CD18", "0x8098C990", "0x8098B0D0", "0x8098B660", "0x80323168", "0x8032567C", "0x80326A50", "0x8098FEA0", "0x8098FEAC", "0x804296A0", "0x8098A8E8", "0x8098A230", "0x8097BCC0", "0x8097DB00", "0x80954010", "0x809544A8", "0x80956E4C",
            "0x80957230", "0x80954F5C", "0x80964AE0", "0x80964028", "0x80977D38", "0x809615B8", "0x80966030", "0x8096603C", "0x80956468", "0x809568D8", "0x80951610", "0x80951878", "0x809519D8", "0x8098A360", "0x80953500", "0x8095CCD8", "0x809622F8", "0x80979648", "0x80979378", "0x80979288", "0x80979918", "0x80979468", "0x80979198", "0x80979828", "0x80979738",
            "0x80979558", "0x80AF7DD0", "0x80B02318", "0x80AFA9C8", "0x80AFDCB0", "0x80B02AF8", "0x80AFBF00", "0x80B0C150", "0x80B07488", "0x80ADAFC8", "0x80AF0E08", "0x80B095F0", "0x80B095FC", "0x80B09608", "0x80959E58", "0x80959E64", "0x80959E70", "0x80959E7C", "0x80959E88", "0x80959E94", "0x80959EA0", "0x80ADEC90", "0x80AEEB28", "0x80AEEB34", "0x80AEEB40",
            "0x80AEEB58", "0x80AEEB64", "0x80ADCA08", "0x80ADCA14", "0x80ADCA20", "0x80ADEF88", "0x80AE8158", "0x80AE8164", "0x80AF3570", "0x80AF357C", "0x80AE8790", "0x80AF3A38", "0x80B0B850", "0x80AE90D8", "0x80B0BD28", "0x80AD8C70", "0x80AE7A80", "0x80AE6EF8", "0x80AE76A8", "0x80AE72D0", "0x80AE6B48", "0x80AE6020", "0x80AE6790", "0x80AE63D8", "0x80AF3180",
            "0x80AF2A80", "0x80AF2D50", "0x80AF27A8", "0x80B0DA58", "0x80324AA8", "0x80324060", "0x80959C30", "0x80959A10", "0x80953CE0", "0x80AEE178", "0x80AE8DA8", "0x80ADE298", "0x80AED820", "0x80AEF9F0", "0x80AF90F8", "0x8095CDB8", "0x80AEE408", "0x8096E908", "0x80955A58", "0x80ADEA00", "0x80B05E10", "0x8097CEE8", "0x8097CD28", "0x8097CE08", "0x80AD6078",
            "0x80972660", "0x80AE8B08", "0x80AF65D0", "0x80AF65DC", "0x80AF65E8", "0x80AF65F4", "0x80AD74F8", "0x8097ED30", "0x80ADDB20", "0x80B01A40", "0x80AFB8F0", "0x80AFCF88", "0x80AEBDA0", "0x80B0D2D0", "0x80AE5498", "0x8096A030", "0x80ADA578", "0x80AFA400", "0x80ADA998", "0x80AE0608", "0x80B07920", "0x80B082F0", "0x80B07D58", "0x80AED4E0", "0x80AEAF80",
            "0x80AD67A8", "0x80AEC030", "0x80AEB8E8", "0x80951530", "0x80B0A500", "0x80AD6B38", "0x80AF8718", "0x80B03D70", "0x8097D450", "0x80B03600", "0x80B03624", "0x80B0360C", "0x80B03618", "0x80AF54A0", "0x80AF54AC", "0x80AF5B38", "0x80B060A0", "0x80B0D748", "0x80B10340", "0x80B1034C", "0x80AFD490", "0x80AFD830", "0x80952998", "0x8095D018", "0x80AEDC90",
            "0x80AD7EC0", "0x80B0ABD0", "0x80B0ABDC", "0x80AE5A70", "0x80AD9AE8", "0x80AD9D98", "0x80AD9838", "0x80AD9588", "0x80B09E40", "0x80B09A48", "0x80AEC4E8", "0x80AEC918", "0x80ADA048", "0x80B10BA0", "0x80B0E230", "0x80B0E8B0", "0x80AF4378", "0x80AF0950", "0x80B0D3B0", "0x80AE9478", "0x80B7C790", "0x80B08630", "0x8097F250", "0x80B088C0", "0x8097BAD0",
            "0x80AF03D0", "0x80B0FBC0", "0x80951410", "0x80958D68", "0x80958C88", "0x80958B58", "0x80971BB0", "0x8097E138", "0x809789C8", "0x80978E90", "0x80955978", "0x80951EB0", "0x80961C00", "0x8097B4D8", "0x8097B1C0", "0x8097B2C8", "0x8097B3D0", "0x8095BB28", "0x8095B858", "0x8095B948", "0x8095BA38", "0x80323620", "0x80B00A98", "0x80B01E68", "0x80AF5FC0",
            "0x80962900", "0x80971578", "0x80AD6308", "0x80AE7E50", "0x80B0A240", "0x80AFE430", "0x80B0C510", "0x80ADFAE8", "0x80AF7528", "0x809790B8", "0x809584B8", "0x80AFB640", "0x80AFB64C", "0x80AFB658", "0x80AFB664", "0x80B10E48", "0x80B81980", "0x80B87020", "0x80B7B6E8", "0x80B82840", "0x80B84E10", "0x80B85E28", "0x80B83AD8", "0x80B76B58", "0x80B79B60",
            "0x80B7AB38", "0x80B75CA8", "0x80957440", "0x80B77600", "0x80B78EC8", "0x809747F8", "0x80B78148", "0x80B7DA08", "0x80B7F630", "0x80B7FD00", "0x8097EB38", "0x80963C20", "0x80965110", "0x80963408", "0x80962E98", "0x80963AB0", "0x80965738", "0x80957C80", "0x80972820", "0x80972CD0", "0x80974C60", "0x809759C8", "0x809742F0", "0x80976BB8", "0x809556C0",
            "0x80955350", "0x80954288", "0x8096BE48", "0x8096BE54", "0x8097E9A8", "0x80959408", "0x8097E438", "0x809597A0", "0x809637A0", "0x80B0CAB8", "0x80B0CAC4", "0x80AF4C48", "0x80AF51B0", "0x80AF7830", "0x80AD5A60", "0x80AFC4E8", "0x80AF8AF0", "0x80AD7A50", "0x8097C478", "0x80B05808", "0x8097F4B8", "0x8095E450", "0x8095E9B4", "0x8095F118", "0x8095FDD0",
            "0x8095AA00", "0x8095AEB0", "0x8095B148", "0x8095B4D8", "0x80953700", "0x80B80328", "0x80B80A38", "0x80B81278", "0x80960568", "0x809608A4", "0x80960898", "0x8095F924", "0x80960F38", "0x80977878", "0x80964768", "0x80323288", "0x8097E840", "0x8097E760", "0x8097EF20", "0x80951D18", "0x8095DDC0", "0x80970DB8", "0x80989900", "0x80AEF2D0", "0x8097E250",
            "0x80AE01A0", "0x80AFC910", "0x80B0B090", "0x80AE1458", "0x8095E108", "0x80989D08", "0x80B0F320", "0x80B0F688", "0x8095BC18", "0x80970FA0", "0x80B06360", "0x80B0636C", "0x80B06968", "0x80B03050", "0x80AEFDD8", "0x8097F730", "0x80B0DFA0", "0x80AF8318", "0x80AF1F80", "0x8095E360", "0x809623D8", "0x809626D8", "0x80ADF7B8", "0x80AE0A08", "0x80AFACC8",
            "0x80958178", "0x8096F220", "0x8096F690", "0x80AF2210", "0x80970368", "0x8096FB98", "0x8096FBA8", "0x80970950", "0x80970960", "0x809775A0", "0x809775B0", "0x80977170", "0x8096FF4C", "0x80961F40", "0x80955C50", "0x80ADF428", "0x8097F598", "0x80950FF0", "0x8097A9B0", "0x80B06BF8", "0x8097B0D0", "0x80AFA738", "0x8097BF48", "0x80AEA4D0", "0x8095C660",
            "0x8096C150", "0x80951F90", "0x80952550", "0x80AF7148", "0x80B0EFD8", "0x80AEA0B8", "0x80976538", "0x809761C8", "0x8097CC48", "0x80952E10", "0x809530F0", "0x80952D30", "0x8097F0E0", "0x80B0B440", "0x8097F348", "0x80971090", "0x8097D5C0", "0x8096EB78", "0x8096EB84", "0x8096C9C8", "0x8098AA20", "0x80AE17F8", "0x8097DE38", "0x8097DD78", "0x80975EF0",
            "0x8097C9B8", "0x80AE1B28", "0x80AE3390", "0x80AE3A60", "0x80AE2CC8", "0x80AE40D8", "0x80AE4DD0", "0x80ADD1A0", "0x80AE4758", "0x80B053D8", "0x80AECD48", "0x80324288", "0x8096B250", "0x80978570", "0x80323B60", "0x80326960", "0x8097B5E0", "0x80978228", "0x809531D0", "0x80971E90", "0x80971F70", "0x80B065F8", "0x80979C78", "0x80979F18", "0x80979E08",
            "0x80955D40", "0x8096A5D0", "0x8096B110", "0x8096A710", "0x80970E98", "0x809620F0", "0x80969E78", "0x809684F8", "0x80967A38", "0x80967810", "0x8096781C", "0x80AFEEC0", "0x80B003E0", "0x80AFF390", "0x80AFF39C", "0x80AFF3A8", "0x80AFF3B4", "0x80AFF3C0", "0x80AFF3CC", "0x80AF9C00", "0x8096AE08", "0x8096A860", "0x809669E8", "0x80B01538", "0x80B00EB0",
            "0x8096AB50", "0x80B01290", "0x8097E5A0", "0x8097E680", "0x8095D370", "0x8095D560", "0x8095D468", "0x80968990", "0x80969438", "0x80966FE0", "0x80968030", "0x8096A440", "0x809667D8", "0x80967F40", "0x80967C50", "0x80968240", "0x80AF95A8", "0x80B0C808", "0x80ADFDE0", "0x80AE1088", "0x80AF6CDC", "0x80AF6CD0", "0x8096A138", "0x80967628", "0x8096B928",
            "0x80977008", "0x809716E8", "0x8096B6F8", "0x80964F30", "0x8097D0A8", "0x8097D248", "0x80AF96F8", "0x80967430", "0x809671E0", "0x80968B98", "0x80AF8E40", "0x8096A228", "0x80B04A90", "0x80B043F0", "0x80B04838", "0x80B03EE0", "0x8095C0F8", "0x80AED108", "0x80AED330", "0x80AF48F0", "0x80B04FE0", "0x80AD6F90", "0x80AF3ED0", "0x80AEEB4C", "0x80AD9060",
            "0x80B090E0", "0x80AFB390", "0x809733B8", "0x80969A28", "0x80969CF8", "0x80B07030", "0x80968DA8", "0x809690F0", "0x80B0A940", "0x8096803C", "0x80958088", "0x80AE9D40", "0x80AFE748", "0x80AFE754", "0x80AFE760", "0x80AFE76C", "0x80972168", "0x80AFE778", "0x80AFE784", "0x80ADCDE8", "0x80ADC0B0", "0x80ADC4A0", "0x80959248", "0x80958E48", "0x80B0FE60",
            "0x8096C740", "0x8096C820", "0x8096C3B8", "0x80969620", "0x80B00680", "0x80AE2600", "0x8097A498", "0x80ADB440", "0x80ADB44C", "0x80980B38", "0x80981038", "0x80967548", "0x8095DBC0", "0x8095D828", "0x80B106D8", "0x80B02730", "0x80B0273C", "0x80971CD8", "0x80AD88F8", "0x80AEA9F8", "0x80958868", "0x8097AC38", "0x8097A1F0", "0x8097A6B8", "0x80979A08",
            "0x80958768", "0x80952EF0", "0x8095D0F8", "0x80AD82B0", "0x80980090", "0x8097FE80", "0x80AF6CE8", "0x80ADAC28", "0x8097D950", "0x80ADB898", "0x80980DD8", "0x809722D8", "0x80ADE5C8", "0x80ADBCDC", "0x80ADBCE8", "0x8095C2C8", "0x80980CC8", "0x80AF1B68", "0x8097CFC8", "0x80955EE8", "0x80962DB8", "0x80962B20", "0x80976AC0", "0x809769C8", "0x80976860",
            "0x8097C1A8", "0x8097F9C0", "0x80974168", "0x8098A728", "0x8098A808", "0x80975808", "0x809758E8", "0x80975568", "0x80975728", "0x80975648", "0x80966CF8", "0x80975430", "0x80966EA8", "0x80968700", "0x8096BB30", "0x80978BE0", "0x80980200", "0x809719F8", "0x80971A04", "0x80B0EC30", "0x80323DF8", "0x80950B00", "0x80950B0C", "0x80950B18", "0x80950B24",
            "0x80950B30", "0x80950B3C", "0x809808B0", "0x80ADD890", "0x80324D78", "0x8098FDA8", "0x809803A8", "0x809803B4", "0x80980620", "0x8095A4B8", "0x8095A7A8", "0x8095A1B8", "0x8095CA80", "0x8097AF18", "0x809527C8", "0x80B7F1A8", "0x8097C2E0", "0x8097A070", "0x8097BDA0", "0x80952B98", "0x80429540", "0x8098A98C", "0x8098EEC8", "0x80984710", "0x80987F5C",
            "0x80981BD4", "0x80982284", "0x80986334", "0x80984BF4", "0x809834F0", "0x8098369C", "0x80985434", "0x80985C8C", "0x80985704", "0x80983B64", "0x80983D34", "0x80983A6C", "0x80983E3C", "0x809826B4", "0x809857B0", "0x80986144", "0x80982D1C", "0x80982A1C", "0x809821AC", "0x80984258", "0x8098687C", "0x80986F58", "0x80987544", "0x809876C0", "0x80986B48",
            "0x809870D8", "0x809873D0", "0x80987258", "0x80986D64", "0x80981A3C", "0x8098872C", "0x809894B4", "0x80988934", "0x809878C0", "0x809883B4", "0x80988DDC", "0x8098586C", "0x80984A24", "0x8098640C", "0x80987BD8", "0x80982F34", "0x80983190", "0x809832B0", "0x80987A64", "0x80989794", "0x80988574", "0x80981960", "0x80988B60", "0x80982530", "0x8098550C",
            "0x8098408C", "0x80984B10", "0x80981CA0", "0x80981E0C", "0x809838E4", "0x80984E94", "0x809864DC", "0x80983F40", "0x80982844", "0x80982B08", "0x80982FD4", "0x80986074", "0x809845F8", "0x80985E1C", "0x8098E278", "0x8098E948", "0x8093FE28", "0x8093F810", "0x809412C0", "0x8094B0E0", "0x8094F788", "0x809501B0", "0x80942B38", "0x80981290", "0x80943160",
            "0x8094E418", "0x80949450", "0x80950768", "0x80941960", "0x8076B470", "0x8098EFDC", "0x803275E0", "0x80322B18", "0x80327668", "0x8098AA88", "0x80327D24", "0x8098B9F8", "0x8094D8D8", "0x8094C050", "0x8094D1E8", "0x803225FC", "0x80940C40", "0x8094BBFC", "0x80945418", "0x803229E8", "0x80429538", "0x8094EC40", "0x80944E70", "0x80947630", "0x80941D18",
            "0x80943610", "0x80940388", "0x80945DF8", "0x80946728", "0x80948BF8", "0x80948030", "0x80948640", "0x80947B60", "0x80948B10", "0x80945A20", "0x8093E8E8", "0x8093F3B0", "0x8093E448", "0x8093E280", "0x8094A378", "0x8093FFE8", "0x8076B300", "0x809427B0", "0x8094F0D8", "0x80950428", "0x80942400", "0x80945560", "0x80958A78", "0x809656E0", "0x80429658"
        };
        decimal ActorNumber;
        int ActorNumber2;
        string cppfile;
        string customespritename;
        string igspritename;
        string spritefileinfotargetname;
        string spritefileinfotargetnamestore;
        string xpos;
        string ypos;
        string rectx1;
        string rectx2;
        string recty1;
        string recty2;
        string xposstore;
        string yposstore;
        string rectx1store;
        string rectx2store;
        string recty1store;
        string recty2store;
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void ActorNum_ValueChanged(object sender, EventArgs e)
        {
            ActorNumber = ActorNum.Value;
            ActorNumber2 = Decimal.ToInt32(ActorNumber);
            ActorIName.SelectedIndex = (int)ActorNum.Value;
            SpriteName.SelectedIndex = (int)ActorNum.Value;
            if (spritenumber[(int)ActorNum.Value] != 483)
            {
                SpriteNum.Value = spritenumber[(int)ActorNum.Value];
            }
            else
            {
                SpriteNum.Value = 0;
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            String FinalText = "";
            if (isNormalHook.Checked)
            {
                if (cppfile == null || customespritename == null || igspritename == null || cppfile == "" || customespritename == "" || igspritename == "")
                {
                    Output.Text = "";
                    logs.Text = "ERROR: You have to fill all the text boxes!";
                    copyToolStripItem.Enabled = false;
                    saveAsToolStripItem.Enabled = false;
                    return;
                }
                if (spritenumber[ActorNumber2] == 483)
                {
                    FinalText = "---\r\n" +
                        "#Replaces Actor " + ActorNumber2 + " " + ActorName[ActorNumber2] + "\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "source_files: [../src/" + cppfile + "]\r\n" +
                        "hooks:\r\n" +
                        "  - name: " + customespritename + "Build\r\n" +
                        "    type: add_func_pointer\r\n" +
                        "    src_addr_pal: " + ActorBuildPointer[ActorNumber2] + "\r\n" +
                        "    target_func: '" + igspritename + "::build()'";
                }
                else
                {
                    FinalText = "---\r\n" +
                        "#Replaces Actor " + ActorNumber2 + " " + ActorName[ActorNumber2] + " (Sprite " + spritenumber[ActorNumber2] + ")\r\n" +
                        "\r\n" +
                        "\r\n" +
                        "source_files: [../src/" + cppfile + "]\r\n" +
                        "hooks:\r\n" +
                        "  - name: " + customespritename + "Build\r\n" +
                        "    type: add_func_pointer\r\n" +
                        "    src_addr_pal: " + ActorBuildPointer[ActorNumber2] + "\r\n" +
                        "    target_func: '" + igspritename + "::build()'";
                }
                if (spritefileinfo.Checked)
                {
                    if (spritefileinfotargetname == null || spritefileinfotargetname == "")
                    {
                        Output.Text = "";
                        logs.Text = "ERROR: You have to fill all the text boxes!";
                        copyToolStripItem.Enabled = false;
                        saveAsToolStripItem.Enabled = false;
                        return;
                    }
                    else
                    {
                        if (spritenumber[ActorNumber2] == 483)
                        {
                            Output.Text = "";
                            logs.Text = "ERROR: The sprite you want to replace don't exist as a level-placeable sprite!";
                            copyToolStripItem.Enabled = false;
                            saveAsToolStripItem.Enabled = false;
                            return;
                        }
                        FinalText += "\r\n" +
                        "\r\n" +
                        "  - name: " + customespritename + "SpriteFileInfo\r\n" +
                        "    type: add_func_pointer\r\n" +
                        "    src_addr_pal: " + spritefileinfotargetvalue[spritenumber[ActorNumber2]] + "\r\n" +
                        "    target_func: '" + spritefileinfotargetname + "'\r\n" +
                        "    # 0x8031AB4C + sprite num * 0x4 == offset" + "\r\n";
                    }
                }
                if (isSSI.Checked)
                {
                    if (SSIXPos.Text == null || SSIXPos.Text == ""
                        || SSIYPos.Text == null || SSIYPos.Text == ""
                        || SSIDDX1.Text == null || SSIDDX1.Text == ""
                        || SSIDDY1.Text == null || SSIDDY1.Text == ""
                        || SSIDDX2.Text == null || SSIDDX2.Text == ""
                        || SSIDDY2.Text == null || SSIDDY2.Text == "")
                    {
                        Output.Text = "";
                        logs.Text = "ERROR: You have to fill all the text boxes!";
                        copyToolStripItem.Enabled = false;
                        saveAsToolStripItem.Enabled = false;
                        return;
                    }
                    else
                    {
                        if (spritenumber[ActorNumber2] == 483)
                        {
                            Output.Text = "";
                            logs.Text = "ERROR: The sprite you want to replace don't exist as a level-placeable sprite!";
                            copyToolStripItem.Enabled = false;
                            saveAsToolStripItem.Enabled = false;
                            return;
                        }
                        String ID = new String('0', 4 - ActorNumber2.ToString("X").Length) + ActorNumber2.ToString("X");
                        string XOffs = new String('0', 8 - SSIXPos.Text.Length) + SSIXPos.Text + " ";
                        string YOffs = new String('0', 8 - SSIYPos.Text.Length) + SSIYPos.Text + "  ";
                        string RectX1 = new String('0', 8 - SSIDDX1.Text.Length) + SSIDDX1.Text + " ";
                        string RectY1 = new String('0', 8 - SSIDDY1.Text.Length) + SSIDDY1.Text + " ";
                        string RectX2 = new String('0', 8 - SSIDDX2.Text.Length) + SSIDDX2.Text + " ";
                        string RectY2 = new String('0', 8 - SSIDDY2.Text.Length) + SSIDDY2.Text + " ";
                        FinalText += "\r\n" +
                        "\r\n" +
                        "  - name: Update" + customespritename + "SpriteInfo\r\n" +
                        "    type: patch\r\n" +
                        "    # 0x8030A340 + sprite num * 0x28 == offset\r\n" +
                        "    addr_pal: " + updatespritefileinfotargetvalue[spritenumber[ActorNumber2]] + "\r\n" +
                        "    #      -ID- ----  -X Offs- -Y Offs-  -RectX1- -RectY1- -RectX2- -RectY2-  -1C- -1E- -20- -22-  Flag ----\r\n" +
                        "    data: '" + ID + " 0000  " + XOffs + YOffs + RectX1 + RectY1 + RectX2 + RectY2 + " 0000 0000 0000 0000  0000 0000'";
                    }
                }
                if ((customespritename.IndexOf("matt", StringComparison.OrdinalIgnoreCase) >= 0) || (cppfile.IndexOf("matt", StringComparison.OrdinalIgnoreCase) >= 0) || (igspritename.IndexOf("matt", StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    Output.Text = "";
                    logs.Text = "ERROR: Invalid Sprite Name, C++ Filename or IG-Name";
                    copyToolStripItem.Enabled = false;
                    saveAsToolStripItem.Enabled = false;
                    return;
                }
                if (!(cppfile.IndexOf(".cpp", StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    Output.Text = "";
                    logs.Text = "ERROR: Invalid C++ Filename";
                    copyToolStripItem.Enabled = false;
                    saveAsToolStripItem.Enabled = false;
                    return;
                }
            }
            if(isUniversalHook.Checked)
            {
                if (cppfile == null || customespritename == null || igspritename == null || cppfile == "" || customespritename == "" || igspritename == "")
                {
                    Output.Text = "";
                    logs.Text = "ERROR: You have to fill all the text boxes!";
                    copyToolStripItem.Enabled = false;
                    saveAsToolStripItem.Enabled = false;
                    return;
                }
                long input = Convert.ToInt64(ActorBuildPointer[ActorNumber2].Replace("0x", ""), 16);
                MapfileTool instance = new MapfileTool();
                FinalText = "hooks:\r\n" +
                "- {name: " + customespritename + "Build, src_addr_jpn: " + instance.EU1ToJP1(input, false) + ", src_addr_jpn2: " + instance.EU1ToJP2(input, false) + ", src_addr_ntsc: " + instance.EU1ToUS1(input, false) + ",\r\n" +
                "  src_addr_ntsc2: " + instance.EU1ToUS2(input, false) + ", src_addr_pal: " + input + ", src_addr_pal2: " + instance.EU1ToEU2(input, false) + ",\r\n" +
                "  target_func: '" + igspritename + "::build()', type: add_func_pointer}\r\n";
                if (isSSI.Checked)
                {
                    if (SSIXPos.Text == null || SSIXPos.Text == ""
                        || SSIYPos.Text == null || SSIYPos.Text == ""
                        || SSIDDX1.Text == null || SSIDDX1.Text == ""
                        || SSIDDY1.Text == null || SSIDDY1.Text == ""
                        || SSIDDX2.Text == null || SSIDDX2.Text == ""
                        || SSIDDY2.Text == null || SSIDDY2.Text == "")
                    {
                        Output.Text = "";
                        logs.Text = "ERROR: You have to fill all the text boxes!";
                        copyToolStripItem.Enabled = false;
                        saveAsToolStripItem.Enabled = false;
                        return;
                    }
                    else
                    {
                        if (spritenumber[ActorNumber2] == 483)
                        {
                            Output.Text = "";
                            logs.Text = "ERROR: The sprite you want to replace don't exist as a level-placeable sprite!";
                            copyToolStripItem.Enabled = false;
                            saveAsToolStripItem.Enabled = false;
                            return;
                        }
                        String ID = new String('0', 4 - ActorNumber2.ToString("X").Length) + ActorNumber2.ToString("X");
                        string XOffs = new String('0', 8 - SSIXPos.Text.Length) + SSIXPos.Text + " ";
                        string YOffs = new String('0', 8 - SSIYPos.Text.Length) + SSIYPos.Text + "  ";
                        string RectX1 = new String('0', 8 - SSIDDX1.Text.Length) + SSIDDX1.Text + " ";
                        string RectY1 = new String('0', 8 - SSIDDY1.Text.Length) + SSIDDY1.Text + " ";
                        string RectX2 = new String('0', 8 - SSIDDX2.Text.Length) + SSIDDX2.Text + " ";
                        string RectY2 = new String('0', 8 - SSIDDY2.Text.Length) + SSIDDY2.Text + " ";
                        long inputssi = Convert.ToInt64(updatespritefileinfotargetvalue[spritenumber[ActorNumber2]].Replace("0x", ""), 16);

                        FinalText += "- {addr_jpn: " + instance.EU1ToJP1(inputssi, false) + ", addr_jpn2: " + instance.EU1ToJP2(inputssi, false) + ", addr_ntsc: " + instance.EU1ToUS1(inputssi, false) + ", addr_ntsc2: " + instance.EU1ToUS2(inputssi, false) + ",\r\n" +
                        "  addr_pal: " + inputssi + ", addr_pal2: " + instance.EU1ToEU2(inputssi, false) + ", data: " + ID + " 0000  " + XOffs + YOffs + RectX1 + "\r\n" +
                        "    " + RectY1 + RectX2 + RectY2 + " 0000 0000 0000 0000  0000 0000, name: Update" + customespritename + "SpriteInfo,\r\n" +
                        "  type: patch}\r\n";
                    }
                }
                if (spritefileinfo.Checked)
                {
                    if (spritefileinfotargetname == null || spritefileinfotargetname == "")
                    {
                        Output.Text = "";
                        logs.Text = "ERROR: You have to fill all the text boxes!";
                        copyToolStripItem.Enabled = false;
                        saveAsToolStripItem.Enabled = false;
                        return;
                    }
                    else
                    {
                        if (spritenumber[ActorNumber2] == 483)
                        {
                            Output.Text = "";
                            logs.Text = "ERROR: The sprite you want to replace don't exist as a level-placeable sprite!";
                            copyToolStripItem.Enabled = false;
                            saveAsToolStripItem.Enabled = false;
                            return;
                        }
                        long inputsfi = Convert.ToInt64(spritefileinfotargetvalue[spritenumber[ActorNumber2]].Replace("0x", ""), 16);
                        FinalText += "- {name: " + customespritename + "SpriteFileInfo, src_addr_jpn: " + instance.EU1ToJP1(inputsfi, false) + ", src_addr_jpn2: " + instance.EU1ToJP2(inputsfi, false) + ",\r\n" +
                        "  src_addr_ntsc: " + instance.EU1ToUS1(inputsfi, false) + ", src_addr_ntsc2: " + instance.EU1ToUS2(inputsfi, false) + ", src_addr_pal: " + inputsfi + ",\r\n" +
                        "  src_addr_pal2: " + instance.EU1ToEU2(inputsfi, false) + ", target_func: '" + spritefileinfotargetname + "', type: add_func_pointer}\r\n";
                    }
                }
                if ((customespritename.IndexOf("matt", StringComparison.OrdinalIgnoreCase) >= 0) || (cppfile.IndexOf("matt", StringComparison.OrdinalIgnoreCase) >= 0) || (igspritename.IndexOf("matt", StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    Output.Text = "";
                    logs.Text = "ERROR: Invalid Sprite Name, C++ Filename or IG-Name";
                    copyToolStripItem.Enabled = false;
                    saveAsToolStripItem.Enabled = false;
                    return;
                }
                if (!(cppfile.IndexOf(".cpp", StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    Output.Text = "";
                    logs.Text = "ERROR: Invalid C++ Filename";
                    copyToolStripItem.Enabled = false;
                    saveAsToolStripItem.Enabled = false;
                    return;
                }
                FinalText += "source_files: [../src/" + cppfile + "]";
            }
            Output.Text = FinalText;
            copyToolStripItem.Enabled = true;
            saveAsToolStripItem.Enabled = true;
            logs.Text = "Generated YAML File successfully !";
        }

        private void cppfilename_TextChanged(object sender, EventArgs e)
        {
            cppfile = cppfilename.Text;
        }

        private void customspritename_TextChanged(object sender, EventArgs e)
        {
            customespritename = customspritename.Text;
        }

        private void ingamespritename_TextChanged(object sender, EventArgs e)
        {
            igspritename = ingamespritename.Text;
        }

        private void example_Click(object sender, EventArgs e)
        {
            ActorNum.Value = 51;
            cppfilename.Text = "customsprite.cpp";
            customspritename.Text = "MyCustomSprite";
            ingamespritename.Text = "daCustomSprite_c";
            if (spritefileinfo.Checked)
            {
                spritefileinfotarget.Text = "CSarcNameList";
            }
            if (!spritefileinfo.Checked)
            {
                spritefileinfotarget.Text = "";
            }
            if (isSSI.Checked)
            {
                SSIXPos.Text = "00000008";
                SSIYPos.Text = "FFFFFFF8";
                SSIDDX1.Text = "00000000";
                SSIDDY1.Text = "00000000";
                SSIDDX2.Text = "00000010";
                SSIDDY2.Text = "00000010";
            }
            if (!isSSI.Checked)
            {
                SSIXPos.Text = "";
                SSIYPos.Text = "";
                SSIDDX1.Text = "";
                SSIDDY1.Text = "";
                SSIDDX2.Text = "";
                SSIDDY2.Text = "";
            }
        }

        private void spritefileinfo_CheckedChanged(object sender, EventArgs e)
        {
            if (spritefileinfo.Checked)
            {
                spritefileinfotarget.ReadOnly = false;
                spritefileinfotargetname = spritefileinfotargetnamestore;
                spritefileinfotarget.Text = spritefileinfotargetname;
            }
            else
            {
                spritefileinfotarget.ReadOnly = true;
                spritefileinfotargetnamestore = spritefileinfotargetname;
                spritefileinfotarget.Text = "";
            }
        }

        private void spritefileinfotarget_TextChanged(object sender, EventArgs e)
        {
            spritefileinfotargetname = spritefileinfotarget.Text;
        }

        private void ActorIName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActorNum.Value = ActorIName.SelectedIndex;
        }

        private void SpriteName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActorNum.Value = SpriteName.SelectedIndex;
        }

        private void SpriteNum_ValueChanged(object sender, EventArgs e)
        {
            if (SpriteNum.Value != 0)
            {
                int pos = Array.FindIndex(spritenumber, x => x == SpriteNum.Value);
                if (pos > -1)
                {
                    ActorNum.Value = pos;
                }
                if (pos < 0)
                {
                    ActorNum.Value = 0;
                }
            }
        }
        public bool didIsawTheMessage = false;
        private void isSSI_CheckedChanged(object sender, EventArgs e)
        {
            if (isSSI.Checked)
            {
                if (!didIsawTheMessage)
                {
                    DialogResult result;
                    result = MessageBox.Show("Values in this section has to be entered in Hexadecimal format.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SSIDDX1.ReadOnly = false;
                SSIDDX2.ReadOnly = false;
                SSIDDY1.ReadOnly = false;
                SSIDDY2.ReadOnly = false;
                SSIXPos.ReadOnly = false;
                SSIYPos.ReadOnly = false;
                didIsawTheMessage = true;
                xpos = xposstore;
                ypos = yposstore;
                rectx1 = rectx1store;
                rectx2 = rectx2store;
                recty1 = recty1store;
                recty2 = recty2store;
                SSIDDX1.Text = rectx1;
                SSIDDX2.Text = rectx2;
                SSIDDY1.Text = recty1;
                SSIDDY2.Text = recty2;
                SSIXPos.Text = xpos;
                SSIYPos.Text = ypos;
            }
            else
            {
                SSIDDX1.ReadOnly = true;
                SSIDDX2.ReadOnly = true;
                SSIDDY1.ReadOnly = true;
                SSIDDY2.ReadOnly = true;
                SSIXPos.ReadOnly = true;
                SSIYPos.ReadOnly = true;
                xposstore = xpos;
                yposstore = ypos;
                rectx1store = rectx1;
                rectx2store = rectx2;
                recty1store = recty1;
                recty2store = recty2;
                SSIDDX1.Text = "";
                SSIDDX2.Text = "";
                SSIDDY1.Text = "";
                SSIDDY2.Text = "";
                SSIXPos.Text = "";
                SSIYPos.Text = "";
            }
        }

        private void HexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) &&
               (e.KeyChar != 'A') && (e.KeyChar != 'a') &&
               (e.KeyChar != 'B') && (e.KeyChar != 'b') &&
               (e.KeyChar != 'C') && (e.KeyChar != 'c') &&
               (e.KeyChar != 'D') && (e.KeyChar != 'd') &&
               (e.KeyChar != 'E') && (e.KeyChar != 'e') &&
               (e.KeyChar != 'F') && (e.KeyChar != 'f'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter Hexadecimal numbers only");
            }
        }

        private void SSIXPos_TextChanged(object sender, EventArgs e)
        {
            xpos = SSIXPos.Text;
        }

        private void SSIYPos_TextChanged(object sender, EventArgs e)
        {
            ypos = SSIYPos.Text;
        }

        private void SSIDDX1_TextChanged(object sender, EventArgs e)
        {
            rectx1 = SSIDDX1.Text;
        }

        private void SSIDDX2_TextChanged(object sender, EventArgs e)
        {
            rectx2 = SSIDDX2.Text;
        }

        private void SSIDDY1_TextChanged(object sender, EventArgs e)
        {
            recty1 = SSIDDY1.Text;
        }

        private void SSIDDY2_TextChanged(object sender, EventArgs e)
        {
            recty2 = SSIDDY2.Text;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog textDialog;
            textDialog = new SaveFileDialog();
            textDialog.Filter = "YAML Files | *.yaml|All files (*.*)|*.*";
            textDialog.DefaultExt = "yaml";
            if (textDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.Stream fileStream = textDialog.OpenFile();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                sw.Write(Output.Text);
                logs.Text = "Saved file as " + ((FileStream)(sw.BaseStream)).Name;
                sw.Close();
            }
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Output.Text);
            logs.Text = "Copied output to the Clipboard !";
        }

        private void getAnExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActorNum.Value = 51;
            cppfilename.Text = "customsprite.cpp";
            customspritename.Text = "MyCustomSprite";
            ingamespritename.Text = "daCustomSprite_c";
            if (spritefileinfo.Checked)
            {
                spritefileinfotarget.Text = "CSarcNameList";
            }
            if (!spritefileinfo.Checked)
            {
                spritefileinfotarget.Text = "";
            }
            if (isSSI.Checked)
            {
                SSIXPos.Text = "00000008";
                SSIYPos.Text = "FFFFFFF8";
                SSIDDX1.Text = "00000000";
                SSIDDY1.Text = "00000000";
                SSIDDX2.Text = "00000010";
                SSIDDY2.Text = "00000010";
            }
            if (!isSSI.Checked)
            {
                SSIXPos.Text = "";
                SSIYPos.Text = "";
                SSIDDX1.Text = "";
                SSIDDY1.Text = "";
                SSIDDX2.Text = "";
                SSIDDY2.Text = "";
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SSIXPos.Text = "";
            SSIYPos.Text = "";
            SSIDDX1.Text = "";
            SSIDDY1.Text = "";
            SSIDDX2.Text = "";
            SSIDDY2.Text = "";
            spritefileinfotarget.Text = "";
            ActorNum.Value = 0;
            cppfilename.Text = "";
            customspritename.Text = "";
            ingamespritename.Text = "";
            isSSI.Checked = false;
            spritefileinfo.Checked = false;
            Output.Text = "";
            logs.Text = "Waiting for Action...";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            DialogResult dialogresult = a.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                a.Close();
            }
        }

        private void hexCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator a = new Calculator();
            DialogResult dialogresult = a.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                a.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SpriteName.SelectedIndex = 0;
            ActorIName.SelectedIndex = 0;
        }

        private void mapfileToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapfileTool a = new MapfileTool();
            DialogResult dialogresult = a.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                a.Close();
            }
        }

        private void isNormalHook_CheckedChanged(object sender, EventArgs e)
        {
            if(Output.Text != "" && Output.Text != null)
            {
                Generate_Click(sender, e);
            }
        }

        private void sub2AddressToolStripItem_Click(object sender, EventArgs e)
        {
            Sub2Address a = new Sub2Address();
            DialogResult dialogresult = a.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                a.Close();
            }
        }

        private void multiKamekToolStripItem_Click(object sender, EventArgs e)
        {
            MultiKamek a = new MultiKamek();
            a.Show();
        }
    }
}
