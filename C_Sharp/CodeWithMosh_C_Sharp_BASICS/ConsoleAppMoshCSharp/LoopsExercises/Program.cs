using System;

namespace LoopsExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loops Exercise #2
            Console.WriteLine("Exercise #2");
            int num1 = 0;
            string input = "";
            while (input != "ok")
            {
                Console.WriteLine("enter a number or type 'ok' to exit and calculate the sum");
                input = Console.ReadLine();
                if (input != "ok")
                {
                    num1 = num1 + Int32.Parse(input);
                }
            }
            Console.WriteLine("total sumn = " + num1);

            //Loops Exercise #3
            Console.WriteLine("Exercise #3: Enter a number");
            var input2 = Console.ReadLine();
            int num2 = Int32.Parse(input2);
            int numTotal = 0;
            while (num2 != 0)
            {
                numTotal = numTotal + num2;
                Console.WriteLine(numTotal);
                num2--;
            }
            Console.WriteLine("Factorial sum = " + numTotal);

            //Loops Exercise #4
            Console.WriteLine("Exercise #4");
            var random = new Random();
            int num3 = random.Next(1, 10);
            for (var i = 4; i > 0; i--)
            {
                Console.WriteLine("guess a number between 1 and 10");
                int input3 = Int32.Parse(Console.ReadLine());
                if (input3 == num3)
                {
                    Console.WriteLine("You guessed correctly!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
            Console.WriteLine("This was the correct number : " + num3);
        }
    }
}
