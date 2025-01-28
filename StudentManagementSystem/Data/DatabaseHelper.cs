using System;
using System.Data;
using System.Data.SQLite;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data
{
    public static class DatabaseHelper
    {
        private const string ConnectionString = "Data Source=SMS.db";

        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(
                    @"CREATE TABLE IF NOT EXISTS Students (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Age INTEGER NOT NULL,
                        Grade TEXT NOT NULL
                    )", connection);
                command.ExecuteNonQuery();
            }
        }

        public static DataTable GetAllStudents()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var adapter = new SQLiteDataAdapter("SELECT * FROM Students", connection);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static void AddStudent(Student student)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(
                    "INSERT INTO Students (Name, Age, Grade) VALUES (@Name, @Age, @Grade)", connection);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Grade", student.Grade);
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteStudent(int studentId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(
                    "DELETE FROM Students WHERE StudentID = @StudentID", connection);
                command.Parameters.AddWithValue("@StudentID", studentId);
                command.ExecuteNonQuery();
            }
        }

        // New Update method for updating a student
        public static void UpdateStudent(Student student)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(
                    "UPDATE Students SET Name = @Name, Age = @Age, Grade = @Grade WHERE StudentID = @StudentID", connection);
                command.Parameters.AddWithValue("@StudentID", student.StudentID);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Grade", student.Grade);
                command.ExecuteNonQuery();
            }
        }
    }
}
