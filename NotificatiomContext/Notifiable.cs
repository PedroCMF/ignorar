using System.Collections.Generic;
using MAONAMASSA.ContentContext;


namespace MAONAMASSA.NotificatiomContext
{

//Esta classe é criada para nao ser preciso ficar criando lista de notificação nas outras classes
    public abstract class Notifiable  //As outras classe irao herdar desta classe. Vai ser abstrata para não poder ser instanciada

    {
        public List<Notification> Notifications { get; set; }


        public Notifiable()
        {

            Notifications = new List<Notification>(); //inicia a lista no contrutor
        }

        public void AddNotification(Notification notification) //metodo que recebe a notificação
        {

            Notifications.Add(notification);
        }

        
        public void AddNotifications(IEnumerable<Notification> notifications) //metodo que recebe a lista de notificação
        {

            Notifications.AddRange(notifications);
        }
        
        public bool IsInValido => Notifications.Any(); //Propriedade se estiver um erro para saber se o metodo é valido ou nao


    }
}

