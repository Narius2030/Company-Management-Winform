//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_QLCongTy
{
    using System;
    using System.Collections.Generic;
    
    public partial class DUAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DUAN()
        {
            this.PHANCONGDUANs = new HashSet<PHANCONGDUAN>();
        }
    
        public string MaDA { get; set; }
        public string TenDA { get; set; }
        public string MaPB { get; set; }
        public Nullable<decimal> VonDH { get; set; }
        public string TruongDA { get; set; }
        public Nullable<System.DateTime> NgayBD { get; set; }
        public Nullable<System.DateTime> NgayKT { get; set; }
        public string TrangThai { get; set; }
        public Nullable<int> Tiendo { get; set; }

        public DUAN(string maDA, string tenDA, string maPB, string truongDA, DateTime? ngayBD, DateTime? ngayKT, string trangThai)
        {
            MaDA = maDA;
            TenDA = tenDA;
            MaPB = maPB;
            TruongDA = truongDA;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
            TrangThai = trangThai;
        }
        public virtual PHONGBAN PHONGBAN { get; set; }
        public virtual NHANSU NHANSU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONGDUAN> PHANCONGDUANs { get; set; }
    }
}