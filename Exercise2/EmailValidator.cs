using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_Cs_1.Exercise2
{
    internal class EmailValidator : IValidator
    {
        public string Email;

        public EmailValidator(string email)
        {
            Email = email;
        }

        public bool Validate()
        {
            return Email.Contains("@") && Email.Contains(".") && Email.Length > 5;//звичайна валідація 
        }
    }
}
