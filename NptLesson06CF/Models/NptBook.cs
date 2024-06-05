using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NptLesson06CF.Models
{
    public class NptBook
    {
        [Key]
        public int NptId { get; set; }
        public int NptBookId { get; set; }
        public string NptTitle { get; set; }
        public string NptAuthor { get; set; }
        public int NptYear { get; set; }
        public string NptPublisher { get; set; }
        public string NptPicture { get; set; }
        public string NptCategoryid { get; set; }
        //Thuoc tinh qua he
        public virtual NptCategory NptCategory { get; set; }
    }
}