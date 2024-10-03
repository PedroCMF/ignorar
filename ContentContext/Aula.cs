using System.Collections;

namespace MAONAMASSA.ContentContext.Enums
{

//aulas que sera usada no curso
public class Aula : Base//herda as notificaçoes de Base 
    {

        public int Ordem { get; set; } //A ordem das aulas
        public string Titulo { get; set; }//O titulodas das aulas

        public int DuraçãoInMinutos { get; set;} //Duração da aula

      public EContentNivel Nivel { get; set; }//para sabe o Nivel do curso
        
        
        
    }

}


