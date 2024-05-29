using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NptLesson06.Models
{
    public class NptSong
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Npt: Hay nhap tieu de")]
        [DisplayName("Tieu de")]
        public string NptTitle { get; set; }
        [Required(ErrorMessage ="Npt: Hay nhap tac gia")]
        [DisplayName("Tac gia")]
        public string NptAuthor { get; set; }
        [Required(ErrorMessage = "Npt: Hay nhap nghe si")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Npt: Thieu ten nghe si co toi thieu 2 ki tu,toi da nam ki tu")]
        [DisplayName("Nghe si")]
        public string NptArtist { get; set; }
        [Required(ErrorMessage = "Npt: Hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9{4}]",ErrorMessage ="Npt: Nhap xuat ban phai co 4 ky tu so")]
        [Range(1900,2024,ErrorMessage ="Npt: Nam xuat ban trong khoang nam 1900 - 2024")]
        [DisplayName("Nam san xuat")]
        public int NptYearRelease { get; set; }
    }
}