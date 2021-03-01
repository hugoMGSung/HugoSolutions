using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HugoSMS.WinForm.App.Models;

namespace HugoSMS.WinForm.App.Business
{
    public static class DataAccess
    {

        #region USER영역

        /// <summary>
        /// 모든 사용자 정보 가져오기
        /// </summary>
        /// <returns></returns>
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var ctx = new ssmsEntities())
            {
                users = ctx.User.ToList();
            }

            return users;
        }

        /// <summary>
        /// 사용자 정보 저장하기
        /// </summary>
        /// <param name="tmpUser"></param>
        /// <returns></returns>
        public static int SetUsers(User tmpUser)
        {
            using (var ctx = new ssmsEntities())
            {
                ctx.User.Add(tmpUser);
                return ctx.SaveChanges();
            }
        }

        #endregion


    }
}
