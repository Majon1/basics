using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
        PrintStars(5);
        PrintStars(3);
        PrintStars(9);
        PrintSquare(4);
        PrintRectangle(17,3);
        PrintTriangle(4);
    }


    public static void PrintStars(int number)
    {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
      for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
     }

    public static void PrintSquare(int size)
      {
      int i = 0;
      {
      for (i = 0; i < size; i++)
      {
        PrintStars(size);
      }
      }
    }

    public static void PrintRectangle(int width, int height)
    {
      int j = 0;
      for (j = 0; j < height; j++)
      {
      PrintStars(width);   
      }
    }

    public static void PrintTriangle(int size)
    {//
      int l;
      int k = size;
      for (l = 0; l <= size; l++)
      {
        PrintStars(size - k);
        k--;
      }
    }
  }
}

