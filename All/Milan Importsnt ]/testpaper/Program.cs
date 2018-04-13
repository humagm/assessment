using System;
namespace A

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.Clear();

            Console.WriteLine("please enter a number");

            var input = Console.ReadLine();






            var number = 0;

            var isnum = int.TryParse (input, out number);






            if(isnum){

            int count = 12;

            for (int i = 0; i <=count; i++)

            Console.WriteLine(input + "X"  +i);
            }

            Console.ResetColor();

            Console.WriteLine();

            Console.WriteLine("Press <Enter> to quit the program");

            Console.ReadKey();

        }

    }

}
