using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Info
{
    public class ArticleInfo
    {
        public int ArticleID { get; set; }
        public int CategoryID { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public string ImgUrl { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> StratDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public string CreateAccount { get; set; }
        public string ModifyAccount { get; set; }
        public int PublishStatus { get; set; }
        public int DeleteFalg { get; set; }
    }
}
