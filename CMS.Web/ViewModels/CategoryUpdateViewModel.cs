using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Web.ViewModels
{
    public class CategoryUpdateViewModel
    {
        [Display(Name = "編號")]
        public string CategoryID { get; set; }
        [Required]
        [Display(Name = "名稱")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "類別")]
        public string Kind { get; set; }
        [Required]
        [Display(Name = "狀態")]
        public int PublishStatus { get; set; }
    }
}