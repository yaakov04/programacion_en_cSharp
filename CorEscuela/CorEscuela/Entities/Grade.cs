﻿
namespace CorEscuela.Entities
{
    public class Grade:BaseObject
    {
        public Student Student { get; set; }

        public Subject Subject { get; set; }

        public float grade { get; set; }

    }
}
