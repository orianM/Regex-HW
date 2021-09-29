using System;
using System.Text.RegularExpressions;

namespace Regex_HW
{
    class Program
    {

        static void Main(string[] args)
        {
            #region exercise 1

            Console.WriteLine("Uppercase D\n");

            Regex startWithD = new Regex(@"\AD");
            string testString1 = Console.ReadLine();
            if (startWithD.IsMatch(testString1))
            {
                Console.WriteLine("\nMatch");
            }
            else
            {
                Console.WriteLine("\nNot match");
            }

            Console.WriteLine("-----------------------------------------");

            #endregion

            #region exercise 2

            Console.WriteLine("Uppercase F,D or I\n");

            Regex startWithFDI = new Regex(@"\AF|\AD|\AI");
            string testString2 = Console.ReadLine();
            if (startWithFDI.IsMatch(testString2))
            {
                Console.WriteLine("\nMatch");
            }
            else
            {
                Console.WriteLine("\nNot match");
            }

            Console.WriteLine("-----------------------------------------");

            #endregion

            #region exercise 3

            Console.WriteLine("Uppercase F,D or I and then 6 numbers, underscore and two Uppercase letters\n");

            Regex startWithFDIandOther = new Regex(@"\AF\d{6}(_[A-Z]{2})|\AD\d{6}(_[A-Z]{2})|\AI\d{6}(_[A-Z]{2})");
            string testString3 = Console.ReadLine();
            if (startWithFDIandOther.IsMatch(testString3))
            {
                Console.WriteLine("\nMatch");
            }
            else
            {
                Console.WriteLine("\nNot match");
            }

            Console.WriteLine("-----------------------------------------");

            #endregion

            #region exercise 4

            Console.WriteLine("replace yyy\n");

            Regex myExpression = new Regex(@"(yyy)");
            string testString4 = Console.ReadLine();
            if (myExpression.IsMatch(testString4))
            {
                testString4 = myExpression.Replace(testString4, "");
                Console.WriteLine("Replaced");
            }
            Console.WriteLine("\nstring is now: {0}", testString4);

            Console.WriteLine("-----------------------------------------");

            #endregion

            #region exercise 5

            Console.WriteLine("Start with Uppercase letter\n");

            Regex startWithUppercase = new Regex(@"[A-Z]");
            string teststring5 = Console.ReadLine();
            if (startWithUppercase.IsMatch(teststring5))
            {
                Console.WriteLine("\nMatch");
            }
            else
            {
                Console.WriteLine("\nNot match");
            }

            Console.WriteLine("-----------------------------------------");

            #endregion

            #region exercise 6

            Console.WriteLine("abc or ABC\n");

            Regex abcOrABC = new Regex(@"(abc|ABC)");
            string teststring6 = Console.ReadLine();
            if (abcOrABC.IsMatch(teststring6))
            {
                Console.WriteLine("\nMatch");
            }
            else
            {
                Console.WriteLine("\nNot match");
            }

            Console.WriteLine("-----------------------------------------");

            #endregion

            #region exercise 7

            Console.WriteLine("more than 2 letters and two words\n");

            Console.WriteLine("Enter First name");
            string firstname = Console.ReadLine();

            Console.WriteLine("\nEnter Last name");
            string lastname = Console.ReadLine();

            FullName name = new FullName(firstname, lastname);

            var isProperName = new Regex(@"([A-z]{2,18})");
            if (isProperName.IsMatch(name.FirstName) && isProperName.IsMatch(name.LastName))
            {
                Console.WriteLine("\nProper name\n\nFirst name: {0}\nLast name: {1}", name.FirstName, name.LastName);
            }
            else
            {
                Console.WriteLine("\nNot a proper name\n\nFirst name: {0}\nLast name: {1}", name.FirstName, name.LastName);
            }

            Console.WriteLine("-----------------------------------------");

            #endregion

            #region exercise 8

            Console.WriteLine("Write a Decimal Number\n");

            var decimalNumber = new Regex(@"(\d\.)");
            string teststring8 = (Console.ReadLine());
            if (decimalNumber.IsMatch(teststring8))
            {
                Console.WriteLine("\n{0} Is a Decimal number", teststring8);
            }
            else
            {
                Console.WriteLine("\n{0} Is Not a decimal number", teststring8);
            }

            Console.WriteLine("-----------------------------------------");

            #endregion

            #region exercise 9

            Console.WriteLine("Write a Decimal Number with 3 numbers after the dot\n");

            var decimalwith3numbers = new Regex(@"(\d\.\d\d\d)");
            string teststring9 = (Console.ReadLine());
            if (decimalwith3numbers.IsMatch(teststring9))
            {
                Console.WriteLine("\n{0} has 3 numbers after the dot", teststring9);
            }
            else
            {
                Console.WriteLine("\n{0} doesn't have 3 numbers after the dot", teststring9);
            }

            Console.WriteLine("-----------------------------------------");

            #endregion

            #region exercise 10

            Console.WriteLine("Enter gmail address\n");

            var emailAddress = new Regex(@"([A-z]*\D*\@gmail\.com)");
            string testString10 = Console.ReadLine();
            if (emailAddress.IsMatch(testString10))
            {
                Console.WriteLine("\nValid email address");
            }
            else
            {
                Console.WriteLine("\nInvalid email address");
            }

            Console.WriteLine("-----------------------------------------");

            #endregion

        }
    }
}
