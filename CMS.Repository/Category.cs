//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Category
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
