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

            Report report = new Report(dictionary);
            IEnumerable<Grade> listGrades = report.GetGrades();
            IEnumerable<string> listSubjects = report.GetSubjects();
            Dictionary<string, IEnumerable<Grade>> listGradesPerSubject = report.GetGradesPerSubject();
            Dictionary<string, IEnumerable<StudentAverage>> averageStudentsPerSubject = report.GetAverageStudentsPerSubject();


            Printer.writeTitle("Captura la calificación");

            Grade newGrade = new Grade();
            string name, stringGrade;
            float grade;

            WriteLine("Ingrese el nombre de la evaluación");
            Printer.PressEnter();
            name = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El valor del nombre no puede estar vacio");
            }
            else
            {
                newGrade.Name = name.ToLower();
                WriteLine("EL nombre ha sido ingresado correctamente");
            }

            WriteLine("Ingrese la calificación");
            Printer.PressEnter();
            stringGrade = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(stringGrade))
            {
                throw new ArgumentException("El valor de la nota no puede estar vacio");
            }
            else
            {
                try
                {
                    grade = float.Parse(stringGrade);
                    if (grade <0 || grade > 5)
                    {
                        throw new ArgumentOutOfRangeException("La nota debe estar entre 0 y 5");
                    }
                    newGrade.grade = grade;
                    WriteLine("La calificación ha sido ingresada correctamente");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Printer.writeTitle(ex.Message);
                }
                catch (Exception)
                {
                    Printer.writeTitle("El valor de la nota no es un número válido");

                }
            }

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