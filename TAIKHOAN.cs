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
    
    public partial class TAIKHOAN
    {
        public string taikhoan1 { get; set; }
        public string matkhau { get; set; }
        public string MaCV { get; set; }
    
        public virtual CHUCVU CHUCVU { get; set; }
        public virtual NHANSU NHANSU { get; set; }
    }
}