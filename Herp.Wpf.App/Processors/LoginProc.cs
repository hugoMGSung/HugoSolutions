using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using Dapper;
using Herp.Wpf.App.Helpers;
using Herp.Wpf.App.Models;

namespace Herp.Wpf.App.Processors
{
    public class LoginProc
    {
        public bool CheckUserInfo(Users paramUser)
        {
            var mdHash = MD5.Create();
            paramUser.Password = Commons.GetMd5Hash(mdHash, paramUser.Password);
            var query = QueryBanks.Users.GetUserInfo;
            var result = 0;

            try
            {
                var param = new DynamicParameters();
                param.Add("@UserId", paramUser.UserId);
                param.Add("@Password", paramUser.Password);

                using (IDbConnection conn = new SqlConnection(Commons.ConnString))
                {
                    conn.Open();
                    result = conn.Query<int>(query, param, commandType: CommandType.Text).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Commons.NLogger.Error($"{e}");
            }

            return result == 1;
        }
    }
}
