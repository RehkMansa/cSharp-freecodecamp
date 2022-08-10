// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    string secret = "rehkmansa";

    string guess = "";

    int guessCount = 5;

    bool outOfGuess = false;

    while (guess != secret && !outOfGuess)
    {
      guessCount--;

      Console.Write("Please enter any word: ");

      guess = Console.ReadLine().ToLower();

      Console.WriteLine("You have " + guessCount + " left");

      if (guessCount <= 0)
      {
        outOfGuess = true;
      }

    }


    if (outOfGuess)
    {
      Console.WriteLine("You loose");
    }
    else
    {
      Console.WriteLine("Yeah!!! You got the answer");
    }

  }
}
