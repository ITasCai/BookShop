using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using BookModels;
using BookShopBLL;

namespace BookShopWeb.ashx
{
    /// <summary>
    /// SpecialBookShow 的摘要说明
    /// </summary>
    public class SpecialBookShow : IHttpHandler
    {

        HomePageBooksManager hpbm = new HomePageBooksManager();


        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write(GetTableRow());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public string GetTableRow()
        {
            StringBuilder sbHtml = new StringBuilder();
            List<Books> list = hpbm.SpecialBookShow();
            int num = 0;
            foreach (Books book in list)
            {

                if (num % 3 == 0)
                {
                    sbHtml.Append("<tr>");
                }
                sbHtml.Append("<td>");
                sbHtml.Append("<dl id = 'bookNew'>");
                sbHtml.Append("<dt>");
                sbHtml.Append("<img style = 'width: 80px; height: 100px' src ='img/BookCovers/" + book.ImageName + ".jpg'/>");
                sbHtml.Append("</dt>");
                sbHtml.Append("<dd>");
                sbHtml.Append("<a href ='BookDetails.html?"+book.Id+"'><span class='book_title'>" + book.Title + "</span></a>");
                sbHtml.Append("<br/>");
                sbHtml.Append("<span class='book_publish'>出版日期:" + book.PublishDate + "</span><br/><span style = 'color: red; font - weight: bold'> 价格：" + book.UnitPrice + "元</span>");
                sbHtml.Append("</dd>");
                sbHtml.Append("</dl>");
                sbHtml.Append("</td>");
                num++;
                if (num % 3 == 0)
                {
                    sbHtml.Append("</tr>");
                }
            }
            return sbHtml.ToString();

        }
    }
}