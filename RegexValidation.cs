using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PinCodeProblem
{
    class RegexValidation
    {
        public void Validation(string pinCode)
        {
            Regex regex = new Regex("[1-9]{1}[0-9]{5}");
            
            if (regex.IsMatch(pinCode))
            {
                Console.WriteLine("The PIN code is Valid");
            }
            else
            {
                Console.WriteLine("The PIN code is not Valid");
            }
           
        }
    }
}
