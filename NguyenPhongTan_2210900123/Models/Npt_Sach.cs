//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NguyenPhongTan_2210900123.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Npt_Sach
    {
        public string Npt_Masach { get; set; }
        public string Npt_Tensach { get; set; }
        public string Npt_Sotrang { get; set; }
        public Nullable<System.DateTime> Npt_NamXB { get; set; }
        public string Npt_MaTG { get; set; }
        public Nullable<bool> Npt_Trangthai { get; set; }
    
        public virtual Npt_TacGia Npt_TacGia { get; set; }
    }
}