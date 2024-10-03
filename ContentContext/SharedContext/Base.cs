
using System;
using MAONAMASSA.NotificatiomContext;

namespace MAONAMASSA.ContentContext
{
   
    public abstract class Base : Notifiable //herda toda a parametrização das notificações que estão na classe Notifiable
    {

       public Base()
       {

            Id = Guid.NewGuid();

       }


        public Guid Id { get; set; }
    }

}


