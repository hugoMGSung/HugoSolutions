using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using HSMS.Caliburn.App.Helpers;

namespace HSMS.Caliburn.App.Models
{
    public class SqlHelper
    {
        /// <summary>
        /// 로그인 콤보박스 단과대학 리스트
        /// </summary>
        /// <returns></returns>
        public static List<College> GetAllColleges()
        {
            var query = "SELECT * FROM TblColleges";
            using (IDbConnection conn = new SqlConnection(Commons.CONNSTR))
            {
                conn.Open();
                var colleges = conn.Query<College>(query).ToList();

                return colleges;
            }
        }

        /// <summary>
        /// 로그인처리 메서드
        /// 로그인 성공시 1 아니면 0
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pwd"></param>
        /// <param name="idx"></param>
        /// <returns></returns>
        public static int CheckUserLogin(string name, string pwd, int idx)
        {
            var query = @"SELECT COUNT(*) 
                            FROM TblSystemUsers 
                           WHERE Name = @Name 
                             AND Pwd = @Pwd 
                             AND CollegeIdx = @CollegeIdx ";
            var param = new DynamicParameters();
            param.Add("@Name", name);
            param.Add("@Pwd", pwd);
            param.Add("@CollegeIdx", idx);

            using (IDbConnection conn = new SqlConnection(Commons.CONNSTR))
            {
                conn.Open();
                var output = conn.Query<int>(query, param, commandType: CommandType.Text)
                                    .FirstOrDefault();

                return output;
            }
        }
    }
}
