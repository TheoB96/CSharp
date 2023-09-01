using System;
using System.Collections.Generic;

public struct Student
{
    public string Name { get; set; }
    public List<int> Scores { get; set; }

    public Student(string name, List<int> scores)
    {
        Name = name;
        Scores = scores;
    }

    public decimal AverageScore()
    {
        int totalScore = 0;
        foreach (var score in Scores)
        {
            totalScore += score;
        }
        return (decimal)totalScore / Scores.Count;
    }

    public char DetermineGrade()
    {
        decimal avg = AverageScore();
        if (avg >= 90) return 'A';
        if (avg >= 80) return 'B';
        return 'F'; // Default grade
    }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Sophia", new List<int>{93, 87, 98, 95, 100}),
            new Student("Nicolas", new List<int>{80, 83, 82, 88, 85}),
            new Student("Zahirah", new List<int>{84, 96, 73, 85, 79}),
            new Student("Jeong", new List<int>{90, 92, 98, 100, 97})
        };

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name}: {student.AverageScore()} {student.DetermineGrade()}");
        }
    }
}
