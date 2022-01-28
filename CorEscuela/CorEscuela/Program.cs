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
            /*
              Course[] courses;
              courses = new Course[3];
              courses[0] = new Course()
              {
                  name = "101"
              };
              courses[1] = new Course()
              {
                  name = "201"
              };
              courses[2] = new Course() 
              {
                  name= "301"
              };

            //////
              school.Course = new Course[]
                {
                    new Course(){name="101"},
                    new Course(){name="102"},
                    new Course(){name="103"},
                };
              */

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

            school.Course.AddRange(anotherList);

            WriteLine(school);
            PrintCourses(school);

            Predicate<Course> miAlgoritmo = Predicado;
            school.Course.RemoveAll(miAlgoritmo);
            PrintCourses(school);

        }

        private static bool Predicado(Course obj)
        {
            return obj.name == "202";
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