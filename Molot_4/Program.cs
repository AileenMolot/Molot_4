using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace Molot_4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            int a = 5;
            Square mySquare = new Square(a);

            int area = mySquare.GetArea();
            int perimeter = mySquare.GetPerimeter();

            Square mySquare2 = new Square();
            mySquare2.SideLength = a;

            int area2 = mySquare2.GetArea();
            int perimeter2 = mySquare2.GetPerimeter();

            /*
             test 1

            Console.WriteLine("mySquare area = {0}, perimeter = {1}", mySquare.GetArea(), mySquare.GetPerimeter());
            Console.WriteLine("mySquare2 side = {0}, area = {1}, perimeter = {2}", mySquare2.SideLength, mySquare2.GetArea(), mySquare2.GetPerimeter());
            */

            //task2

            AProg AProg1 = new AProg(2, 2, 3);

            int last = AProg1.GetLast();
            int sum = AProg1.GetSum();
            int avg = AProg1.GetAverage();

            AProg AProg2 = new AProg(2, 2);
            AProg2.Number = 3;

            int last2 = AProg2.GetLast();
            int sum2 = AProg2.GetSum();
            int avg2 = AProg2.GetAverage();

            /*
             * test 2
            Console.WriteLine("last = {0}, sum = {1}, average = {2}", last, sum, avg);
            Console.WriteLine("last = {0}, sum = {1}, average = {2}", last2, sum2, avg2);
            */
        }
    }
}
