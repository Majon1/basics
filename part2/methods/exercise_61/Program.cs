using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
      PrintRightTriangle(4);
      ChristmasTree(10);
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
      int i;
      for (i = 1; i <= n; i++)
      {
        PrintSpaces(n - i);
        
        PrintStars(i);   
      }
    }

    public static void ChristmasTree(int height)
    {
      int l = height;
      int i; 
      int k = 1;
      int t = 0;
      
      for (i = 1; i <= l; i++)
      {
        PrintSpaces(l - i);
        PrintStars(t + i);
        t++; 
      }
      for (k = 1; k <= 2; k++)
      {
      PrintSpaces (l - 2);
      PrintStars (3);
      }
     
    }
  }
  }

