using CorEscuela.Entities;
using System;

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

            Console.WriteLine(school);
            System.Console.WriteLine("===========================");
            PrintCourses(courses);
        }

        private static void PrintCourses(Course[] courses)
        {
            Console.WriteLine("Cursos");
            foreach (Course course in courses)
            {
                Console.WriteLine($"Nombre: {course.name} \nId: {course.UniqueId}\n");
            }
        }
    }
}