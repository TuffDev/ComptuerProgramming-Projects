using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FractionPart2
    {
        public struct Fraction
        {
            private int var1, var2, var3;

            public Fraction(int first, int second, int third)
            {
                var1 = first; //whole number
                var2 = second; // numerator

                if (third != 0) // if the denom is 0, set it to 1
                {
                    var3 = third;
                }
                else
                {
                    var3 = 1;

                }
            }

            public double getFloat()
            {
                double ans = Convert.ToDouble(var1) / Convert.ToDouble(var2);
                return ans;
            }

            public int getVar1()
            {
                return var1;
            }

            public int getVar2()
            {
                return var2;
            }

            public int getVar3()
            {
                return var3;
            }

            public override string ToString()
            {
                return var3 + " " + var1 + "/" + var2;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the whole number");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numerator");
            int var2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the denominator");
            int var3 = Convert.ToInt32(Console.ReadLine());

            Fraction frac1 = new Fraction(var1, var2, var3);
        }

        static string getFracSum(Fraction frac1, Fraction frac2)
        {

            int numerator = frac1.getVar2() * frac2.getVar2();
            int denom = frac1.getVar3() * frac2.getVar3();
            int whole = frac1.getVar1() + frac2.getVar1();

            return whole + " " + numerator + "/" + denom;
        }
    }
}

