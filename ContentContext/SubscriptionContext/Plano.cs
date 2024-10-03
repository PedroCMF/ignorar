
using System;
using System.Threading.Tasks;
using MAONAMASSA.ContentContext;

namespace MAONAMASSA.SubscriptionContext

{
    public class Plano : Base
    {
        //cada assinatura pertence a um aluno. Cada aluno pode ter uma ou mais assinatura
        public string Titulo { get; set; } //titulo do plano
        public decimal Preco { get; set; } //preço do plano
        
        public int Dias { get; set; }
      
    }
}