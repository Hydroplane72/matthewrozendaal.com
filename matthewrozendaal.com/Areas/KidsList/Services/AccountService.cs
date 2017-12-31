using matthewrozendaal.com.Areas.KidsList.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;

namespace matthewrozendaal.com.Areas.KidsList.Services
{
    /// <summary>
    /// Used to connect the model with the name correlated controller.
    /// This seperates accessing the database directly from the controller.
    /// It brings the benefit of better unit testing.
    /// </summary>
    public class AccountService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <param name="Username"></param>
        /// <returns></returns>
        public Boolean AccountLogin(String Password, String Username)
        {
            ControllerReturn<Account> controllerReturn = new ControllerReturn<Account>();
            //TODO:
            //check input if not clear return false
            UserInputCheck inputCheck = new UserInputCheck();
            if(!inputCheck.UserLogin(Username, Password)) //Return false if check failed
            {
                return false;
            }
           KidsListDatabaseEntity entity = new KidsListDatabaseEntity();
           DbContextTransaction context =  entity.Database.BeginTransaction();
            /*
             * Code Obtained from:
             * https://stackoverflow.com/questions/22790893/linq-check-exist-username-then-get-that-users-id
             */
            try
            {
                int userId = (from x in entity.Accounts
                              where x.username == Username.ToUpper() //All usernames are uppercase
                              select x.Account_ID).SingleOrDefault();

                if (userId > 0)
                {
                    // user exists
                }
                else
                {
                    // user does not exist
                    Console.WriteLine("User does not exist");
                    return false;
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Username: _" + Username + "_");
                Console.WriteLine("Returned more than one username.");
                // has more than one element
                return false;
            }
            
            return true;
        }
        /*
         * var user = entity.Accounts.SingleOrDefault(user => user.username == Username);
            //var user = Context.Accounts.SinlgeOrDefault(user => user.UserName == "yourValue");
            if (user != null)
            {
                // you can safely access the user properties here
            }
            entity.
         */
    }
}