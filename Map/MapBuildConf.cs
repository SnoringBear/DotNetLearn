namespace DotNetLearn.Map;

/// <summary>
/// 地图资源配置
/// </summary>
public class MapBuildConf
{
    // 配置
    public static Dictionary<int, ConfStruct> confs { get; set; }

    /// <summary>
    /// 加载配置
    /// </summary>
    public void Load()
    {
    }

    /// <summary>
    /// 获取配置
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public static ConfStruct GetConfById(int id)
    {
        return confs[id];
    }

    /// <summary>
    /// 根据类型获取宽、高
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static List<int> GetWidthAndLengthByType(GridType type)
    {
        List<int> list = new List<int>();
        foreach (var confsValue in confs.Values)
        {
            if (confsValue.GridType == type)
            {
                list.Add(confsValue.width);
                list.Add(confsValue.length);
                return list;
            }

        }
        return list;
    }
}

/// <summary>
/// 建筑物配置
/// </summary>
public class ConfStruct
{
    // 配置id
    public int Id { get; set; }

    // 格子类型
    public GridType GridType { get; set; }

    // 宽度
    public int width {get; set; }
    // 长度
    public int length { get; set; }

    // 等级
    public int Level { get; set; }

    // 名称
    public string Name { get; set; }

    // 可能掉落奖励
    public string Reward { get; set; }

    // 推荐实力
    public int RecommendPower { get; set; }


    // 远征消耗
    public int ExpeditionConsume { get; set; }

    // 远征条件
    public int ExpeditionLevel { get; set; }


    // 储量
    public int Reserves { get; set; }

    // 采集消耗时间
    public int ConsumeTime { get; set; }
}