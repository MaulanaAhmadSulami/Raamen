using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.View
{
    public class regist
    {
        public bool IsUsernameValid(string username)
        {
            // Check if the username length is between 5 and 15 characters
            if (username.Length < 5 || username.Length > 15)
            {
                return false;
            }

            // Check if the username contains only alphabets and spaces
            foreach (char c in username)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }

            return true;
        }
    }
}