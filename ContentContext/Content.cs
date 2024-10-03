namespace MAONAMASSA.ContentContext
{

    public abstract class Content : Base //todas as outras classes irao herdar da classe Content. E content vai herda as notificaçoes de Base
    {
        public Content(string titulo, string url) //devido ter criado o contrutor no Content, deverar criar o contrutor base nas outras classes
        {

             
             Title = titulo;
             Url = url;
            
        }

        
        public string Title { get; set; }
        public string Url { get; set; }
    }

}

