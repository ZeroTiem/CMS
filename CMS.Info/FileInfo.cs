using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Info
{
    public partial class FileInfo
    {
        public int FileID { get; set; }
        public int KindID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string FileUrl { get; set; }
        public Nullable<System.DateTime> StratDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public string CreateAccount { get; set; }
        public string ModifyAccount { get; set; }
        public int Status { get; set; }
    }
}
