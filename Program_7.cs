using System;

namespace AttendanceTracker
{	

	/*Question 7
7.	A school tracks the attendance of students over 5 days. The system should be able to record attendance, calculate the total number of days attended, and identify if a student has perfect attendance;
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize attendance array
            bool[] attendance = new bool[5];

            // Record attendance for each day
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Was the student present on day {i + 1}? (y/n): ");
                string input = Console.ReadLine();

                attendance[i] = (input.ToLower() == "y");
            }

            // Calculate total days attended
            int totalDaysAttended = CalculateTotalDaysAttended(attendance);

            // Check for perfect attendance
            bool hasPerfectAttendance = HasPerfectAttendance(attendance);

            Console.WriteLine($"Total days attended: {totalDaysAttended}");
            Console.WriteLine($"Has perfect attendance: {hasPerfectAttendance}");
        }

        static int CalculateTotalDaysAttended(bool[] attendance)
        {
            int totalDaysAttended = 0;

            foreach (bool present in attendance)
            {
                if (present)
                {
                    totalDaysAttended++;
                }
            }

            return totalDaysAttended;
        }

        static bool HasPerfectAttendance(bool[] attendance)
        {
            foreach (bool present in attendance)
            {
                if (!present)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
