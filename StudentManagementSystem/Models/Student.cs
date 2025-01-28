using System;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string? Name { get; set; }  // Nullable string
        public int Age { get; set; }
        public string? Grade { get; set; }  // Nullable string

        // Constructor
        public Student(int studentID, string? name, int age, string? grade)
        {
            StudentID = studentID;
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
}
