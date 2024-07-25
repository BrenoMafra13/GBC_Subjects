using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public List<string> Classes { get; private set; }

    private static int _idCounter = 1;

    public Person(string name)
    {
        Name = name;
        Id = _idCounter++;
        Classes = new List<string>();
    }

    public void AddClass(string className)
    {
        Classes.Add(className);
    }
}

public class Student : Person
{
    public Student(string name) : base(name)
    {
    }
}

public class Professor : Person
{
    public Professor(string name) : base(name)
    {
    }
}

public class SchoolSystem
{
    private List<Student> students = new List<Student>();
    private List<Professor> professors = new List<Professor>();
    private Dictionary<string, List<int>> classEnrollments = new Dictionary<string, List<int>>();

    public void AddStudent(string name)
    {
        students.Add(new Student(name));
    }

    public void AddProfessor(string name)
    {
        professors.Add(new Professor(name));
    }

    public void EnrollStudent(int studentId, string className)
    {
        if (!classEnrollments.ContainsKey(className))
        {
            classEnrollments[className] = new List<int>();
        }

        if (!classEnrollments[className].Contains(studentId))
        {
            classEnrollments[className].Add(studentId);
            students.First(s => s.Id == studentId).AddClass(className);
        }
        else
        {
            Console.WriteLine("Student already enrolled in this class.");
        }
    }

    public void ViewAllStudents()
    {
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
        }
    }

    public void ViewAllProfessors()
    {
        foreach (var professor in professors)
        {
            Console.WriteLine($"ID: {professor.Id}, Name: {professor.Name}");
        }
    }

    public void ViewStudentsInClass(string className)
    {
        if (classEnrollments.ContainsKey(className))
        {
            foreach (int studentId in classEnrollments[className])
            {
                Student student = students.First(s => s.Id == studentId);
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            }
        }
        else
        {
            Console.WriteLine("Class not found.");
        }
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("1. Add a new student");
            Console.WriteLine("2. Add a new professor");
            Console.WriteLine("3. View all students");
            Console.WriteLine("4. View all professors");
            Console.WriteLine("5. Enroll a student in a class");
            Console.WriteLine("6. View students in a class");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Console.Write("Enter student name: ");
                    AddStudent(Console.ReadLine());
                    break;
                case "2":
                    Console.Write("Enter professor name: ");
                    AddProfessor(Console.ReadLine());
                    break;
                case "3":
                    ViewAllStudents();
                    break;
                case "4":
                    ViewAllProfessors();
                    break;
                case "5":
                    Console.Write("Enter student ID: ");
                    int studentId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter class name: ");
                    string className = Console.ReadLine();
                    EnrollStudent(studentId, className);
                    break;
                case "6":
                    Console.Write("Enter class name to view students: ");
                    ViewStudentsInClass(Console.ReadLine());
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var system = new SchoolSystem();
        system.Run();
    }
}
