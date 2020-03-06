using System.Collections.Generic;
using System;
public class GradeRegister
{
  private List<int> grades;
  private List<int> scores;

  public GradeRegister()
  {
    this.grades = new List<int>();
    this.scores = new List<int>();
  }

  public void AddGradeBasedOnPoints(int points)
  {
    this.grades.Add(PointsToGrades(points));
    this.scores.Add(points);
  }

  public int NumberOfGrades(int grade)
  {
    int count = 0;
    foreach (int received in this.grades)
    {
      if (received == grade)
      {
        count++;
      }
    }
    return count;
  }

  public static int PointsToGrades(int points)
  {
    int grade = 0;
    if (points < 50)
    {
      grade = 0;
    }
    else if (points < 60)
    {
      grade = 1;
    }
    else if (points < 70)
    {
      grade = 2;
    }
    else if (points < 80)
    {
      grade = 3;
    }
    else if (points < 90)
    {
      grade = 4;
    }
    else
    {
      grade = 5;
    }
    return grade;
  }

  public double AverageOfGrades()
  { 
    if (this.grades.Count == 0)
    {
    return -1;
    }
    int sum = 0;
    foreach (int grade in grades)
    {
    sum += grade;
    }
    double average = (double)sum / this.grades.Count;
    return Math.Round(average, 2);
    //return Math.Round(((double)sum / grades.Count), 2);
  

    // Hint! You don't need to round the -1, but you do need it for all the other results...
    //return Math.Round(-1.0, 2);
    
  }
  public double AverageOfPoints()
  {
    double summa = 0.00;
    foreach (double points in this.scores)
    {
      summa = summa + points;
    }
    if (this.scores.Count == 0)
    {
    return -1;
    }
    else 
    {
     return Math.Round(summa / this.scores.Count, 2);
   // return Math.Round(-1.0, 2);
    }
  }
}