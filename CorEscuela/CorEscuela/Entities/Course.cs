namespace CorEscuela.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string name { get; set; }
        public ShiftTypes Shift { get; set; }

        public Course()
        {
            this.UniqueId = Guid.NewGuid().ToString();
        }

    }
}
