using System;
using System.Collections.Generic;
using taxSystem.Entities;
using System.Globalization;

namespace taxSystem {
    class Program {
        static void Main(string[] args) {


            /*
                Sistema montado com objetivo de estudo, sobre classes e metodos abstratos.
                Esse sistema recebe um numero de trabalhadores, e de acordo com as caracateristicas de cada:
                (caso pessoa fisica ou juridica), ter seus imposto calculado com base nos ganhos anuais.
             */

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"tax payer #{i} :");
                Console.Write("Individual or company (i/c) ? ");
                char typeTaxPayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if (typeTaxPayer == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpensives = double.Parse(Console.ReadLine());

                    taxPayers.Add(new NaturalPerson(name, income, healthExpensives));

                }
                else if (typeTaxPayer == 'c') {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new LegalPerson(name, income, numberEmployees));
                }
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("TAXES PAID: ");

            foreach (TaxPayer tp in taxPayers) {
                Console.WriteLine("Name: " + tp.Name + " $" + tp.TotalIncome().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
