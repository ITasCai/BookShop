using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BookModels;
using IBookShopDAL;
using BookShopCommon;

namespace BookShopDAL
{
    /// <summary>
    /// 用户操作数据访问类
    /// </summary>
    public class UserService : IUser
    {
        /// <summary>
        /// 用户登录判断
        /// </summary>
        /// <returns></returns>
        public int IfUser(Users user)
        {
            string sql = @"SELECT COUNT(*) FROM dbo.Users WHERE UserRoleId=1 
                         AND LoginId=@LoginId AND LoginPwd=@LoginPwd";

            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@LoginId",user.LoginId),
                new SqlParameter("@LoginPwd",user.LoginPwd)
            };

            return SqlHelper.ExecuteScalar<int>(CommandType.Text,sql,pa);
        }
    }
}
