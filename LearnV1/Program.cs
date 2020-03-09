using System;

namespace LearnV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            rectangle rectangle1 = new rectangle();
            rectangle1.basis = 3;
            rectangle1.height = 7;

            Console.WriteLine(rectangle1.area());
            Console.WriteLine(rectangle1.perimeter());

            //rectangle1.grow(3); //suma 3 a basis y height

            Console.WriteLine(rectangle1.area());
            Console.WriteLine(rectangle1.perimeter());

            rectangle rectangle2 = new rectangle();
            rectangle2.basis = 1.5;
            rectangle2.height = 4;

            //diferencia entre area rectangle1 y rectangle1
            Console.WriteLine(rectangle1.compare(rectangle2));

            rectangle rectangle3 = new rectangle();
            rectangle3.basis = 8;
            rectangle3.height = 12;

            //obs

            Console.ReadKey();
        }
    }
}
