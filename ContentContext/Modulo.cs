using System.Collections.Generic;
using MAONAMASSA.ContentContext.Enums;

namespace MAONAMASSA.ContentContext
{
     //O curso tem varios modules e um modulos tem varias classes
    public class Modulo : Base  ////aulas que sera usada no curso 
    {

        public Modulo()
        {
           
           aulas = new List<Aula>(); //no costrutor inicia as aulas

        }

        public int Ordem { get; set; } //sao as ordem do curso
        public int Titulo { get; set; } //titulo das aulas
        public IList<Aula> aulas { get; set;} // lista das aulas deste modulo
    }

}

