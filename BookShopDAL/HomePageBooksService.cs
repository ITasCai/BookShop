using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookModels;
using BookShopDAL;
using IBookShopDAL;
using System.Data;
using System.Data.SqlClient;
using BookShopCommon;

namespace BookShopDAL
{
    /// <summary>
    /// 显示首页书籍信息数据访问类
    /// </summary>
    public class HomePageBooksService : IHomePageBooksShow
    {
        /// <summary>
        /// 显示最新书籍信息
        /// </summary>
        /// <returns></returns>
        public List<Books> NewestBookShow()
        {
           
            string sql = "SELECT TOP 9  *FROM dbo.Books WHERE PublishDate>='2007-08-01'";
            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);
            List<Books> list = new List<Books>();
            while (dr.Read())
            {
                Books book = new Books();
                book.Id= Convert.ToInt32(dr["Id"]);
                book.Title = dr["Title"].ToString();
                book.PublishDate = Convert.ToDateTime(dr["PublishDate"]);
                book.ImageName = dr["ImageName"].ToString();
                book.UnitPrice =Convert.ToDecimal( dr["UnitPrice"]);
                list.Add(book);


            }
            return list;
        }


        /// <summary>
        /// 显示书籍的详细内容
        /// </summary>
        /// <returns></returns>
        public List<Books> ParticularBookShow()
        {
            string sql = "SELECT*FROM dbo.Books";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);
            List<Books> list = new List<Books>();
            while (dr.Read())
            {
                Books book = new Books();
              
                book.Id = Convert.ToInt32(dr["Id"]);
                book.Title = dr["Title"].ToString();
                book.Author = dr["Author"].ToString();
                book.PublishId = Convert.ToInt32(dr["PublishId"]);
                book.PublishDate = Convert.ToDateTime(dr["PublishDate"]);
                book.ISBN = dr["ISBN"].ToString();
                book.WordsCount = Convert.ToInt32(dr["WordsCount"]);
                book.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                book.ContentDescription = dr["ContentDescription"].ToString();
                book.AuthorDescription = dr["AuthorDescription"].ToString();
                book.EditorComment = dr["EditorComment"].ToString();
                book.TOC = dr["TOC"].ToString();
                book.CategoryId = Convert.ToInt32(dr["CategoryId"]);
                book.Clicks = Convert.ToInt32(dr["Clicks"]);
                book.ImageType = dr["ImageType"].ToString();
                book.ImageName = dr["ImageName"].ToString();

                list.Add(book);


            }
            return list;
        }

        /// <summary>
        /// 特价书籍
        /// </summary>
        /// <returns></returns>
        public List<Books> SpecialBookShow()
        {
            string sql = "select top 9 * from Books  order by UnitPrice asc";

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, null);
            List<Books> list = new List<Books>();
            while (dr.Read())
            {
                Books book = new Books();
                book.Id = Convert.ToInt32(dr["Id"]);
                book.Title = dr["Title"].ToString();
                book.PublishDate = Convert.ToDateTime(dr["PublishDate"]);
                book.ImageName = dr["ImageName"].ToString();
                book.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                list.Add(book);


            }
            return list;
        }
    }
}
