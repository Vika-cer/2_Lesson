using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            //5*) Дослідити інші способи поміняти місцями значення двох змінних без використання тимчасової змінної. 
            Console.Write("Enter variable 1: ");
            int inputNum1 = int.Parse(Console.ReadLine());
            Console.Write("Enter variable 2: ");
            int inputNum2 = int.Parse(Console.ReadLine());

            //inputNum2 = inputNum1 + (inputNum1 = inputNum2) - inputNum2;    //Way1

            //inputNum1 = inputNum1 * inputNum2;    //Way2
            //inputNum2 = inputNum1 / inputNum2;    //Way2
            //inputNum1 = inputNum1 / inputNum2;    //Way2


            Console.WriteLine($" \nVariable 1 is {inputNum1} \nVariable 2 is {inputNum2}\n");
            Console.ReadKey();
        }

    }

}

