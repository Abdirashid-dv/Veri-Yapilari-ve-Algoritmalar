using System.Collections;
using DataStructures.Array.Contracts;
using DataStructures.LinkedList.Singly;

namespace DataStructures.Array;

public class Array<T> : StaticArray<T>, IDynamicArray<T>
{
    private int index = 0;

    public int Count => index;

    public int Capacity => Length;

    public void Add(T value)
    {
        CheckDoubleArray();
        _innerArray[index] = value;
        index++;
    }

    public T RemoveAt(int position)
    {
        if (position < 0 || position > Count - 1)
        {
            throw new IndexOutOfRangeException();
        }


        var removedItem = _innerArray[position];

        _innerArray[position] = default;

        for (int i = position; i < Count - 1; i++)
        {
            Swap(i, i + 1);
        }
        index--;
        ShrinkArray();
        return removedItem;
    }

    public void Swap(int position1, int position2)
    {
        var temp = _innerArray[position1];
        _innerArray[position1] = _innerArray[position2];
        _innerArray[position2] = temp;
    }

    public bool ContainsDuplicate(T[] nums)
    {
        var list = new List<T>();
        foreach (var num in nums)
        {
            if (list.Contains(num))
            {
                return true;
            }
            list.Add(num);
        }
        return false;
    }

    public SinglyLinkedList<T> ToSingleLinkedList()
    {
        var list = new SinglyLinkedList<T>();
        for (int i = 0; i < Count; i++)
        {
            list.AddLast(_innerArray[i]);
        }
        return list;
    }
    private void CheckDoubleArray()
    {
        //if (Count.Equals(Capacity))
        if (index.Equals(_innerArray.Length))
        {
            var newArray = new T[_innerArray.Length * 2];
            for (int i = 0; i < _innerArray.Length; i++)
            {
                newArray[i] = _innerArray[i];
            }
            _innerArray = newArray;
        }
    }

    private void ShrinkArray()
    {
        if (Count <= Capacity / 4)
        {
            var newArray = new T[Capacity / 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = _innerArray[i];
            }
            _innerArray = newArray;
        }
    }
}