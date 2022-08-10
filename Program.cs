// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    string secret = "rehkmansa";

    int guesses = 5;

    string userInput = "";

    bool outOfGuess = false;


    do
    {
      if (guesses <= 0)
      {
        outOfGuess = true;
      }
      else
      {

        Console.Write("You Have " + guesses + " left \nPlease Enter any word ");

        userInput = Console.ReadLine().ToLower();

        guesses--;
      }


    } while (userInput != secret && !outOfGuess);


    if (outOfGuess)
    {
      Console.WriteLine("You Lost, Please Try Again");
    }
    else
    {
      Console.WriteLine("You won the game");
    }



  }
}
