using System;
using System.Linq;

namespace AuthenticationJWT.Application
{
    public class UserApp : App
    {
        public AppResult ValidateUser(string username, string password)
        {
            var res = new AppResult();

            try
            {
                var user = db.User.FirstOrDefault(x => x.UserName == username);
                if (user == null)
                    return res;

                if (user.Password == password)
                {
                    return res.Good(user);
                }

                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
