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

        public School(string name, int year)
        {
            this.name = name;
            this.YearCreation = year;
        }

        public override string ToString()
        {
            return $"Nombre: {name} \nTipo: {SchoolTypes} \nPais: {Country} \nCiudad: {City}";
        }
    }
}
