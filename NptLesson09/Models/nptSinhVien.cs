//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NptLesson09.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class nptSinhVien
    {
        public string NptId { get; set; }
        public string NptHoSV { get; set; }
        public string NptTenSV { get; set; }
        public Nullable<System.DateTime> NptNgaysinh { get; set; }
        public Nullable<bool> NptPhai { get; set; }
        public string NptPhone { get; set; }
        public string NptEmail { get; set; }
        public string NptMaKH { get; set; }
    
        public virtual nptKhoa nptKhoa { get; set; }
    }
}