using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement
{
    public class EmpWageUsingSwitch
    {
        public void WageUsingSwitch()
        {
            //CONSTANTS
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            int RATE_PER_HOUR = 20;
            //VARIABLES
            int WAGE = 0;
            int HR = 0;
            Random random = new Random();
            int empCheck=random.Next(0,3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    HR = 4;
                    break;
                case IS_FULL_TIME:
                    HR = 8;
                    break;
                    default:
                    HR = 0;
                    break;
            }
            WAGE = HR * RATE_PER_HOUR;
            Console.WriteLine("Employee wage is UC4: "+WAGE);
        }
    }
}
