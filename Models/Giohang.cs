//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOTPIZZA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Giohang
    {
        public string IdMon { get; set; }
        public string TenMon { get; set; }
        public string HinhMinhHoa { get; set; }
        public Nullable<decimal> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    
        public virtual DanhMucMon DanhMucMon { get; set; }
    }
}
