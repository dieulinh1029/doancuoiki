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
    
    public partial class DanhMucMon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucMon()
        {
            this.CTDonDatHangs = new HashSet<CTDonDatHang>();
            this.KhaiVivaSalads = new HashSet<KhaiVivaSalad>();
            this.MonAnKems = new HashSet<MonAnKem>();
            this.MonChinhvaMiYs = new HashSet<MonChinhvaMiY>();
            this.Pizzas = new HashSet<Pizza>();
            this.ThucUongs = new HashSet<ThucUong>();
            this.TrangMiengs = new HashSet<TrangMieng>();
        }
    
        public string IdDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDonDatHang> CTDonDatHangs { get; set; }
        public virtual Giohang Giohang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhaiVivaSalad> KhaiVivaSalads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonAnKem> MonAnKems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonChinhvaMiY> MonChinhvaMiYs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pizza> Pizzas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucUong> ThucUongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrangMieng> TrangMiengs { get; set; }
    }
}
