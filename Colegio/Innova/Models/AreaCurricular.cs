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
    
    public partial class AreaCurricular
    {
        public AreaCurricular()
        {
            this.CurriculaBaseCompetencia = new HashSet<CurriculaBaseCompetencia>();
            this.Curso = new HashSet<Curso>();
        }
    
        public int IdAreaCurricular { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<CurriculaBaseCompetencia> CurriculaBaseCompetencia { get; set; }
        public virtual ICollection<Curso> Curso { get; set; }
    }
}
