
using MAONAMASSA.NotificatiomContext;

namespace MAONAMASSA.ContentContext.Enums
{

public class CarreiraItem : Base //itens da carreira
    {

        public List<string> Notifications { get; set; }
        public CarreiraItem(int ordem, string titulo, string descrição, Course corso)
        
        {

            if(corso == null)
            
                 AddNotification(new Notification("Corse","Curso Invalido")); //valida se o parametro do curso está nulo


            Ordem = ordem;
            Titulo = titulo;
            Descrição = descrição;
            Corso = corso;
        }

    
        public int Ordem { get; set; }
       public string Titulo { get; set; }
       public string Descrição { get; set; }

       public Course Corso { get; set; } //propriedade corso do tipo Course

    }

}

