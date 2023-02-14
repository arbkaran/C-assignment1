// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {

        static void Assignment1()
        {
            string name = "Antti";
            int currentScore = 1000;
            int levelScore = 50;
            int totalScore = currentScore + levelScore;

            Console.WriteLine("Antti has score before level: " + currentScore);
            Console.WriteLine("Antti has score after level:: " + totalScore);
        }

        static void Assignment2()
        {
            double x = 10.5, y = 20, multiplier = 0.5;
            double xMultiplier = x * multiplier;
            double yMultiplier = y * multiplier;
            Console.WriteLine("Divided X : " + xMultiplier + " ,y:" + yMultiplier);
        }
        /*
        Include at least the following:
        - Name
        - Age
        - Hometown
        - Favorite color
        - Likes rock-music - true/false
        */
        static void Assignment3()
        {
            string name = "Arup", hometown = "Bangladesh", color = "green";
            int age = 19;
            Boolean likeRockMusisc = true;
            Boolean hasPet = true;
            Console.WriteLine(
                 "My Name is " + name + "\n" +
                 "I am " + age + " years old" + "\n" +
                 "I am from " + hometown + "\n" +
                 "My favourite color is " + color + "\n" +
                 "It is " + likeRockMusisc + " that I like Rock Music" + "\n" +
                 "It is " + hasPet + " that I have a pet" + "\n"
            );
        }
        static void Main(string[] args)
        {
            // Assignment1();
            // Assignment2();
            Assignment3();

        }
    }
}
