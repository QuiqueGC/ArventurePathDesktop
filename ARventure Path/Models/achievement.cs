//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARventure_Path.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class achievement
    {
        public achievement()
        {
            this.arventure = new HashSet<arventure>();
            this.user = new HashSet<user>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
    
        public virtual ICollection<arventure> arventure { get; set; }
        public virtual ICollection<user> user { get; set; }
    }
}
