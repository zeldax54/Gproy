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
    
    public partial class Stage
    {
        public Stage()
        {
            this.ProjectDetails = new HashSet<ProjectDetails>();
            this.Schedule = new HashSet<Schedule>();
        }
    
        public int stageId { get; set; }
        public string name { get; set; }
        public int serviceId { get; set; }
        public int orden { get; set; }
    
        public virtual ICollection<ProjectDetails> ProjectDetails { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
        public virtual Service Service { get; set; }
    }
}
