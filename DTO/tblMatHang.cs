//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMatHang()
        {
            this.tblGoiMatHangs = new HashSet<tblGoiMatHang>();
        }
    
        public string MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public double DonGiaMatHang { get; set; }
        public string MaLoaiHang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGoiMatHang> tblGoiMatHangs { get; set; }
        public virtual tblLoaiHang tblLoaiHang { get; set; }
    }
}
