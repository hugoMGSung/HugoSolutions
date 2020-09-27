using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using HERP.Origin.App.Model;
using NLog;

namespace HERP.Origin.App.Helpers
{
    public static class SqlHelper
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static int GetDataScalar(params string[] args)
        {
            var result = 0;

            try
            {
                var query = args[0];
                var param = new DynamicParameters();
                param.Add("@UserId", args[1]);
                param.Add("@UserPwd", args[2]);

                using (IDbConnection conn = new SqlConnection(Commons.ConnString))
                {
                    conn.Open();
                    result = conn.Query<int>(query, param, commandType: CommandType.Text)
                        .FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Commons.NLogger.Error($"{e}");
            }

            return result;
        }

        public static IEnumerable<dynamic> GetDataTable(params string[] args)
        {
            IEnumerable<dynamic> result = null;

            try
            {
                if (args.Length == 1) // query만 있음
                {
                    var query = args[0];

                    using (IDbConnection conn = new SqlConnection(Commons.ConnString))
                    {
                        conn.Open();
                        result = conn.Query(query).AsList();
                    }
                }
                else if (args.Length == 2)
                {
                    var query = args[0];
                    var param = new DynamicParameters();
                    param.Add("@UserId", args[1]);
                    using (IDbConnection conn = new SqlConnection(Commons.ConnString))
                    {
                        conn.Open();
                        result = conn.Query(query, param).AsList();
                    }
                }
            }
            catch (Exception e)
            {
                Commons.NLogger.Error($"{e}");
            }

            return result;
        }
    }
}
