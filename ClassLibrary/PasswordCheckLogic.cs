using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PasswordCheckLogic
    {
        //get password
        public string Password { get;}

        public PasswordCheckLogic(string password)
        {
            Password = password;
        }

        public PasswordCheckLogic()
        {
        }

        //Password check method return bool
        public bool PasswordChecked(string password)
        {
            bool hasNum = false, hasCaps = false, hasLow = false, hasSymbol = false, hasSpace = true;
            char currentCharacter;

            //check for password længde
            if (password.Length < 12)
            {
                return false;
            }

            //læse password check om kravene er opfyldt
            for (int i = 0; i < password.Length; i++)
            {
                currentCharacter = password[i];

                if (char.IsDigit(currentCharacter))
                {

                    hasNum = true;

                }

                if (char.IsUpper(currentCharacter))
                {
                    hasCaps = true;
                }

                if (char.IsLower(currentCharacter))
                {
                    hasLow = true;
                }

                if(Regex.IsMatch(password, @"[!-&]"))
                {
                    hasSymbol = true;
                }

                if (char.Equals(currentCharacter, " "))
                {
                    hasSpace = false;

                }

                if (hasNum && hasCaps && hasLow && hasSymbol && hasSpace)
                {
                    return true;
                }


            }

            return false;
        }

    }
}
