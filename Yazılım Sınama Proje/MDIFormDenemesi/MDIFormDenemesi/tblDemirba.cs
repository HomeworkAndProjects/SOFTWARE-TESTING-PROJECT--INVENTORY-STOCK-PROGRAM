//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDIFormDenemesi
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDemirba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDemirba()
        {
            this.tblOdaDemirbas = new HashSet<tblOdaDemirba>();
        }
    
        public int demirbasID { get; set; }
        public string demirbasAdi { get; set; }
        public Nullable<decimal> fiyat { get; set; }
        public System.DateTime alimTarihi { get; set; }
        public int demirbasTuruID { get; set; }
        public int fakulteID { get; set; }
        public int departmanID { get; set; }
        public Nullable<int> adet { get; set; }
    
        public virtual tblDemirbasTuru tblDemirbasTuru { get; set; }
        public virtual tblDepartman tblDepartman { get; set; }
        public virtual tblFakulte tblFakulte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOdaDemirba> tblOdaDemirbas { get; set; }
    }
}
