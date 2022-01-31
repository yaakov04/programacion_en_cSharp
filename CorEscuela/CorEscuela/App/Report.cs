
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

        public IEnumerable<School> GetGrades()
        {
            //IEnumerable<BaseObject> list = null;
            bool keyExist  = dictionary.TryGetValue(DictionaryKey.School, out IEnumerable<BaseObject> list);
            if(keyExist)
            {
                return list.Cast<School>();
            }

            return null;
            // reportar en el log
        }
    }
}
