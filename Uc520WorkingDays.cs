using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement
{
    public class _20WorkingDays
    {
        public void WorkDays()
        {
            //CONSTANTS
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            int RATE_PER_HOUR = 20;
            int NUM_OF_WORKING_DAYS = 20;
            //VARIABLES
            int WAGE = 0;
            int HR = 0;
            int TotalWage = 0;

            for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
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
                TotalWage += WAGE;
                Console.WriteLine("Employee wage is UC5: " + WAGE);
            }
            Console.WriteLine("employee total wage is UC5: "+TotalWage);
        }   
    }
}
