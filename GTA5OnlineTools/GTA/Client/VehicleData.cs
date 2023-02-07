﻿namespace GTA5OnlineTools.GTA.Client;

public static class VehicleData
{
    public class VehicleClass
    {
        public string Name;
        public string Icon;
        public List<VehicleInfo> VehicleInfo;
    }

    public class VehicleInfo
    {
        public string Name;
        public string Display;
        public uint Hash;
        public int[] Mod;
    }

    public enum VehicleModType
    {
        Spoilers = 0,
        FrontBumper = 1,
        RearBumper = 2,
        SideSkirt = 3,
        Exhaust = 4,
        Frame = 5,
        Grille = 6,
        Hood = 7,
        Fender = 8,
        RightFender = 9,
        Roof = 10,
        Engine = 11,
        Brakes = 12,
        Transmission = 13,
        Horns = 14,
        Suspension = 15,
        Armor = 16,
        FrontWheel = 23,
        RearWheel = 24,
        PlateHolder = 25,
        VanityPlates = 26,
        TrimDesign = 27,
        Ornaments = 28,
        Dashboard = 29,
        DialDesign = 30,
        DoorSpeakers = 31,
        Seats = 32,
        SteeringWheels = 33,
        ColumnShifterLevers = 34,
        Plaques = 35,
        Speakers = 36,
        Trunk = 37,
        Hydraulics = 38,
        EngineBlock = 39,
        AirFilter = 40,
        Struts = 41,
        ArchCover = 42,
        Aerials = 43,
        Trim = 44,
        Tank = 45,
        Windows = 46,
        Doors = 47,
        Livery = 48
    }

