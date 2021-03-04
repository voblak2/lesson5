using System;

namespace lesson5
{
    public class Student
    {
        string firstName;
        string lastName;
        string courseFocus;

        //Default constructor
        public Student()
        {
            firstName = "";
            lastName = "";
            courseFocus = "";
        }

        // Parameterized constructor
        public Student(string first, string last, string focus)
        {
            firstName = first;
            lastName = last;
            courseFocus = focus;

            Console.WriteLine(firstName + " " + lastName + " is studying " + courseFocus);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("James", "Gosling", "C#");        }
    }
} //C# Lesson 5, Objects and Classes p4 under Properties