using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_1.Exercise2
{
    internal class PasswordValidator : IValidator
    {
        public string Password;

        public PasswordValidator(string pass)
        {
            Password = pass;
        }

        public bool Validate()
        {
            return Password.Length >= 6 && Password.Any(char.IsDigit);//Валідний пароль якщо довжина більше за 6 символів та хоча б один символ  цифрою
        }
    }

}
