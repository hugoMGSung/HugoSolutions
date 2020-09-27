using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HERP.Origin.App.Model;

namespace HERP.Origin.App.Business
{
    public class MainProc
    {
        /// <summary>
        /// 모든 메뉴를 가져오기
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<TMenu> GetAllMenus(string userId)
        {
            var temp = MainModelDal.GetAllMenuInfos(userId);
            var result = new List<TMenu>();

            foreach (var item in temp)
            {
                var curr = new TMenu
                {
                    Idx = item.Idx, Name = item.Name, Parent_Idx = item.Parent_Idx,
                    ID = item.ID, UseYn = item.UseYn, Class = item.Class,
                    Orders = item.Orders, UserId = item.UserId
                };
                result.Add(curr);
            }
            return result;
        }

        public List<MyTable> GetSampleMenus()
        {
            var temp = MainModelDal.GetAllSampleMenuInfos();
            var result = new List<MyTable>();

            foreach (var item in temp)
            {
                var curr = new MyTable {Id = item.ID, Title = item.title, ParentId = item.parentID};
                result.Add(curr);
            }
            return result;
        }
    }
}
