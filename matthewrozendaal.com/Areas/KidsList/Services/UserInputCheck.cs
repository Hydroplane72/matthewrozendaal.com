using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace matthewrozendaal.com.Areas.KidsList.Services
{
    public class UserInputCheck
    {
        /// <summary>
        /// Checks the user's input in the User Login Screen.
        /// </summary>
        /// <param name="username">The user's username</param>
        /// <param name="password">The user's password</param>
        /// <returns></returns>
        public Boolean UserLogin(String username, String password)
        {
            //if checks clear return true
            if (GeneralInputCheck(username) && GeneralInputCheck(password))
                return true;
            else
                return false;
        }
        private Boolean GeneralInputCheck(String input)
        {
            if (input != null) //if null then it will not present a threat

            {

                //Makes it easier to  check individual letters

                input = input.ToUpper();

                if (input.Contains("(") || input.Contains(")")

                    || input.Contains("?") || input.Contains("=")

                    || input.Contains("[") || input.Contains("]")

                    || input.Contains("{") || input.Contains("}")

                    || input.Contains("INSERT") || input.Contains("SELECT"))



                {

                    return false;

                }

            }

            return true;
        }
    }
}