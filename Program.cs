// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    string secret = "rehkmansa";

    string guess = "";

    while (guess != secret.ToLower())
    {
      Console.Write("Enter a word: ");

      guess = Console.ReadLine().ToLower();
    }
  }
}
