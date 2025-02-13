using System.Globalization;
using System.Text;

namespace AbstractsExercises.Entities
{
    internal class FisicPerson : Person
    {
        public double HealthExpenses { get; set; }

        public FisicPerson(double health_expenses, string name, double anualtotal) : base(name, anualtotal) 
        {
            HealthExpenses = health_expenses;
        }
        
        public double expenses()
        {
            double total = 0;
            if(AnualTotal > 20000.00)
            {
                total += (AnualTotal * 0.25); 
            }
            else
            {
                total += (AnualTotal * 0.15);
            }
            return total;
        }
        public double expensivesHealth()
        {
            double total = 0;
            if (HealthExpenses !=0)
            {
                total += (HealthExpenses * 0.50);
            }
            return total;
        }

        public override double Total()
        {
            return expenses() - expensivesHealth();
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
