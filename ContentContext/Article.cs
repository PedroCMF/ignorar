
using System;
using MAONAMASSA.NotificatiomContext;

namespace MAONAMASSA.ContentContext
{
    public class Article : Content //o artigo herda o tipo de conteudo de Content
    {
        public IList<Notification> Notifications { get; set; } //lista de notificação

        public Article(string title, string url) //Contrutor

        : base(title, url) //Atravez do base é pasado O title e o url para o construtor do content tambem
        {

        
        }

    }
}