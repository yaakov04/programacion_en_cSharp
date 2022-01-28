using CorEscuela.Entities;

namespace CorEscuela.App
{
    public class SchoolEngine
    {
        public School School { get; set; }

        public void init()
        {
            School = new School("Rosa Leal", 1980, SchoolTypes.Elementary,
                city: "Monterrey",
                country: "México"
                );
            School.Course = new List<Course>()
            {
                new Course(){name="101", Shift = ShiftTypes.Morning},
                new Course(){name="201", Shift = ShiftTypes.Morning},
                new Course(){name="301", Shift = ShiftTypes.Morning},
                new Course(){name="401", Shift = ShiftTypes.Afternoon},
                new Course(){name="501", Shift = ShiftTypes.Afternoon},
            };
        }
    }
}
