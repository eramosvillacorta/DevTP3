//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Innova.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CurriculaBase
    {
        public CurriculaBase()
        {
            this.Curricula = new HashSet<Curricula>();
            this.CurriculaBaseCompetencia = new HashSet<CurriculaBaseCompetencia>();
        }
    
        public int IdCurriculaBase { get; set; }
        public int Año { get; set; }
        public string NumeroResolucion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Vigencia { get; set; }
    
        public virtual ICollection<Curricula> Curricula { get; set; }
        public virtual ICollection<CurriculaBaseCompetencia> CurriculaBaseCompetencia { get; set; }
    }
}
