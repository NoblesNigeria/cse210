using System.Runtime.CompilerServices;

public class mathProject
    {
        private int _topNumber;
        private int _bottomNumber;
        private int _wholeNumber;
        public int fraction()
        {
            Console.WriteLine("Hello World! This is the Fractions Project.");
            _topNumber = int.Parse(Console.ReadLine());
            _bottomNumber = int.Parse(Console.ReadLine());
            _wholeNumber = int.Parse(Console.ReadLine());
            return _topNumber / _bottomNumber;

        }
        public int Display()
        {
            Console.WriteLine($"The fraction is: {_topNumber}/{_bottomNumber}");

        }
    }