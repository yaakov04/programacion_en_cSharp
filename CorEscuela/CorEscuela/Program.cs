using CorEscuela.App;
using CorEscuela.Entities;
using CorEscuela.Util;
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
            Printer.writeTitle("Administrador de Escuela");

            WriteLine(engine.School);
            PrintCourses(engine.School);
        }


        private static void PrintCourses(School school)
        {
            Printer.writeTitle("Cursos de la Escuela");

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