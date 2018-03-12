using System;

public static class Heap<T> where T : IComparable<T>
{
    public static void Sort(T[] arr)
    {
        int n = arr.Length;

        for (int i = n/2 - 1; i >= 0; i--)
        {
            HeapifyDown(arr, i,n);
        }

        for (int i = n - 1; i >= 0; i--)
        {
            Swap(arr, 0, i);
            HeapifyDown(arr, 0,i);
        }
    }
    private static void HeapifyDown(T[] heap, int index, int length)
    {
        int parentIndex = index;

        while (parentIndex < length / 2)
        {
            //Left child
            int childIndex = (parentIndex * 2) + 1;

            //Check if there is right child && rightchild > leftChild
            if (childIndex + 1 < length && IsGreater(heap,childIndex, childIndex + 1))
            {
                //Right Child ( LeftChild + 1)
                childIndex += 1;
            }

            int compare = heap[parentIndex]
                .CompareTo(heap[childIndex]);

            if (compare < 0)
            {
                Swap(heap,childIndex, parentIndex);
            }
            parentIndex = childIndex;
        }
    }

    private static bool IsGreater(T[] heap, int left, int right)
    {
        return heap[left].CompareTo(heap[right]) < 0;
    }
    private static void Swap(T[] heap, int index, int parent)
    {
        T temp = heap[parent];
        heap[parent] = heap[index];
        heap[index] = temp;
    }
}
