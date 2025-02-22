//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GProyOficial.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public Service()
        {
            this.Stage = new HashSet<Stage>();
            this.Supplement = new HashSet<Supplement>();
        }
    
        public int serviceId { get; set; }
        public string name { get; set; }
        public int globalServiceId { get; set; }
        public int rateId { get; set; }
    
        public virtual GlobalService GlobalService { get; set; }
        public virtual Rate Rate { get; set; }
        public virtual ICollection<Stage> Stage { get; set; }
        public virtual ICollection<Supplement> Supplement { get; set; }
    }
}
