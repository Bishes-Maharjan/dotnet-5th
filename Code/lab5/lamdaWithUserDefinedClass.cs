using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int RollNo { get; set; }
    public string? Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student { RollNo = 1, Name = "Liza" },
            new Student { RollNo = 2, Name = "Stewart" },
            new Student { RollNo = 3, Name = "Tina" },
            new Student { RollNo = 4, Name = "Stefani" },
            new Student { RollNo = 5, Name = "Trish" }
        };

        // Sorting by Name using lambda
        var sortedList = students.OrderBy(x => x.Name);

        foreach (var s in sortedList)
            Console.WriteLine($"{s.RollNo} {s.Name}");
    }
}