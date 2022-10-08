
namespace SalaryManagement
{
    public class employee
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public static void Main(string[] args)
        {
            //Employee checkAtte = new Employee();
            //checkAtte.CheckAttendance();

            //Aemployee CheckWage = new Aemployee();
            //CheckWage.CheckEmpWage();

            //Parttime obj3 = new Parttime();
            //obj3.AddPArtTime();

            //UseSwitch obj4=new UseSwitch();
            //obj4.WageUsingSwitch();

            //_20WorkingDays obj5= new _20WorkingDays();
            //obj5.WorkDays();

            //WageUsingWhileLoop obj6 = new WageUsingWhileLoop();
            //obj6.WageUsingWhile();
            // UC9Refactor.ComputeWage();
            //Console.WriteLine("intel exel");
            Uc8WageForMultipleCompany.WageCompute("Intelexel", 50, 20, 21);

            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.addCompanyEmpWage("Dmart", 20, 50, 15);
            //empWageBuilder.addCompanyEmpWage("Reliance", 30, 40, 20);
            //empWageBuilder.ComputeEmpWage();

        }
    }
}

