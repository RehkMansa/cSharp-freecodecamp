// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {

    Console.WriteLine(Exponent(3, 3));

  }

  static int Exponent(int num, int exp)
  {
    int result = num;


    for (int i = 1; i < exp; i++)
    {
      result *= num;
    }


    return result;
  }
}
