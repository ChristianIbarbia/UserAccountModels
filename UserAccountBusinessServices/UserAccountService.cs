using UserAccountModel;
using UserAccountDataServices;

namespace UserAccountBusinessServices
{

    public class UserAccountService
    {
        public bool VerifyUser(string Username)

        {
            UserDataServices dataService = new UserDataServices();
        var result = dataService.GetUserAccount(Username);

            return result.Username != null ? true: false;
        }
    }
}
