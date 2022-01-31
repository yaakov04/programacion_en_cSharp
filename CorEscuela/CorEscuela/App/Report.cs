
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
            bool keyExist  = dictionary.TryGetValue(DictionaryKey.Grade, out IEnumerable<BaseObject> list);
            if(keyExist)
            {
                return list.Cast<Grade>();
            }

            return new List<Grade>();
        }
    }
}
