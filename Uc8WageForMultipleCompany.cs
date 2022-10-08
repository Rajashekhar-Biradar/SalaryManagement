using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement
{
    internal class Uc8WageForMultipleCompany
    {
        public static void WageCompute(string company,int RATE_PER_HOUR,int NUM_OF_WORKING_DAYS,int MAX_HOUR_IN_MONTH)
        {
            //CONSTANTS
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            //VARIABLES
            int TotalHr = 0;
            int HR = 0;
            int TotalWage = 0;
            int TotalWorkingDays = 0;

            while (TotalWorkingDays <= NUM_OF_WORKING_DAYS && TotalHr <= MAX_HOUR_IN_MONTH)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        HR = 4;
                        break;
                    case 2:
                        HR = IS_FULL_TIME;
                        break;
                    default:
                        HR = 0;
                        break;
                }

                TotalHr += HR;
                Console.WriteLine("totaldays# : " + TotalWorkingDays + " TotalHours: " + TotalHr);
            }
            TotalWage = TotalHr * RATE_PER_HOUR;
            Console.WriteLine(" Employee total wage :" + TotalWage);
        }
    }
}
