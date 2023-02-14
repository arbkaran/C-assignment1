// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Antti";
            int currentScore = 1000;
            int levelScore = 50;
            int totalScore = currentScore + levelScore;

            Console.WriteLine("Antti has score before level: " + currentScore);
            Console.WriteLine("Antti has score after level:: " + totalScore);


        }
    }
}
