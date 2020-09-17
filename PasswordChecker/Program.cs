using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a password...");
            string password = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Password inputted : " + password);
            int score = 0;
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            string specialChars = "#?!,-'/`_*$";
            if (password.Length >= minLength)
            {
                score += 1;
                Console.WriteLine("Password longer than (or = ) 8 characters! (+1 SCORE POINT)");
            }
            else
            {
                score -= 1;
                Console.WriteLine("Password is shorter than 8 characters. (-1 SCORE POINT)");
            }
            if (Tools.Contains(password, uppercase))
            {
                Console.WriteLine("Uppercase letter! (+1 SCORE POINT)");
                score += 1;
            }
            else
            {
                Console.WriteLine("No uppercase letters! (-1 SCORE POINT)");
                score -= 1;
            }
            if (Tools.Contains(password, digits))
            {
                Console.WriteLine("Digits included! (+1 SCORE POINT)");
                score += 1;
            }
            else
            {
                Console.WriteLine("Include digits! (-1 SCORE POINT)");
                score -= 1;
            }
            if (Tools.Contains(password, specialChars))
            {
                Console.WriteLine("Special chars included! (+1 SCORE POINT)");
                score += 1;
            }
            else
            {
                Console.WriteLine("Include special chars! (-1 SCORE POINT)");
                score -= 1;
            }
            Console.WriteLine("Final score : " + score);
        }
    }
}