using System;
namespace helloworld
{
    class WageCase2
    {
        void emp()
        {
            int fullHour = 8;
            int halfHour = 4;
            int month = 30;
            int empWagePerHour = 200;
            int day = 0;
            int totalWage = 0;
            Random rand = new Random();
            Console.WriteLine("Employee Wage System");
            for (int i = 1; i < month; i++)
            {
                int attendance = rand.Next();
                attendance = attendance % 3;

                switch (attendance)
                {
                    case 0:
                        day = halfHour * empWagePerHour;
                        totalWage = totalWage + day; 
                        Console.WriteLine(" Half Day "+i+" Salary : "+day);
                        break;
                    case 1:
                        day = fullHour * empWagePerHour;
                        totalWage = totalWage + day;
                        Console.WriteLine(" Full Day " + i + " Salary : " + day);
                        break;
                    default:
                        Console.WriteLine("Absent " + i + " : 0");
                        break;
                }
            }
            Console.WriteLine("Total Salary : " + totalWage);
        }

            static void Main(string[] args)
            {
                WageCase2 obj = new WageCase2();
                obj.emp();
            }
        }

    }
