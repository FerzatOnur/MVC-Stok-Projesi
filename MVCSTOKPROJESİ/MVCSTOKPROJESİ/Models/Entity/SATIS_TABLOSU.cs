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
    
    public partial class SATIS_TABLOSU
    {
        public int SATISID { get; set; }
        public Nullable<int> URUN { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<byte> ADET { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
    
        public virtual MUSTERI_TABLOSU MUSTERI_TABLOSU { get; set; }
        public virtual URUN_TABLOSU URUN_TABLOSU { get; set; }
    }
}
