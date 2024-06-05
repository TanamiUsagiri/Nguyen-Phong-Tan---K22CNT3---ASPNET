using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NptLesson06CF.Models
{
    public class NptCategory
    {
        [Key]
        public int NptId { get; set; }
        public string NptCategoryName { get; set; }

        //Thuoc tinh quan he
        public virtual ICollection<NptBook> NptBooks { get; set; }
    }
}