// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    string data = GetMax(10, 5);


    Console.WriteLine(data);
  }

  static string GetMax(int num1, int num2)
  {
    string result;
    if (num1 > num2)
    {
      result = num1.ToString() + " is greater than " + num2.ToString();
    }
    else if (num1 < num2)
    {
      result = num1.ToString() + " is less than " + num2.ToString();

    }
    else
    {
      result = num1.ToString() + " is equal to " + num2.ToString();

    }
    return result;
  }
}
