using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin.Hosting;
using Owin;

namespace ComboSurf
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
                WebApp.Start("http://localhost:3000/",app=>app.UseWebApi(new HttpConfiguration()));
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }
    }
}
