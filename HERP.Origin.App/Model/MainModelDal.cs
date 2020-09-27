using System.Collections.Generic;
using System.Data;
using HERP.Origin.App.Helpers;

namespace HERP.Origin.App.Model
{
    public static class MainModelDal
    {
        public static IEnumerable<dynamic> GetAllMenuInfos(string userId)
        {
            var query = QueryBanks.Menu.QrySelectAllMenuInfos;
            var result = SqlHelper.GetDataTable(query, userId);
            return result;
        }

        public static IEnumerable<dynamic> GetAllSampleMenuInfos()
        {
            var query = QueryBanks.Menu.QrySelectAllSampleMenuInfos;
            var result = SqlHelper.GetDataTable(query);

            return result;
        }
    }
}
