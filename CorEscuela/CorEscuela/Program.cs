using CorEscuela.Entities;
using System;
using static System.Console;

namespace CorEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Administración de Escuelas\n\n");
            School school = new School("Rosa Leal", 1980, SchoolTypes.Elementary,
                city:"Monterrey",
                country: "México"
                );
           
            school.Course = new List<Course>()
            {
                new Course(){name="101", Shift = ShiftTypes.Morning},
                new Course(){name="202", Shift = ShiftTypes.Morning},
                new Course(){name="303", Shift = ShiftTypes.Morning},
            };

            school.Course.Add(new Course() { name = "102", Shift = ShiftTypes.Afternoon });
            school.Course.Add(new Course() { name = "202", Shift = ShiftTypes.Afternoon });

            List<Course> anotherList = new List<Course>()
            {
                new Course(){name="401", Shift = ShiftTypes.Morning},
                new Course(){name="501", Shift = ShiftTypes.Morning},
            };

            WriteLine(school);
            PrintCourses(school);
        }


        private static void PrintCourses(School school)
        {
            WriteLine("\n====================");
            WriteLine("Cursos de la Escuela");
            WriteLine("====================");

            if (school?.Course != null)
            {
                List<Course> courses = school.Course;
                foreach (Course course in courses)
                {
                    WriteLine($"Nombre: {course.name} \nId: {course.UniqueId}\n");
                }
            }
        }
    }

}