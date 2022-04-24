// Created by: Marshall Demars
// Created on: Apr 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program guesses the correct number
        int guess;
        Random randomNumber = new Random();
        int number = randomNumber.Next(1, 6);

        // input
        Console.WriteLine("This program lets the user guess a number between 1-6");

        Console.WriteLine("");
        Console.Write("Input a number between 1-6: ");
        guess = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        if (guess == number)
        {
            Console.WriteLine("You are correct!");
        }

        if (guess != number)
        {
            Console.WriteLine("Sorry ,you are incorrect!");
        }

        Console.WriteLine("\nDone.");
    }
}