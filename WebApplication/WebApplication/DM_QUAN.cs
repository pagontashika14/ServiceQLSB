//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_QUAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_QUAN()
        {
            this.DM_KHU_SAN = new HashSet<DM_KHU_SAN>();
        }
    
        public decimal ID { get; set; }
        public decimal ID_THANH_PHO { get; set; }
        public string TEN_QUAN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_KHU_SAN> DM_KHU_SAN { get; set; }
        public virtual DM_THANH_PHO DM_THANH_PHO { get; set; }
    }
}
