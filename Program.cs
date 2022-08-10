// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    string data = GetMax(7);


    Console.WriteLine(data);
  }

  static string GetMax(int date)
  {
    string result;
    switch (date)
    {
      case 1:
        result = "Monday";
        break;

      default:

        result = "Enter a valid date";
        break;
    }
    return result;
  }
}
