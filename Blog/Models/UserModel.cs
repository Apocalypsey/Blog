using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class UserModel
    {
        public string UserId { get; set; }

        public string PassWord { get; set; }

        public string NickName { get; set; }

        public DateTime RgTime { get; set; }

        public string States { get; set; }
    }
}