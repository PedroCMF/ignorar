using MAONAMASSA.ContentContext.Enums;

namespace MAONAMASSA.ContentContext
{


    public class Career : Content //a carreira herda o tipo de conteudo de Content
    {

        public Career(string title, string url)
        : base(title, url)
        {

            items = new List<CarreiraItem>(); //Inicia a lista no contrutor
        }

       public IList<CarreiraItem> items { get; set; }
       public int TotalCursos => items.Count;   // usa se o Expression body para conta da quantidade de itens que tem
       
    }


}