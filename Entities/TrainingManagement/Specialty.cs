using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Entities.TrainingManagement
{

   [GwinEntity(Localizable =true,DisplayMember ="Code")]
  [Menu(Group ="Trainee")]
    public class Specialty : BaseEntity 
   {

        public Specialty()
        {
            this.Title = new LocalizedString();
        }

        [DisplayProperty(isInGlossary = true)]
        [EntryForm(Ordre = 1)]
        [Filter]
        [DataGrid(WidthColonne = 150)]
        public LocalizedString Title { set; get; }

        [DisplayProperty(isInGlossary = true)]
        [EntryForm(Ordre = 2,WidthControl =50)]
        [Filter]
        [DataGrid]
        public  String Code { set; get; }

        [DisplayProperty(isInGlossary = true)]
        [EntryForm(Ordre = 3,WidthControl =200,MultiLine =true)]
        public String Description { set; get; }

         
        public List<TraineeManagement.Group> Groups { set; get; }
        // public  List<Module> Modules { set; get; }
    }
}