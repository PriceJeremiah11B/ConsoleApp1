using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Jeremiah";
            string message1 = "Idaho";

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.WriteLine("My name is " + message + " and I am from " + message1);

            Console.ReadKey();
        }
    }
}
