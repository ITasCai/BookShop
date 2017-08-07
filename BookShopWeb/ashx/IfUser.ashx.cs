using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookShopBLL;
using BookModels;

namespace BookShopWeb.ashx
{
    /// <summary>
    /// IfUser 的摘要说明
    /// </summary>
    public class IfUser : IHttpHandler
    {

        UserManager um = new UserManager();
        Users user = new Users();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            user.LoginId = context.Request["LoginId"];
            user.LoginPwd = context.Request["LoginPwd"];
            context.Response.Write(um.IfUser(user));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}