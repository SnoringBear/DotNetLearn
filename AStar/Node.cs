namespace DotNetLearn.AStar;
// Node 表示网格中的一个节点
public class Node
{
    public int X { get; set; }
    public int Y { get; set; }
    public double F { get; set; } // F = G + H
    public double G { get; set; } // 从起点到当前节点的实际代价
    public double H { get; set; } // 启发式估计值
    public Node Parent { get; set; } // 父节点

    public Node(int x, int y)
    {
        X = x;
        Y = y;
    }

    // 重写 Equals 和 GetHashCode 以便在字典中使用
    public override bool Equals(object obj)
    {
        if (obj is Node other)
            return X == other.X && Y == other.Y;
        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode();
    }
}