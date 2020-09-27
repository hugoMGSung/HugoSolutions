using HERP.Origin.App.Helpers;

namespace HERP.Origin.App.Model
{
    public static class LoginModelDal
    {
        public static int CheckUserInfo(string userId, string userPwd)
        {
            var query = QueryBanks.ErpUser.QrySelectCountUserInfo;
            var result = SqlHelper.GetDataScalar(query, userId, userPwd);

            return result;
        }
    }
}
