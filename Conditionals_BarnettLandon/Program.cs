using System.Runtime.CompilerServices;

namespace Conditionals_BarnettLandon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks for a number to check and assigns it
            Console.WriteLine("Give me a number Yo");
            int myNum = Convert.ToInt32(Console.ReadLine());
            
            //Checks positive or negative value
            if (myNum >= 0) 
            {
                Console.WriteLine($"{myNum} is a positive number");
            }
            else
            {
                Console.WriteLine($"{myNum} is a negative number");
            }
            //Checks even or odd
            if (myNum % 2 == 0)
            {
                Console.WriteLine($"{myNum} is an even number");
            }
            else
            {
                Console.WriteLine($"{myNum} is an odd number");
            }
            //Gets 2 more numbers
            int num1 = 4;
            int num2 = 59;
            //max of myNum and new number
            int firstMax = Math.Max(myNum, num1);
            //maximum number
            int max = Math.Max(firstMax, num2);
            //Prints max to console
            Console.WriteLine($"The maximun number of {myNum}, {num1}, and {num2} is {max}");

            //Asks to enter a grade and assigns it to char var
            Console.WriteLine("Enter a grade (A, B, C, D, F)");
            char grade = Console.ReadKey().KeyChar;

            //Prints description based on grade value
            switch ( grade ) 
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("\nYou did not enter a valid grade");
                    break;
            }
        }
    }
}