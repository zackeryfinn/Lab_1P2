using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Part2
{
    class Program
    {
       
        static void Main(string[] args)

        {
            bool repeat = true;
            while (repeat)
            {
                //start -- collect the two dates here
                //first date

                Console.WriteLine("Let's find out how much time in hours, minuets, and seconds there is between two dates.");
            Console.WriteLine("Please enter the first date in the MM-DD-YYYY format: ");


            string line = Console.ReadLine();

            DateTime first;
            while (!DateTime.TryParseExact(line, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out first))
            {
                Console.WriteLine("Invalid format, please retry");
                line = Console.ReadLine();
            }


                //second date

                Console.WriteLine("Please enter the second date also in the MM-DD-YYYY format: ");


            string lined = Console.ReadLine();

            DateTime second;
            while (!DateTime.TryParseExact(lined, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out second))
            {
                Console.WriteLine("Invalid format, please retry");
                lined = Console.ReadLine();
            }

            // get the difference between the two dates and process into days, 
            

            TimeSpan span = (first - second);

            int dayz = span.Days;
            int hourz = (dayz / 24);
            int minz = (hourz / 60);

            
            
            Console.WriteLine("There are {0} days, {1} hours, and {2} minutes between {3} and {4}", dayz, hourz, minz, first.ToShortDateString(), second.ToShortDateString());

            Console.WriteLine("Go again? Y/N");
            string go = Console.ReadLine();
            if (go == "Y" || go == "y")
            {
                repeat = true;
            }
            else
            {
                repeat = false;
            }

        }
    }
        }

    }



        


    

