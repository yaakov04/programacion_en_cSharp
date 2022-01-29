namespace CorEscuela.Entities
{
    public abstract class BaseObject
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public BaseObject()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

    }
}
