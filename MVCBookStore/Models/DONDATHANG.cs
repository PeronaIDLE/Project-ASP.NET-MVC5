//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCBookStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DONDATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONDATHANG()
        {
            this.CTDATHANGs = new HashSet<CTDATHANG>();
        }
    
        public int MaDonHang { get; set; }
        public Nullable<bool> Dathanhtoan { get; set; }
        public Nullable<bool> Tinhtranggiohang { get; set; }
        public Nullable<System.DateTime> Ngaydat { get; set; }
        public Nullable<System.DateTime> Ngaygiao { get; set; }
        public Nullable<int> MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiachiKH { get; set; }
        public string SoDienthoaiKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDATHANG> CTDATHANGs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
