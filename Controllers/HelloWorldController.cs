using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace semana_2.Controllers
{
    public class HelloWorldController : Controller
    {
        //
       // GET: /HelloWorld/ Reemplazar el método index:

       public string Index()
        {
            return "This is my default action...";
        }

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}


        // 
        // public string Welcome(string Nico, int numTimes = 10)
        //{
        //   return HtmlEncoder.Default.Encode($"Hello; {Nico}, NumTimes is: {numTimes}");
        //}

        public string Welcome(string Nico, int ID = 5)
        {
            return HtmlEncoder.Default.Encode($"Hello {Nico}, ID: {ID}");
        }
    }
}
