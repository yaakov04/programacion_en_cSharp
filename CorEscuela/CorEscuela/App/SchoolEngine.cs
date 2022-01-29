using CorEscuela.Entities;

namespace CorEscuela.App
{
    public sealed class SchoolEngine
    {
        public School School { get; set; }

        public void init()
        {
            School = new School("Rosa Leal", 1980, SchoolTypes.Elementary,
                city: "Monterrey",
                country: "México"
                );
            LoadCourses();
            LoadSubjects();
            LoadGrades();
        }

        private void LoadGrades()
        {
            foreach (Course course in School.Course)
            {
                foreach (Subject subject in course.Subjects)
                {
                    foreach (Student student in course.Students)
                    {
                        Random rnd = new Random(System.Environment.TickCount);
                        student.Grade = new List<Grade>();
                        for (int i = 0; i < 4; i++)
                        {
                            Grade grade = new Grade()
                            {
                                Subject = subject,
                                Name = $"{student.Name} #{i + 1}",
                                grade = (float)(5 * rnd.NextDouble()),
                                Student = student,
                            };
                            student.Grade.Add(grade);
                        }
                    }
                }
            }
        }

        internal IReadOnlyList<BaseObject> GetSchoolObjects(
            bool hasGrades = true,
            bool hasStudents = true,
            bool hasSubjects = true,
            bool hasCourses = true
            )
        {
            return GetSchoolObjects(out int dummy, out dummy, out dummy, out dummy);
        }

        internal IReadOnlyList<BaseObject> GetSchoolObjects(
            out int countGrade,
            bool hasGrades = true,
            bool hasStudents = true,
            bool hasSubjects = true,
            bool hasCourses = true
            )
        {
            return GetSchoolObjects(out countGrade, out int dummy, out dummy, out dummy);
        }
        internal IReadOnlyList<BaseObject> GetSchoolObjects(
            out int countGrade, out int countStudents,
            bool hasGrades = true,
            bool hasStudents = true,
            bool hasSubjects = true,
            bool hasCourses = true
            )
        {
            return GetSchoolObjects(out countGrade, out countStudents, out int dummy, out dummy);
        }
        internal IReadOnlyList<BaseObject> GetSchoolObjects(
            out int countGrade, out int countStudents, out int countSubjects,
            bool hasGrades = true,
            bool hasStudents = true,
            bool hasSubjects = true,
            bool hasCourses = true
            )
        {
            return GetSchoolObjects(out countGrade, out countStudents, out countSubjects, out int dummy);
        }

        internal IReadOnlyList<BaseObject> GetSchoolObjects(
            out int countGrades,
            out int countStudents,
            out int countSubjects,
            out int countCourses,
            bool hasGrades = true,
            bool hasStudents = true,
            bool hasSubjects = true,
            bool hasCourses = true
            )
        {
            countStudents = countSubjects = countGrades = 0;
            List<BaseObject> list = new List<BaseObject>();

            list.Add(School);

            if (hasCourses)
            {
                list.AddRange(School.Course);
            }
            countCourses = School.Course.Count;
            foreach (Course course in School.Course)
            {
                countStudents += course.Students.Count;
                countSubjects += course.Subjects.Count;
                if (hasSubjects)
                {
                    list.AddRange(course.Subjects);
                }

                if (hasStudents)
                {
                    list.AddRange(course.Students);
                }

                if (hasGrades)
                {
                    foreach (Student student in course.Students)
                    {
                        list.AddRange(student.Grade);
                        countGrades += student.Grade.Count;
                    }
                }


            }
            return list.AsReadOnly();
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
                course.Subjects = subjects;
            }
        }

        private List<Student> GenerateStudents(int number)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            IEnumerable<Student> students = from n1 in nombre1
                                            from n2 in nombre2
                                            from a1 in apellido1
                                            select new Student { Name = $"{n1} {n2} {a1}" };
            return students.OrderBy((st) => st.UniqueId).Take(number).ToList();
        }

        private void LoadCourses()
        {
            School.Course = new List<Course>()
            {
                new Course(){Name="101", Shift = ShiftTypes.Morning},
                new Course(){Name="201", Shift = ShiftTypes.Morning},
                new Course(){Name="301", Shift = ShiftTypes.Morning},
                new Course(){Name="401", Shift = ShiftTypes.Afternoon},
                new Course(){Name="501", Shift = ShiftTypes.Afternoon},
            };
            Random rnd = new Random();
            foreach (Course course in School.Course)
            {
                int numRnd = rnd.Next(15, 30);
                course.Students = GenerateStudents(numRnd);
            }
        }
    }
}
