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

            Dictionary<DictionaryKey, IEnumerable<BaseObject>> dictionary = engine.GetObjectsDictionary();
            //engine.printDictionary(dictionary, true);

            Report report = new Report(dictionary);
            report.GetGrades();
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