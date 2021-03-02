using System;
using System.Text;

namespace PwdGen
{
    public class PasswordGenerator
    {
        private int pwdLength;
        private bool uppercase;
        private bool lowercase;
        private bool digit;
        private bool specialSymbol;

        private string lowercaseLetters = "abcdefghijklmnopqrstuvxyz";
        private string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
        private string digits = "0123456789";
        private string specialSymbols = "!@#$%^&*()-=_+[]{}|;/.,<>?:`~";


        private static Random rnd = new Random();
        public PasswordGenerator(): this(8, true, true, true, false)
        {

        }

        public PasswordGenerator(int pwdLength, bool uppercase, bool lowercase, bool digit, bool specialSymbol)
        {
            this.pwdLength = pwdLength;
            this.uppercase = uppercase;
            this.lowercase = lowercase;
            this.digit = digit;
            this.specialSymbol = specialSymbol;
        }

        // TODO: implementati un algoritm pentru generare de parole (euristic) care sa tina cont de numarul de
        // caractere din fiecare categorie si sa introduca acele caractere in mod proportional 
        public string GetPwd()
        {
            string result = "";

            string chars = "";
            if (uppercase)
            {
                chars += uppercaseLetters;
            }
            if (lowercase)
            {
                chars += lowercaseLetters;
            }
            if (digit)
            {
                chars += digits;
            }
            if (specialSymbol)
            {
                chars += specialSymbols;
            }

            StringBuilder sb = new StringBuilder();


            
            int n = chars.Length;
            for (int i = 0; i < pwdLength; i++)
            {
                // TODO
                sb.Append(chars[rnd.Next(n)]);
            }

            result = sb.ToString();
            return result;
        }

        public string GetPwd(int pwdLength, bool uppercase, bool lowercase, bool digit, bool specialSymbol)
        {
            this.pwdLength = pwdLength;
            this.uppercase = uppercase;
            this.lowercase = lowercase;
            this.digit = digit;
            this.specialSymbol = specialSymbol;


            return GetPwd();


        }
    }
}
