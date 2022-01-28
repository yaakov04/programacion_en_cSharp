using CorEscuela.Entities;
using System;

namespace CorEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School("Rosa Leal", 1980, SchoolTypes.Elementary,
                city:"Monterrey",
                country: "Mexico"
                );
            
            school.SchoolTypes = SchoolTypes.Elementary;
            Console.WriteLine(school);
        }
    }
}