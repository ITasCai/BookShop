using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using BookShopBLL;
using BookModels;

namespace BookShopWeb.ashx
{
    /// <summary>
    /// ParticularBookShow 的摘要说明
    /// </summary>
    public class ParticularBookShow : IHttpHandler
    {
        HomePageBooksManager hpbm = new HomePageBooksManager();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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
            List<Books> list = hpbm.ParticularBookShow();
          
            foreach (Books book in list)
            {


                sbHtml.Append("<div class='bookList_content'>");
                sbHtml.Append("<div class='bookDetail_content_left'>");
                sbHtml.Append("<img id = 'ContentPlaceHolder1_imgCover' src='img / BookCovers / 20161212461.jpg' style='height: 200px; width: 176px;'/>");
                sbHtml.Append("</div>");
                sbHtml.Append("<div class='bookDetail_content_right'>");
                sbHtml.Append("<ul>");
                sbHtml.Append("<li id ='bookDetail_l1'>< strong > 图书名称:</strong><span id = 'ContentPlaceHolder1_lblBookName' >"+ +"</span><a href = '#' class='blue_size'></a></li>");
                sbHtml.Append("<li id ='bookDetail_l2'>< strong > 作者:</strong><span id = 'ContentPlaceHolder1_lblAuthor'>"+ +"</ span ></ li >");
                sbHtml.Append("<li id='bookDetail_l3'>");
                sbHtml.Append("<ul>");
                sbHtml.Append("<li><strong>出版社:</strong><span id = 'ContentPlaceHolder1_lblPublishName'>"+ +"</span ></li>");
                sbHtml.Append("< li >< strong > 出版时间:</strong><span id = 'ContentPlaceHolder1_lblPublishDate'>"+ +"</ span ></ li >");
                sbHtml.Append("</ul>");
                sbHtml.Append("</li>");
                sbHtml.Append("<li id='bookDetail_l4'>");
                sbHtml.Append("<ul>");
                sbHtml.Append("<li><strong>ISBN:</strong><span id ='ContentPlaceHolder1_lblISBN'> 23456789 </ span ></ li >");
                sbHtml.Append("< li >< strong > 字数:</strong><span id = 'ContentPlaceHolder1_lblWordsCount' >"+ +"</ span ></ li >");
                sbHtml.Append("</ul>");
                sbHtml.Append("</li>");
                sbHtml.Append("<li id='bookDetail_l5'>");
                sbHtml.Append("<ul>");
                sbHtml.Append("<li><strong>点击量:</strong><span id = 'ContentPlaceHolder1_lblClickCount' >"+ +"</ span ></ li >");
                sbHtml.Append("< li >< strong > 价格:</strong><span style ='color: red; font - weight:bold'>¥<span id ='ContentPlaceHolder1_lblUnitPrice'>"+ +"</span> 元 </ span ></ li >");
                sbHtml.Append("</ul>");
                sbHtml.Append("</li>");
                sbHtml.Append("<li id='bookDetail_l6'>");
                sbHtml.Append("<input type ='image' name='ctl00$ContentPlaceHolder1$ibtnBuy' id='ContentPlaceHolder1_ibtnBuy' src='img / bnt_buy.gif' />");
                sbHtml.Append("</li>");
                sbHtml.Append("</ul>");
                sbHtml.Append("</div>");
                sbHtml.Append("< div class='bookDetail_content_bottom'></div>");
                sbHtml.Append("<div class='bookDetail_content_Descript_title'>");
                sbHtml.Append("<strong>图书内容描述:</strong>");
                sbHtml.Append("</div>");
                sbHtml.Append("<div class='bookDetail_content_Descript_p'>");
                sbHtml.Append("<p id ='ContentPlaceHolder1_pdetails' >< p >"+ +"</p><p><br/></p></p>");
                sbHtml.Append("</div>");
                sbHtml.Append("</div>");
               

    
            }
            return sbHtml.ToString();

        }
    }
}