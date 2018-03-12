using System;
using System.Collections.Generic;

public class KdTree
{
    private Node root;
    private int K = 2;

    public class Node
    {
        public Node(Point2D point)
        {
            this.Point = point;
        }

        public Rectangle Rectangle { get; set; }
        public Point2D Point { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    public Node Root
    {
        get
        {
            return this.root;
        }
    }

    public bool Contains(Point2D point)
    {
        Node current = this.root;
        int depth = 0;
        while (current != null)
        {
            if (this.Compare(point,current.Point,depth) < 0)
            {
                current = current.Left;
            }
            else if (this.Compare(point, current.Point, depth) > 0)
            {
                current = current.Right;
            }
            else
            {
                return true;
            }
            depth++;
        }
        return false;
    }

    private int Compare(Point2D a, Point2D b, int depth)
    {
        int cmp = 0;
        if (depth % 2 == 0)
        {
            cmp = a.X.CompareTo(b.X);
            if (cmp == 0)
            {
                cmp = a.Y.CompareTo(b.Y);
            }

            return cmp;
        }
        else
        {
            cmp = a.Y.CompareTo(b.Y);
            if (cmp == 0)
            {
                cmp = a.X.CompareTo(b.X);
            }

            return cmp;
        }
    }

    public void Insert(Point2D point)
    {
        this.root = this.Insert(this.root, point, 0);
    }

    private Node Insert(Node node, Point2D point, int depth)
    {
        if (node == null)
        {
            return new Node(point);
        }

        bool isDepthOdd = depth % K == 0;
        if (isDepthOdd)
        {
            int compareX = node.Point.X.CompareTo(point.X);
            if (compareX > 0)
            {
                node.Left = this.Insert(node.Left, point, depth + 1);
            }
            else if (compareX <= 0)
            {
                node.Right = this.Insert(node.Right, point, depth + 1);
            }
        }
        else
        {
            int compareY = node.Point.Y.CompareTo(point.Y);
            if (compareY > 0)
            {
                node.Left = this.Insert(node.Left, point, depth + 1);
            }
            else if (compareY <= 0)
            {
                node.Right = this.Insert(node.Right, point, depth + 1);
            }
        }

        return node;
    }

    public void BuildFromList(List<Point2D> systems)
    {
        this.root = this.Build(systems);
    }

    private Node Build(List<Point2D> systems, int depth = 0)
    {

        if (systems.Count == 0)
        {
            return null;
        }

        int axis = depth % 2;
        systems.Sort((x, y) =>
        {
            if (axis == 0)
            {
                return x.X.CompareTo(y.X);
            }
            return x.Y.CompareTo(y.Y);
        });

        int median = systems.Count / 2;
        List<Point2D> left = new List<Point2D>();
        List<Point2D> right = new List<Point2D>();

        for (int i = 0; i < median; i++)
        {
            left.Add(systems[i]);
        }
        for (int i = median + 1; i < systems.Count; i++)
        {
            right.Add(systems[i]);
        }

        Node newNode = new Node(systems[median]);
        newNode.Left = this.Build(left, depth + 1);
        newNode.Right = this.Build(right, depth + 1);
        return newNode;
    }

    public void EachInOrder(Action<Point2D> action)
    {
        this.EachInOrder(this.root, action);
    }

    private void EachInOrder(Node node, Action<Point2D> action)
    {
        if (node == null)
        {
            return;
        }

        this.EachInOrder(node.Left, action);
        action(node.Point);
        this.EachInOrder(node.Right, action);
    }

    public void GetPoints(Action<Point2D> action, Rectangle rectangle, Rectangle space, int depth = 0)
    {
        this.EachInOrder(this.Root, action, rectangle, space, depth);
    }

    private void EachInOrder(Node node, Action<Point2D> action, Rectangle rectangle, Rectangle space, int depth)
    {
        if (node == null)
        {
            return;
        }

        if (node.Point.IsInRectangle(rectangle))
        {
            action(node.Point);
        }

        Rectangle leftRect;
        Rectangle rightRect;

        if (depth % 2 == 0)
        {
            leftRect = new Rectangle(space.X1, node.Point.X, space.Y1, space.Y2);
            rightRect = new Rectangle(node.Point.X, space.X2, space.Y1, space.Y2);
        }
        else
        {
            leftRect = new Rectangle(space.X1, space.X2, space.Y1, node.Point.Y);
            rightRect = new Rectangle(space.X1, space.X2, node.Point.Y, space.Y2);
        }

        if (rectangle.Intersects(leftRect))
        {
            this.EachInOrder(node.Left, action, rectangle, leftRect, depth + 1);
        }

        if (rectangle.Intersects(rightRect))
        {
            this.EachInOrder(node.Right, action, rectangle, rightRect, depth + 1);
        }
    }
}
