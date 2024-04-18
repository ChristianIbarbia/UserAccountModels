using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAccountModel;

namespace UserAccountDataServices

{

    public class UserDataServices

    {

        List<UserAccount> dummyUsers = new List<UserAccount>();

        public UserDataServices()
        {

            CreateDummyData();
        }

        private void CreateDummyData()
        {

            UserAccount dummyUser = new UserAccount
            {

                Username = "Xtian",
            Password = "Pogi"
            };


            dummyUsers.Add(dummyUser);
        }


        public UserAccount GetUserAccount(string Username)
        {

            UserAccount foundUserAccount = new UserAccount();
            foreach (var user in dummyUsers)
            {
                if (Username == user.Username);
            {
                    foundUserAccount = user;
                }
            }
            return foundUserAccount;
        }
    }
}