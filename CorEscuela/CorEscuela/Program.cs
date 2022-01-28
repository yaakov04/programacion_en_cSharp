using CorEscuela.App;
using CorEscuela.Entities;
using System;
using static System.Console;

namespace CorEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolEngine engine = new SchoolEngine();
            engine.init();
            WriteLine(engine.School);
            PrintCourses(engine.School);
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