//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hastanerandevu.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class randevular
    {
        public int RANDEVUID { get; set; }
        public int USERID { get; set; }
        public int DOKTORID { get; set; }
        public string RANDEVUTARIH { get; set; }
        public string RANDEVUSAAT { get; set; }
        public Nullable<int> RANDEVUTUR { get; set; }
        public List<string> list { get; set; }

        public virtual doktorlar doktorlar { get; set; }
        public virtual tur tur { get; set; }
        public virtual user user { get; set; }
    }
}
