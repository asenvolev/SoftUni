using System;
using System.Collections.Generic;

public class AStar
{
    private char[,] maze;
    private PriorityQueue<Node> pQue;
    private Dictionary<Node, Node> parents;
    private Dictionary<Node, int> gCost;

    public AStar(char[,] map)
    {
        this.maze = map;
        this.parents = new Dictionary<Node, Node>();
        this.pQue = new PriorityQueue<Node>();
        this.gCost = new Dictionary<Node, int>();
    }

    public static int GetH(Node current, Node goal)
    {
        var deltaX = Math.Abs(current.Col - goal.Col);
        var deltaY = Math.Abs(current.Row - goal.Row);

        return deltaX + deltaY;
    }

    public IEnumerable<Node> GetPath(Node start, Node goal)
    {
        pQue.Enqueue(start);
        gCost.Add(start, 0);
        parents.Add(start, null);
        while (pQue.Count>0)
        {
            Node current = pQue.Dequeue();
            if (current.Equals(goal))
            {
                break;
            }
            var neighbourNodes = GetNeigbourNodes(current);
            foreach (var node in neighbourNodes)
            {
                int newCost = gCost[current] + 1;
                if (!gCost.ContainsKey(node) || newCost<gCost[current])
                {
                    node.F = newCost + GetH(node, goal);
                    parents.Add(node, current);
                    gCost.Add(node, newCost);
                    pQue.Enqueue(node);
                }

            }
        }

        return this.ReconstructPath(parents, start, goal);
    }

    private IEnumerable<Node> ReconstructPath(Dictionary<Node, Node> parents, Node start, Node goal)
    {
        var path = new Stack<Node>();

        if (!parents.ContainsKey(goal))
        {
            return new List<Node>()
            {
                start
            };
        }
        Node current = parents[goal];
        path.Push(goal);
        while (!current.Equals(start))
        {
            path.Push(current);
            current = parents[current];
        }
        path.Push(start);
        return path;
    }

    private List<Node> GetNeigbourNodes(Node current)
    {
        var neighbours = new List<Node>();
        if (current.Row-1>=0 && maze[current.Row - 1, current.Col] !='W')
        {
            neighbours.Add(new Node(current.Row - 1, current.Col));
        }
        if (current.Row+1 < maze.GetLength(0) && maze[current.Row + 1, current.Col] != 'W')
        {
            neighbours.Add(new Node(current.Row + 1, current.Col));
        }
        if (current.Col-1 >=0 && maze[current.Row, current.Col - 1] != 'W')
        {
            neighbours.Add(new Node(current.Row, current.Col - 1));
        }
        if (current.Col+1 < maze.GetLength(1) && maze[current.Row, current.Col + 1] != 'W')
        {
            neighbours.Add(new Node(current.Row, current.Col + 1));
        }
        
        return neighbours;
    }
}

