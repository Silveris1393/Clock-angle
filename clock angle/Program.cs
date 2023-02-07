using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock_angle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            // Calculate the hour arrow angle
            double hourAngle = (hours % 12 + minutes / 60.0) * 30;

            // Calculate the minute arrow angle
            double minuteAngle = minutes * 6;

            // Calculate the difference between the hour arrow angle and the minute arrow angle
            double angleDifference = Math.Abs(hourAngle - minuteAngle);

            // Get the lesser angle
            double lesserAngle = Math.Min(angleDifference, 360 - angleDifference);

            Console.WriteLine("The lesser angle between the hour arrow and the minute arrow is " + lesserAngle + " degrees.");
            Console.ReadLine();
        }
    }
}
