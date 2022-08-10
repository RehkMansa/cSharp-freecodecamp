// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    int index = 1;


    while (index <= 5)
    {
      Console.Write(index);


      index++;
    }


    for (int i = 0; i <= 5; i++)
    {
      Console.Write(i);
    }


    do
    {
      index++;
    } while (index <= 5);
  }
}
