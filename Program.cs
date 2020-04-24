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

            Console.WriteLine("Type the width (meters): ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Tyoe the height (meters): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " meters.");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres.");
            Console.WriteLine("My name is " + message + " and I am from " + message1);

            Console.ReadKey();
        }
    }
}
