//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OgrenciBilgiSistemi
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_BOLUMLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_BOLUMLER()
        {
            this.TBL_NOTLAR = new HashSet<TBL_NOTLAR>();
            this.TBL_OGRENCIBOLUMLISTESI = new HashSet<TBL_OGRENCIBOLUMLISTESI>();
            this.TBL_OGRENCIDERSLISTESI = new HashSet<TBL_OGRENCIDERSLISTESI>();
            this.TBL_OGRETMENLER = new HashSet<TBL_OGRETMENLER>();
            this.TBL_DERSLER = new HashSet<TBL_DERSLER>();
        }
    
        public int ID { get; set; }
        public string BOLUM { get; set; }
        public string BOLUMKODU { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_NOTLAR> TBL_NOTLAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_OGRENCIBOLUMLISTESI> TBL_OGRENCIBOLUMLISTESI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_OGRENCIDERSLISTESI> TBL_OGRENCIDERSLISTESI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_OGRETMENLER> TBL_OGRETMENLER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_DERSLER> TBL_DERSLER { get; set; }
    }
}
