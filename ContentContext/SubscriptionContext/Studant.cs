using System.ComponentModel;
using System;
using System;
using System.Threading.Tasks;
using System.Collections;
using MAONAMASSA.SubscriptionContext;
using MAONAMASSA.NotificatiomContext;

namespace MAONAMASSA.ContentContext.SubscriptionContext
{
    public class Studant : Base
    {

      public Studant()
      {

           Subscriptions = new List<Subscription>(); //carrega a lista de assinatura no contrutor do estudanteS
      }

      public string Nome { get; set; }
      public string Email { get; set; }

      public User user { get; set; }

      public IList<Subscription> Subscriptions { get; set; } //carrega a lista de assinatura

       public void CreateSubscripton(Subscription subscription)        //metodo para Valida para o aluno so pode ter uma assinatura ativa
       {

         if (IsPremiun) //se for premiun entra na rotina
         {
              
              AddNotification(new Notification("Premium", "O aluno ja vem com assinatura ativa"));
              return;

         }
         
         //se nao for premiun entra aqui
         Subscriptions.Add(subscription);

       }

      public bool IsPremiun => Subscriptions.Any(x => !x.IsInative); //Valida se o estudante e valido ou nao. (!x = negativa a função)


    }
}