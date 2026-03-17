using System.Runtime.CompilerServices;

public class mathProject
    {
        private int _topNumber;
        private int _bottomNumber;
        private int _wholeNumber;
       
        public void fraction()
        {
            Console.WriteLine("Hello World! This is the Fractions Project.");
            _topNumber = int.Parse(Console.ReadLine());
            _bottomNumber = int.Parse(Console.ReadLine());

            Return _topNumber / _bottomNumber;
        }
    }