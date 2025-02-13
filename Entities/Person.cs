

namespace AbstractsExercises.Entities
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnualTotal { get; set; }

        protected Person(string name, double anualTotal)
        {
            Name = name;
            AnualTotal = anualTotal;
        }

        public abstract double Total();
    }

}
