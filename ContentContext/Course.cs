using System.Collections;
namespace MAONAMASSA.ContentContext.Enums
{

    public class Course : Content //o curso herda o tipo de conteudo de Content
    {

        public Course(string title, string url) //contrutor
            : base(title, url) //é pasado para o construtor do content tambem 

        {

            Modulos = new List<Modulo>(); //inicia a lista de modulos
            
        }
        
        public string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; } //listas dos modulos

        public EContentNivel Nivel{ get; set; } //propriedade do tipo numerador(enum) para pega o nivel do curso

        
    }

}