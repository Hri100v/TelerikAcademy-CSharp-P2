﻿/*Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints 
the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17_Problem___Date_in_Bulgarian
{
    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //              day.month.year hour:minute:second
            string format = "dd.MM.yyyy HH:mm:ss";
            string addTime = "6:30";
            //DateTime hoursAdd = DateTime.ParseExact(addTime, "H:mm", CultureInfo.InvariantCulture);
            //Console.WriteLine(int.Parse(hoursAdd));

            string time = "01.03.2015 22:20:25";

            DateTime takeTime = DateTime.ParseExact(time, format, CultureInfo.InvariantCulture);  //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG"));
            takeTime = takeTime.AddHours(6.5);
            Console.WriteLine("{0} <> {1}", takeTime.ToString("dddd", new CultureInfo("bg-BG")), takeTime);
            //Console.WriteLine(takeTime.ToString("dddd", CultureInfo.GetCultureInfo("bg-BG")));

        }
    }
}
