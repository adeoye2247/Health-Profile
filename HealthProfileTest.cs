// program to test out the class


using System;

class HealthProfileTest
{
    public static void Main(string[] args)
    {
        HealthProfile htp = new HealthProfile(null, null, 0, null, 0, 0, 0, null);

        Console.Write("Enter your First Name: ");
        htp.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter your Last Name: ");
        htp.LastName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter your Day of Birth: ");
        htp.DayOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Month of Birth: ");
        htp.MonthOfBirth = (Console.ReadLine());
        Console.Write("Enter your Year of Birth: ");
        htp.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Weight in pounds: ");
        htp.WeightInPounds = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Height in inches: ");
        htp.HeightInInches = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your Gender: ");
        htp.Gender = Convert.ToString(Console.ReadLine());

        
        
        htp.DisplayFirstName();
        htp.DisplayLastName();
        htp.DisplayDayOfBirth();
        htp.DisplayMonthOfBirth();
        htp.DisplayYearOfBirth();
        htp.DisplayWeightInPounds();
        htp.DisplayHeightInInches();
        htp.DisplayGender();
        htp.DisplayYearsOfAgeSimple();
        htp.DisplayMaxHeartRate();
        htp.DisplayTargetHeartRate();
        htp.DisplayBodyMassIndex();
        htp.DisplayBMIOutput();
        htp.DisplayBMIChart();        
    }
}