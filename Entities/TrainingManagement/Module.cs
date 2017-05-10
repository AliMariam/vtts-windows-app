using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.TrainingManagement
{
    public class Module : BaseEntity
    {
        public Module()
        {
            this.Name = new LocalizedString();
            this.Presentation = new LocalizedString();
            this.Competence = new LocalizedString();
            this.TeachingStrategy = new LocalizedString();
            this.Learning = new LocalizedString();
            this.Evaluation = new LocalizedString();
            this.Description = new LocalizedString();
        }
       

        // 
        // Informations g�n�rale
        //
       
        public LocalizedString Name { set; get; }


        public LocalizedString Competence { set; get; }



        public String Code { set; get; }



      
        public LocalizedString Presentation { set; get; }

        // 
        // Description p�dagogique
        //

        public LocalizedString TeachingStrategy { set; get; }

        public LocalizedString Learning { set; get; }

        public LocalizedString Evaluation { set; get; }

        // 
        // Planning
        //
        /// <summary>
        /// La dur� en Nombre d'heure
        /// </summary>
        public int Duration { set; get; }
        // 
        // Affectation
        //
       
     //   public virtual Filiere Filiere { set; get; }
 
        // 
        // Description Technique
        //  
       
        //public virtual List<Precision> Precisions { set; get; }

        //public virtual List<PrevisionSeance> PrevisionSeances { set; get; }
        //public virtual List<Formation> Formations { set; get; }

        public LocalizedString Description { set; get; }
    }
}