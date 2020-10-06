using System;

namespace PinCodeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the indian pin code number");
            string pinCode = Console.ReadLine();
            RegexValidation reg = new RegexValidation();
            reg.Validation(pinCode);
        }
    }
}
