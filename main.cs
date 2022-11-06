// Created by: Allen
// Created on: Nov 2022
//
// This program calculates Volume of Sphere

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        decimal fahrenheit;
        decimal celsius;

        Console.WriteLine("This program calculates fahrenheit to celsius.");
        Console.WriteLine("");

        Console.Write("Enter the fahrenheit (°F): ");
        fahrenheit = Convert.ToInt32(Console.ReadLine());

        celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("");
        Console.WriteLine("The celsius is: " + celsius.ToString("0.00") + " °C.");

        Console.WriteLine("\nDone.");
    }
}