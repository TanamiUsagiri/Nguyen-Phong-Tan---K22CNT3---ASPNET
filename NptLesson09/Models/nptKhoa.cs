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
    
    public partial class nptKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nptKhoa()
        {
            this.nptSinhViens = new HashSet<nptSinhVien>();
        }
    
        public string NptmaKH { get; set; }
        public string NptTenKH { get; set; }
        public Nullable<bool> NptTrangthai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nptSinhVien> nptSinhViens { get; set; }
    }
}
