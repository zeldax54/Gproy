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
    
    public partial class Organism
    {
        public Organism()
        {
            this.Client = new HashSet<Client>();
            this.Entity = new HashSet<Entity>();
        }
    
        public int organismId { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Entity> Entity { get; set; }
    }
}
