namespace CorEscuela.Entities
{
    internal class School
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
        public int YearCreation { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        public SchoolTypes SchoolTypes { get; set; }

        public List<Course> Course { get; set; }

        public School(string name, int year, SchoolTypes type, string country ="", string city="")
        {
            this.name = name;
            this.YearCreation = year;
            this.SchoolTypes = type;
            this.Country = country;
            this.City = city;
        }

        public override string ToString()
        {
            return $"Nombre: {name} \nTipo: {SchoolTypes} \nPais: {Country} \nCiudad: {City}";
        }
    }
}
