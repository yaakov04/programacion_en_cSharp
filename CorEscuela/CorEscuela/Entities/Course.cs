namespace CorEscuela.Entities
{
    public class Course: BaseObject
    {
        public ShiftTypes Shift { get; set; }

        public List<Subject> Subjects { get; set; }  
        public List<Student> Students { get; set; }

    }
}
