using System;
using System.Collections.Generic;
using System.Text;

namespace taxSystem.Entities {
    class LegalPerson : TaxPayer{

        public int EmployeeNumber { get; set; }

        public LegalPerson() { }

        public LegalPerson(string name, double currentIncome, int employeeNumber) : base(name, currentIncome){
            EmployeeNumber = employeeNumber;
        }

        public override double TotalIncome() {

            double tax = 0;

            if(EmployeeNumber > 10) {
                tax = CurrentIncome * 0.14;
            }
            else {
                tax = CurrentIncome * 0.16;
            }

            return tax;
        }
    }
}
