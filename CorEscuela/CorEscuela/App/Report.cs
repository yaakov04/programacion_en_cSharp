
using CorEscuela.Entities;

namespace CorEscuela.App
{
    public class Report
    {
        Dictionary<DictionaryKey, IEnumerable<BaseObject>> dictionary;
        public Report(Dictionary<DictionaryKey, IEnumerable<BaseObject>> dictionary)
        {
            if(dictionary == null)
            {
                throw new ArgumentNullException(nameof(dictionary));
            }
            this.dictionary = dictionary;
        }

        public IEnumerable<Grade> GetGrades()
        {
            bool valueExist  = dictionary.TryGetValue(DictionaryKey.Grade, out IEnumerable<BaseObject> list);
            if(valueExist)
            {
                return list.Cast<Grade>();
            }

            return new List<Grade>();
        }

        public IEnumerable<string> GetSubjects(out IEnumerable<Grade> grades)
        {
            grades = GetGrades();

            return (from grade in grades
                   select grade.Subject.Name).Distinct();
        }

        public IEnumerable<string> GetSubjects()
        {
            return GetSubjects(out IEnumerable<Grade> dummy);
        }

        public Dictionary<string,IEnumerable<Grade>> GetGradesPerSubject()
        {
            Dictionary<string, IEnumerable<Grade>> dictionary = new Dictionary<string, IEnumerable<Grade>>();
            
            IEnumerable<string> Subjects = GetSubjects(out IEnumerable<Grade> Grades);

            foreach (string subject in Subjects)
            {
                IEnumerable<Grade> gradesPerSubject = from grades in Grades
                                                      where grades.Subject.Name == subject
                                                      select grades;
                dictionary.Add(subject, gradesPerSubject);
            }

            return dictionary;
        }

        public Dictionary<string, IEnumerable<object>> GetAverageStudentsPerSubject()
        {
            Dictionary<string, IEnumerable<object>> averageStudentsPerSubject = new Dictionary<string, IEnumerable<object>>();

            Dictionary<string, IEnumerable<Grade>> gradesPerSubject = GetGradesPerSubject();

            foreach (KeyValuePair<string, IEnumerable<Grade>> subjectWithGrades in gradesPerSubject)
            {
                var dummy = from grade in subjectWithGrades.Value
                            group grade by grade.Student.UniqueId
                            into grades
                            select new
                            {
                                StudentId = grades.Key,
                                Average = grades.Average(gr =>gr.grade)
                            };
            }

            return averageStudentsPerSubject;
        }
    }
}
