// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
  public static void Main(string[] args)
  {
    Users rehkmansa = new Users("rehkmansa", "developer", 22, "hjka");
    Console.WriteLine(rehkmansa.GetUserCount());
  }
}
