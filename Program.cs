﻿// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    double num1, num2;

    string operation;


    Console.WriteLine("Rehkmansa calculator");
    Console.Write("\nEnter Your First Number: ");


    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("\nEnter Your Second Number: ");

    num2 = Convert.ToDouble(Console.ReadLine());



    Console.Write("\nEnter operation symbol (+ or - or / or *) to perform required operation ");


    operation = Console.ReadLine();

    switch (operation)
    {
      case "+":
        Console.WriteLine(num1 + num2);
        break;

      case "-":
        Console.WriteLine(num1 - num2);
        break;
      case "/":
        Console.WriteLine(num1 / num2);
        break;
      case "*":
        Console.WriteLine(num1 * num2);
        break;
      default:
        Console.WriteLine("Wrong Operand Type");
        break;
    }
  }
}
