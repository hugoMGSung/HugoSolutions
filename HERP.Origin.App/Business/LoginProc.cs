using System.Security.Cryptography;
using HERP.Origin.App.Helpers;
using HERP.Origin.App.Model;

namespace HERP.Origin.App.Business
{
    public class LoginProc
    {
        public int CheckUserInfo(string userId, string userPwd)
        {
            var mdHash = MD5.Create();
            var encPwd = Commons.GetMd5Hash(mdHash, userPwd);
            var result = LoginModelDal.CheckUserInfo(userId, encPwd);

            return result;
        }
    }
}
