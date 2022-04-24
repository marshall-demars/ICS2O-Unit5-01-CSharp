// Created by: Marshall Demars
// Created on: Apr 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double fahrenheit;
        double celsius;

        // input
        Console.WriteLine("This program calculates Fahrenheit to Celsius");
        Console.WriteLine("");
        Console.WriteLine("The conversion formula is (fahrenheit - 32) * 5 / 9");
        Console.WriteLine("");
        Console.WriteLine("Please enter the Fahrenheit (℉)");
        Console.WriteLine("");

        Console.Write("Input the Fahrenheit: ");
        fahrenheit = Convert.ToDouble(Console.ReadLine());

        // process
        celsius = (fahrenheit - 32) * 5 / 9;

        // output
        Console.WriteLine("");
        Console.WriteLine(fahrenheit + "℉ in Celsius is: " + celsius.ToString("0.00") + "℃");
        Console.WriteLine("\nDone.");
    }
}
