using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating student object
            Student student = new Student();

            InitialiseStudents(student);

            var returnedStudent = student.GetStudentbyStudentNumber(1232); // works

            Console.WriteLine($"{returnedStudent?.FirstName} - {returnedStudent?.LastName}"); // what will be the output

            // update a student
            student.UpdateStudent(new Student()
            {
                FirstName = "Mary",
                LastName = "Lung"
            });
        }

        private static void InitialiseStudents(Student student)
        {
            student.AddStudent(new Student()
            {
                FirstName = "John",
                LastName = "Phiri",
                Gender = "Male",
                Programme = "Informations Systems",
                StudentNumber = 12324,
                YearOfStudy = 4
            });

            student.AddStudent(new Student()
            {
                FirstName = "Mary",
                LastName = "Tembo",
                Gender = "Female",
                Programme = "Informations Systems",
                StudentNumber = 12345,
                YearOfStudy = 3
            });
        }
    }
}
