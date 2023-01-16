using System;

namespace Adaptor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! adapter");
            Circle c1 = new Circle(2);
            SqauareAdapter s1 = new SqauareAdapter(2);

            Console.WriteLine(c1.Circumfarence());
            Console.WriteLine(s1.Circumfarence());
        }
    }

    interface ICircle
    {
        public double Circumfarence();
    }
    interface ISquare
    {
        public double Perimeter();
    }
    class Circle : ICircle
    {
        public double Radius { get; set; }
        public Circle(double radius) { Radius = radius; }
        public double Circumfarence()
        {
            return 3.14 * Radius * Radius;
        }
    }
    class Square : ISquare
    {
        public double Length { get; set; }
        public Square(double length) { Length = length; }
        public double Perimeter() { return 4 * Length; }
    }
    class SqauareAdapter : ICircle
    {
        public Square sq;
        public SqauareAdapter(double length) { sq = new Square(length); }
        public double Circumfarence()
        {
            return sq.Perimeter();
        }
    }
}

