//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopAccessApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public services()
        {
            this.client_order_sets = new HashSet<client_order_sets>();
        }
    
        public int id { get; set; }
        public string service { get; set; }
        public Nullable<decimal> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<client_order_sets> client_order_sets { get; set; }
    }
}
