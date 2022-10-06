
public class Employee
{
    public void CheckAttendance()
    {
        int IS_FULL_TIME = 1;
        Random num = new Random();
        int empCheck = num.Next(0, 2);

        if (empCheck == IS_FULL_TIME)
        {       
            Console.WriteLine("Employee is present");
        }
        else
        {
            Console.WriteLine("Employee is absent");
        }
    }
}