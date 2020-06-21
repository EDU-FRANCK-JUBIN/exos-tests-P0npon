using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exo_tests
{
    public static class NameTool
    {
        public static string extractInitials(string firstName, string lastName)
        {
            // Check if arguments are not null
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException();
            }

            //Check if arguments are valid
            if (!(Regex.IsMatch(firstName, @"^[a-zA-Z\s]*$") && Regex.IsMatch(lastName, @"^[a-zA-Z\s]*$")))
            {
                throw new ArgumentException();
            }

            string initials = "";

            // Extract first names initials
            string[] firstNames = firstName.Split(' ');
            foreach (var element in firstNames)
            {
                if(element[0]>96)
                {
                    initials += (char)(element[0]-32);
                }

                else
                {
                    initials += element[0];
                }
                
            }

            //Add space between first name initial and last name initial
            initials += " ";

            // Extract last names initials
            string[] lastNames = lastName.Split(' ');
            foreach (var element in lastNames)
            {
                if (element[0] > 96)
                {
                    initials += (char)(element[0] - 32);
                }

                else
                {
                    initials += element[0];
                }
            }

            //Delete the last space and return initials
            return initials;
        }
    }
}
