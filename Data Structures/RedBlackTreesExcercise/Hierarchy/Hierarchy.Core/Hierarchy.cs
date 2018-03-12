using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public class Hierarchy<T> : IHierarchy<T>
{
    private Node root;
    private Dictionary<T, Node> nodesByValue;

    public Hierarchy(T root)
    {
        this.root = new Node(root);
        this.nodesByValue = new Dictionary<T, Node>
        {
            {root,this.root }
        };
    }

    public int Count
    {
        get
        {
            return this.nodesByValue.Count;
        }
    }

    public void Add(T element, T child)
    {
        if (!nodesByValue.ContainsKey(element) || nodesByValue.ContainsKey(child))
        {
            throw new ArgumentException();
        }
        var node = nodesByValue[element];
        var childNode = new Node(child,node);
        node.Children.Add(childNode); 
        nodesByValue.Add(child, childNode);
    }

    public void Remove(T element)
    {
        if (!nodesByValue.ContainsKey(element))
        {
            throw new ArgumentException();
        }

        var node = nodesByValue[element];

        if (node.Parent==null)
        {
            throw new InvalidOperationException();
        }

        foreach (var child in node.Children)
        {
            child.Parent = node.Parent;
            node.Parent.Children.Add(child);
        }

        node.Parent.Children.Remove(node);
        nodesByValue.Remove(element);
    }

    public IEnumerable<T> GetChildren(T item)
    {
        if (!nodesByValue.ContainsKey(item))
        {
            throw new ArgumentException();
        }
        return nodesByValue[item].Children.Select(x=>x.Value);
    }

    public T GetParent(T item)
    {
        if (!nodesByValue.ContainsKey(item))
        {
            throw new ArgumentException();
        }
        var node = nodesByValue[item];

        return node.Parent != null ? node.Parent.Value : default(T) ;
    }

    public bool Contains(T value)
    {
        return nodesByValue.ContainsKey(value);
    }

    public IEnumerable<T> GetCommonElements(Hierarchy<T> other)
    {
        var commonElements = new List<T>();
        foreach (var elem in this.nodesByValue)
        {
            if (other.Contains(elem.Key))
            {
                commonElements.Add(elem.Key);
            }
        }
        return commonElements;
    } 

    public IEnumerator<T> GetEnumerator()
    {
        var queue = new Queue<Node>();
        queue.Enqueue(this.root);
        while (queue.Count > 0)
        {
            var current = queue.Dequeue();
            yield return current.Value;
            foreach (var child in current.Children)
            {
                queue.Enqueue(child);
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class Node
    {
        public Node Parent { get; set; }

        public T Value { get; set; }

        public List<Node> Children { get; set; }

        public Node(T value, Node parent = null)
        {
            this.Value = value;
            this.Children = new List<Node>();
            this.Parent = parent;
        }
    }
}
