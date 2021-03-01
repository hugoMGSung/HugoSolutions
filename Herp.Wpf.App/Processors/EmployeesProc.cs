using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Herp.Wpf.App.Helpers;
using Herp.Wpf.App.Models;

namespace Herp.Wpf.App.Processors
{
    public class EmployeesProc
    {
        public ObservableCollection<Employees> GetAllEmployeeses(string name)
        {
            
            IEnumerable<Employees> result = new List<Employees>();
            try
            {
                using (IDbConnection conn = new SqlConnection(Commons.ConnString))
                {
                    conn.Open();
                    if (string.IsNullOrEmpty(name))
                    {
                        var query = QueryBanks.Employees.GetAllEmployees;
                        result = conn.Query<Employees>(query, null, commandType: CommandType.Text);
                    }
                    else
                    {
                        var query = QueryBanks.Employees.GetEmployees;
                        var param = new DynamicParameters();
                        param.Add("@Name", name);
                        result = conn.Query<Employees>(query, param, commandType: CommandType.Text);
                    }
                }
            }
            catch (Exception e)
            {
                Commons.NLogger.Error($"{e}");
            }

            return new ObservableCollection<Employees>(result);
        }
    }
}
