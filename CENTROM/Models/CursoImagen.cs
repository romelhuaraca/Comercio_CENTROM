//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CENTROM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CursoImagen
    {
        public int CursoImagenId { get; set; }
        public int CursoId { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
    
        public virtual Curso Curso { get; set; }
    }
}
