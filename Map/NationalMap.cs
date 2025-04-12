namespace DotNetLearn.Map;

public class NationalMap
{
    private MapGrid[][] data;

    /// <summary>
    ///  加载配置
    /// </summary>
    public void Load()
    {
    }


    /// <summary>
    /// 是否能操作
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="op"></param>
    /// <param name="rid"></param>
    /// <returns></returns>
    public bool CanOperate(int x, int y, Operate op, int rid)
    {
        var mapGrid = data[x][y];
        var confById = MapBuildConf.GetConfById(mapGrid.Id);
        if (confById.GridType == GridType.Obstracle)
        {
            return false;
        }

        switch (op)
        {
            case Operate.MoveCity:
                return CanMoveCity(mapGrid, confById, rid);
            case Operate.Occupied:
                return CanOccupied(mapGrid, confById);
            case Operate.Gather:
                return CanGather(mapGrid, confById);
            case Operate.Expedition:
                return CanExpedition(mapGrid, confById);
            default:
                return false;
        }
    }

    /// <summary>
    /// 是否能迁城
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="confById"></param>
    /// <param name="rid"></param>
    /// <returns></returns>
    private bool CanMoveCity(MapGrid grid, ConfStruct confById, int rid)
    {
        // TODO 判断是否是同一个联盟
        if (confById.GridType != GridType.Moor)
        {
            return false;
        }

        // 判断与其他建筑物是否重叠
        var widthAndLengthByType = MapBuildConf.GetWidthAndLengthByType(GridType.City);
        var border1 = new GridBorder
        {
            x1 = grid.X - widthAndLengthByType[0],
            y1 = grid.Y - widthAndLengthByType[1],
        };
        border1.x2 = grid.X + widthAndLengthByType[0];
        border1.y2 = grid.Y + widthAndLengthByType[1];
        for (var i = data.Length - 1; i >= 0; i--)
        {
            for (var j = 0; j < data[i].Length; j++)
            {
                var mapGrid = data[i][j];
                var temp = MapBuildConf.GetConfById(mapGrid.Id);
                if (temp.GridType != GridType.Moor)
                {
                    var border2 = new GridBorder
                    {
                        x1 = i - temp.width,
                        y1 = j - temp.width,
                    };
                    border2.x2 = i + temp.width;
                    border2.y2 = j + temp.length;
                    if (Collision(border1, border2))
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    /// <summary>
    /// 是否相撞
    /// </summary>
    /// <param name="border1"></param>
    /// <param name="border2"></param>
    /// <returns></returns>
    private bool Collision(GridBorder border1, GridBorder border2)
    {
        return !(border1.x1 >= border2.x2 || border1.y1 >= border2.y2 || border2.x1 >= border1.x2 ||
                 border2.y1 >= border1.y2);
    }

    /// <summary>
    /// 是否能占领
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="confById"></param>
    /// <returns></returns>
    private bool CanOccupied(MapGrid grid, ConfStruct confById)
    {
        if (confById.GridType != GridType.Moor)
        {
            return false;
        }

        // 是否是占领的过程
        // 是否占领中

        return true;
    }

    /// <summary>
    /// 是否能采集
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="confById"></param>
    /// <returns></returns>
    private bool CanGather(MapGrid grid, ConfStruct confById)
    {
        if (!IsResourceGrid(confById))
        {
            return false;
        }

        // 是否在采集路上
        // 是否采集中

        return true;
    }

    /// <summary>
    /// 是否是资源点
    /// </summary>
    /// <param name="confById"></param>
    /// <returns></returns>
    private bool IsResourceGrid(ConfStruct confById)
    {
        if (confById.GridType < GridType.Stone || confById.GridType > GridType.Denar)
        {
            return false;
        }

        return true;
    }


    /// <summary>
    /// 是否能远征
    /// </summary>
    /// <param name="grid"></param>
    /// <param name="confById"></param>
    /// <returns></returns>
    private bool CanExpedition(MapGrid grid, ConfStruct confById)
    {
        if (confById.GridType != GridType.Monster)
        {
            return false;
        }

        return true;
    }
}

public class GridBorder
{
    public int x1 { get; set; }
    public int y1 { get; set; }
    public int x2 { get; set; }
    public int y2 { get; set; }
}