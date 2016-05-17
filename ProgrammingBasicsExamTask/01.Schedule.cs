using System;
using System.Globalization;

namespace _09.Exam_Schedule
{
    class Schedule
    {
        static void Main(string[] args)
        {


            int startHour = Int32.Parse(Console.ReadLine());
            int startMinutes = Int32.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            int endHour = Int32.Parse(Console.ReadLine());
            int endMinutes = Int32.Parse(Console.ReadLine()); 


            if (timeOfDay == "PM")
            {
                startHour += 12;

                if (startHour == 24)
                {
                    startHour = 0;
                }
            }

            DateTime startTime = new DateTime(2015, 03, 08, startHour, startMinutes, 0);
            DateTime endTime = startTime.AddHours(endHour).AddMinutes(endMinutes);
            Console.WriteLine("{0:hh:mm:tt}", endTime);

        }
    }
}
