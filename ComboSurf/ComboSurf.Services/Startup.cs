using System;
using System.Linq;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Newtonsoft.Json.Serialization;
using Owin;

namespace ComboSurf.Services
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var configuration = new HttpConfiguration();
            configuration.MapHttpAttributeRoutes();
            var JsonFormatter = configuration.Formatters.OfType<JsonMediaTypeFormatter>().First();
            JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            configuration.Formatters.Remove(configuration.Formatters.OfType<XmlMediaTypeFormatter>().First());
            app.UseWebApi(configuration);
        }
    }
}
