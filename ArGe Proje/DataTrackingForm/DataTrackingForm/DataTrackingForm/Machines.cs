//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataTrackingForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Machines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Machines()
        {
            this.Data = new HashSet<Data>();
        }
    
        public int Id { get; set; }
        public string MachineName { get; set; }
        public Nullable<double> Voltage { get; set; }
        public Nullable<double> Frequency { get; set; }
        public Nullable<double> Power { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Data> Data { get; set; }
    }
}
