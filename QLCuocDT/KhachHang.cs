//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCuocDT
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.THONGTINSIMs = new HashSet<THONGTINSIM>();
        }
    
        public string IDKHACHHANG { get; set; }
        public string Tenkhachhang { get; set; }
        public string CMND { get; set; }
        public string Nghenghiep { get; set; }
        public string Chucvu { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THONGTINSIM> THONGTINSIMs { get; set; }
    }
}