    /// <summary>
    /// ★常用载具
    /// </summary>
    public static List<VehicleInfo> CommonVehicle = new()
    {
        new VehicleInfo(){ Name="oppressor2", Display="佩嘉西 暴君 Mk 2", Hash=0x7B54A9D3, Mod=new int[43]{ 0,0,0,0,0,1,2,0,0,0,2,4,3,0,0,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="kuruma2", Display="卡林 骷髅马（装甲版）", Hash=0x187D938D, Mod=new int[43]{ 5,3,0,6,3,1,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,15 } },
        new VehicleInfo(){ Name="police3", Display="警用巡逻车", Hash=0x71FA16EA, Mod=new int[43]{ 2,2,2,2,1,2,0,2,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="ambulance", Display="救护车", Hash=0x45D56ADA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="buzzard", Display="秃鹰攻击直升机", Hash=0x2F03547B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dodo", Display="巨象 嘟嘟鸟", Hash=0xCA495705, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sanchez", Display="麦霸子 桑切斯（涂装版）", Hash=0x2EF89E46, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rhino", Display="犀牛坦克", Hash=0x2EA68690, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="hydra", Display="巨象 九头蛇", Hash=0x39D6E83F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="lazer", Display="P-996 天煞", Hash=0xB39B0AE6, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="taxi", Display="出租车", Hash=0xC703DB5F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="thruster", Display="巨象 推进者", Hash=0x58CDAF30, Mod=new int[43]{ 0,2,0,0,1,0,0,0,0,0,2,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="khanjali", Display="TM-02 可汗贾利", Hash=0xAA6F980A, Mod=new int[43]{ 0,0,0,0,0,1,0,0,0,1,1,4,3,0,58,0,5,50,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="savage", Display="野蛮人", Hash=0xFB133A17, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dinghy", Display="长崎 小艇", Hash=0x3D961290, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="patrolboat", Display="库尔兹 31 巡逻艇", Hash=0xEF813606, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 0 当前分类: 小型汽车
    /// </summary>
    public static List<VehicleInfo> Compacts = new()
    {
        new VehicleInfo(){ Name="asbo", Display="麦克斯韦 反社会", Hash=0x42ACA95F, Mod=new int[43]{ 15,6,0,12,8,4,2,11,4,4,6,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="blista", Display="丁卡 旅行家", Hash=0xEB70965F, Mod=new int[43]{ 0,1,1,1,1,0,0,1,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="brioso", Display="古罗帝 精力霸 R/A", Hash=0x5C55CB39, Mod=new int[43]{ 4,3,1,0,0,0,0,3,0,0,3,5,4,4,58,4,5,48,0,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,6 } },
        new VehicleInfo(){ Name="brioso2", Display="古罗帝 精力霸 300", Hash=0x55365079, Mod=new int[43]{ 4,7,4,3,5,1,0,2,3,2,11,4,3,3,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="brioso3", Display="古罗帝 精力霸 300 宽体版", Hash=0x00E827DE, Mod=new int[43]{ 13,11,7,3,5,5,7,11,8,6,14,4,3,3,58,5,5,36,0,0,0,10,0,5,0,8,14,16,0,0,0,11,0,8,0,0,9,0,0,0,0,0,18 } },
        new VehicleInfo(){ Name="club", Display="毕福 俱乐部", Hash=0x82E47E85, Mod=new int[43]{ 10,8,5,2,9,6,5,8,2,6,5,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,14 } },
        new VehicleInfo(){ Name="dilettante", Display="卡林 半吊子", Hash=0xBC993509, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,0,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dilettante2", Display="卡林 半吊子", Hash=0x64430650, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,0,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="issi2", Display="威尼 天威", Hash=0xB9CB3B69, Mod=new int[43]{ 0,1,1,1,1,0,0,1,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="issi3", Display="威尼 天威经典版", Hash=0x378236E1, Mod=new int[43]{ 9,9,5,8,9,6,9,13,12,6,6,4,3,3,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="issi4", Display="威尼 末日天威", Hash=0x256E92BA, Mod=new int[43]{ 3,3,0,2,4,3,4,13,3,5,1,4,3,4,58,5,5,50,0,0,11,0,4,0,0,0,0,0,0,8,0,0,0,0,4,3,3,1,0,2,0,0,4 } },
        new VehicleInfo(){ Name="issi5", Display="威尼 科幻天威", Hash=0x5BA0FF1E, Mod=new int[43]{ 5,5,4,8,6,3,4,13,8,5,1,4,3,4,58,5,5,50,0,0,0,0,8,4,0,0,0,0,0,0,0,0,0,0,4,3,3,1,0,2,0,0,18 } },
        new VehicleInfo(){ Name="issi6", Display="威尼 梦魇天威", Hash=0x49E25BA1, Mod=new int[43]{ 3,3,0,2,4,3,4,12,3,5,1,4,3,4,58,5,5,50,0,0,11,0,4,0,0,0,0,0,0,8,0,0,0,0,4,3,3,1,0,2,0,0,4 } },
        new VehicleInfo(){ Name="kanjo", Display="丁卡 旅行家羽黑", Hash=0x18619B7E, Mod=new int[43]{ 18,12,13,7,11,6,7,15,9,4,6,4,3,3,58,4,5,48,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,6,0,0,0,3,0,13 } },
        new VehicleInfo(){ Name="panto", Display="贝飞特 哑剧", Hash=0xE644E480, Mod=new int[43]{ 5,4,2,4,5,1,3,0,2,0,4,4,3,3,58,5,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="prairie", Display="包洛坎 原野行者", Hash=0xA988D3A2, Mod=new int[43]{ 6,7,2,7,6,0,0,9,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="rhapsody", Display="绝致 狂想曲", Hash=0x322CF98F, Mod=new int[43]{ 1,1,0,0,3,0,0,3,3,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="weevil", Display="毕福 象鼻虫", Hash=0x61FE4D6A, Mod=new int[43]{ 5,16,8,6,11,7,1,5,9,6,16,4,3,3,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,15 } },
    };

    /// <summary>
    /// 1 当前分类: 轿车
    /// </summary>
    public static List<VehicleInfo> Sedans = new()
    {
        new VehicleInfo(){ Name="asea", Display="绝致 海致", Hash=0x94204D89, Mod=new int[43]{ 1,4,0,0,1,0,0,3,1,1,2,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="asea2", Display="绝致 海致", Hash=0x9441D8D5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="asterope", Display="卡林 爱硕普", Hash=0x8E9254FB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cinquemila", Display="兰帕达缇 五千", Hash=0xA4F52C13, Mod=new int[43]{ 17,14,4,14,8,3,7,17,3,2,11,5,4,4,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="cog55", Display="埃努斯 至尊慧眼 55", Hash=0x360A438E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cog552", Display="埃努斯 至尊慧眼 55（装甲版）", Hash=0x29FCD3E4, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cognoscenti", Display="埃努斯 至尊慧眼", Hash=0x86FE0B60, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cognoscenti2", Display="埃努斯 至尊慧眼（装甲版）", Hash=0xDBF2D57A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="deity", Display="埃努斯 神灵", Hash=0x5B531351, Mod=new int[43]{ 18,8,5,12,11,1,11,13,3,1,9,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,1,0,0,12 } },
        new VehicleInfo(){ Name="emperor", Display="亚班尼 皇霸天", Hash=0xD7278283, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="emperor2", Display="亚班尼 皇霸天", Hash=0x8FC3AADC, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="emperor3", Display="亚班尼 皇霸天", Hash=0xB5FCF74E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="fugitive", Display="雪佛 流星", Hash=0x71CB2FFB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="glendale", Display="贝飞特 格伦戴尔", Hash=0x047A6BC1, Mod=new int[43]{ 3,1,0,1,3,0,0,5,0,0,3,4,3,3,58,6,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="glendale2", Display="贝飞特 格伦戴尔改装版", Hash=0xC98BBAD6, Mod=new int[43]{ 3,0,0,0,8,0,0,10,0,0,3,4,3,3,58,0,5,30,4,13,16,12,45,0,14,0,0,16,15,22,4,5,5,6,0,0,0,0,0,2,0,0,10 } },
        new VehicleInfo(){ Name="ingot", Display="福狮 英卡特", Hash=0xB3206692, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="intruder", Display="卡林 入侵者", Hash=0x34DD8AA1, Mod=new int[43]{ 1,1,1,1,1,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="limo2", Display="贝飞特 武装礼车", Hash=0xF92AEC4D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="premier", Display="绝致 统领", Hash=0x8FB66F9B, Mod=new int[43]{ 1,1,0,1,2,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="primo", Display="亚班尼 初代", Hash=0xBB6B404F, Mod=new int[43]{ 2,1,1,1,3,0,3,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="primo2", Display="亚班尼 初代改装版", Hash=0x86618EDA, Mod=new int[43]{ 2,4,1,1,4,0,5,3,0,0,0,4,3,3,58,0,5,50,4,13,16,4,45,0,7,0,0,16,15,22,4,7,4,6,5,0,0,4,3,3,0,0,9 } },
        new VehicleInfo(){ Name="regina", Display="敦追里 女皇", Hash=0xFF22D208, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rhinehart", Display="绝品 莱茵哈特", Hash=0x91673D0E, Mod=new int[43]{ 8,8,8,9,9,5,6,12,8,0,17,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="romero", Display="烈火马 钢骨灵车", Hash=0x2560B2FC, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="schafter2", Display="贝飞特 莎夫特", Hash=0xB52B5113, Mod=new int[43]{ 3,2,1,2,4,0,2,3,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="schafter5", Display="贝飞特 莎夫特 V12（装甲版）", Hash=0xCB0E7CD9, Mod=new int[43]{ 3,3,1,2,4,0,0,3,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="schafter6", Display="贝飞特 长轴莎夫特（装甲版）", Hash=0x72934BE4, Mod=new int[43]{ 3,3,1,2,4,0,0,3,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="stafford", Display="埃努斯 斯塔福德", Hash=0x1324E960, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,4,58,3,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="stanier", Display="威皮 史塔尼亚", Hash=0xA7EDE74D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="stratum", Display="赛柯尼 地层先锋", Hash=0x66B4FC45, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="stretch", Display="敦追里 加长型礼车", Hash=0x8B13F083, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="superd", Display="埃努斯 金钻耀星", Hash=0x42F2ED16, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="surge", Display="雪佛 奔腾", Hash=0x8F0E3594, Mod=new int[43]{ 1,1,1,1,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tailgater", Display="奥北 密探", Hash=0xC3DDFDCE, Mod=new int[43]{ 5,4,4,4,4,0,5,6,2,0,2,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tailgater2", Display="奥北 密探 S", Hash=0xB5D306A4, Mod=new int[43]{ 28,15,11,19,8,6,3,23,4,3,3,4,3,3,58,4,5,40,0,3,2,3,0,2,0,1,14,17,0,0,0,0,0,5,9,12,3,6,13,3,0,2,15 } },
        new VehicleInfo(){ Name="warrener", Display="福狮 守护星", Hash=0x51D83328, Mod=new int[43]{ 4,3,2,2,4,1,4,2,2,0,0,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="warrener2", Display="福狮 守护星 HKR", Hash=0x2290C50A, Mod=new int[43]{ 8,10,2,0,8,5,3,7,2,0,3,4,3,3,58,4,5,48,0,0,6,8,0,5,4,9,14,16,0,0,0,0,0,4,4,12,2,4,6,5,0,11,15 } },
        new VehicleInfo(){ Name="washington", Display="亚班尼 华盛顿", Hash=0x69F06B57, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 2 当前分类: SUV
    /// </summary>
    public static List<VehicleInfo> SUVs = new()
    {
        new VehicleInfo(){ Name="astron", Display="菲斯特 宇航", Hash=0x258C9364, Mod=new int[43]{ 9,8,8,9,5,15,3,15,2,0,2,5,4,4,58,3,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="baller", Display="悠游 行者", Hash=0xCFCA3668, Mod=new int[43]{ 0,2,1,1,1,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="baller2", Display="悠游 行者", Hash=0x08852855, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="baller3", Display="悠游 行者 LE", Hash=0x6FF0F727, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="baller4", Display="悠游 长轴行者 LE", Hash=0x25CBE2E2, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="baller5", Display="悠游 行者 LE（装甲版）", Hash=0x1C09CF5E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="baller6", Display="悠游 长轴行者 LE（装甲版）", Hash=0x27B4E6B0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="baller7", Display="悠游 行者 ST", Hash=0x1573422D, Mod=new int[43]{ 6,4,1,2,7,2,5,7,2,1,8,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,13 } },
        new VehicleInfo(){ Name="bjxl", Display="卡林 碧杰 XL", Hash=0x32B29A4B, Mod=new int[43]{ 0,1,0,1,0,0,0,0,0,0,1,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cavalcade", Display="亚班尼 骑兵", Hash=0x779F23AA, Mod=new int[43]{ 0,2,0,1,1,1,2,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cavalcade2", Display="亚班尼 骑兵", Hash=0xD0EB2BE5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="contender", Display="威皮 争夺者", Hash=0x28B67ACA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dubsta", Display="贝飞特 迪布达", Hash=0x462FE277, Mod=new int[43]{ 1,6,2,2,2,0,3,2,1,0,4,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dubsta2", Display="贝飞特 迪布达", Hash=0xE882E5F6, Mod=new int[43]{ 0,2,0,0,2,0,0,2,1,0,2,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="fq2", Display="深水 FQ 2", Hash=0xBC32A33B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="granger", Display="绝致 屌王", Hash=0x9628879C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="granger2", Display="绝致 屌王 3600LX", Hash=0xF06C29C7, Mod=new int[43]{ 2,2,3,3,8,1,4,7,3,1,2,4,3,3,58,4,5,38,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,1,0,0,12 } },
        new VehicleInfo(){ Name="gresley", Display="冒险家 情欲猎手", Hash=0xA3FC0F4D, Mod=new int[43]{ 0,1,1,1,1,0,0,1,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="habanero", Display="皇霸天 哈拔尼禄", Hash=0x34B7390F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="huntley", Display="埃努斯 亨特利 S", Hash=0x1D06D681, Mod=new int[43]{ 0,0,0,0,4,0,0,4,0,0,1,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="issi8", Display="威尼 天威拉力", Hash=0x5C6C00B4, Mod=new int[43]{ 16,3,4,6,3,11,5,12,8,4,12,5,4,4,58,5,5,40,0,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="iwagen", Display="奥北 爱瓦根", Hash=0x27816B7E, Mod=new int[43]{ 3,6,6,0,0,0,0,7,0,0,0,4,3,0,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="jubilee", Display="埃努斯 吉伯力", Hash=0x1B8165D3, Mod=new int[43]{ 2,15,9,17,6,1,0,17,0,1,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,1,0,0,9 } },
        new VehicleInfo(){ Name="landstalker", Display="敦追里 追捕者", Hash=0x4BA4E8DC, Mod=new int[43]{ 0,1,0,1,1,0,0,0,0,0,1,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="landstalker2", Display="敦追里 追捕者 XL", Hash=0xCE0B9F22, Mod=new int[43]{ 0,5,3,8,7,0,6,7,0,2,6,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="mesa", Display="卡尼斯 炎魔", Hash=0x36848602, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mesa2", Display="卡尼斯 炎魔", Hash=0xD36A4B44, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="novak", Display="兰帕达缇 诺瓦克", Hash=0x92F5024E, Mod=new int[43]{ 8,5,4,4,4,0,0,8,0,0,2,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="patriot", Display="巨象 爱国者", Hash=0xCFCFEB3B, Mod=new int[43]{ 0,2,2,0,2,0,0,3,0,0,1,4,3,3,58,3,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="patriot2", Display="巨象 爱国者加长型", Hash=0xE6E967F8, Mod=new int[43]{ 0,2,2,0,3,0,0,8,0,2,0,4,3,3,58,3,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="radi", Display="威皮 辐光", Hash=0x9D96B45B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rebla", Display="绝品 瑞巴 GTS", Hash=0x04F48FC4, Mod=new int[43]{ 8,8,3,8,7,5,9,13,7,2,2,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="rocoto", Display="奥北 小辣椒", Hash=0x7F5C91F1, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="seminole", Display="卡尼斯 陆上专家", Hash=0x48CECED3, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="seminole2", Display="卡尼斯 陆上专家边境", Hash=0x94114926, Mod=new int[43]{ 3,9,1,2,5,4,6,8,5,1,7,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="serrano", Display="贝飞特 瑟雷诺", Hash=0x4FB1A214, Mod=new int[43]{ 1,1,1,1,2,0,1,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="squaddie", Display="巨象 列兵", Hash=0xF9E67C05, Mod=new int[43]{ 13,13,8,14,9,5,19,14,7,16,9,4,3,3,58,5,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20 } },
        new VehicleInfo(){ Name="toros", Display="佩嘉西 奔牛", Hash=0xBA5334AC, Mod=new int[43]{ 8,9,4,6,12,0,14,12,1,0,8,4,3,4,58,5,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="xls", Display="贝飞特 XLS", Hash=0x47BBCF2E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="xls2", Display="贝飞特 XLS(装甲版)", Hash=0xE6401328, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 3 当前分类: 轿跑车
    /// </summary>
    public static List<VehicleInfo> Coupes = new()
    {
        new VehicleInfo(){ Name="cogcabrio", Display="埃努斯 至尊慧眼敞篷版", Hash=0x13B57D8A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="exemplar", Display="浪子 典范", Hash=0xFFB15B5E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="f620", Display="欧斯洛 F620", Hash=0xDCBCBE48, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="felon", Display="兰帕达缇 恶龙", Hash=0xE8A8BDA8, Mod=new int[43]{ 1,1,1,1,1,0,0,1,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="felon2", Display="兰帕达缇 恶龙 GT", Hash=0xFAAD85EE, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="jackal", Display="欧斯洛 胡狼", Hash=0xDAC67112, Mod=new int[43]{ 2,1,1,1,1,0,0,2,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="kanjosj", Display="丁卡 羽黑 SJ", Hash=0xFC2E479A, Mod=new int[43]{ 18,7,9,9,7,8,15,16,6,3,6,4,3,3,58,4,5,50,0,0,0,3,0,5,0,8,15,16,0,0,0,0,0,6,4,20,0,6,8,0,0,8,15 } },
        new VehicleInfo(){ Name="oracle", Display="绝品 先知 XS", Hash=0x506434F6, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="oracle2", Display="绝品 先知", Hash=0xE18195B2, Mod=new int[43]{ 0,0,0,0,3,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="postlude", Display="丁卡 后奏", Hash=0xEE6F8F79, Mod=new int[43]{ 13,5,5,0,18,5,0,19,5,0,8,4,3,3,58,4,5,48,0,0,7,3,0,5,0,7,14,16,0,0,0,0,0,6,0,15,5,0,0,0,4,5,13 } },
        new VehicleInfo(){ Name="previon", Display="卡林 普莱温", Hash=0x546DA331, Mod=new int[43]{ 10,4,2,5,7,5,5,12,2,2,2,4,3,3,58,4,5,50,0,0,8,8,0,4,4,8,14,16,0,0,0,0,0,4,25,20,9,6,0,0,5,2,15 } },
        new VehicleInfo(){ Name="sentinel", Display="绝品 卫士 XS", Hash=0x50732C82, Mod=new int[43]{ 30,13,8,13,6,8,0,23,3,3,7,5,4,4,58,5,5,50,0,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="sentinel2", Display="绝品 卫士", Hash=0x3412AE2D, Mod=new int[43]{ 4,1,1,1,3,0,0,1,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="windsor", Display="埃努斯 温莎", Hash=0x5E4327C8, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="windsor2", Display="埃努斯 温莎敞篷版", Hash=0x8CF5CAE1, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="zion", Display="绝品 绝品天堂", Hash=0xBD1B39C3, Mod=new int[43]{ 3,0,0,0,4,1,0,1,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="zion2", Display="绝品 绝品天堂敞篷版", Hash=0xB8E2AE18, Mod=new int[43]{ 3,0,0,0,4,1,0,1,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 4 当前分类: 肌肉车
    /// </summary>
    public static List<VehicleInfo> Muscle = new()
    {
        new VehicleInfo(){ Name="blade", Display="威皮 刀锋", Hash=0xB820ED5E, Mod=new int[43]{ 2,1,1,0,1,1,1,4,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="broadway", Display="卡拉斯科 百老汇", Hash=0x8CC51028, Mod=new int[43]{ 0,6,5,5,4,4,0,6,5,3,2,4,3,3,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="buccaneer", Display="亚班尼 风流海盗", Hash=0xD756460C, Mod=new int[43]{ 0,1,2,0,0,0,1,4,0,0,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="buccaneer2", Display="亚班尼 风流海盗改装版", Hash=0xC397F748, Mod=new int[43]{ 0,1,2,0,1,0,1,4,1,0,0,4,3,3,58,0,5,36,4,13,16,12,45,0,14,0,0,16,15,22,4,7,4,5,4,0,0,0,0,2,0,0,9 } },
        new VehicleInfo(){ Name="buffalo4", Display="冒险家 猛牛 STX", Hash=0xDB0C9B04, Mod=new int[43]{ 15,8,2,4,8,1,5,4,1,1,13,4,3,3,58,4,5,50,0,0,0,0,6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,1,0,0,12 } },
        new VehicleInfo(){ Name="chino", Display="威皮 奇诺", Hash=0x14D69010, Mod=new int[43]{ 0,1,1,0,1,2,0,2,0,2,0,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="chino2", Display="威皮 奇诺改装版", Hash=0xAED64A63, Mod=new int[43]{ 0,1,1,0,1,0,0,2,0,2,0,4,3,3,58,0,5,36,4,13,16,12,45,0,14,0,0,16,15,22,0,8,5,4,3,0,0,0,0,2,0,0,9 } },
        new VehicleInfo(){ Name="clique", Display="威皮 克里克", Hash=0xA29F78B0, Mod=new int[43]{ 1,4,4,0,0,1,7,2,2,0,3,4,3,4,58,5,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 } },
        new VehicleInfo(){ Name="coquette3", Display="非凡 艳妇黑鳍", Hash=0x2EC385FE, Mod=new int[43]{ 2,2,0,0,3,1,0,5,0,0,0,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="deviant", Display="赛乐斯特 异类", Hash=0x4C3FFF49, Mod=new int[43]{ 10,8,6,0,3,0,11,7,0,0,2,4,3,4,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="dominator", Display="威皮 公路霸者", Hash=0x04CE68AC, Mod=new int[43]{ 2,1,1,1,1,1,1,1,0,0,3,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dominator2", Display="威皮 尿汤啤公路霸者", Hash=0xC96B73D9, Mod=new int[43]{ 2,1,1,1,1,1,1,1,0,0,3,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dominator3", Display="威皮 公路霸者 GTX", Hash=0xC52C6B93, Mod=new int[43]{ 17,4,3,14,10,5,10,16,1,5,19,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dominator4", Display="威皮 末日公路霸者", Hash=0xD6FB0F30, Mod=new int[43]{ 3,1,0,1,5,3,6,3,0,5,0,4,3,4,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,7,0,0,0,0,4,3,3,1,0,2,0,0,4 } },
        new VehicleInfo(){ Name="dominator5", Display="威皮 科幻公路霸者", Hash=0xAE0A3D4F, Mod=new int[43]{ 0,1,0,1,5,3,3,0,0,5,0,4,3,4,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,3,3,1,0,2,0,0,18 } },
        new VehicleInfo(){ Name="dominator6", Display="威皮 梦魇公路霸者", Hash=0xB2E046FB, Mod=new int[43]{ 3,1,0,1,5,3,6,3,0,5,0,4,3,4,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,7,0,0,0,0,4,3,3,1,0,2,0,0,4 } },
        new VehicleInfo(){ Name="dominator7", Display="威皮 公路霸者 ASP", Hash=0x196F9418, Mod=new int[43]{ 23,14,13,18,8,5,3,25,1,6,3,4,3,3,58,4,5,50,0,0,0,3,0,4,6,6,14,16,0,0,0,0,0,4,25,16,4,6,3,1,2,11,15 } },
        new VehicleInfo(){ Name="dominator8", Display="威皮 公路霸者 GTT", Hash=0x2BE8B90A, Mod=new int[43]{ 9,2,5,6,6,5,3,17,5,0,4,4,3,3,58,4,5,50,0,0,7,2,0,0,0,0,14,16,0,0,0,0,0,6,14,12,8,5,0,3,0,0,15 } },
        new VehicleInfo(){ Name="dukes", Display="英庞提 公爵", Hash=0x2B26F456, Mod=new int[43]{ 1,1,1,0,2,2,0,5,0,0,26,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dukes2", Display="英庞提 死亡公爵", Hash=0xEC8F7094, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dukes3", Display="英庞提 比特公爵", Hash=0x7F3415E3, Mod=new int[43]{ 7,10,3,4,9,8,4,12,4,2,26,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,13 } },
        new VehicleInfo(){ Name="ellie", Display="威皮 爱利", Hash=0xB472D2B5, Mod=new int[43]{ 0,2,0,0,7,0,0,0,0,0,4,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="eudora", Display="威拉德 尤朵拉", Hash=0xB581BF9A, Mod=new int[43]{ 7,8,7,3,7,2,9,13,3,8,1,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 } },
        new VehicleInfo(){ Name="faction", Display="威拉德 宗派", Hash=0x81A9CDDF, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="faction2", Display="威拉德 宗派改装版", Hash=0x95466BDB, Mod=new int[43]{ 0,0,0,0,2,0,0,1,0,0,0,4,3,3,58,0,5,36,4,13,16,5,45,0,14,0,0,16,15,22,2,3,4,4,5,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="faction3", Display="威拉德 宗派改装巨轮版", Hash=0x866BCE26, Mod=new int[43]{ 0,0,0,0,2,0,0,1,0,0,0,4,3,3,58,0,5,36,4,13,16,5,45,0,14,0,0,16,15,22,2,7,0,4,5,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="gauntlet", Display="冒险家 铁腕", Hash=0x94B395C5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="gauntlet2", Display="冒险家 红木烟业铁腕", Hash=0x14D22159, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="gauntlet3", Display="冒险家 铁腕经典版", Hash=0x2B0C4DCD, Mod=new int[43]{ 8,4,3,7,5,6,5,13,1,2,8,4,3,4,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="gauntlet4", Display="冒险家 铁腕地狱火", Hash=0x734C5E50, Mod=new int[43]{ 10,6,1,2,5,6,6,10,6,9,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="gauntlet5", Display="冒险家 铁腕经典改装版", Hash=0x817AFAAD, Mod=new int[43]{ 17,13,5,8,10,2,6,12,7,2,3,4,3,3,58,4,5,36,0,0,3,3,6,4,4,5,5,13,0,6,0,0,0,8,0,0,6,2,3,5,0,0,10 } },
        new VehicleInfo(){ Name="greenwood", Display="冒险家 格林伍德", Hash=0x026ED430, Mod=new int[43]{ 11,4,2,2,12,1,2,0,11,1,3,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,0,5,0,2,0,0,0,12 } },
        new VehicleInfo(){ Name="hermes", Display="亚班尼 赫耳墨斯", Hash=0x00E83C17, Mod=new int[43]{ 0,8,2,1,1,0,0,0,1,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 } },
        new VehicleInfo(){ Name="hotknife", Display="威皮 热情使徒", Hash=0x0239E390, Mod=new int[43]{ 0,0,0,0,0,1,0,2,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="hustler", Display="威皮 赫斯勒", Hash=0x23CA25F2, Mod=new int[43]{ 0,2,2,2,4,0,6,4,0,0,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="impaler", Display="绝致 刺刑官", Hash=0x83070B62, Mod=new int[43]{ 3,2,4,0,4,0,2,7,0,0,0,4,3,4,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="impaler2", Display="绝致 末日刺刑官", Hash=0x3C26BD0C, Mod=new int[43]{ 2,3,1,0,1,3,0,2,3,5,1,4,3,4,58,0,5,36,36,0,0,0,1,0,0,0,0,0,0,8,1,0,0,0,4,3,3,1,0,2,0,0,4 } },
        new VehicleInfo(){ Name="impaler3", Display="绝致 科幻刺刑官", Hash=0x8D45DF49, Mod=new int[43]{ 3,3,1,0,0,3,0,3,0,5,3,4,3,4,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,3,3,1,0,2,0,0,18 } },
        new VehicleInfo(){ Name="impaler4", Display="绝致 梦魇刺刑官", Hash=0x9804F4C7, Mod=new int[43]{ 2,3,1,0,1,3,0,2,3,5,1,4,3,4,58,0,5,36,36,0,0,0,1,0,0,0,0,0,0,8,1,0,0,0,4,3,3,1,0,2,0,0,4 } },
        new VehicleInfo(){ Name="imperator", Display="威皮 末日凯撒大帝", Hash=0x1A861243, Mod=new int[43]{ 0,0,0,0,6,3,3,7,0,5,1,4,3,3,58,4,5,36,0,0,0,0,3,0,0,0,0,0,0,7,0,0,0,0,4,3,4,1,1,2,0,0,4 } },
        new VehicleInfo(){ Name="imperator2", Display="威皮 科幻凯撒大帝", Hash=0x619C1B82, Mod=new int[43]{ 0,0,0,0,4,3,0,7,0,5,1,4,3,3,58,4,5,36,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,4,3,4,1,1,2,0,0,18 } },
        new VehicleInfo(){ Name="imperator3", Display="威皮 梦魇凯撒大帝", Hash=0xD2F77E37, Mod=new int[43]{ 0,0,0,0,6,3,3,7,0,5,1,4,3,3,58,4,5,36,0,0,0,0,3,0,0,0,0,0,0,7,0,0,0,0,4,3,4,1,1,2,0,0,4 } },
        new VehicleInfo(){ Name="lurcher", Display="亚班尼 闹鬼灵车", Hash=0x7B47A6A7, Mod=new int[43]{ 0,1,1,0,3,0,1,4,0,0,0,4,3,3,58,4,5,36,0,0,0,0,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="manana2", Display="亚班尼 明日之星改装版", Hash=0x665F785D, Mod=new int[43]{ 0,3,0,0,1,0,1,0,2,0,0,4,3,3,58,0,5,30,4,13,16,14,45,0,14,0,0,16,15,22,0,5,5,4,5,0,2,0,0,2,0,0,12 } },
        new VehicleInfo(){ Name="moonbeam", Display="绝致 月光", Hash=0x1F52A43F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="moonbeam2", Display="绝致 月光改装版", Hash=0x710A2B9B, Mod=new int[43]{ 1,0,0,0,1,1,2,0,0,0,2,4,3,3,58,0,5,36,6,13,16,4,45,0,14,5,1,16,15,22,0,5,4,4,3,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="nightshade", Display="英庞提 暗夜魅影", Hash=0x8C2BD0DC, Mod=new int[43]{ 4,1,1,0,1,1,3,4,0,0,0,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="peyote2", Display="威皮 佩优特古董赛车", Hash=0x9472CD24, Mod=new int[43]{ 0,0,0,0,11,5,5,17,0,0,0,4,3,3,58,4,5,36,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="phoenix", Display="英庞提 不死鸟", Hash=0x831A21D5, Mod=new int[43]{ 2,2,0,1,2,0,1,3,0,0,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="picador", Display="雪佛 斗牛士", Hash=0x59E0FBF3, Mod=new int[43]{ 6,8,9,1,0,3,2,4,1,8,3,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="ratloader", Display="老爷卡车", Hash=0xD83C13CE, Mod=new int[43]{ 0,0,0,0,4,1,4,6,2,0,4,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="ratloader2", Display="冒险家 老爷货车", Hash=0xDCE1D9F7, Mod=new int[43]{ 0,0,0,0,4,1,3,5,2,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="ruiner", Display="英庞提 灭世暴徒", Hash=0xF26CEFF9, Mod=new int[43]{ 4,2,0,0,4,0,0,3,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="ruiner2", Display="英庞提 灭世暴徒 2000", Hash=0x381E10BD, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="ruiner3", Display="英庞提 灭世暴徒", Hash=0x2E5AFD37, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="ruiner4", Display="英庞提 灭世暴徒 ZZ-8", Hash=0x65BDEBFC, Mod=new int[43]{ 21,19,11,15,11,3,3,20,6,2,5,4,3,3,58,2,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="sabregt", Display="绝致 军刀涡轮", Hash=0x9B909C94, Mod=new int[43]{ 1,4,1,0,3,2,2,5,0,0,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sabregt2", Display="绝致 军刀涡轮改装版", Hash=0x0D4EA603, Mod=new int[43]{ 1,4,1,0,3,2,2,5,0,0,0,4,3,3,58,4,5,36,4,13,16,14,45,0,14,0,0,16,15,22,2,5,4,7,4,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="slamvan", Display="威皮 大满贯皮卡", Hash=0x2B7F9DE3, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="slamvan2", Display="威皮 失落摩托帮大满贯皮卡", Hash=0x31ADBBFC, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="slamvan3", Display="威皮 大满贯皮卡改装版", Hash=0x42BC5E19, Mod=new int[43]{ 2,1,0,0,5,0,5,4,0,0,1,4,3,3,58,4,5,36,4,13,16,3,45,2,14,0,11,16,15,22,0,0,4,4,5,0,0,0,0,2,1,0,9 } },
        new VehicleInfo(){ Name="slamvan4", Display="威皮 末日大满贯皮卡", Hash=0x8526E2F5, Mod=new int[43]{ 0,0,3,0,0,3,4,5,0,5,0,4,3,3,58,0,5,36,0,0,0,0,0,0,0,0,0,0,0,3,1,0,0,0,4,3,6,1,1,2,0,0,4 } },
        new VehicleInfo(){ Name="slamvan5", Display="威皮 科幻大满贯皮卡", Hash=0x163F8520, Mod=new int[43]{ 0,0,3,0,0,3,4,0,0,5,0,4,3,3,58,0,5,36,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,4,3,6,1,1,2,0,0,18 } },
        new VehicleInfo(){ Name="slamvan6", Display="威皮 梦魇大满贯皮卡", Hash=0x67D52852, Mod=new int[43]{ 1,0,3,0,0,3,4,5,0,5,0,4,3,3,58,0,5,36,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,4,3,6,1,1,2,0,0,4 } },
        new VehicleInfo(){ Name="stalion", Display="绝致 种马", Hash=0x72A4C31E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="stalion2", Display="绝致 吃得饱汉堡种马", Hash=0xE80F67EE, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tahoma", Display="绝致 塔霍马轿跑车", Hash=0xE478B977, Mod=new int[43]{ 0,4,4,0,9,0,3,7,7,0,10,5,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="tampa", Display="绝致 坦帕", Hash=0x39F9C898, Mod=new int[43]{ 3,4,3,0,1,1,4,4,0,0,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tampa3", Display="绝致 武装坦帕", Hash=0xB7D9F7F1, Mod=new int[43]{ 0,1,1,0,0,3,0,3,0,1,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="tulip", Display="绝致 郁金", Hash=0x56D42971, Mod=new int[43]{ 6,7,1,0,4,0,0,11,0,0,0,4,3,4,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="tulip2", Display="绝致 郁金 M-100", Hash=0x1004EDA4, Mod=new int[43]{ 14,5,4,2,8,6,5,11,1,2,2,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16 } },
        new VehicleInfo(){ Name="vamos", Display="绝致 瓦魔狮", Hash=0xFD128DFD, Mod=new int[43]{ 8,6,3,0,6,2,6,10,3,0,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="vigero", Display="绝致 活力够", Hash=0xCEC6B9B7, Mod=new int[43]{ 2,0,0,0,1,1,0,5,0,0,1,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="vigero2", Display="绝致 活力够 ZX", Hash=0x973141FC, Mod=new int[43]{ 16,17,15,17,8,3,9,29,14,6,3,5,4,4,58,5,5,36,0,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,13 } },
        new VehicleInfo(){ Name="virgo", Display="亚班尼 室女座", Hash=0xE2504942, Mod=new int[43]{ 0,1,1,0,1,3,1,2,1,0,0,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="virgo2", Display="敦追里 经典室女座改装版", Hash=0xCA62927A, Mod=new int[43]{ 0,0,0,0,3,1,3,0,0,0,0,4,3,3,58,0,5,36,4,13,16,4,45,0,14,0,0,16,15,22,5,6,4,5,4,0,0,3,2,4,0,0,9 } },
        new VehicleInfo(){ Name="virgo3", Display="敦追里 经典室女座", Hash=0x00FDFFB0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="voodoo", Display="绝致 巫毒改装版", Hash=0x779B4F2D, Mod=new int[43]{ 0,2,0,0,2,1,3,0,0,0,0,4,3,3,58,0,5,30,5,13,16,12,45,0,8,0,0,16,15,22,0,5,5,4,3,0,3,3,8,3,0,0,9 } },
        new VehicleInfo(){ Name="voodoo2", Display="绝致 巫毒", Hash=0x1F3766E3, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="weevil2", Display="毕福 象鼻虫改装版", Hash=0xC4BB1908, Mod=new int[43]{ 8,13,7,6,14,4,11,8,8,0,16,4,3,3,58,4,5,36,0,0,0,10,0,0,0,0,8,18,15,0,0,0,0,0,0,0,10,10,0,0,8,6,16 } },
        new VehicleInfo(){ Name="yosemite", Display="绝致 约塞米蒂", Hash=0x6F946279, Mod=new int[43]{ 10,11,1,11,0,3,4,9,0,0,4,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="yosemite2", Display="绝致 漂移约塞米蒂", Hash=0x64F49967, Mod=new int[43]{ 9,11,1,11,1,3,4,5,1,0,4,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
    };

    /// <summary>
    /// 5 当前分类: 经典跑车
    /// </summary>
    public static List<VehicleInfo> SportsClassics = new()
    {
        new VehicleInfo(){ Name="ardent", Display="欧斯洛 炽焰", Hash=0x097E5533, Mod=new int[43]{ 3,5,1,0,1,0,0,6,2,0,6,4,3,4,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="btype", Display="亚班尼 罗斯福", Hash=0x06FF6914, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="btype2", Display="亚班尼 科学怪人", Hash=0xCE6B35A4, Mod=new int[43]{ 0,0,0,0,0,0,0,2,0,0,0,4,3,3,58,4,5,36,0,0,0,0,45,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4 } },
        new VehicleInfo(){ Name="btype3", Display="亚班尼 罗斯福勇气", Hash=0xDC19D101, Mod=new int[43]{ 2,2,2,1,0,3,2,3,2,1,1,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,3,0,2,0,0 } },
        new VehicleInfo(){ Name="casco", Display="兰帕达缇 卡斯科", Hash=0x3822BDFE, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cheburek", Display="卢恩 切布列克", Hash=0xC514AAE0, Mod=new int[43]{ 9,8,4,2,0,0,2,8,2,0,7,4,3,3,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="cheetah2", Display="古罗帝 猎豹经典版", Hash=0x0D4E5F4D, Mod=new int[43]{ 18,8,1,5,3,0,0,4,2,4,4,4,3,4,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="coquette2", Display="非凡 艳妇经典版", Hash=0x3C4E2113, Mod=new int[43]{ 0,7,3,0,4,1,0,2,0,0,0,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="deluxo", Display="英庞提 德罗索", Hash=0x586765FB, Mod=new int[43]{ 8,3,0,2,3,0,9,4,0,0,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dynasty", Display="威尼 王朝", Hash=0x127E90D5, Mod=new int[43]{ 5,6,6,8,4,0,6,6,6,6,7,4,3,3,58,5,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="fagaloa", Display="福狮 法加洛亚", Hash=0x6068AD86, Mod=new int[43]{ 4,5,2,9,2,1,5,0,3,6,6,4,3,3,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="feltzer3", Display="贝飞特 斯特林 GT", Hash=0xA29D6D10, Mod=new int[43]{ 4,0,1,0,2,3,2,11,0,0,5,5,4,4,58,5,5,50,0,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,22 } },
        new VehicleInfo(){ Name="gt500", Display="古罗帝 GT500", Hash=0x8408F33A, Mod=new int[43]{ 0,2,0,0,2,0,0,2,0,0,0,4,3,3,58,3,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="infernus2", Display="佩嘉西 炼狱魔经典版", Hash=0xAC33179C, Mod=new int[43]{ 6,0,0,3,3,6,6,0,3,0,4,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="jb700", Display="浪子 JB 700", Hash=0x3EAB5555, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="jb7002", Display="浪子 JB 700W", Hash=0x177DA45C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,2,1,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mamba", Display="绝致 曼巴", Hash=0x9CFFFC56, Mod=new int[43]{ 0,0,0,0,1,0,0,5,0,0,0,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="manana", Display="亚班尼 明日之星", Hash=0x81634188, Mod=new int[43]{ 0,3,1,0,2,2,1,2,1,0,0,4,3,3,58,0,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="michelli", Display="兰帕达缇 米其利 GT", Hash=0x3E5BD8D9, Mod=new int[43]{ 4,7,2,3,6,2,5,1,3,0,4,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="monroe", Display="佩嘉西 门罗", Hash=0xE62B361B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,3,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="nebula", Display="福狮 星云涡轮", Hash=0xCB642637, Mod=new int[43]{ 7,8,1,1,3,1,3,7,1,2,5,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="peyote", Display="威皮 佩优特", Hash=0x6D19CCBC, Mod=new int[43]{ 0,1,3,0,1,2,4,3,1,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="peyote3", Display="威皮 佩优特改装版", Hash=0x4201A843, Mod=new int[43]{ 0,0,0,0,5,2,4,6,0,1,0,4,3,3,58,0,5,30,4,13,16,14,45,0,8,0,0,16,15,22,4,5,5,6,0,0,0,3,0,2,0,0,10 } },
        new VehicleInfo(){ Name="pigalle", Display="兰帕达缇 皮卡乐", Hash=0x404B6381, Mod=new int[43]{ 1,0,0,0,2,0,0,3,0,0,4,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rapidgt3", Display="浪子 疾速 GT 经典版", Hash=0x7A2EF5E4, Mod=new int[43]{ 5,4,3,2,16,1,3,0,5,5,4,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="retinue", Display="威皮 随行者", Hash=0x6DBD6C0A, Mod=new int[43]{ 5,4,1,1,4,1,3,2,1,0,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="retinue2", Display="威皮 随行者 Mk 2", Hash=0x79178F0A, Mod=new int[43]{ 6,6,1,0,0,5,4,8,6,2,5,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="savestra", Display="爱尼仕 萨维斯特拉", Hash=0x35DED0DD, Mod=new int[43]{ 9,12,6,4,5,8,12,6,7,0,1,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="stinger", Display="古罗帝 史汀格", Hash=0x5C23AF9B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="stingergt", Display="古罗帝 史汀格 GT", Hash=0x82E499FA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="stromberg", Display="欧斯洛 斯特龙伯格", Hash=0x34DBA661, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="swinger", Display="欧斯洛 放荡者", Hash=0x1DD4C0FF, Mod=new int[43]{ 0,2,0,4,4,10,4,11,0,0,3,4,3,3,58,3,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="toreador", Display="佩嘉西 图拉尔多", Hash=0x56C8A5EF, Mod=new int[43]{ 10,9,9,0,0,0,10,0,0,0,2,4,3,3,58,2,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="torero", Display="佩嘉西 斗牛", Hash=0x59A9E570, Mod=new int[43]{ 6,2,3,0,3,0,5,4,0,4,5,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tornado", Display="绝致 龙卷风", Hash=0x1BB290BC, Mod=new int[43]{ 0,2,0,0,2,0,0,3,4,1,0,4,3,3,58,0,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tornado2", Display="绝致 龙卷风", Hash=0x5B42A5C4, Mod=new int[43]{ 0,2,0,0,2,0,0,3,4,1,0,4,3,3,58,0,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tornado3", Display="绝致 龙卷风", Hash=0x690A4153, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tornado4", Display="绝致 龙卷风", Hash=0x86CF7CDD, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tornado5", Display="绝致 龙卷风改装版", Hash=0x94DA98EF, Mod=new int[43]{ 0,2,3,0,4,0,0,5,0,1,0,4,3,3,58,0,5,30,5,13,16,14,45,8,14,0,0,16,15,22,0,3,6,5,4,0,6,3,8,3,0,0,9 } },
        new VehicleInfo(){ Name="tornado6", Display="绝致 龙卷风破烂老爷车", Hash=0xA31CB573, Mod=new int[43]{ 0,0,0,0,1,0,0,2,0,0,0,4,3,3,58,0,5,30,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="turismo2", Display="古罗帝 远途经典版", Hash=0xC575DF11, Mod=new int[43]{ 13,6,0,2,4,0,0,7,2,0,3,5,4,4,58,1,5,40,0,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="viseris", Display="兰帕达缇 维瑟瑞斯", Hash=0xE8A8BA94, Mod=new int[43]{ 10,5,2,4,7,3,7,3,2,0,1,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="z190", Display="卡林 190z", Hash=0x3201DD49, Mod=new int[43]{ 21,16,14,18,14,12,11,17,9,9,12,4,3,3,58,3,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="zion3", Display="绝品 天堂经典版", Hash=0x6F039A67, Mod=new int[43]{ 8,7,3,10,5,3,2,8,3,2,5,4,3,4,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="ztype", Display="特卢菲 Z 型", Hash=0x2D3BD401, Mod=new int[43]{ 0,1,0,1,0,0,2,1,0,0,0,4,3,3,58,0,5,30,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 6 当前分类: 跑车
    /// </summary>
    public static List<VehicleInfo> Sports = new()
    {
        new VehicleInfo(){ Name="alpha", Display="亚班尼 阿尔法", Hash=0x2DB8D1AA, Mod=new int[43]{ 4,1,0,1,2,0,0,2,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="banshee", Display="冒险家 女妖", Hash=0xC1E908D2, Mod=new int[43]{ 5,1,0,0,2,0,0,2,0,0,0,5,4,4,58,5,5,50,0,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,17 } },
        new VehicleInfo(){ Name="bestiagts", Display="古罗帝 野兽 GTS", Hash=0x4BFCF28B, Mod=new int[43]{ 2,3,0,3,1,0,0,3,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blista2", Display="丁卡 小型旅行家", Hash=0x3DEE5EDA, Mod=new int[43]{ 3,0,0,1,3,1,0,2,0,0,1,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blista3", Display="丁卡 冲冲猴旅行家", Hash=0xDCBC1C3B, Mod=new int[43]{ 3,0,0,1,3,1,0,2,0,0,1,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="buffalo", Display="冒险家 猛牛", Hash=0xEDD516C6, Mod=new int[43]{ 1,1,1,1,1,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="buffalo2", Display="冒险家 猛牛 S", Hash=0x2BEC3CBE, Mod=new int[43]{ 5,5,2,2,5,1,4,4,0,0,2,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="buffalo3", Display="冒险家 霜碧猛牛", Hash=0x0E2C013E, Mod=new int[43]{ 5,5,2,2,5,1,4,4,0,0,2,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="calico", Display="卡林 卡利科 GTF", Hash=0xB8D657AD, Mod=new int[43]{ 22,27,7,24,10,7,2,26,3,0,20,4,3,3,58,4,5,40,0,3,0,0,0,4,0,7,15,17,0,0,0,0,0,4,8,11,3,6,2,5,0,2,15 } },
        new VehicleInfo(){ Name="carbonizzare", Display="古罗帝 汗血宝马", Hash=0x7B8AB45F, Mod=new int[43]{ 2,0,0,0,1,0,0,1,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="comet2", Display="菲斯特 陆上彗星", Hash=0xC1AE4D16, Mod=new int[43]{ 2,2,0,0,1,1,0,0,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="comet3", Display="菲斯特 陆上彗星怀旧改装版", Hash=0x877358AD, Mod=new int[43]{ 8,19,4,9,4,5,0,9,8,0,0,4,3,3,58,4,5,50,0,0,0,2,0,5,8,6,14,16,0,0,0,0,0,0,0,12,0,3,0,0,0,0,9 } },
        new VehicleInfo(){ Name="comet4", Display="菲斯特 彗星狩猎者", Hash=0x5D1903F9, Mod=new int[43]{ 3,18,2,6,15,5,3,10,3,6,1,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="comet5", Display="菲斯特 陆上彗星 SR", Hash=0x276D98A3, Mod=new int[43]{ 8,3,2,3,4,2,0,2,1,0,2,4,3,3,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="comet6", Display="菲斯特 陆上彗星 S2", Hash=0x991EFC04, Mod=new int[43]{ 24,8,10,10,5,7,0,14,4,3,2,4,3,3,58,4,5,50,0,3,5,2,0,7,0,4,14,16,0,0,0,0,0,0,0,0,9,7,6,0,3,0,15 } },
        new VehicleInfo(){ Name="comet7", Display="菲斯特 陆上彗星 S2 敞篷版", Hash=0x440851D8, Mod=new int[43]{ 5,8,10,10,5,0,0,14,4,0,0,4,3,3,58,4,5,50,0,0,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 } },
        new VehicleInfo(){ Name="coquette", Display="非凡 艳妇", Hash=0x067BC037, Mod=new int[43]{ 5,4,4,2,4,1,0,5,1,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="coquette4", Display="非凡 艳妇 D10", Hash=0x98F65A5E, Mod=new int[43]{ 8,5,4,3,6,3,3,6,0,0,3,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="corsita", Display="兰帕达缇 科西塔", Hash=0xD3046147, Mod=new int[43]{ 15,11,10,12,5,3,8,14,9,4,18,4,3,3,58,2,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 } },
        new VehicleInfo(){ Name="cypher", Display="绝品 塞弗", Hash=0x68A5D1EF, Mod=new int[43]{ 14,12,5,9,8,9,13,14,2,5,8,4,3,3,58,4,5,40,0,0,2,9,2,4,1,8,11,16,0,0,0,0,0,12,0,17,9,8,7,4,0,0,15 } },
        new VehicleInfo(){ Name="drafter", Display="奥北 8F 尾随者", Hash=0x28EAB80F, Mod=new int[43]{ 8,3,3,3,6,3,4,9,1,3,6,4,3,4,58,5,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="elegy", Display="爱尼仕 挽歌怀旧改装版", Hash=0x0BBA2261, Mod=new int[43]{ 20,6,3,5,9,5,3,12,6,0,7,4,3,3,58,4,5,50,0,3,4,1,0,5,15,7,14,16,0,0,0,0,0,4,8,12,6,11,2,5,2,0,9 } },
        new VehicleInfo(){ Name="elegy2", Display="爱尼仕 挽歌 RH8", Hash=0xDE3D9D22, Mod=new int[43]{ 5,2,3,4,2,1,2,3,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="euros", Display="爱尼仕 欧洲", Hash=0x7980BDD5, Mod=new int[43]{ 16,3,3,12,6,8,0,21,9,0,11,4,3,3,58,4,5,40,0,0,8,2,0,3,0,8,15,16,0,0,0,0,0,4,10,20,8,6,15,0,0,2,15 } },
        new VehicleInfo(){ Name="everon2", Display="卡林 燃轨埃弗伦", Hash=0xF82BC92E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,29 } },
        new VehicleInfo(){ Name="feltzer2", Display="贝飞特 飞特者", Hash=0x8911B9F5, Mod=new int[43]{ 2,1,1,0,0,0,0,0,1,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="flashgt", Display="威皮 闪电 GT", Hash=0xB4F32118, Mod=new int[43]{ 8,6,0,6,4,6,0,5,0,0,3,4,3,3,58,5,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="furoregt", Display="兰帕达缇 沸洛雷 GT", Hash=0xBF1691E0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="fusilade", Display="赛乐斯特 眩光", Hash=0x1DC0BA53, Mod=new int[43]{ 3,1,0,1,3,0,0,2,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="futo", Display="卡林 福多", Hash=0x7836CE2F, Mod=new int[43]{ 4,3,3,1,3,1,2,2,0,0,1,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="futo2", Display="卡林 福多 GTX", Hash=0xA6297CC8, Mod=new int[43]{ 16,7,2,3,13,5,6,15,3,2,5,4,3,3,58,4,5,48,0,4,2,2,0,5,0,0,14,16,0,0,0,0,0,4,8,12,6,0,3,3,3,7,15 } },
        new VehicleInfo(){ Name="gb200", Display="威皮 GB200", Hash=0x71CBEA98, Mod=new int[43]{ 3,4,3,1,1,5,3,10,1,0,1,4,3,3,58,5,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="growler", Display="菲斯特 嚎叫者", Hash=0x4DC079D7, Mod=new int[43]{ 7,3,5,8,18,12,6,16,2,2,5,4,3,3,58,4,5,50,0,9,14,9,0,3,3,4,14,16,0,0,0,0,0,0,0,15,0,9,0,0,5,4,15 } },
        new VehicleInfo(){ Name="hotring", Display="绝致 燃轨军刀", Hash=0x42836BE5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,31 } },
        new VehicleInfo(){ Name="imorgon", Display="傲弗拉 明日", Hash=0xBC7C0A00, Mod=new int[43]{ 14,8,20,2,5,24,2,7,18,2,2,4,3,3,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="issi7", Display="威尼 天威跑车版", Hash=0x6E8DA4F7, Mod=new int[43]{ 5,6,3,6,7,0,3,10,4,2,7,4,3,4,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="italigto", Display="古罗帝 义塔力 GTO", Hash=0xEC3E3404, Mod=new int[43]{ 8,9,4,6,5,1,3,10,3,0,8,4,3,4,58,5,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 } },
        new VehicleInfo(){ Name="italirsx", Display="古罗帝 义塔力 RSX", Hash=0xBB78956A, Mod=new int[43]{ 20,5,14,9,8,5,7,13,0,2,7,4,3,3,58,2,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 } },
        new VehicleInfo(){ Name="jester", Display="丁卡 弄臣", Hash=0xB2A716A3, Mod=new int[43]{ 4,3,2,3,3,2,0,0,0,0,1,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="jester2", Display="丁卡 弄臣（赛车）", Hash=0xBE0E6126, Mod=new int[43]{ 4,3,2,3,3,2,0,0,0,0,1,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="jester3", Display="丁卡 弄臣经典版", Hash=0xF330CB6A, Mod=new int[43]{ 10,12,4,2,4,4,5,10,2,0,3,4,3,3,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="jester4", Display="丁卡 弄臣 RR", Hash=0xA1B3A871, Mod=new int[43]{ 14,12,11,9,13,9,8,13,2,5,5,4,3,3,58,4,5,36,0,0,3,11,2,4,4,8,11,16,0,0,0,0,0,5,9,17,3,0,2,8,0,0,15 } },
        new VehicleInfo(){ Name="jugular", Display="欧斯洛 扼喉", Hash=0xF38C4245, Mod=new int[43]{ 10,3,2,4,2,0,3,7,2,0,1,4,3,4,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="khamelion", Display="海岬 变色龙", Hash=0x206D1B68, Mod=new int[43]{ 2,0,0,0,2,0,0,2,0,0,2,4,3,0,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="komoda", Display="兰帕达缇 科莫达", Hash=0xCE44C4B9, Mod=new int[43]{ 24,12,4,18,4,0,0,17,3,2,11,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="kuruma", Display="卡林 骷髅马", Hash=0xAE2BFE94, Mod=new int[43]{ 5,3,0,6,3,1,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,15 } },
        new VehicleInfo(){ Name="kuruma2", Display="卡林 骷髅马（装甲版）", Hash=0x187D938D, Mod=new int[43]{ 5,3,0,6,3,1,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,15 } },
        new VehicleInfo(){ Name="locust", Display="欧斯洛 蝗虫", Hash=0xC7E55211, Mod=new int[43]{ 9,8,0,6,6,12,0,5,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="lynx", Display="欧斯洛 山猫", Hash=0x1CBDC10B, Mod=new int[43]{ 4,4,5,1,4,1,0,4,0,0,0,4,3,3,58,5,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="massacro", Display="浪子 马萨克罗", Hash=0xF77ADE32, Mod=new int[43]{ 4,3,2,4,1,2,0,3,1,0,0,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="massacro2", Display="浪子 马萨克罗（赛车）", Hash=0xDA5819A3, Mod=new int[43]{ 4,3,2,4,1,2,0,3,1,0,0,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="neo", Display="维沙 尼欧", Hash=0x9F6ED5A2, Mod=new int[43]{ 9,8,3,4,13,8,12,10,2,0,6,4,3,4,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="neon", Display="菲斯特 霓虹", Hash=0x91CA96EE, Mod=new int[43]{ 6,6,2,9,0,0,0,2,5,0,0,4,3,0,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="ninef", Display="奥北 9F", Hash=0x3D8FA25C, Mod=new int[43]{ 1,1,1,1,1,0,0,1,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="ninef2", Display="奥北 9F 敞篷版", Hash=0xA8E38B01, Mod=new int[43]{ 1,1,1,1,3,1,0,1,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="omnis", Display="奥北 奥姆尼斯", Hash=0xD1AD4937, Mod=new int[43]{ 2,0,0,0,1,0,0,0,0,0,0,4,3,3,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="omnisegt", Display="奥北 奥姆尼斯 e-GT", Hash=0xE1E2E6D7, Mod=new int[43]{ 8,6,6,3,0,1,3,2,2,1,9,4,3,0,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,15 } },
        new VehicleInfo(){ Name="panthere", Display="苔原 潘瑟力", Hash=0x7D326F04, Mod=new int[43]{ 9,17,11,21,8,3,9,24,6,9,11,5,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="paragon", Display="埃努斯 帕拉贡 R", Hash=0xE550775B, Mod=new int[43]{ 4,8,3,3,5,6,5,10,2,0,2,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="paragon2", Display="埃努斯 帕拉贡 R（装甲版）", Hash=0x546D8EEE, Mod=new int[43]{ 4,8,3,3,5,6,5,10,2,0,2,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="pariah", Display="欧斯洛 放逐者", Hash=0x33B98FE2, Mod=new int[43]{ 12,8,2,2,0,0,0,11,0,0,2,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="penumbra", Display="麦霸子 半影使者", Hash=0xE9805550, Mod=new int[43]{ 4,2,3,2,2,1,1,3,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="penumbra2", Display="麦霸子 半影使者 FF", Hash=0xDA5EC7DA, Mod=new int[43]{ 22,10,8,15,9,12,16,13,4,2,6,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="r300", Display="爱尼仕 300R", Hash=0x402586F8, Mod=new int[43]{ 15,12,3,9,8,1,0,17,6,1,11,4,3,3,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,13,16,0,0,0,2,0,6,0,10 } },
        new VehicleInfo(){ Name="raiden", Display="旋风 雷电", Hash=0xA4D99B7D, Mod=new int[43]{ 6,3,2,3,0,0,0,2,2,0,0,4,3,0,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rapidgt", Display="浪子 疾速 GT", Hash=0x8CB29A14, Mod=new int[43]{ 2,0,0,0,1,1,0,1,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rapidgt2", Display="浪子 疾速 GT", Hash=0x679450AF, Mod=new int[43]{ 2,0,0,0,1,0,0,1,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="raptor", Display="毕福 迅猛龙", Hash=0xD7C56D39, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="remus", Display="爱尼仕 雷姆斯", Hash=0x5216AD5E, Mod=new int[43]{ 17,6,6,4,13,5,6,11,7,3,4,4,3,3,58,4,5,50,0,0,7,3,0,5,15,7,14,16,0,0,0,2,0,6,10,12,5,0,5,5,0,1,15 } },
        new VehicleInfo(){ Name="revolter", Display="绝品 反叛者", Hash=0xE78CC3D9, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,1,4,3,3,58,0,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="rt3000", Display="丁卡 RT3000", Hash=0xE505CF99, Mod=new int[43]{ 8,5,14,0,9,0,6,10,9,3,8,4,3,3,58,4,5,50,0,0,5,3,0,4,0,7,14,16,0,0,0,0,0,6,10,12,5,0,0,0,2,8,15 } },
        new VehicleInfo(){ Name="ruston", Display="海岬 拉斯顿", Hash=0x2AE524A8, Mod=new int[43]{ 5,4,4,5,4,4,4,4,0,0,0,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="schafter3", Display="贝飞特 莎夫特 V12", Hash=0xA774B5A6, Mod=new int[43]{ 3,3,1,2,4,0,0,3,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="schafter4", Display="贝飞特 长轴莎夫特", Hash=0x58CF185C, Mod=new int[43]{ 3,3,1,2,4,0,0,3,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="schlagen", Display="贝飞特 撞击 GT", Hash=0xE1C03AB0, Mod=new int[43]{ 10,9,6,6,4,4,5,10,3,2,5,4,3,4,58,5,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="schwarzer", Display="贝飞特 施瓦兹", Hash=0xD37B7976, Mod=new int[43]{ 14,18,3,14,12,5,8,15,0,6,5,4,3,3,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="sentinel3", Display="绝品 卫士经典版", Hash=0x41D149AA, Mod=new int[43]{ 18,9,3,3,4,5,4,16,3,0,13,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="sentinel4", Display="绝品 卫士经典宽体版", Hash=0xAF1FA439, Mod=new int[43]{ 19,15,17,12,11,5,11,19,2,0,8,4,3,3,58,2,5,36,0,0,0,3,0,5,0,8,15,16,0,0,0,0,0,6,10,12,7,6,16,3,7,2,14 } },
        new VehicleInfo(){ Name="seven70", Display="浪子 柒-70", Hash=0x97398A4B, Mod=new int[43]{ 4,0,0,2,2,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sm722", Display="贝飞特 SM722", Hash=0x2E3967B0, Mod=new int[43]{ 21,6,7,12,5,4,9,5,0,0,0,4,3,3,58,2,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="specter", Display="浪子 幽鬼", Hash=0x706E2B40, Mod=new int[43]{ 1,1,1,1,1,0,0,0,0,0,0,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="specter2", Display="浪子 幽鬼改装版", Hash=0x400F5147, Mod=new int[43]{ 17,13,9,12,4,4,0,0,7,0,0,4,3,3,58,4,5,40,0,0,0,0,0,4,8,1,11,16,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="streiter", Display="贝飞特 斯垂特", Hash=0x67D2B389, Mod=new int[43]{ 0,6,0,0,0,0,0,9,0,0,0,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sugoi", Display="丁卡 斯国一", Hash=0x3ADB9758, Mod=new int[43]{ 14,14,7,9,7,0,7,12,4,0,6,4,3,3,58,5,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="sultan", Display="卡林 王者", Hash=0x39DA2754, Mod=new int[43]{ 3,2,1,1,1,1,0,4,0,0,1,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sultan2", Display="卡林 王者经典版", Hash=0x3404691C, Mod=new int[43]{ 16,5,4,4,9,9,4,15,3,7,3,4,3,3,58,4,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="sultan3", Display="卡林 王者 RS 经典版", Hash=0xEEA75E63, Mod=new int[43]{ 16,5,4,4,8,5,4,15,3,7,3,4,3,3,58,4,5,48,0,0,0,2,0,5,15,7,0,0,0,0,0,0,0,3,7,12,5,7,7,0,0,0,15 } },
        new VehicleInfo(){ Name="surano", Display="贝飞特 速雷", Hash=0x16E478C1, Mod=new int[43]{ 2,1,1,1,1,0,0,2,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tampa2", Display="绝致 漂移坦帕", Hash=0xC0240885, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="tenf", Display="奥北 10F", Hash=0xCAB6E261, Mod=new int[43]{ 24,18,18,16,12,6,17,19,3,4,10,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="tenf2", Display="奥北 10F 宽体版", Hash=0x10635A0E, Mod=new int[43]{ 29,18,20,16,22,0,2,19,7,8,10,4,3,3,58,5,5,40,0,0,17,7,0,4,0,4,14,7,0,0,0,0,0,0,0,0,1,4,7,0,0,0,16 } },
        new VehicleInfo(){ Name="tropos", Display="兰帕达缇 逐波雷厉", Hash=0x707E63A4, Mod=new int[43]{ 2,0,0,0,2,0,1,1,0,0,1,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="vectre", Display="皇霸天 韦柯特", Hash=0xA42FC3A5, Mod=new int[43]{ 18,9,9,16,5,8,0,20,4,0,8,4,3,3,58,4,5,40,0,0,13,2,0,3,0,8,15,16,0,0,0,0,0,4,10,20,7,8,14,0,0,2,15 } },
        new VehicleInfo(){ Name="verlierer2", Display="冒险家 迷失者", Hash=0x41B77FA4, Mod=new int[43]{ 5,6,0,1,2,3,0,5,1,0,3,4,3,3,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="veto", Display="丁卡 微托经典版", Hash=0xCCE5C8FA, Mod=new int[43]{ 2,6,0,0,12,3,12,0,0,4,0,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="veto2", Display="丁卡 微托现代版", Hash=0xA703E4A9, Mod=new int[43]{ 2,0,0,0,12,3,12,0,0,4,0,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="vstr", Display="亚班尼 V-STR", Hash=0x56CDEE7D, Mod=new int[43]{ 8,6,0,4,17,3,1,13,2,5,2,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="zr350", Display="爱尼仕 ZR350", Hash=0x91373058, Mod=new int[43]{ 16,6,2,14,9,5,5,14,4,4,4,4,3,3,58,4,5,50,0,0,8,8,0,4,4,8,14,16,0,0,0,0,0,2,8,12,2,8,2,0,5,3,15 } },
        new VehicleInfo(){ Name="zr380", Display="爱尼仕 末日 ZR380", Hash=0x20314B42, Mod=new int[43]{ 6,1,1,0,2,3,0,5,3,5,0,4,3,4,58,0,5,36,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,4,3,4,1,1,2,0,0,4 } },
        new VehicleInfo(){ Name="zr3802", Display="爱尼仕 科幻 ZR380", Hash=0xBE11EFC6, Mod=new int[43]{ 7,2,1,0,3,3,3,3,4,5,1,4,3,4,58,0,5,36,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,4,3,4,1,1,2,0,0,18 } },
        new VehicleInfo(){ Name="zr3803", Display="爱尼仕 梦魇 ZR380", Hash=0xA7DCC35C, Mod=new int[43]{ 6,1,1,0,2,3,0,4,3,5,0,4,3,4,58,0,5,36,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,4,3,4,1,1,2,0,0,4 } },
    };

    /// <summary>
    /// 7 当前分类: 超级跑车
    /// </summary>
    public static List<VehicleInfo> Super = new()
    {
        new VehicleInfo(){ Name="adder", Display="特卢菲 灵蛇", Hash=0xB779A091, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="autarch", Display="傲弗拉 独裁者", Hash=0xED552C74, Mod=new int[43]{ 16,11,2,4,7,0,0,8,1,5,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="banshee2", Display="冒险家 女妖 900R", Hash=0x25C5AF13, Mod=new int[43]{ 6,6,0,5,5,0,4,9,2,0,0,4,3,3,58,3,5,50,0,0,0,0,45,3,0,4,13,16,0,0,0,0,0,4,0,11,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="bullet", Display="威皮 子弹", Hash=0x9AE6DDA1, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="champion", Display="浪子 冠军", Hash=0xC972A155, Mod=new int[43]{ 4,2,3,1,2,1,2,1,0,1,3,5,4,4,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,1,0,0,10 } },
        new VehicleInfo(){ Name="cheetah", Display="古罗帝 猎豹", Hash=0xB1D95DA0, Mod=new int[43]{ 3,0,0,0,3,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cyclone", Display="旋风 飓风", Hash=0x52FF9437, Mod=new int[43]{ 9,4,0,4,0,0,0,0,0,0,0,4,3,0,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="deveste", Display="普林西比 蹂躏者 8", Hash=0x5EE005DA, Mod=new int[43]{ 11,4,5,0,8,5,0,0,0,0,0,5,4,4,58,2,5,40,0,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,14 } },
        new VehicleInfo(){ Name="emerus", Display="培罗 艾梅鲁斯", Hash=0x4EE74355, Mod=new int[43]{ 24,0,0,12,5,0,6,0,2,0,7,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="entity2", Display="傲弗拉 本质 XXR", Hash=0x8198AEDC, Mod=new int[43]{ 5,7,3,0,3,0,0,3,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="entity3", Display="傲弗拉 本质 MT", Hash=0x6838FC1D, Mod=new int[43]{ 31,15,3,11,14,0,4,20,3,1,6,5,4,4,58,5,5,40,0,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="entityxf", Display="傲弗拉 本质 XF", Hash=0xB2FE5CF9, Mod=new int[43]{ 1,1,1,1,2,1,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="fmj", Display="威皮 FMJ", Hash=0x5502626C, Mod=new int[43]{ 5,3,0,0,0,0,0,0,0,0,4,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="furia", Display="古罗帝 狂热", Hash=0x3944D5A0, Mod=new int[43]{ 0,8,8,6,14,2,9,14,0,2,2,4,3,3,58,2,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="gp1", Display="培罗 GP1", Hash=0x4992196C, Mod=new int[43]{ 11,9,2,3,18,10,3,12,3,5,7,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="ignus", Display="佩嘉西 伊格纳斯", Hash=0xA9EC907B, Mod=new int[43]{ 15,17,6,12,5,0,0,18,0,0,10,4,3,3,58,2,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="infernus", Display="佩嘉西 炼狱魔", Hash=0x18F25AC7, Mod=new int[43]{ 2,0,0,0,1,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="italigtb", Display="培罗 义塔力 GTB", Hash=0x85E8E76B, Mod=new int[43]{ 10,7,8,6,7,0,0,9,1,0,5,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="italigtb2", Display="培罗 义塔力 GTB 改装版", Hash=0xE33A477B, Mod=new int[43]{ 13,17,3,2,4,3,0,13,3,3,4,4,3,3,58,0,5,40,0,0,0,0,0,5,8,6,13,16,0,0,0,0,0,0,0,0,0,3,0,0,0,0,9 } },
        new VehicleInfo(){ Name="krieger", Display="贝飞特 武夫", Hash=0xD86A0247, Mod=new int[43]{ 13,0,0,1,5,0,0,4,0,0,0,4,3,4,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="le7b", Display="爱尼仕 RE-7B", Hash=0xB6846A55, Mod=new int[43]{ 1,0,0,0,1,0,0,0,0,0,0,4,3,3,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="lm87", Display="贝飞特 LM87", Hash=0xFF5968CD, Mod=new int[43]{ 26,11,3,4,10,0,2,7,4,3,0,4,3,3,58,2,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="nero", Display="特卢菲 尼罗", Hash=0x3DA47243, Mod=new int[43]{ 0,2,0,2,5,0,0,3,0,0,0,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="nero2", Display="特卢菲 尼罗改装版", Hash=0x4131F378, Mod=new int[43]{ 7,3,2,0,5,3,3,1,1,0,1,4,3,3,58,0,5,40,0,0,3,0,0,2,0,2,3,16,0,0,0,0,0,2,0,0,0,3,1,0,3,0,9 } },
        new VehicleInfo(){ Name="osiris", Display="佩嘉西 奥西里斯", Hash=0x767164D6, Mod=new int[43]{ 2,6,1,3,3,0,0,0,1,0,0,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="penetrator", Display="欧斯洛 穿刺者", Hash=0x9734F3EA, Mod=new int[43]{ 5,5,6,10,5,0,6,6,0,0,3,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="pfister811", Display="菲斯特 811", Hash=0x92EF6E04, Mod=new int[43]{ 1,5,1,2,3,0,0,0,0,0,1,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="prototipo", Display="古罗帝 X80 原型", Hash=0x7E8F677F, Mod=new int[43]{ 3,3,0,3,1,0,0,0,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="reaper", Display="佩嘉西 死神", Hash=0x0DF381E5, Mod=new int[43]{ 3,0,0,0,0,0,0,0,0,0,0,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="s80", Display="爱尼仕 S80RR", Hash=0xECA6B6A3, Mod=new int[43]{ 7,0,0,0,4,0,0,3,1,0,1,4,3,4,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="sc1", Display="绝品 SC1", Hash=0x5097F589, Mod=new int[43]{ 6,3,3,1,3,0,0,2,0,0,5,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="scramjet", Display="绝致 超燃", Hash=0xD9F0503D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,4,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="sheava", Display="皇霸天 ETR1", Hash=0x30D3F6D8, Mod=new int[43]{ 4,2,1,0,1,0,0,1,0,0,3,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="sultanrs", Display="卡林 王者 RS", Hash=0xEE6024BC, Mod=new int[43]{ 16,15,8,4,5,5,4,10,6,0,5,5,3,4,58,4,5,50,0,0,0,1,45,5,6,7,14,16,0,0,0,0,0,4,8,12,6,2,2,0,3,0,8 } },
        new VehicleInfo(){ Name="t20", Display="培罗 T20", Hash=0x6322B39A, Mod=new int[43]{ 0,2,2,1,3,0,0,2,0,0,1,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="taipan", Display="雪佛 泰斑", Hash=0xBC5DC07E, Mod=new int[43]{ 5,4,3,5,6,1,0,6,2,0,6,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tempesta", Display="佩嘉西 风暴", Hash=0x1044926F, Mod=new int[43]{ 5,2,0,3,1,1,0,9,0,0,1,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tezeract", Display="佩嘉西 泰泽拉克", Hash=0x3D7C6410, Mod=new int[43]{ 6,9,4,0,0,4,0,0,0,0,0,4,3,0,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="thrax", Display="特卢菲 特拉克斯", Hash=0x3E3D1F59, Mod=new int[43]{ 9,4,3,5,10,3,8,15,0,0,3,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="tigon", Display="兰帕达缇 虎狮兽", Hash=0xAF0B8D48, Mod=new int[43]{ 11,6,5,5,5,0,0,0,0,0,2,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="torero2", Display="佩嘉西 斗牛 XO", Hash=0xF62446BA, Mod=new int[43]{ 19,15,12,17,14,9,11,16,3,0,15,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 } },
        new VehicleInfo(){ Name="turismor", Display="古罗帝 远途 R", Hash=0x185484E1, Mod=new int[43]{ 21,12,1,12,8,3,0,0,0,0,2,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="tyrant", Display="傲弗拉 统治者", Hash=0xE99011C2, Mod=new int[43]{ 3,0,0,2,2,0,0,1,0,0,0,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tyrus", Display="培罗 泰勒斯", Hash=0x7B406EFB, Mod=new int[43]{ 2,0,0,0,3,0,0,0,0,0,0,4,3,3,58,3,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="vacca", Display="佩嘉西 狂牛", Hash=0x142E0DC3, Mod=new int[43]{ 2,0,0,0,1,1,0,1,0,0,0,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="vagner", Display="浪子 瓦格纳", Hash=0x7397224C, Mod=new int[43]{ 9,3,0,0,2,0,0,3,0,0,5,4,3,3,58,5,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="vigilante", Display="义警", Hash=0xB5EF4C33, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,1,4,3,3,58,5,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="virtue", Display="欧斯洛 美德", Hash=0x27E34161, Mod=new int[43]{ 9,13,5,12,0,1,3,2,3,1,4,4,3,3,58,3,5,40,0,0,0,6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,2,0,0,0,11 } },
        new VehicleInfo(){ Name="visione", Display="古罗帝 幻象", Hash=0xC4810400, Mod=new int[43]{ 5,5,5,0,4,0,0,3,0,0,0,4,3,3,58,5,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="voltic", Display="旋风 狂雷", Hash=0x9F4B77BE, Mod=new int[43]{ 2,1,0,1,0,0,0,3,0,0,0,4,3,0,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="voltic2", Display="旋风 火箭狂雷", Hash=0x3AF76F4A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,0,0,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="xa21", Display="欧斯洛 XA-21", Hash=0x36B4A8A9, Mod=new int[43]{ 9,6,6,7,14,3,14,13,10,0,3,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="zeno", Display="傲弗拉 捷诺", Hash=0x2714AA93, Mod=new int[43]{ 16,15,15,21,20,0,0,13,3,0,9,4,3,3,58,4,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="zentorno", Display="佩嘉西 桑托劳", Hash=0xAC5DF515, Mod=new int[43]{ 12,3,1,5,8,2,1,4,2,2,2,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="zorrusso", Display="佩嘉西 佐路索", Hash=0xD757D97D, Mod=new int[43]{ 5,4,0,0,6,0,2,3,0,0,1,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
    };

    /// <summary>
    /// 8 当前分类: 摩托车
    /// </summary>
    public static List<VehicleInfo> Motorcycles = new()
    {
        new VehicleInfo(){ Name="akuma", Display="丁卡 街头恶魔", Hash=0x63ABADE7, Mod=new int[43]{ 0,0,0,0,2,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="avarus", Display="LCC 阿瓦鲁斯", Hash=0x81E38F7F, Mod=new int[43]{ 12,2,2,8,3,3,1,0,1,0,5,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,18 } },
        new VehicleInfo(){ Name="bagger", Display="西部 驮兽", Hash=0x806B9CC3, Mod=new int[43]{ 0,1,0,0,3,2,0,0,2,0,2,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="bati", Display="佩嘉西 801 巴提", Hash=0xF9300CC5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="bati2", Display="佩嘉西 801RR 巴提", Hash=0xCADD5D2D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="bf400", Display="长崎 BF400", Hash=0x05283265, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="carbonrs", Display="长崎 碳纤 RS 型", Hash=0x00ABB0C0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="chimera", Display="长崎 奇美拉", Hash=0x00675ED7, Mod=new int[43]{ 6,4,0,8,6,3,0,1,8,0,7,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,18 } },
        new VehicleInfo(){ Name="cliffhanger", Display="西部 高潮", Hash=0x17420102, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="daemon", Display="西部 恶魔", Hash=0x77934CEE, Mod=new int[43]{ 1,2,0,1,1,2,0,0,0,0,1,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="daemon2", Display="西部 恶魔", Hash=0xAC4E93C9, Mod=new int[43]{ 11,4,3,9,7,3,2,5,8,2,7,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,18 } },
        new VehicleInfo(){ Name="deathbike", Display="西部 末日丧尸", Hash=0xFE5F0722, Mod=new int[43]{ 0,0,0,0,0,3,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,0,1,1,1,0,0,4 } },
        new VehicleInfo(){ Name="deathbike2", Display="西部 科幻丧尸", Hash=0x93F09558, Mod=new int[43]{ 0,0,0,0,0,6,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,0,1,1,1,0,0,18 } },
        new VehicleInfo(){ Name="deathbike3", Display="西部 梦魇丧尸", Hash=0xAE12C99C, Mod=new int[43]{ 0,0,0,0,0,3,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,3,0,1,1,1,0,0,4 } },
        new VehicleInfo(){ Name="defiler", Display="诗津 亵渎者", Hash=0x30FF0190, Mod=new int[43]{ 2,2,1,0,4,3,0,1,0,0,4,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="diablous", Display="普林西比 蒂雅布萝", Hash=0xF1B44F44, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="diablous2", Display="普林西比 蒂雅布萝改装版", Hash=0x6ABDF65E, Mod=new int[43]{ 10,11,11,0,6,0,0,0,0,7,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,14,0,0,0,0,0,0,2,9,0,0,0,0,8,0,0,18 } },
        new VehicleInfo(){ Name="double", Display="丁卡 双 T", Hash=0x9C669788, Mod=new int[43]{ 0,0,0,0,1,1,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="enduro", Display="丁卡 恩斗罗", Hash=0x6882FA73, Mod=new int[43]{ 0,0,0,0,2,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="esskey", Display="佩嘉西 爱时吉", Hash=0x794CB30C, Mod=new int[43]{ 1,4,2,0,4,0,0,4,0,0,4,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="faggio", Display="佩嘉西 费甲欧现代版", Hash=0x9229E4EB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="faggio2", Display="佩嘉西 费甲欧", Hash=0x0350D1AB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="faggio3", Display="佩嘉西 费甲欧摩登版", Hash=0xB328B188, Mod=new int[43]{ 4,3,3,2,0,9,9,6,20,7,6,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="fcr", Display="佩嘉西 FCR 1000", Hash=0x25676EAF, Mod=new int[43]{ 0,3,2,0,3,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="fcr2", Display="佩嘉西 FCR 1000 改装版", Hash=0xD2D5E00E, Mod=new int[43]{ 13,10,8,0,6,0,0,0,5,1,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,5,0,0,0,0,0,0,7,2,0,0,0,0,7,0,0,18 } },
        new VehicleInfo(){ Name="gargoyle", Display="西部 石像鬼", Hash=0x2C2C2324, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="hakuchou", Display="诗津 白鸟", Hash=0x4B6C568A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="hakuchou2", Display="诗津 白鸟竞速版", Hash=0xF0C2A91F, Mod=new int[43]{ 0,6,0,0,4,2,0,0,0,0,2,5,4,4,58,0,5,72,72,0,0,0,0,0,0,0,0,0,4,0,1,0,0,0,0,0,0,0,0,0,0,0,14 } },
        new VehicleInfo(){ Name="hexer", Display="LCC 迷魅光轮", Hash=0x11F76C14, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="innovation", Display="LCC 创新", Hash=0xF683EACA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="lectro", Display="普林西比 雷克卓", Hash=0x26321E67, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="manchez", Display="麦霸子 曼切兹", Hash=0xA5325278, Mod=new int[43]{ 0,3,1,0,3,2,0,1,0,0,3,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="manchez2", Display="麦霸子 曼切兹侦查", Hash=0x40C332A3, Mod=new int[43]{ 4,2,0,0,4,5,0,0,0,0,4,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20 } },
        new VehicleInfo(){ Name="manchez3", Display="麦霸子 曼切兹侦查 C", Hash=0x5285D628, Mod=new int[43]{ 0,5,1,0,8,3,1,3,3,0,4,5,3,4,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="nemesis", Display="普林西比 复仇女神", Hash=0xDA288376, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="nightblade", Display="西部 夜刃", Hash=0xA0438767, Mod=new int[43]{ 0,2,0,3,4,2,0,0,3,0,4,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="oppressor", Display="佩嘉西 暴君", Hash=0x34B82784, Mod=new int[43]{ 1,1,1,0,0,1,0,2,1,0,1,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="oppressor2", Display="佩嘉西 暴君 Mk 2", Hash=0x7B54A9D3, Mod=new int[43]{ 0,0,0,0,0,1,2,0,0,0,2,4,3,0,0,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="pcj", Display="诗津 PCJ 600", Hash=0xC9CEAF06, Mod=new int[43]{ 0,2,1,0,2,2,1,0,0,0,1,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="powersurge", Display="西部 电涌", Hash=0xAD5E30D7, Mod=new int[43]{ 1,3,2,0,0,2,7,7,0,1,15,5,3,0,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="ratbike", Display="西部 破烂摩托车", Hash=0x6FACDF31, Mod=new int[43]{ 11,4,3,9,7,3,0,5,8,2,7,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="reever", Display="西部 里弗", Hash=0x76D7C404, Mod=new int[43]{ 6,9,7,0,4,5,13,0,0,0,0,5,4,4,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="rrocket", Display="西部 狂暴火箭", Hash=0x36A167E0, Mod=new int[43]{ 0,0,0,0,0,4,0,0,0,0,0,4,3,4,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="ruffian", Display="佩嘉西 恶霸", Hash=0xCABD11E8, Mod=new int[43]{ 0,1,1,0,2,1,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sanchez", Display="麦霸子 桑切斯（涂装版）", Hash=0x2EF89E46, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sanchez2", Display="麦霸子 桑切斯", Hash=0xA960B13E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sanctus", Display="LCC 圣驹", Hash=0x58E316C7, Mod=new int[43]{ 12,2,2,8,3,3,0,0,0,0,5,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,18 } },
        new VehicleInfo(){ Name="shinobi", Display="长崎 信奴比", Hash=0x50A6FB9C, Mod=new int[43]{ 0,3,0,3,4,3,0,3,0,0,0,5,4,4,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="shotaro", Display="长崎 圣太郎", Hash=0xE7D2A16E, Mod=new int[43]{ 0,1,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sovereign", Display="西部 君主", Hash=0x2C509634, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="stryder", Display="长崎 斯特德", Hash=0x11F58A5A, Mod=new int[43]{ 0,0,5,0,5,0,0,0,0,0,0,4,3,3,58,0,5,40,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="thrust", Display="丁卡 猛冲", Hash=0x6D6F8F43, Mod=new int[43]{ 0,0,0,0,1,1,0,0,0,0,1,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="vader", Display="诗津 威德", Hash=0xF79A00F7, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="vindicator", Display="丁卡 审判者", Hash=0xAF599F01, Mod=new int[43]{ 0,1,0,0,5,1,0,0,0,0,1,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="vortex", Display="佩嘉西 漩涡", Hash=0xDBA9DBFC, Mod=new int[43]{ 5,6,0,2,1,3,0,2,2,0,1,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="wolfsbane", Display="西部 恶狼克星", Hash=0xDB20A373, Mod=new int[43]{ 11,4,3,9,7,3,0,5,8,2,7,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,18 } },
        new VehicleInfo(){ Name="zombiea", Display="西部 鞭尸者", Hash=0xC3D7C72B, Mod=new int[43]{ 11,4,2,9,8,3,0,4,8,0,7,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,18 } },
        new VehicleInfo(){ Name="zombieb", Display="西部 碎尸者", Hash=0xDE05FB87, Mod=new int[43]{ 11,4,2,9,8,3,0,4,8,0,7,4,3,3,58,0,5,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,18 } },
    };

    /// <summary>
    /// 9 当前分类: 越野车
    /// </summary>
    public static List<VehicleInfo> OffRoad = new()
    {
        new VehicleInfo(){ Name="bfinjection", Display="毕福 沙丘征服者", Hash=0x432AA566, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="bifta", Display="毕福 必浮塔", Hash=0xEB298297, Mod=new int[43]{ 3,0,0,1,3,1,0,0,0,0,2,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blazer", Display="长崎 烈焰", Hash=0x8125BCF9, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blazer2", Display="长崎 烈焰救生型", Hash=0xFD231729, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blazer3", Display="长崎 火辣烈焰", Hash=0xB44F0582, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blazer4", Display="长崎 街头烈焰", Hash=0xE5BA6858, Mod=new int[43]{ 4,6,2,4,5,2,4,0,6,3,2,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blazer5", Display="长崎 水陆烈焰骑士", Hash=0xA1355F67, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="bodhi2", Display="卡尼斯 万用行者", Hash=0xAA699BB6, Mod=new int[43]{ 0,2,2,0,0,3,4,6,4,0,5,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="boor", Display="卡林 粗人", Hash=0x3B639C8D, Mod=new int[43]{ 9,11,7,0,4,0,0,10,2,0,1,4,3,3,58,5,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,14 } },
        new VehicleInfo(){ Name="brawler", Display="旋风 斗殴者", Hash=0xA7CE1BC5, Mod=new int[43]{ 0,2,2,0,0,1,0,0,0,0,3,4,3,3,58,5,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="bruiser", Display="贝飞特 末日捍士", Hash=0x27D79225, Mod=new int[43]{ 3,0,0,0,4,3,3,13,1,5,3,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,6,0,0,0,0,4,3,6,1,0,2,0,0,4 } },
        new VehicleInfo(){ Name="bruiser2", Display="贝飞特 科幻捍士", Hash=0x9B065C9E, Mod=new int[43]{ 2,1,1,0,4,3,3,7,0,5,3,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,3,6,1,0,2,0,0,18 } },
        new VehicleInfo(){ Name="bruiser3", Display="贝飞特 梦魇捍士", Hash=0x8644331A, Mod=new int[43]{ 3,0,0,0,4,3,3,13,1,5,3,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,6,0,0,0,0,4,3,6,1,0,2,0,0,4 } },
        new VehicleInfo(){ Name="brutus", Display="绝致 末日布鲁图斯", Hash=0x7F81A829, Mod=new int[43]{ 0,3,3,2,5,3,3,3,2,5,4,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,4,3,7,0,1,2,0,0,4 } },
        new VehicleInfo(){ Name="brutus2", Display="绝致 科幻布鲁图斯", Hash=0x8F49AE28, Mod=new int[43]{ 0,1,2,2,1,3,1,2,1,5,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,3,7,0,1,2,0,0,18 } },
        new VehicleInfo(){ Name="brutus3", Display="绝致 梦魇布鲁图斯", Hash=0x798682A2, Mod=new int[43]{ 0,3,3,2,5,3,3,3,2,5,4,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,4,3,7,0,1,2,0,0,4 } },
        new VehicleInfo(){ Name="caracara", Display="威皮 卡拉卡拉", Hash=0x4ABEBF23, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,1,4,3,3,58,0,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20 } },
        new VehicleInfo(){ Name="caracara2", Display="威皮 卡拉卡拉四驱车", Hash=0xAF966F3C, Mod=new int[43]{ 9,7,5,0,2,0,3,8,3,0,2,4,3,4,58,5,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="dloader", Display="冒险家 越野游侠", Hash=0x698521E3, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="draugur", Display="绝致 德劳古尔", Hash=0xD235A4A6, Mod=new int[43]{ 3,18,2,10,9,6,6,0,5,6,2,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="dubsta3", Display="贝飞特 迪布达 6x6", Hash=0xB6410173, Mod=new int[43]{ 0,6,2,0,0,0,3,2,0,0,4,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dune", Display="毕福 沙丘魔宝", Hash=0x9CF21E0F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dune2", Display="太空码头工", Hash=0x1FD824AF, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dune3", Display="毕福 沙丘 FAV", Hash=0x711D4738, Mod=new int[43]{ 0,0,0,2,0,2,0,0,0,1,2,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="dune4", Display="斜面魔宝", Hash=0xCEB28249, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dune5", Display="斜面魔宝", Hash=0xED62BFA9, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="everon", Display="卡林 埃弗伦", Hash=0x97553C28, Mod=new int[43]{ 1,10,2,2,2,0,0,23,0,7,17,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="freecrawler", Display="卡尼斯 自由攀登者", Hash=0xFCC2F483, Mod=new int[43]{ 0,3,3,11,3,4,10,7,1,0,2,4,3,3,58,0,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="hellion", Display="爱尼仕 恶人", Hash=0xEA6A047F, Mod=new int[43]{ 3,16,10,9,8,4,10,0,9,0,3,4,3,4,58,3,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="insurgent", Display="HVY 叛乱分子皮卡", Hash=0x9114EADA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="insurgent2", Display="HVY 叛乱分子", Hash=0x7B7E56F0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="insurgent3", Display="HVY 叛乱分子皮卡改装版", Hash=0x8D4B7A8A, Mod=new int[43]{ 0,0,0,0,0,3,0,0,0,1,1,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="kalahari", Display="卡尼斯 卡拉哈里", Hash=0x05852838, Mod=new int[43]{ 0,2,1,1,1,0,0,1,0,0,0,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="kamacho", Display="卡尼斯 卡马乔", Hash=0xF8C2E0E7, Mod=new int[43]{ 9,12,8,4,4,5,3,8,2,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="marshall", Display="雪佛 马绍尔", Hash=0x49863E9C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="menacer", Display="HVY 威胁者", Hash=0x79DD18AE, Mod=new int[43]{ 0,14,8,16,12,1,9,21,0,0,4,4,3,3,58,0,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="mesa3", Display="卡尼斯 炎魔", Hash=0x84F42E51, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="monster", Display="威皮 解放者", Hash=0xCD93A7DB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="monster3", Display="冒险家 末日大脚怪", Hash=0x669EB40A, Mod=new int[43]{ 0,3,2,0,2,3,0,3,0,5,0,4,3,3,58,0,5,38,0,0,0,0,0,0,0,0,0,0,0,6,0,0,0,0,4,3,6,0,0,1,0,0,4 } },
        new VehicleInfo(){ Name="monster4", Display="冒险家 科幻大脚怪", Hash=0x32174AFC, Mod=new int[43]{ 0,3,2,0,2,3,0,3,0,5,0,4,3,3,58,0,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,3,6,0,0,1,0,0,18 } },
        new VehicleInfo(){ Name="monster5", Display="冒险家 梦魇大脚怪", Hash=0xD556917C, Mod=new int[43]{ 0,3,2,0,2,3,0,3,0,5,0,4,3,3,58,0,5,38,0,0,0,0,0,0,0,0,0,0,0,6,0,0,0,0,4,3,6,0,0,1,0,0,4 } },
        new VehicleInfo(){ Name="nightshark", Display="HVY 夜鲨", Hash=0x19DD9ED1, Mod=new int[43]{ 0,3,3,0,2,3,9,10,3,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="outlaw", Display="长崎 不法之徒", Hash=0x185E2FF3, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20 } },
        new VehicleInfo(){ Name="patriot3", Display="巨象 爱国者军用版", Hash=0xD80F4A44, Mod=new int[43]{ 3,10,7,10,6,1,16,7,7,1,9,4,3,3,58,4,5,38,0,0,0,0,9,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,1,0,0,10 } },
        new VehicleInfo(){ Name="rancherxl", Display="绝致 蓝彻 XL", Hash=0x6210CBB0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rancherxl2", Display="绝致 蓝彻 XL", Hash=0x7341576B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rcbandito", Display="RC 匪徒", Hash=0xEEF345EC, Mod=new int[43]{ 0,0,0,0,0,20,0,0,1,2,0,4,3,0,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="rebel", Display="卡林 叛逆男女生锈版", Hash=0xB802DD46, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,0,5,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rebel2", Display="卡林 叛逆男女", Hash=0x8612B64B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="riata", Display="威皮 利雅塔", Hash=0xA4A4E453, Mod=new int[43]{ 0,10,3,4,3,0,2,8,0,0,11,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="sandking", Display="威皮 大脚霸王 XL", Hash=0xB9210FD0, Mod=new int[43]{ 0,4,0,2,0,4,2,0,0,0,1,4,3,3,58,5,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sandking2", Display="威皮 大脚霸王 SWB", Hash=0x3AF8C345, Mod=new int[43]{ 0,4,0,2,0,4,2,0,0,0,1,4,3,3,58,5,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="technical", Display="卡林 铁尼高", Hash=0x83051506, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="technical2", Display="卡林 水陆铁尼高", Hash=0x4662BCBB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="technical3", Display="卡林 铁尼高改装版", Hash=0x50D4D19F, Mod=new int[43]{ 0,0,0,0,0,3,5,0,0,1,1,4,3,4,58,3,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="trophytruck", Display="威皮 越野卡车", Hash=0x0612F4B6, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,5,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="trophytruck2", Display="威皮 沙漠突击", Hash=0xD876DBE2, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,5,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="vagrant", Display="麦克斯韦 流浪者", Hash=0x2C1FEA99, Mod=new int[43]{ 0,0,0,0,8,2,2,2,3,3,2,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="verus", Display="丁卡 维鲁斯", Hash=0x11CBC051, Mod=new int[43]{ 3,0,0,0,3,2,2,6,0,0,0,4,3,3,58,5,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20 } },
        new VehicleInfo(){ Name="winky", Display="威皮 威起", Hash=0xF376F1E6, Mod=new int[43]{ 3,7,2,6,4,10,4,6,3,0,1,4,3,3,58,2,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,29 } },
        new VehicleInfo(){ Name="yosemite3", Display="绝致 约塞米蒂蓝彻", Hash=0x0409D787, Mod=new int[43]{ 7,14,5,6,5,4,9,14,5,15,5,4,3,3,58,4,5,35,0,0,0,0,45,0,14,2,10,16,15,0,0,2,0,4,5,0,7,6,2,10,8,2,18 } },
        new VehicleInfo(){ Name="zhaba", Display="卢恩 炸吧", Hash=0x4C8DBA51, Mod=new int[43]{ 6,3,3,8,9,3,6,0,2,2,6,4,3,2,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
    };

    /// <summary>
    /// 10 当前分类: 工业用车
    /// </summary>
    public static List<VehicleInfo> Industrial = new()
    {
        new VehicleInfo(){ Name="bulldozer", Display="HVY 推土机", Hash=0x7074F39D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cutter", Display="HVY 钻洞机", Hash=0xC3FBA120, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dump", Display="HVY 矿石搬运车", Hash=0x810369E2, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="flatbed", Display="MTL 平板拖车", Hash=0x50B0215A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="guardian", Display="威皮 守护者", Hash=0x825A9F4C, Mod=new int[43]{ 0,0,0,0,1,0,0,0,0,0,0,4,3,3,58,5,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="handler", Display="码头装卸车", Hash=0x1A7FCEFA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mixer", Display="HVY 混凝土搅拌车", Hash=0xD138A6BB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mixer2", Display="HVY 混凝土搅拌车", Hash=0x1C534995, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rubble", Display="乔氏 砂通天", Hash=0x9A5B1DCC, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tiptruck", Display="威霸 工地倾卸车", Hash=0x02E19879, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tiptruck2", Display="工地倾卸车", Hash=0xC7824E5E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 11 当前分类: 公共事业用车
    /// </summary>
    public static List<VehicleInfo> Utility = new()
    {
        new VehicleInfo(){ Name="airtug", Display="行李拖车", Hash=0x5D0AAC8F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="armytanker", Display="军用拖车", Hash=0xB8081009, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="armytrailer", Display="军用拖车", Hash=0xA7FF33F5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="armytrailer2", Display="军用拖车", Hash=0x9E6B14D6, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="baletrailer", Display="草捆拖车", Hash=0xE82AE656, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="boattrailer", Display="拖船", Hash=0x1F3D44B5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="caddy", Display="高尔夫球车", Hash=0x44623884, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="caddy2", Display="高尔夫球车", Hash=0xDFF0594C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="caddy3", Display="高尔夫球车", Hash=0xD227BDBB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="docktrailer", Display="", Hash=0x806EFBEE, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="docktug", Display="码头拖车", Hash=0xCB44B1CA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="forklift", Display="HVY 叉车", Hash=0x58E49664, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="freighttrailer", Display="", Hash=0xD1ABB666, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="graintrailer", Display="", Hash=0x3CC7F596, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mower", Display="割草车", Hash=0x6A4BD8F6, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="proptrailer", Display="", Hash=0x153E1B0A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="raketrailer", Display="拖车", Hash=0x174CB172, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="ripley", Display="机场牵引车", Hash=0xCD935EF9, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sadler", Display="威皮 沙德勒", Hash=0xDC434E51, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sadler2", Display="威皮 沙德勒", Hash=0x2BC345D1, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="scrap", Display="废五金回收车", Hash=0x9A9FD3DF, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="slamtruck", Display="威皮 大满贯卡车", Hash=0xC1A8A914, Mod=new int[43]{ 0,7,0,3,3,0,9,4,0,8,0,4,3,3,58,0,5,38,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,18 } },
        new VehicleInfo(){ Name="tanker", Display="拖车", Hash=0xD46F4737, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tanker2", Display="", Hash=0x74998082, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="towtruck", Display="拖吊车", Hash=0xB12314E0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="towtruck2", Display="拖吊车", Hash=0xE5A2D6C6, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tr2", Display="拖车", Hash=0x7BE032C6, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tr3", Display="拖车", Hash=0x6A59902D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tr4", Display="拖车", Hash=0x7CAB34D0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tractor", Display="老式拖拉机", Hash=0x61D6BA8C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tractor2", Display="斯坦利 农耕机", Hash=0x843B73DE, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tractor3", Display="斯坦利 农耕机", Hash=0x562A97BD, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="trailerlarge", Display="机动作战中心", Hash=0x5993F939, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,2,4,3,4,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="trailerlogs", Display="拖车", Hash=0x782A236D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="trailers", Display="拖车", Hash=0xCBB2BE0E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="trailers2", Display="拖车", Hash=0xA1DA3C91, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="trailers3", Display="拖车", Hash=0x8548036D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="trailers4", Display="拖车", Hash=0xBE66F5AA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="trailersmall", Display="拖车", Hash=0x2A72BEAB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="trflat", Display="拖车", Hash=0xAF62F6B2, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tvtrailer", Display="拖车", Hash=0x967620BE, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="utillitruck", Display="公共事业卡车", Hash=0x1ED0A534, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="utillitruck2", Display="公共事业卡车", Hash=0x34E6BF6B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="utillitruck3", Display="公共事业卡车", Hash=0x7F2153DF, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 12 当前分类: 厢型车
    /// </summary>
    public static List<VehicleInfo> Vans = new()
    {
        new VehicleInfo(){ Name="bison", Display="冒险家 野牛", Hash=0xFEFD644F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="bison2", Display="冒险家 野牛", Hash=0x7B8297C5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="bison3", Display="冒险家 野牛", Hash=0x67B3F020, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="bobcatxl", Display="威皮 雄猫 XL", Hash=0x3FC5D440, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="boxville", Display="威霸 厢村", Hash=0x898ECCEA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="boxville2", Display="厢村", Hash=0xF21B33BE, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="boxville3", Display="威霸 厢村", Hash=0x07405E08, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="boxville4", Display="威霸 厢村", Hash=0x1A79847A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="boxville5", Display="装甲版厢村", Hash=0x28AD20E1, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="burrito", Display="绝致 屌客", Hash=0xAFBB2CA4, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="burrito2", Display="绝致 除虫大师屌客", Hash=0xC9E8FF76, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="burrito3", Display="绝致 屌客", Hash=0x98171BD3, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="burrito4", Display="绝致 屌客", Hash=0x353B561D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="burrito5", Display="绝致 屌客", Hash=0x437CF2A0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="camper", Display="威霸 露营车", Hash=0x6FD95F68, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="gburrito", Display="绝致 屌客帮派版", Hash=0x97FA4F36, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="gburrito2", Display="绝致 屌客帮派版", Hash=0x11AA0E14, Mod=new int[43]{ 1,1,1,0,3,0,2,5,0,0,2,4,3,3,58,5,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="journey", Display="赛柯尼 安旅者", Hash=0xF8D48E7A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="journey2", Display="赛柯尼 安旅者 2", Hash=0x9F04C481, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,5,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="minivan", Display="威皮 迷你厢型车", Hash=0xED7EADA4, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="minivan2", Display="威皮 迷你厢型车改装版", Hash=0xBCDE91F0, Mod=new int[43]{ 1,0,0,0,1,0,1,0,0,0,3,4,3,3,58,0,5,50,6,13,16,4,45,0,14,5,1,16,15,22,0,9,4,4,3,0,0,0,0,0,0,0,9 } },
        new VehicleInfo(){ Name="paradise", Display="冒险家 天堂", Hash=0x58B3979C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="pony", Display="威霸 小马", Hash=0xF8DE29A8, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="pony2", Display="威霸 小马", Hash=0x38408341, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rumpo", Display="冒险家 澜波", Hash=0x4543B74D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rumpo2", Display="冒险家 澜波", Hash=0x961AFEF7, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="rumpo3", Display="冒险家 澜波改装版", Hash=0x57F682AF, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="speedo", Display="威皮 劲速", Hash=0xCFB3870C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="speedo2", Display="威皮 小丑花车", Hash=0x2B6DC64A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="speedo4", Display="威皮 劲速改装版", Hash=0x0D17099D, Mod=new int[43]{ 0,0,0,0,0,3,0,0,0,1,3,4,3,3,58,0,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="surfer", Display="毕福 乘风", Hash=0x29B0DA97, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="surfer2", Display="毕福 乘风", Hash=0xB1D80E06, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="surfer3", Display="毕福 乘风改装版", Hash=0xC247AEE5, Mod=new int[43]{ 4,5,2,3,15,30,9,3,16,5,4,4,3,3,58,3,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,13 } },
        new VehicleInfo(){ Name="taco", Display="玉米饼餐车", Hash=0x744CA80D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="youga", Display="冒险家 游侠", Hash=0x03E5F6B8, Mod=new int[43]{ 0,3,0,0,1,1,0,1,0,0,2,4,3,3,58,3,5,48,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="youga2", Display="冒险家 游侠经典版", Hash=0x3D29CD2B, Mod=new int[43]{ 1,0,0,1,1,1,0,0,0,0,1,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,12 } },
        new VehicleInfo(){ Name="youga3", Display="冒险家 游侠经典四驱车", Hash=0x6B73A9BE, Mod=new int[43]{ 8,4,6,5,6,1,7,9,0,4,3,4,3,3,58,4,5,36,0,0,0,15,0,4,0,7,1,16,0,0,0,8,0,6,0,0,5,1,5,6,4,3,16 } },
        new VehicleInfo(){ Name="youga4", Display="威皮 游侠改装版", Hash=0x589A840C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 13 当前分类: 自行车
    /// </summary>
    public static List<VehicleInfo> Cycles = new()
    {
        new VehicleInfo(){ Name="bmx", Display="BMX", Hash=0x43779C54, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cruiser", Display="巡航者", Hash=0x1ABA13B5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="fixter", Display="费斯特", Hash=0xCE23D3BF, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="scorcher", Display="先驱者", Hash=0xF4E1AA15, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tribike", Display="惠比特竞速自行车", Hash=0x4339CD69, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tribike2", Display="极限耐力竞速自行车", Hash=0xB67597EC, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tribike3", Display="特莱赛可竞速自行车", Hash=0xE823FB48, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 14 当前分类: 船
    /// </summary>
    public static List<VehicleInfo> Boats = new()
    {
        new VehicleInfo(){ Name="avisa", Display="海怪 阿维萨", Hash=0x9A474B5E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dinghy", Display="长崎 小艇", Hash=0x3D961290, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dinghy2", Display="长崎 小艇", Hash=0x107F392C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dinghy3", Display="长崎 小艇", Hash=0x1E5E54EA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dinghy4", Display="长崎 小艇", Hash=0x33B47F96, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dinghy5", Display="长崎 武装小艇", Hash=0xC58DA34A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="jetmax", Display="诗津 极限快艇", Hash=0x33581161, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="kosatka", Display="卢恩 虎鲸", Hash=0x4FAF0D70, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,5,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,46 } },
        new VehicleInfo(){ Name="longfin", Display="诗津 长鳍", Hash=0x6EF89CCC, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="marquis", Display="丁卡 水上侯爵", Hash=0xC1CE1183, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="patrolboat", Display="库尔兹 31 巡逻艇", Hash=0xEF813606, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="predator", Display="警用追猎快艇", Hash=0xE2E7D4AB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="seashark", Display="水上枭雄 海鲨摩托艇", Hash=0xC2974024, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="seashark2", Display="水上枭雄 海鲨摩托艇", Hash=0xDB4388E4, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="seashark3", Display="水上枭雄 海鲨摩托艇", Hash=0xED762D49, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="speeder", Display="佩嘉西 飙速", Hash=0x0DC60D2B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="speeder2", Display="佩嘉西 飙速", Hash=0x1A144F2A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="squalo", Display="诗津 思快乐快艇", Hash=0x17DF5EC2, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="submersible", Display="潜水艇", Hash=0x2DFF622F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="submersible2", Display="海怪", Hash=0xC07107EE, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="suntrap", Display="诗津 向阳号", Hash=0xEF2295C9, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="toro", Display="兰帕达缇 公牛", Hash=0x3FD5AA2F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="toro2", Display="兰帕达缇 公牛", Hash=0x362CAC6D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tropic", Display="诗津 烈阳号", Hash=0x1149422F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tropic2", Display="诗津 烈阳号", Hash=0x56590FE9, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tug", Display="拖船", Hash=0x82CAC433, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 15 当前分类: 直升机
    /// </summary>
    public static List<VehicleInfo> Helicopters = new()
    {
        new VehicleInfo(){ Name="akula", Display="阿库拉", Hash=0x46699F47, Mod=new int[43]{ 0,0,0,0,0,2,0,0,0,4,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="annihilator", Display="歼灭者", Hash=0x31F0B376, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="annihilator2", Display="歼灭者隐形版", Hash=0x11962E49, Mod=new int[43]{ 0,0,0,0,0,2,0,0,0,0,0,4,3,3,58,5,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20 } },
        new VehicleInfo(){ Name="buzzard", Display="秃鹰攻击直升机", Hash=0x2F03547B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="buzzard2", Display="秃鹰直升机", Hash=0x2C75F0DD, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cargobob", Display="运兵直升机", Hash=0xFCFCB68B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cargobob2", Display="运兵直升机", Hash=0x60A7EA10, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cargobob3", Display="运兵直升机", Hash=0x53174EEF, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cargobob4", Display="运兵直升机", Hash=0x78BC1A3C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="conada", Display="白金汉 康纳达", Hash=0xE384DD25, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="frogger", Display="穿梭者", Hash=0x2C634FBD, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="frogger2", Display="穿梭者", Hash=0x742E9AC0, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="havok", Display="长崎 浩劫者", Hash=0x89BA59F5, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,0,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="hunter", Display="FH-1 猎杀者", Hash=0xFD707EDE, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,4,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="maverick", Display="小蛮牛", Hash=0x9D0450CA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="polmav", Display="警用小蛮牛", Hash=0x1517D4D9, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="savage", Display="野蛮人", Hash=0xFB133A17, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="seasparrow", Display="海雀", Hash=0xD4AE63D9, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,2,4,3,3,58,5,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="seasparrow2", Display="麻雀", Hash=0x494752F7, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,0,2,4,3,0,58,5,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="seasparrow3", Display="麻雀", Hash=0x5F017E6B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,2,4,3,0,58,5,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="skylift", Display="吊挂直升机", Hash=0x3E48BF23, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="supervolito", Display="白金汉 超级沃利托", Hash=0x2A54C47D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="supervolito2", Display="白金汉 超级沃利托碳纤版", Hash=0x9C5E5644, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="swift", Display="白金汉 斯威夫特", Hash=0xEBC24DF2, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="swift2", Display="白金汉 斯威夫特豪华版", Hash=0x4019CB4C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="valkyrie", Display="女武神", Hash=0xA09E15FD, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="valkyrie2", Display="女武神 MOD.0", Hash=0x5BFA5C4B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="volatus", Display="白金汉 弗拉图斯", Hash=0x920016F1, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 16 当前分类: 飞机
    /// </summary>
    public static List<VehicleInfo> Planes = new()
    {
        new VehicleInfo(){ Name="alkonost", Display="RO-86 阿尔科诺斯特", Hash=0xEA313705, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,4,0,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="alphaz1", Display="白金汉 阿尔法-Z1", Hash=0xA52F6866, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,0,0,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="avenger", Display="巨象 复仇者", Hash=0x81BD2ED0, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,4,2,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="avenger2", Display="巨象 复仇者", Hash=0x18606535, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,4,2,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="besra", Display="西部 雀鹰", Hash=0x6CBD1D6D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blimp", Display="原子飞艇", Hash=0xF7004C86, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blimp2", Display="希罗飞艇", Hash=0xDB6B4924, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="blimp3", Display="飞艇", Hash=0xEDA4ED97, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20 } },
        new VehicleInfo(){ Name="bombushka", Display="RM-10 邦布什卡", Hash=0xFE0A508C, Mod=new int[43]{ 0,2,0,0,1,1,0,0,0,4,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="cargoplane", Display="货机", Hash=0x15F27762, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cargoplane2", Display="货机", Hash=0x8B4864E1, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cuban800", Display="古邦 800", Hash=0xD9927FE3, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="dodo", Display="巨象 嘟嘟鸟", Hash=0xCA495705, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="duster", Display="洒药机", Hash=0x39D6779E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="howard", Display="白金汉 霍华德 NX-25", Hash=0xC3F25753, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,0,0,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="hydra", Display="巨象 九头蛇", Hash=0x39D6E83F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="jet", Display="喷气机", Hash=0x3F119114, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="lazer", Display="P-996 天煞", Hash=0xB39B0AE6, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="luxor", Display="白金汉 乐梭", Hash=0x250B0C5E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="luxor2", Display="白金汉 乐梭豪华版", Hash=0xB79F589E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mammatus", Display="天行巨兽", Hash=0x97E55D11, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="microlight", Display="长崎 鸿毛", Hash=0x96E24857, Mod=new int[43]{ 0,2,0,0,2,0,0,0,0,0,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="miljet", Display="白金汉 军用喷气机", Hash=0x09D80F93, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mogul", Display="巨象 莫古尔", Hash=0xD35698EF, Mod=new int[43]{ 0,2,0,0,1,1,0,0,0,4,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="molotok", Display="V-65 莫洛托克", Hash=0x5D56F01B, Mod=new int[43]{ 0,2,0,1,0,0,0,0,0,0,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,20 } },
        new VehicleInfo(){ Name="nimbus", Display="白金汉 灵气号", Hash=0xB2CF7250, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="nokota", Display="P-45 诺克塔", Hash=0x3DC92356, Mod=new int[43]{ 0,2,0,1,0,0,0,0,0,0,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="pyro", Display="白金汉 狂焰", Hash=0xAD6065C0, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,0,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="rogue", Display="西部 恶徒", Hash=0xC5DD6967, Mod=new int[43]{ 0,2,0,0,0,1,0,0,0,4,2,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="seabreeze", Display="西部 海风", Hash=0xE8983F9F, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,4,1,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="shamal", Display="白金汉 夏玛尔客机", Hash=0xB79C1BF5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="starling", Display="LF-22 星椋", Hash=0x9A9EB7DE, Mod=new int[43]{ 0,2,0,0,1,0,0,0,0,4,1,4,3,1,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="strikeforce", Display="B-11 突击部队", Hash=0x64DE07A1, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,4,0,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,11 } },
        new VehicleInfo(){ Name="stunt", Display="野鸭", Hash=0x81794C70, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="titan", Display="泰坦号", Hash=0x761E2AD3, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tula", Display="巨象 图拉", Hash=0x3E2E4F8A, Mod=new int[43]{ 0,2,0,0,1,0,0,0,0,4,2,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,8 } },
        new VehicleInfo(){ Name="velum", Display="梅杜莎", Hash=0x9C429B6A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="velum2", Display="梅杜莎 5 座", Hash=0x403820E8, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="vestra", Display="白金汉 威斯特拉", Hash=0x4FF77E37, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="volatol", Display="沃拉托", Hash=0x1AAD0DED, Mod=new int[43]{ 0,2,0,0,0,0,0,0,0,4,0,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
    };

    /// <summary>
    /// 17 当前分类: 服务用车
    /// </summary>
    public static List<VehicleInfo> Service = new()
    {
        new VehicleInfo(){ Name="airbus", Display="机场巴士", Hash=0x4C80EB0E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="brickade", Display="MTL 布里凯德", Hash=0xEDC6F847, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="brickade2", Display="MTL 布里凯德 6x6", Hash=0xA2073353, Mod=new int[43]{ 0,0,0,0,0,1,0,0,0,5,0,4,3,3,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="bus", Display="巴士", Hash=0xD577C962, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="coach", Display="白狗巴士", Hash=0x84718D34, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="pbus2", Display="音乐节巴士", Hash=0x149BD32A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,4,58,3,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="rallytruck", Display="MTL 沙丘", Hash=0x829A3C44, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,5,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 } },
        new VehicleInfo(){ Name="rentalbus", Display="租用穿梭巴士", Hash=0xBE819C63, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="taxi", Display="出租车", Hash=0xC703DB5F, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tourbus", Display="观光巴士", Hash=0x73B1C3CB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="trash", Display="垃圾大王", Hash=0x72435A19, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="trash2", Display="垃圾大王", Hash=0xB527915C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="wastelander", Display="MTL 拓荒者", Hash=0x8E08EC82, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 18 当前分类: 特种车
    /// </summary>
    public static List<VehicleInfo> Emergency = new()
    {
        new VehicleInfo(){ Name="ambulance", Display="救护车", Hash=0x45D56ADA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="fbi", Display="FIB", Hash=0x432EA949, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="fbi2", Display="FIB", Hash=0x9DC66994, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="firetruk", Display="MTL 消防车", Hash=0x73920F8E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="lguard", Display="绝致 沙滩急救车", Hash=0x1BF8D381, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="pbus", Display="移监巴士", Hash=0x885F3671, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="police", Display="警用巡逻车", Hash=0x79FBB0C5, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="police2", Display="警用巡逻车", Hash=0x9F05F101, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="police3", Display="警用巡逻车", Hash=0x71FA16EA, Mod=new int[43]{ 2,2,2,2,1,2,0,2,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="police4", Display="无标识巡航者", Hash=0x8A63C7B9, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="policeb", Display="警用摩托车", Hash=0xFDEFAEC3, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,72,72,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="policeold1", Display="警用蓝彻", Hash=0xA46462F7, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="policeold2", Display="警用公路巡逻车", Hash=0x95F4C618, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="policet", Display="警用运输车", Hash=0x1B38E955, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="pranger", Display="国家公园警用车", Hash=0x2C33B46E, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="riot", Display="警用防暴车", Hash=0xB822A1AA, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="riot2", Display="防暴车", Hash=0x9B16A3B4, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,1,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="sheriff", Display="警长座车", Hash=0x9BAA707C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,36,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="sheriff2", Display="警长 SUV", Hash=0x72935408, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,38,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 19 当前分类: 军用车
    /// </summary>
    public static List<VehicleInfo> Military = new()
    {
        new VehicleInfo(){ Name="apc", Display="HVY APC", Hash=0x2189D250, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,1,1,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="barracks", Display="地霸王", Hash=0xCEEA3F4B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="barracks2", Display="HVY 拖车型地霸王", Hash=0x4008EABB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="barracks3", Display="地霸王", Hash=0x2592B5CF, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="barrage", Display="巴拉杰", Hash=0xF34DFB25, Mod=new int[43]{ 2,10,10,4,20,30,8,22,12,9,1,4,3,3,58,0,5,50,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="chernobog", Display="切尔诺伯格", Hash=0xD6BC7523, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="crusader", Display="卡尼斯 傲世铁骑", Hash=0x132D5A1A, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="halftrack", Display="冒险家 半履战车", Hash=0xFE141DA6, Mod=new int[43]{ 0,0,0,0,0,3,0,0,0,1,1,4,3,0,58,0,5,35,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="khanjali", Display="TM-02 可汗贾利", Hash=0xAA6F980A, Mod=new int[43]{ 0,0,0,0,0,1,0,0,0,1,1,4,3,0,58,0,5,50,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="minitank", Display="入侵与说服 坦克", Hash=0xB53C6C52, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,3,4,4,0,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="rhino", Display="犀牛坦克", Hash=0x2EA68690, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="scarab", Display="HVY 末日圣甲虫", Hash=0xBBA2A2F7, Mod=new int[43]{ 0,8,0,11,4,3,2,0,0,5,7,4,3,0,58,0,5,50,0,0,0,0,6,0,0,0,0,0,0,7,0,0,0,0,4,3,6,3,0,2,0,0,4 } },
        new VehicleInfo(){ Name="scarab2", Display="HVY 科幻圣甲虫", Hash=0x5BEB3CE0, Mod=new int[43]{ 0,10,4,16,3,3,4,0,0,5,7,4,3,0,58,0,5,50,0,0,0,0,6,0,0,0,0,0,0,0,0,0,0,0,4,3,6,2,0,2,0,0,18 } },
        new VehicleInfo(){ Name="scarab3", Display="HVY 梦魇圣甲虫", Hash=0xDD71BFEB, Mod=new int[43]{ 0,8,0,11,4,3,2,0,0,5,7,4,3,0,58,0,5,50,0,0,0,0,6,0,0,0,0,0,0,7,0,0,0,0,4,3,6,3,0,2,0,0,4 } },
        new VehicleInfo(){ Name="thruster", Display="巨象 推进者", Hash=0x58CDAF30, Mod=new int[43]{ 0,2,0,0,1,0,0,0,0,0,2,4,3,0,0,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="trailersmall2", Display="冯·伏厄 防空拖车", Hash=0x8FD54EBB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,2,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,40 } },
        new VehicleInfo(){ Name="vetir", Display="维泰尔", Hash=0x780FFBD2, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 20 当前分类: 商用车
    /// </summary>
    public static List<VehicleInfo> Commercial = new()
    {
        new VehicleInfo(){ Name="benson", Display="威皮 班森", Hash=0x7A61B330, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="biff", Display="HVY 倾卸车", Hash=0x32B91AE8, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="cerberus", Display="MTL 末日地狱犬", Hash=0xD039510B, Mod=new int[43]{ 0,0,3,0,11,3,7,5,0,5,1,4,3,4,58,5,5,50,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,4,3,6,1,0,0,0,0,4 } },
        new VehicleInfo(){ Name="cerberus2", Display="MTL 科幻地狱犬", Hash=0x287FA449, Mod=new int[43]{ 0,0,3,0,7,3,7,5,0,5,1,4,3,4,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,4,3,6,1,0,0,0,0,18 } },
        new VehicleInfo(){ Name="cerberus3", Display="MTL 梦魇地狱犬", Hash=0x71D3B6F0, Mod=new int[43]{ 0,0,3,0,11,3,7,5,0,5,1,4,3,4,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,10,0,0,0,0,4,3,6,1,0,0,0,0,4 } },
        new VehicleInfo(){ Name="hauler", Display="乔氏 搬运者", Hash=0x5A82F9AE, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="hauler2", Display="乔氏 搬运者改装版", Hash=0x171C92C4, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mule", Display="麦霸子 猛骡", Hash=0x35ED670B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mule2", Display="麦霸子 猛骡", Hash=0xC1632BEB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mule3", Display="麦霸子 猛骡", Hash=0x85A5B471, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="mule4", Display="麦霸子 猛骡改装版", Hash=0x73F4110E, Mod=new int[43]{ 0,2,0,0,0,3,0,0,0,1,1,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="mule5", Display="麦霸子 猛骡", Hash=0x501AC93C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="packer", Display="MTL 车辆运送车", Hash=0x21EEE87D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="phantom", Display="乔氏 魅影", Hash=0x809AA4CB, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="phantom2", Display="乔氏 尖锥魅影", Hash=0x9DAE1398, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="phantom3", Display="乔氏 魅影改装版", Hash=0x0A90ED5C, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="pounder", Display="MTL 跑德", Hash=0x7DE35E7D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="pounder2", Display="MTL 跑德改装版", Hash=0x6290F15B, Mod=new int[43]{ 1,0,1,0,0,3,0,0,0,1,3,4,3,3,58,0,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,30 } },
        new VehicleInfo(){ Name="stockade", Display="威霸 拦截者", Hash=0x6827CF72, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="stockade3", Display="威霸 拦截者", Hash=0xF337AB36, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="terbyte", Display="贝飞特 恐霸", Hash=0x897AFC65, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,4,3,3,58,4,5,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 21 当前分类: 火车
    /// </summary>
    public static List<VehicleInfo> Trains = new()
    {
        new VehicleInfo(){ Name="cablecar", Display="缆车", Hash=0xC6C3242D, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="freight", Display="货运列车", Hash=0x3D6AAA9B, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="freightcar", Display="货运列车", Hash=0x0AFD22A6, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="freightcar2", Display="货运列车", Hash=0xBDEC3D99, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="freightcont1", Display="货运列车", Hash=0x36DCFF98, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="freightcont2", Display="货运列车", Hash=0x0E512E79, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="freightgrain", Display="货运列车", Hash=0x264D9262, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="metrotrain", Display="货运列车", Hash=0x33C9E158, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
        new VehicleInfo(){ Name="tankercar", Display="货运列车", Hash=0x22EDDC30, Mod=new int[43]{ 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 } },
    };

    /// <summary>
    /// 22 当前分类: 开轮式
    /// </summary>
    public static List<VehicleInfo> OpenWheel = new()
    {
        new VehicleInfo(){ Name="formula", Display="培罗 PR4", Hash=0x1446590A, Mod=new int[43]{ 12,6,0,7,1,0,5,0,0,0,0,4,4,4,58,0,5,140,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="formula2", Display="欧斯洛 R88", Hash=0x8B213907, Mod=new int[43]{ 9,7,0,5,0,0,0,0,0,0,3,4,4,4,58,0,5,140,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="openwheel1", Display="贝飞特 BR8", Hash=0x58F77553, Mod=new int[43]{ 6,4,0,4,3,0,0,0,0,0,0,4,4,3,58,4,5,140,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
        new VehicleInfo(){ Name="openwheel2", Display="绝致 DR1", Hash=0x4669D038, Mod=new int[43]{ 5,7,0,4,3,6,5,0,3,0,5,4,4,4,58,0,5,140,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10 } },
    };

    /// <summary>
    /// 载具分类
    /// </summary>
    public static List<VehicleClass> VehicleClassData = new()
    {
        /*
             0 当前分类: 小型汽车
             1 当前分类: 轿车
             2 当前分类: SUV
             3 当前分类: 轿跑车
             4 当前分类: 肌肉车
             5 当前分类: 经典跑车
             6 当前分类: 跑车
             7 当前分类: 超级跑车
             8 当前分类: 摩托车
             9 当前分类: 越野车
            10 当前分类: 工业用车
            11 当前分类: 公共事业用车
            12 当前分类: 厢型车
            13 当前分类: 自行车
            14 当前分类: 船
            15 当前分类: 直升机
            16 当前分类: 飞机
            17 当前分类: 服务用车
            18 当前分类: 特种车
            19 当前分类: 军用车
            20 当前分类: 商用车
            21 当前分类: 火车
            22 当前分类: 开轮式
         */
        new VehicleClass(){ Name="常用载具", Icon="\xe610", VehicleInfo=CommonVehicle },
        new VehicleClass(){ Name="小型汽车", Icon="\xe610", VehicleInfo=Compacts },
        new VehicleClass(){ Name="轿车", Icon="\xe610", VehicleInfo=Sedans },
        new VehicleClass(){ Name="SUV", Icon="\xe610", VehicleInfo=SUVs },
        new VehicleClass(){ Name="轿跑车", Icon="\xe610", VehicleInfo=Coupes },
        new VehicleClass(){ Name="肌肉车", Icon="\xe610", VehicleInfo=Muscle },
        new VehicleClass(){ Name="经典跑车", Icon="\xe610", VehicleInfo=SportsClassics },
        new VehicleClass(){ Name="跑车", Icon="\xe610", VehicleInfo=Sports },
        new VehicleClass(){ Name="超级跑车", Icon="\xe610", VehicleInfo=Super },
        new VehicleClass(){ Name="摩托车", Icon="\xe610", VehicleInfo=Motorcycles },
        new VehicleClass(){ Name="越野车", Icon="\xe610", VehicleInfo=OffRoad },
        new VehicleClass(){ Name="工业用车", Icon="\xe610", VehicleInfo=Industrial },
        new VehicleClass(){ Name="公共事业用车", Icon="\xe610", VehicleInfo=Utility },
        new VehicleClass(){ Name="厢型车", Icon="\xe610", VehicleInfo=Vans },
        new VehicleClass(){ Name="自行车", Icon="\xe610", VehicleInfo=Cycles },
        new VehicleClass(){ Name="船", Icon="\xe610", VehicleInfo=Boats },
        new VehicleClass(){ Name="直升机", Icon="\xe610", VehicleInfo=Helicopters },
        new VehicleClass(){ Name="飞机", Icon="\xe610", VehicleInfo=Planes },
        new VehicleClass(){ Name="服务用车", Icon="\xe610", VehicleInfo=Service },
        new VehicleClass(){ Name="特种车", Icon="\xe610", VehicleInfo=Emergency },
        new VehicleClass(){ Name="军用车", Icon="\xe610", VehicleInfo=Military },
        new VehicleClass(){ Name="商用车", Icon="\xe610", VehicleInfo=Commercial },
        new VehicleClass(){ Name="火车", Icon="\xe610", VehicleInfo=Trains },
        new VehicleClass(){ Name="开轮式", Icon="\xe610", VehicleInfo=OpenWheel }
    };
}
