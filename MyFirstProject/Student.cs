using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyFirstProject
{
    public class Student
    {
        private List<Student> Students = new List<Student>(); // database

        public Student()
        {
            //InitialiseStudents();
        }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public int StudentNumber { get; set; }
        public string Gender { get; set; }
        public string Programme { get; set; }
        public int YearOfStudy { get; set; }

        public void AddStudent(Student student) // adds a student to the database
        {
            Students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return Students;
        }

        public Student GetStudentbyStudentNumber(int studentNumber)
        {
            var student = Students.Where(s => s.StudentNumber == studentNumber)
                .FirstOrDefault();

            return student;
        }

        public void InitialiseStudents()
        {
            try
            {
                Students.Add(new Student()
                {
                    FirstName = "John",
                    LastName = "Phiri",
                    Gender = "Male",
                    Programme = "Informations Systems",
                    StudentNumber = 12324,
                    YearOfStudy = 4
                });

                Students.Add(new Student()
                {
                    FirstName = "Mary",
                    LastName = "Banda",
                    Gender = "Female",
                    Programme = "Informations Systems",
                    StudentNumber = 1235,
                    YearOfStudy = 3
                });
            }
            catch (Exception ex)
            {
                var erro = ex.Message;
                throw;
            }

        }

        public bool UpdateStudent(Student student)
        {
            try
            {
                //logic to update student
                var filteredStudent = Students
                    .Where(s => s.StudentNumber == student.StudentNumber)
                    .FirstOrDefault();

                filteredStudent.FirstName = student.FirstName;
                filteredStudent.LastName = student.LastName;
                filteredStudent.YearOfStudy = student.YearOfStudy;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
