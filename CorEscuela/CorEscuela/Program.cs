using CorEscuela.Entities;
using System;

namespace helloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School("Rosa Leal", 1980);
            school.Country = "Mexico";
            school.City = "Monterrey";
            //School.schoolTypes = SchoolTypes.Elementary;
            Console.WriteLine(school.Name);
        }
    }
}