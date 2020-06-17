using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class TDDMethods
    {

        public string ValidateEmail(string name, string email)
        {

            string separator = "_";
            var lowerName = name.ToLowerInvariant();
            var normalized = lowerName.Replace(" ", separator);
            var emailBuilder = normalized.Split('_');

            var userEmail = emailBuilder[0] + "." + emailBuilder[1];

            var comparativeUserEmail = email.Split('@');

            if (comparativeUserEmail[0] != userEmail)
                return "Please, your user need to follow our pattern";

            var completeEmail = userEmail + "@email.com.br";

            return completeEmail;
        }

    }
}
