using System;
using System.Globalization;
using System.Collections.Generic;
using AbstractsExercises.Entities;

namespace AbstractsExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> Peoples = new List<Person>();

            Console.Write("Enter the number of tax payers:");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quant; i++)
            {
                Console.Write($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c):");
                char op = char.Parse(Console.ReadLine());
                if (op == 'i')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income:");
                    double anualTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health Expenditures:");
                    double healthExpenses = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

                    Peoples.Add(new FisicPerson(healthExpenses, name, anualTotal));
                }
                else if (op == 'c')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();
                    Console.Write("Anual Income:");
                    double anualTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees:");
                    int employees = int.Parse(Console.ReadLine());

                    Peoples.Add(new JuridicPerson(employees, name, anualTotal));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach (Person person in Peoples)
            {
                Console.WriteLine(person);
            }

            double total = 0;
            foreach (Person person in Peoples)
            {
                
                total += person.Total();
            }
            Console.WriteLine("TOTAL TAXES:" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
