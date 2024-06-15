using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Validator
{
    internal class PasswordValidator
    {
        private readonly string _password;
        private (bool containsUppercase, bool containsLowercase, bool containsNumber, bool containsValidCharacters) _restrictions;

        public PasswordValidator(string password)
        {
            _password = password;
            _restrictions = (false, false, false, true);
        }

        public bool Validate()
        {
            if (_password == null || _password.Length == 0)
            {
                return false;
            }

            foreach(var character in _password)
            {
                if(char.IsUpper(character))
                {
                    _restrictions.containsUppercase = true;
                } else if (char.IsLower(character))
                {
                    _restrictions.containsLowercase = true;
                } else if (char.IsDigit(character))
                {
                    _restrictions.containsNumber = true;
                } else if(character == 'T' || character == '&')
                {
                    _restrictions.containsValidCharacters = false;
                }
            }

            if(_restrictions == (true, true, true, true))
            {
                return true;
            }
            return false;
        }

        private static string InvalidPasswordReason()
        {

        }


    }
}
