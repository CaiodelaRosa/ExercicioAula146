using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioAula146.Entities;

namespace ExercicioAula146
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            double totalTax = 0;

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char person = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (person == 'i' || person == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PhysicalPerson(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new LegalPerson(name, annualIncome, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");

            foreach (Person person in list)
            {
                Console.WriteLine($"{person.Name}: $ {person.Tax():F2}");
                totalTax += person.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {totalTax:F2}");
        }
    }
}
