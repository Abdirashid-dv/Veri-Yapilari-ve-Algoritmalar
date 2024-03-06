using DataStructures.Array.Contracts;

namespace DataStructures.Array;

public class Array<T> : StaticArray<T>, IDynamicArray<T>
{
    private int index = 0;

    public int Count => index;

    public int Capacity => _innerArray.Length;

    public void Add(T value)
    {
        if (index == _innerArray.Length)
        {
            // katlama işlemi yapılacak
            DoubleArray();

        }
        _innerArray[index] = value;
        index++;
    }

    public void DoubleArray()
    {
        T[] tempArray = new T[_innerArray.Length * 2];
        // for (int i = 0; i < _innerArray.Length; i++)
        // {
        //     tempArray[i] = _innerArray[i];
        // }
        System.Array.Copy(_innerArray, tempArray, _innerArray.Length);
        _innerArray = tempArray;
    }

    public T RemoveAt(int position)
    {
        CheckIndex(position);

        _innerArray[position] = default(T);

        for (int i = position; i < Count - 1; i++)
        {
            Swap(i, i + 1);
        }
        index--;
        ShrinkArray();
        return _innerArray[position];

    }

    public void Swap(int position1, int position2)
    {
        CheckIndex(position1);
        // CheckIndex(position2);

        T temp = _innerArray[position1];
        _innerArray[position1] = _innerArray[position2];
        _innerArray[position2] = temp;

    }

    private void ShrinkArray()
    {
        if (Count < Capacity / 4)
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