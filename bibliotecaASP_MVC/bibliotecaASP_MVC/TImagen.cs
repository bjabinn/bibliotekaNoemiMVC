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
    
    public partial class TImagen
    {
        public TImagen()
        {
            this.TObjecto_Imagen = new HashSet<TObjecto_Imagen>();
        }
    
        public long ID { get; set; }
        public byte[] Imagen { get; set; }
    
        public virtual ICollection<TObjecto_Imagen> TObjecto_Imagen { get; set; }
    }
}
