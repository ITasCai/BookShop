using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookModels;
using BookShopDAL;

namespace BookShopBLL
{
    
   
    /// <summary>
    /// 显示首页书籍信息业务逻辑类
    /// </summary>
    public class HomePageBooksManager
    {

        HomePageBooksService hbs = new HomePageBooksService();

        /// <summary>
        /// 显示最新书籍信息
        /// </summary>
        /// <returns></returns>
        public  List<Books> NewestBookShow()
        {
            return hbs.NewestBookShow();
        }

        /// <summary>
        /// 显示特价书籍
        /// </summary>
        /// <returns></returns>
        public List<Books> SpecialBookShow()
        {
            return hbs.SpecialBookShow();
        }


        /// <summary>
        /// 显示书籍的详细内容
        /// </summary>
        /// <returns></returns>
        public List<Books> ParticularBookShow(int ID)
        {
            return hbs.ParticularBookShow(ID);
        }
        }
}
