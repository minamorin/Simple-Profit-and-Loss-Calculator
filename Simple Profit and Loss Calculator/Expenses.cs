using Simple_Profit_and_Loss_Calculator;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Simple_Profit_and_Loss_Calculator
{
    internal class Expenses
    {
        public double expense;
    }


    internal class Advertising : Expenses
    {
        public double advertising;
    }
    internal class Assets : Expenses
    {
        private double assets;
    }
    internal class Cartruck : Expenses
    {
        private double cartruck;
    }
    internal class Commissionsfees : Expenses
    {
        public double commissionsfees;  
    }
    internal class Contractlabor: Expenses
    {
        public double contractlabor;
    }
    internal class Homeofficeexpenses : Expenses
    {
        public double homeofficeexpenses;
    }
    internal class Insurance : Expenses
    {
        public double insurance;
    }
    internal class Interestpaid : Expenses
    {
        public double interestpaid;
    }
    internal class Legalfeesandprofessionalservices : Expenses
    {
        public double legalfeesprofessionalservicess;
    }
        internal class Meals : Expenses
    {
            public double meals;
    }
        internal class Officeexpenses: Expenses
    {
            public double officeexpenses;
    }
    internal class Otherbusinessexpenses : Expenses
    {
            public double otherbusinessexpenses;
    }
    internal class Rentlease : Expenses
    {
            public double rentlease;
    }
    internal class Repairsmaintenance : Expenses
    {
            public double repairsmaintenance;
    }
    internal class Supplies : Expenses
    {
            public double supplies;
    }
    internal class Taxesandlicenses : Expenses
    {
            public double taxeslicenses;
    }
    internal class Travelexpenses: Expenses
    {
            public double travelexpenses;
    }
    internal class Utilities : Expenses
    {
            public double utilities;
    }

}
