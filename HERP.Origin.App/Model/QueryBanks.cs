namespace HERP.Origin.App.Model
{
    public static class QueryBanks
    {
        public static class ErpUser
        {
            public static string QrySelectCountUserInfo = 
                @"SELECT COUNT(*) FROM dbo.TErpUser
                   WHERE UserId = @UserId
                     AND Pwd = @UserPwd ";
        }

        public static class Menu
        {
            public static string QrySelectAllMenuInfos =
                @"SELECT * 
                    FROM dbo.TMenu
                   WHERE UserId = @UserId ";


            public static string QrySelectAllSampleMenuInfos =
                @"SELECT ID, title, 
                         ISNULL(parentID, 0) AS parentID
	                FROM dbo.myTable";
        }
    }
}
