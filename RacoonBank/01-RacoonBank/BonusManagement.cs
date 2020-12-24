using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_RacoonBank.Employees;

namespace _01_RacoonBank
{
    public class BonusManagement
    {
        private double _totalBonus;
        public double GetTotalBonus()
        {
            return _totalBonus;
        }

        public void Register(Employee employee)
        {
            _totalBonus += employee.GetBonus();
        }

        public void Register(Director director)
        {
            _totalBonus += director.GetBonus();
        }
    }
}
