// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    try
    {
      Console.ReadLine();
    }
    catch (Exception e)
    {

      throw new(e.Message);
    }
  }

}
