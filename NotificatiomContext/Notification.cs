using MAONAMASSA.ContentContext;

namespace MAONAMASSA.NotificatiomContext
{

    public sealed class Notification  //Usa sealed para a classe nao ser estendida, nao ser herdada
    {
       
      public Notification() 
      {


      }

        public Notification(string propriedade, string message) //construtor da classe com as propriedades
        {
            Propriedade = propriedade;
            Message = message;
        }

        public string Propriedade { get; set; }
         public string Message { get; set; }
    }

    
}