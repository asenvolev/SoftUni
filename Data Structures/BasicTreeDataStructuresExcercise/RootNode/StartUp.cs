using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();

    public static void Main()
    {
        ReadTree();
        int targetSum = int.Parse(Console.ReadLine());
        var rootNode = GetRootNode();
        Console.WriteLine($"Subtrees of sum {targetSum}:");
        SubtreeDFS(rootNode, targetSum);
    }

    static int SubtreeDFS(Tree<int> node, int sum)
    {
        int currentSum = node.Value;

        foreach (var child in node.Children)
        {
            currentSum += SubtreeDFS(child, sum);
        }

        if (sum == currentSum)
        {
            List<int> subtree = new List<int>();
            GetSubtree(node, subtree);
            Console.WriteLine(string.Join(" ", subtree));
        }

        return currentSum;
    }

    static void GetSubtree(Tree<int> node, List<int> result)
    {
        result.Add(node.Value);
        foreach (var child in node.Children)
        {
            GetSubtree(child, result);
        }
    }

    public static void AllPathsWithAGivenSum(Tree<int> node, int targetSum, int currSum =0)
    {
        currSum += node.Value;
        if (currSum == targetSum)
        {
            PrintCurrentPath(node);
        }

        foreach (var child in node.Children)
        {
            AllPathsWithAGivenSum(child,targetSum,currSum);
        }
    }

    private static void PrintCurrentPath(Tree<int> node)
    {
        Stack<int> path = new Stack<int>();
        path.Push(node.Value);
        while (node.Parent!=null)
        {
            node = node.Parent;
            path.Push(node.Value);
        }
        Console.WriteLine(string.Join(" ",path));
    }

    public static void LongestPath()
    {
        var rootNode = GetRootNode();
        List<int> result = new List<int>();

        FindDeepestNode(rootNode, result);

        int deepestNodeValue = result[1];
        var deepestNode = nodeByValue[deepestNodeValue];
        List<int> longestPath = new List<int>();
        longestPath.Add(deepestNodeValue);
        while (deepestNode.Parent!=null)
        {
            deepestNode = deepestNode.Parent;
            longestPath.Add(deepestNode.Value);
        }
        longestPath.Reverse();
        Console.WriteLine($"Longest path: {string.Join(" ",longestPath)}");
    }

    public static void FindDeepestNode(Tree<int> node, List<int> result , int currDepth=0)
    {
        if (result.Any())
        {
            if (result[0] < currDepth)
            {
                result[0] = currDepth;
                result[1] = node.Value;
            }
        }
        else
        {
            result.Add(currDepth);
            result.Add(node.Value);
        }
                
        foreach (var child in node.Children)
        {
            FindDeepestNode(child, result, currDepth+1);
        }
        
    }

    public static void PrintMiddleNodes()
    {
        var nodes = nodeByValue
            .Values
            .Where(x => x.Parent != null && x.Children.Any())
            .Select(x => x.Value)
            .OrderBy(x => x)
            .ToArray();

        Console.WriteLine($"Middle nodes: {string.Join(" ",nodes)}");
    }

    public static void FindAllLeafNodes(Tree<int> node, List<int> leafs)
    {
        if (node.Children.Any())
        {
            foreach (var child in node.Children)
            {
                FindAllLeafNodes(child,leafs);
            }
        }
        else
        {
            leafs.Add(node.Value);
        }
    }

    public static void PrintTree(Tree<int> node, int indent = 0)
    {
        Console.Write(new string(' ', 2 * indent));
        Console.WriteLine(node.Value);
        foreach (var child in node.Children)
        {
            PrintTree(child, indent+1);
        }
    }

    public static Tree<int> GetRootNode()
    {
        return nodeByValue.Values.FirstOrDefault(x => x.Parent == null);
    }

    public static void ReadTree()
    {
        var nodeCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < nodeCount-1; i++)
        {
            var edge = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int parentValue = edge[0];
            int childValue = edge[1];
            AddEdge(parentValue, childValue);
        }
    }

    public static void AddEdge(int parent,int child)
    {
        var parentNode = GetTreeNodeByValue(parent);
        var childNode = GetTreeNodeByValue(child);

        parentNode.Children.Add(childNode);
        childNode.Parent = parentNode;
    }

    public static Tree<int> GetTreeNodeByValue(int value)
    {
        if (!nodeByValue.ContainsKey(value))
        {
            nodeByValue.Add(value, new Tree<int>(value));
        }
        return nodeByValue[value];
    }
}

