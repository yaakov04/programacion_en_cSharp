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
            LoadCourses();
            LoadStudents();
            LoadSubjects();
            LoadGrades();
        }

        private void LoadGrades()
        {
            throw new NotImplementedException();
        }

        private void LoadSubjects()
        {
            foreach (Course course in School.Course)
            {
                List<Subject> subjects = new List<Subject>()
                {
                    new Subject(){Name="Matemáticas"},
                    new Subject(){Name="Educación Física"},
                    new Subject(){Name="Ciencias Naturales"},
                    new Subject(){Name="Español"},
                };
                course.Subjects.AddRange(subjects);
            }
        }

        private void LoadStudents()
        {
            throw new NotImplementedException();
        }

        private void LoadCourses()
        {
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
