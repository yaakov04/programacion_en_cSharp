﻿using CorEscuela.Entities;
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
              */

            school.Course = new Course[]
            {
                new Course(){name="101"},
                new Course(){name="102"},
                new Course(){name="103"},
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
                Course[] courses = school.Course;
                foreach (Course course in courses)
                {
                    WriteLine($"Nombre: {course.name} \nId: {course.UniqueId}\n");
                }
            }
        }
    }

}