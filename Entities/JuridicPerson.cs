using System.Globalization;
using System.Text;

namespace AbstractsExercises.Entities
{
    internal class JuridicPerson : Person
    {
        public int Employees { get; set; }

        public JuridicPerson(int employees, string name, double anualTotal) : base(name,anualTotal)
        {
            Employees = employees;
        }
        public override double Total()
        {
            double total = 0;

            if (Employees >= 0 && Employees <=10)
            {
                total += (AnualTotal * 0.16);
            }
            else
            {
                total += (AnualTotal * 0.14);
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(": $ ");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
