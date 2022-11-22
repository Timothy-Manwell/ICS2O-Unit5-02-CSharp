// Created by: Timothy Manwell
// Created on: Nov 2022
//
// This program generates a positive or negative number
using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumPos = random.Next(1, 7);
        int randomNumNeg = random.Next(-7, -1);
        int prefer;

        Console.WriteLine("Welcome to the RandomNum generator!");
        Console.WriteLine("\nYou can choose to generate a positive or negative number");
        Console.Write("\nType 1 for a positive number or 2 for a negative number: ");
        prefer = Convert.ToInt32(Console.ReadLine());

        if (prefer == 1)
        {
            Console.WriteLine("\nYour random positive number is " + randomNumPos);
        } else if (prefer == 2){
            Console.WriteLine("\nYour random negative number is " + randomNumNeg);
        } else {
          Console.WriteLine("\nUnknown input. Try again");
        }
    }
}