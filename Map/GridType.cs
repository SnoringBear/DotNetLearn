namespace DotNetLearn.Map;

/// <summary>
/// 格子类型
/// </summary>
public enum GridType
{
    // 荒原
    Moor = 1,

    // 怪物
    Monster = 2,

    // 城市
    City = 3,

    // 石料
    Stone = 4,

    // 农田
    Farmland = 5,

    // 木材
    Wood = 6,

    // 金矿
    Gold = 7,

    // 宝石
    Denar = 8,

    // 斥候
    Scouts = 9,

    // 村庄
    Village = 10,

    // 山洞
    Cave = 11,

    // 联盟金矿床
    GuildGold = 12,

    // 障碍物
    Obstracle = 13,
}

/// <summary>
/// 操作类型
/// </summary>
public enum Operate
{
    // 迁城
    MoveCity = 100,

    // 占领
    Occupied = 200,

    // 采集
    Gather = 300,

    // 远征
    Expedition = 400,
}