using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookModels;
using BookShopDAL;
using System.Data;
using System.Data.SqlClient;
     

namespace BookShopBLL
{
    /// <summary>
    /// 用户操作业务逻辑类
    /// </summary>
   public class UserManager
    {
        UserService us = new UserService();
        /// <summary>
        /// 用户登录判断
        /// </summary>
        /// <returns></returns>
        public int IfUser(Users user)
        {
            return us.IfUser(user);
        }
        }
}
