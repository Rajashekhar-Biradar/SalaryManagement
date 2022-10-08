using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement
{
    public class ParttimeWage
    {
        public void AddPArtTime()
        {
            //constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int RATE_PER_HOUR = 20;
            //VARIABLES
            int hr = 0;
            int wage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                hr = 4;
            }else if (empCheck == IS_FULL_TIME)
            {
                hr = 8;
            }
            wage = hr * RATE_PER_HOUR;
            Console.WriteLine("Employee wage UC3:" +wage);
        }
    }
}
