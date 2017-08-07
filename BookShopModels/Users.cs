using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookModels
{

    /// <summary>
    /// 用户实体类
    /// </summary>
  public class Users
    {
        public int Id { get; set; }
        public string LoginId { get; set; }
        public string LoginPwd { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int UserRoleId { get; set; }
        public int UserStatesId { get; set; }
    }
}
