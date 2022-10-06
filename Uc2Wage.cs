public class employeeWage
{
    public void CheckEmpWage()
    {
        int IS_FULL_TIME = 1;
        int Hr;
        int empWage;
        int RATE_PER_HR = 20;
        Random num = new Random();
        int empCheck = num.Next(0, 2);

        if (empCheck == IS_FULL_TIME)
        {
            Hr = 8;
        }
        else
        {
            Hr = 0;
        }
        empWage = Hr * RATE_PER_HR;
        Console.WriteLine("Employee wage is UC2: "+empWage);
    }
}