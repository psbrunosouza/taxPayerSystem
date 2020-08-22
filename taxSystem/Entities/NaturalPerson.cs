using System;
using System.Collections.Generic;
using System.Text;

namespace taxSystem.Entities {
    class NaturalPerson : TaxPayer {

        public double HealthExpense { get; set; }

        public NaturalPerson() { }

        public NaturalPerson(string name, double currentIncome, double healthExpense) : base(name, currentIncome) {
            HealthExpense = healthExpense;
        }

        public override double TotalIncome() {

            double tax = 0;

            if (CurrentIncome < 20000.0) {
                if(HealthExpense > 0) {
                    tax = (CurrentIncome * 0.15) - (HealthExpense * 0.50);
                }
                else {
                    tax = CurrentIncome * 0.15;
                }
            }else{
                if (HealthExpense > 0) {
                    tax = (CurrentIncome * 0.25) - (HealthExpense * 0.50);
                }
                else {
                    tax = CurrentIncome * 0.25;
                }
               
            }

            return tax;
        }

    }
}
