using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      PrintRightTriangle(4);
    }

    public static void PrintStars(int number)
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    public static void PrintSpaces(int number)
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write(" ");
      }

    }

    public static void PrintRightTriangle(int size)
    {
      int n = size;
      int i, j, k;
      for (i = 1; i <= n; i++)
      {
        for (k = 1 ; k <= i; k++)
        {
          PrintSpaces(n - 1);
        }
        for (j = n - i; j >= 1; j--)
        {
          PrintStars(j - i);   
        }
       Console.WriteLine("");
      }
    }

    public static void ChristmasTree(int height)
    {

    }
  }
}
