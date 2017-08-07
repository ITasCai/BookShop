using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookModels;

namespace IBookShopDAL
{
    /// <summary>
    /// 对用户进行操作的接口
    /// </summary>
   public interface IUser
    {
       /// <summary>
       /// 进行用户判断
       /// </summary>
       /// <returns></returns>
        int IfUser(Users user);
    }
}
