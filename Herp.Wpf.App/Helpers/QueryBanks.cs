namespace Herp.Wpf.App.Helpers
{
    public static class QueryBanks
    {
        public static class Users
        {
            public static string GetUserInfo =
                @"SELECT COUNT(*) 
                    FROM dbo.Users
                   WHERE UserId = @UserId
                     AND Password = @Password ";
        }

        public static class Employees
        {
            public static string GetAllEmployees =
                @"SELECT Idx
                       , FirstName
                       , LastName
                       , Address
                       , MobileNo
                       , Email
                       , NID
                       , BloodGroup
                       , Religion
                       , Education
                       , Salary
                       , Comment
                       , JoinDate
                       , RegDt
                       , RegId
                       , ModDt
                       , ModId
                    FROM dbo.Employees ";

            public static string GetEmployees =
                @"SELECT Idx
                       , FirstName
                       , LastName
                       , Address
                       , MobileNo
                       , Email
                       , NID
                       , BloodGroup
                       , Religion
                       , Education
                       , Salary
                       , Comment
                       , JoinDate
                       , RegDt
                       , RegId
                       , ModDt
                       , ModId
                    FROM dbo.Employees 
                   WHERE FirstName LIKE CONCAT ('%', @Name, '%') ";
        }
    }
}
