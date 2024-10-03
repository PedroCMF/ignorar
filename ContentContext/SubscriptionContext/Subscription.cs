
using System;
using System.Threading.Tasks;
using MAONAMASSA.ContentContext;

namespace MAONAMASSA.SubscriptionContext
{
    public class Subscription : Base
    {
       public Plano plano{ get; set; } //uma assinatura atrelada a um plano.
                                        //as assinatura vai pertencer a um usuario

       public DateTime? EndDate { get; set; }       //o EndDate tem que ser mais antigo que a data atual  

       public bool IsInative => EndDate  <= DateTime.Now;  //O IsInative Fica inativo se o Endate for menor que o DateTime.Now (Data atual) 
      
    }
}
