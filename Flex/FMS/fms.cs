using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flex.FMS
{
    public abstract class Fms
    {
        //attributes
        protected string m_userName, m_password;
        //

        //default constructor
        public Fms()
        {
            m_userName = "";
            m_password = "";
        }

        public string getPassword()
        {
            return m_password;
        }
        public string getUsername()
        {
            return m_userName;
        }
        // functions for some global input validations
        public void validateInput(ref int input, int lb, int ub)
        {
            //  checking for the range
            while (input < lb || input > ub)
            {
                Console.WriteLine("Not a valid option, re-enter: ");
                input = Convert.ToInt32(Console.ReadLine());
            }
        }

        // precondition: input is empty ie. user didn't provide it
        // postcondition: sets the argument provided to any input (only worked out on emptiness)
        public void validateInput(ref string input)
        {
            while (string.IsNullOrEmpty(input))
            {
                Console.Write("Please provide input: ");
                input = Console.ReadLine() ?? "";
            }
        }


        public void validateIntInput(ref string input, ref int inp)
        {

            validateInput(ref input);
            // if the wrong input is provided ie. characters provided
            // instead of integer
            while (!int.TryParse(input, out inp))
            {
                Console.WriteLine("Invalid input, re-enter: ");
                input = Console.ReadLine();
                validateInput(ref input);
            }
        }
    }
}
