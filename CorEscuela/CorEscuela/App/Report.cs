
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
            
        }
    }
}
