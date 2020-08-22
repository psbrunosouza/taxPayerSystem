using System;
using System.Collections.Generic;
using System.Text;

namespace taxSystem.Entities {
    abstract class TaxPayer {
        public string Name { get; set; }
        public double CurrentIncome { get; set; }

        public TaxPayer() {

        }

        protected TaxPayer(string name, double currentIncome) {
            Name = name;
            CurrentIncome = currentIncome;
        }

        public abstract double TotalIncome();
    }
}
