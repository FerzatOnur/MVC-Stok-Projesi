//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCSTOKPROJESİ.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class MUSTERI_TABLOSU
    {
        public MUSTERI_TABLOSU()
        {
            this.SATIS_TABLOSU = new HashSet<SATIS_TABLOSU>();
        }
    
        public int MUSTERIID { get; set; }
        public string MUSTERIAD { get; set; }
        public string MUSTERISOYAD { get; set; }
    
        public virtual ICollection<SATIS_TABLOSU> SATIS_TABLOSU { get; set; }
    }
}
