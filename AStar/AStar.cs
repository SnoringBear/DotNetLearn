namespace DotNetLearn.AStar;

public class AStar
{
    // A* 寻路算法
    public static List<Node> FindPath(int[,] grid, Node start, Node goal)
    {
        var openList = new List<Node> { start };
        var closedList = new HashSet<Node>();

        while (openList.Count > 0)
        {
            // 找到 F 值最小的节点
            var current = openList[0];
            int currentIndex = 0;
            for (int i = 1; i < openList.Count; i++)
            {
                if (openList[i].F < current.F)
                {
                    current = openList[i];
                    currentIndex = i;
                }
            }

            // 如果当前节点是目标节点，返回路径
            if (current.X == goal.X && current.Y == goal.Y)
                return ReconstructPath(current);

            // 将当前节点从开放列表移到关闭列表
            openList.RemoveAt(currentIndex);
            closedList.Add(current);

            // 遍历当前节点的邻居
            foreach (var neighbor in GetNeighbors(current, grid))
            {
                // 如果邻居在关闭列表中，跳过
                if (closedList.Contains(neighbor))
                    continue;

                // 计算从起点到邻居的 G 值
                double tentativeG = current.G + 1; // 假设每步代价为 1

                // 如果邻居不在开放列表中，或者新的 G 值更小
                if (!openList.Contains(neighbor) || tentativeG < neighbor.G)
                {
                    neighbor.Parent = current;
                    neighbor.G = tentativeG;
                    neighbor.H = Heuristic(neighbor, goal);
                    neighbor.F = neighbor.G + neighbor.H;

                    // 如果邻居不在开放列表中，加入开放列表
                    if (!openList.Contains(neighbor))
                        openList.Add(neighbor);
                }
            }
        }

        // 如果开放列表为空且未找到目标节点，返回空路径
        return null;
    }

    // 获取当前节点的邻居节点
    static List<Node> GetNeighbors(Node node, int[,] grid)
    {
        var neighbors = new List<Node>();
        int[] dx = { -1, 1, 0, 0 }; // 上下左右四个方向
        int[] dy = { 0, 0, -1, 1 };

        for (int i = 0; i < 4; i++)
        {
            int x = node.X + dx[i];
            int y = node.Y + dy[i];

            // 检查邻居是否在地图范围内且不是障碍物
            if (x >= 0 && x < grid.GetLength(0) && y >= 0 && y < grid.GetLength(1) && grid[x, y] == 0)
                neighbors.Add(new Node(x, y));
        }

        return neighbors;
    }

    // 计算启发式估计值（曼哈顿距离）
    static double Heuristic(Node a, Node b)
    {
        return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
    }

    // 从目标节点回溯路径
    static List<Node> ReconstructPath(Node node)
    {
        var path = new List<Node>();
        var current = node;

        while (current != null)
        {
            path.Add(current);
            current = current.Parent;
        }

        path.Reverse(); // 反转路径，从起点到终点
        return path;
    }

    [Test]
    public void Test01()
    {
        // 示例网格地图（0表示可通行，1表示障碍物）
        int[,] grid = {
            { 0, 0, 0, 0, 1 },
            { 1, 1, 0, 1, 0 },
            { 0, 0, 0, 1, 0 },
            { 0, 1, 1, 1, 0 },
            { 0, 0, 0, 0, 0 }
        };

        var start = new Node(0, 0);
        var goal = new Node(4, 4);

        var path = FindPath(grid, start, goal);

        if (path != null)
        {
            Console.WriteLine("找到路径：");
            foreach (var node in path)
                Console.WriteLine($"({node.X}, {node.Y})");
        }
        else
        {
            Console.WriteLine("未找到路径");
        }
    }
}