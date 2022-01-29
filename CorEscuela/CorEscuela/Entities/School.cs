namespace CorEscuela.Entities
{
    public class School: BaseObject
    {
        public int YearCreation { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public SchoolTypes SchoolTypes { get; set; }

        public List<Course> Course { get; set; }

        public School(string name, int year, SchoolTypes type, string country = "", string city = "")
        {
            this.Name = name;
            this.YearCreation = year;
            this.SchoolTypes = type;
            this.Country = country;
            this.City = city;
        }

        public override string ToString()
        {
            return $"Nombre: {Name} \nTipo: {SchoolTypes} \nPais: {Country} \nCiudad: {City}";
        }
    }
}
