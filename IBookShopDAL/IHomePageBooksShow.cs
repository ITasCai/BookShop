using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookModels;

namespace IBookShopDAL
{
    /// <summary>
    /// 显示网站首页书籍内容
    /// </summary>
  public  interface IHomePageBooksShow
    {
        /// <summary>
        /// 显示最新书籍信息
        /// </summary>
        /// <returns></returns>
         List<Books> NewestBookShow();

       /// <summary>
       /// 显示特价书籍信息
       /// </summary>
       /// <returns></returns>
        List<Books> SpecialBookShow();

        /// <summary>
        /// 显示书籍的详细内容
        /// </summary>
        /// <returns></returns>
        List<Books> ParticularBookShow();
    }

   
}
