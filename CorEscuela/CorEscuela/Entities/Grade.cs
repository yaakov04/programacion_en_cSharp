
namespace CorEscuela.Entities
{
    public class Grade
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public Student Student { get; set; }

        public Subject Subject { get; set; }

        public float grade { get; set; }

        public Grade() => UniqueId = Guid.NewGuid().ToString();
    }
}
