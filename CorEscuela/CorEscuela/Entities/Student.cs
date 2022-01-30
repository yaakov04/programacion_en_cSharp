
namespace CorEscuela.Entities
{
    public class Student: BaseObject
    {
        public List<Grade> Grade { get; set; } = new List<Grade>();

    }
}
