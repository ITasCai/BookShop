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
            context.Response.ContentType = "text/html";

            int ID =Convert.ToInt32(context.Request["ID"]);
            context.Response.Write(GetTableRow(ID));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


        public string GetTableRow(int id)
        {
            StringBuilder sbHtml = new StringBuilder();
            List<Books> list = hpbm.ParticularBookShow(id);
          
            foreach (Books book in list)
            {

                sbHtml.Append("<div class='bookList_content'>");
                sbHtml.Append("<div class='bookDetail_content_left'>");
                sbHtml.Append("<img id = 'ContentPlaceHolder1_imgCover' src='img/BookCovers/"+book.ImageName+".jpg' style='height: 200px; width: 176px;'/>");
                sbHtml.Append("</div>");
                sbHtml.Append("<div class='bookDetail_content_right'>");
                sbHtml.Append("<ul>");
                sbHtml.Append("<li id ='bookDetail_l1'><strong>图书名称:</strong><span id = 'ContentPlaceHolder1_lblBookName'>"+book.Title+"</span><a href = '#' class='blue_size'></a></li>");
                sbHtml.Append("<li id ='bookDetail_l2'><strong>作者:</strong><span id = 'ContentPlaceHolder1_lblAuthor'>"+book.Author +"</ span ></ li >");
                sbHtml.Append("<li id='bookDetail_l3'>");
                sbHtml.Append("<ul>");
                sbHtml.Append("<li><strong>出版社:</strong><span id = 'ContentPlaceHolder1_lblPublishName'>"+book.Name +"</span ></li>");
                sbHtml.Append("<li><strong> 出版时间:</strong><span id = 'ContentPlaceHolder1_lblPublishDate'>"+ book.PublishDate+"</ span ></ li >");
                sbHtml.Append("</ul>");
                sbHtml.Append("</li>");
                sbHtml.Append("<li id='bookDetail_l4'>");
                sbHtml.Append("<ul>");
                sbHtml.Append("<li><strong>ISBN:</strong><span id ='ContentPlaceHolder1_lblISBN'>"+book.ISBN+"</span></li>");
                sbHtml.Append("<li><strong> 字数:</strong><span id = 'ContentPlaceHolder1_lblWordsCount' >"+book.WordsCount +"</pan ></li>");
                sbHtml.Append("</ul>");
                sbHtml.Append("</li>");
                sbHtml.Append("<li id='bookDetail_l5'>");
                sbHtml.Append("<ul>");
                sbHtml.Append("<li><strong>点击量:</strong><span id = 'ContentPlaceHolder1_lblClickCount' >"+book.Clicks +"</span></li>");
                sbHtml.Append("<li><strong> 价格:</strong><span style ='color: red; font - weight:bold'>¥<span id ='ContentPlaceHolder1_lblUnitPrice'>"+ book.UnitPrice+"</span> 元 </ span ></ li >");
                sbHtml.Append("</ul>");
                sbHtml.Append("</li>");
                sbHtml.Append("<li id='bookDetail_l6'>");
                sbHtml.Append("<input type ='image' name='ctl00$ContentPlaceHolder1$ibtnBuy' id='ContentPlaceHolder1_ibtnBuy' src='img/bnt_buy.gif'/>");
                sbHtml.Append("</li>");
                sbHtml.Append("</ul>");
                sbHtml.Append("</div>");
                sbHtml.Append("<div class='bookDetail_content_bottom'></div>");
                sbHtml.Append("<div class='bookDetail_content_Descript_title'>");
                sbHtml.Append("<strong>图书内容描述:</strong>");
                sbHtml.Append("</div>");
                sbHtml.Append("<div class='bookDetail_content_Descript_p'>");
                sbHtml.Append("<p id ='ContentPlaceHolder1_pdetails' >"+book.ContentDescription+"</p><p><br/></p></p>");
                sbHtml.Append("</div>");
                sbHtml.Append("</div>");
               

    
            }
            return sbHtml.ToString();

        }
    }
}