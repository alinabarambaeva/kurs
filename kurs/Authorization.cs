﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs.Properties
{
    internal class Authorization
    {
        public static string authorizationRole;

        public static string GetRole(string login, string password)
        {
            var account = Service5Entities.GetContext().Account.FirstOrDefault(a => a.logins == login && a.passwords == password);
            if (account != null)
            {
                return authorizationRole = account.Role_.name_role;
            }

            return null;
        }
    }
}