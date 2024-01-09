using System;

namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OperatorExamples();
            //Repeat();
            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TryAnIfElse()
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if((someValue == 1) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("this line runs no matter what");
        }

        private static void TrySomeLoops()
        {
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x must be 10");
            }
            else
                Console.WriteLine("x isn't 10");
        }

        private static void TryAnIf()
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for(int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            Console.WriteLine(count);
        }

        private static void OperatorExamples()
        {
            int width = 3;
            width++;

            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);

            while (area < 20) 
            {
                height++;
                area = width * height;
            }

            do
            {
                width--;
                area = width * height;
            } while (area > 25);
        }

        static void Repeat()
        {
            int p = 2;
            for(int q = 2; q < 32; q *= 2)
            {
                while(p < q)
                {
                    p *= 2;
                }
                q = p - q;
            }
        }

    }
}