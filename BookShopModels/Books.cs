using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookModels
{
    /// <summary>
    /// 书籍表实体类
    /// </summary>
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int PublishId { get; set; }
        public string ISBN { get; set; }
        public int WordsCount { get; set; }
        public decimal UnitPrice { get; set; }
        public string ContentDescription { get; set; }
        public string AuthorDescription { get; set; }
        public string EditorComment { get; set; }
        public string  TOC { get; set; }
        public int CategoryId { get; set; }
        public int Clicks { get; set; }
        public string ImageType { get; set; }
        public string ImageName { get; set; }
    }
}
