//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace airlines_clone
{
    using System;
    using System.Collections.Generic;
    
    public partial class pajak_bandara
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pajak_bandara()
        {
            this.detil_pesan_tiket = new HashSet<detil_pesan_tiket>();
            this.detil_pesan_tiket1 = new HashSet<detil_pesan_tiket>();
        }
    
        public int id_bandara { get; set; }
        public string nm_bandara { get; set; }
        public decimal pajak { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detil_pesan_tiket> detil_pesan_tiket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detil_pesan_tiket> detil_pesan_tiket1 { get; set; }
    }
}
