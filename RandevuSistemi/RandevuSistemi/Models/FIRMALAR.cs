//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RandevuSistemi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FIRMALAR
    {
        public FIRMALAR()
        {
            this.FIRMACALISANLARIs = new HashSet<FIRMACALISANLARI>();
            this.HIZMETLERs = new HashSet<HIZMETLER>();
            this.RANDEVULERs = new HashSet<RANDEVULER>();
        }
    
        public int ID { get; set; }
        public System.Guid GUID { get; set; }
        public string ADI { get; set; }
        public string INSTAGRAM { get; set; }
        public string MESLEK_GRUBU { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string TELEFON { get; set; }
        public string EPOSTA { get; set; }
        public string SIFRE { get; set; }
        public bool STATUS { get; set; }
    
        public virtual ICollection<FIRMACALISANLARI> FIRMACALISANLARIs { get; set; }
        public virtual ICollection<HIZMETLER> HIZMETLERs { get; set; }
        public virtual ICollection<RANDEVULER> RANDEVULERs { get; set; }
    }
}
