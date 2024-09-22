using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Employment
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = string.IsNullOrWhiteSpace(value) ? "Unknown" : value; }
        }

        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value > 0)
                    _monthlySalary = value;
            }
        }

        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            _monthlySalary = monthlySalary < 0 ? 0.0 : monthlySalary;
        }

        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage <= 20 && raisePercentage > 0)
            {
                _monthlySalary += _monthlySalary * raisePercentage / 100.0;
            }
        }

        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}
