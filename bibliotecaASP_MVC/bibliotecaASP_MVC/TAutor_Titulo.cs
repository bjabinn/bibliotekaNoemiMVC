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
    
    public partial class TAutor_Titulo
    {
        public long ID { get; set; }
        public long TituloID { get; set; }
        public long AutorID { get; set; }
    
        public virtual TAutor TAutor { get; set; }
        public virtual TTitulo TTitulo { get; set; }
    }
}