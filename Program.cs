using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variables
            int num1 = 2;
            int num2 = 1;
            int num3 = 0;



            //Output Initial Values
            Console.WriteLine("Initial Values:");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);
            Console.WriteLine("num3 = " + num3);
            Console.WriteLine();

            //Addition 
            num3 = (num1 + num2);
            Console.WriteLine(num1 + " + " + num2 + " = " + num3);
            

            //Subtraction 
            num3 = (num1 - num2);
            Console.WriteLine(num1 + " - " + num2 + " = " + num3);

            //Multiplication
            num3 = num1 * num2;
            Console.WriteLine(num1 + " * " + num2 + " = " + num3);

            //Division
            num3 = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + num3 + "\n" );

            //Demo of overflow and underflow
            //  2147483647
            // -2147483647

            //overflow
            num1 = int.MaxValue;
            Console.WriteLine(num1 + " is int.MaxValue ");
            Console.WriteLine(num1 + " incremented by 1 is " + (num1 + 1) + "\n");
            
            //underflow
            num1 = int.MinValue;
            Console.WriteLine(num1 + " is int.MinValue ");
            Console.WriteLine(num1 + " decremented by 1 is " + (num1 - 1));
            Console.Read();


            //incrementing

            num1 = 0;

            Console.WriteLine("At first, the number is " + num1);
            Console.WriteLine("if using num1++ in this line, we will get the number as " + num1++);
            Console.WriteLine("and on the next WriteLine, we will get the number as " + num1);
            Console.WriteLine();

            num1 = 0;
            Console.WriteLine("At first, the number is " + num1);
            Console.WriteLine("if using ++num1 in this line, we will display the number as " + ++num1);
            Console.WriteLine("and on the next WriteLine, we will display the number as " + num1);
            Console.WriteLine();
            Console.Read();
            Console.Read();


            //For Loop with Switch/Case

            for(int x = 1; x < 13; x++ )
            {
                switch(x)
                {
                    case 1:
                        Console.WriteLine("month " + x + " is January");
                        break;
                    case 2:
                        Console.WriteLine("month " + x + " is February");
                        break;
                    case 3:
                        Console.WriteLine("month " + x + " is March");
                        break;
                    case 4:
                        Console.WriteLine("month " + x + " is April");
                        break;
                    case 5:
                        Console.WriteLine("month " + x + " is May");
                        break;
                    case 6:
                        Console.WriteLine("month " + x + " is June");
                        break;
                    case 7:
                        Console.WriteLine("month " + x + " is July");
                        break;
                    case 8:
                        Console.WriteLine("month " + x + " is August");
                        break;
                    case 9:
                        Console.WriteLine("month " + x + " is September");
                        break;
                    case 10:
                        Console.WriteLine("month " + x + " is October");
                        break;
                    case 11:
                        Console.WriteLine("month " + x + " is November");
                        break;
                    case 12:
                        Console.WriteLine("month " + x + " is December");
                        break;
                    default:
                        Console.WriteLine("whoops");
                        break;

                }
                
                Console.Read();
                Console.Read();



            }

            //While Loop


            //Do While Loop




        }
    }
}
