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
            int dummy = 0;
            int countGrades = 0;
            int countStudents = 0;
            int countSubjects =0;
            int countCourses = 0;
            engine.GetObjectsDictionary();
            IReadOnlyList<BaseObject> SchoolObjects = engine.GetSchoolObjects();
            WriteLine(SchoolObjects);
        }


        private static void PrintCourses(School school)
        {
            Printer.writeTitle("Cursos de la Escuela");

            if (school?.Course != null)
            {
                List<Course> courses = school.Course;
                foreach (Course course in courses)
                {
                    WriteLine($"Nombre: {course.Name} \nId: {course.UniqueId}\n");
                }
            }
        }
    }

}