using Maths;

var number = new Number(6);
Console.WriteLine(number.Multiply()); 
static int Multiply(ref int x)
{
    x = 2 * x;
    return x;
}

