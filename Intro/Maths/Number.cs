namespace Maths
{
    public class Number
    {
        private int _number;

        public Number(int x)
        {
            _number = x;
        }

        public int Multiply()
        {
            _number = _number * 2;
            return _number;
        }

        public int Multiply(int x)
        {
            _number = x * 2;
            return _number;
        }
        
    }
}