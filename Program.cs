
using System.Diagnostics.Contracts;
using System.Data;
using Microsoft.Win32.SafeHandles;
using System.Reflection;
using System;
using System.IO.Pipes;
using MAONAMASSA.ContentContext;
using MAONAMASSA.ContentContext.Enums;
using MAONAMASSA.NotificatiomContext;
using MAONAMASSA.SubscriptionContext;
using MAONAMASSA.ContentContext.SubscriptionContext;


namespace MAONAMASSA
{
    
    public class Program : Notifiable
    {
        static void Main(string[] args)
        {
            
            var artigo = new List<Article>(); //cria a lista de artigo
            artigo.Add(new Article("Artigo sobre OOP", "oRIENTAÇÃO A OBJETO")); //adiciona as informaçãoe nas classes atraves dos contrutores
            artigo.Add(new Article("Artigo sobre C#", "C#HARP")); //adiciona as informaçãoe nas classes atraves dos contrutores
            artigo.Add(new Article("Artigo sobre .NET", "DOT NET")); //adiciona as informaçãoe nas classes atraves dos contrutores

            foreach (var article1 in artigo)
            {

                    Console.WriteLine(article1.Id);
                    Console.WriteLine(article1.Title);
                    Console.WriteLine(article1.Url);
            }
            
             var courses = new List<Course>(); //inicia a lista de cursos
             
             var corsooop = new Course("fundamentos oop", "Fundamentos - oop");
             var corsocsharp = new Course("fundamentos csharp", "Fundamentos - csharp");
             var corsoaspnet = new Course("fundamentos dotnet", "Fundamentos - dotnet");


            courses.Add(corsooop); //adiciona os cursos na lista de curso
            courses.Add(corsocsharp);
            courses.Add(corsoaspnet);

           //corsoaspnet.AddNotifications()
           

            var carrers = new List<Career>(); //lista de carreiras
           
            var carrerDotnet = new Career("ESPECIALISTA .NET", "especialista - dotnet");
            var carreritem2 = new CarreiraItem(2, "Aprenda dotnet", "", null);
            var carreritem = new CarreiraItem(1, "Comece por aqui", "", corsocsharp);
            var carreritem3 = new CarreiraItem(3, "Aprenda Asp.Net", "", corsoaspnet);
            
            carrerDotnet.items.Add(carreritem);
            carrerDotnet.items.Add(carreritem2);
            carrerDotnet.items.Add(carreritem3);

            carrers.Add(carrerDotnet);

            foreach (var carre in carrers)
            {
                
                Console.WriteLine(carre.Title);

                foreach (var item in carre.items.OrderBy(x => x.Ordem)) //Usando o orderBy ordena os items na forma crecente
                                                                        //Usando o OrderByDescending ordena os itens na forma decrecente            
                {

                      Console.WriteLine($"{item.Ordem} - {item.Titulo}");  
                      Console.WriteLine(item.Corso.Title);
                      Console.WriteLine(item.Corso.Nivel);

                      foreach (var notification in item.Notifications)
                    
                      {
                         Console.WriteLine("Teste");
                     // Console.WriteLine($"{notification.Propriedade} - {notification.Mensagem}");
                       
                    
                      }

                }

                var payPalsubscription = new PayPalSubscription(); //Instaceia o objeto
                var studant = new Studant();
                studant.CreateSubscripton(payPalsubscription); //Direciona para validar o estudante

            }


        }
    }

}