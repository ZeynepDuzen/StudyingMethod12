using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingMethod12
{
    internal class Program
    {
        //int MyMethod(int x)
        //double MyMethod(double x)
        //float MyMethod(float x, float y)

        static int SumMethod(int x,int y) {
            return x + y;
        }

        static double SumMethod(double x , double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int num1 = SumMethod(5,6);
            double num2 = SumMethod(4.5, 5.5);
            Console.WriteLine("int value : " + num1);
            Console.WriteLine("double value : " + num2);

            Console.Read();
        }
    }
}
