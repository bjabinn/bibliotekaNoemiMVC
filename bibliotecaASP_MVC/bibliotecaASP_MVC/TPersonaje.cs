//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bibliotecaASP_MVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class TPersonaje
    {
        public TPersonaje()
        {
            this.TPersonaje_Titulo = new HashSet<TPersonaje_Titulo>();
        }
    
        public long PersonajeID { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<TPersonaje_Titulo> TPersonaje_Titulo { get; set; }
    }
}