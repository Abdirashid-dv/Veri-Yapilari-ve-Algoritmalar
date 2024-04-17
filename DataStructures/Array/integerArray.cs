namespace DataStructures.Array;

public class integerArray : Array<int>
{
    public double Mean()
    {
        double sum = 0;
        for (int i = 0; i < Length; i++)
        {
            sum += _innerArray[i];
        }
        return sum / Length;
    }
}