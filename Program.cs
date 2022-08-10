// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    try
    {
      Console.Write("Enter Input 1: ");
      int num1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter Input 2: ");
      int num2 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(num1 / num2);
    }
    catch (Exception e)
    {

      Console.WriteLine(e.Message);
    }
  }

}
