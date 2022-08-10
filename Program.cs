// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    int cubNum = Cube(5);

    Console.WriteLine(cubNum);
  }

  static int Cube(int num)
  {
    int data = (num * num * num);
    return data;
  }
}
