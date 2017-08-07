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
        public List<Books> ParticularBookShow(int ID)
        {
            string sql = @"SELECT bo.ImageName,bo.Title,bo.Author,pu.Name,bo.ISBN,bo.Clicks,
                            bo.PublishDate,bo.WordsCount,bo.UnitPrice,bo.ContentDescription
                            FROM dbo.Books bo INNER JOIN dbo.Publishers pu
                            ON pu.Id = bo.PublisherId WHERE bo.Id=@Id";
            SqlParameter[] pa = new SqlParameter[] {
                new SqlParameter("@Id",ID)
            };

            SqlDataReader dr = SqlHelper.ExecuteReader(CommandType.Text, sql, pa);
            List<Books> list = new List<Books>();
            while (dr.Read())
            {
                Books book = new Books();
              
              
                book.Title = dr["Title"].ToString();
                book.Author = dr["Author"].ToString();
                book.PublishDate = Convert.ToDateTime(dr["PublishDate"]);
                book.ISBN = dr["ISBN"].ToString();
                book.WordsCount = Convert.ToInt32(dr["WordsCount"]);
                book.UnitPrice = Convert.ToDecimal(dr["UnitPrice"]);
                book.Clicks = Convert.ToInt32(dr["Clicks"]);
                book.ImageName = dr["ImageName"].ToString();
                book.Name = dr["Name"].ToString();
                book.ContentDescription = dr["ContentDescription"].ToString();
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
