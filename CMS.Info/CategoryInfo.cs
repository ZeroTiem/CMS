using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Info
{
    public class CategoryInfo
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Kind { get; set; }
        public string CreateAccount { get; set; }
        public System.DateTime CreateDateTime { get; set; }
        public string ModfiyAccount { get; set; }
        public System.DateTime ModfiyDateTime { get; set; }
        public int PublishStatus { get; set; }
        public int DeleteFalg { get; set; }
    }
}
