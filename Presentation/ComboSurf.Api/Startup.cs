using System;
using System.Linq;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using ComboSurf.ApplicationServices;
using ComboSurf.Domain.Services;
using Microsoft.Owin;
using Newtonsoft.Json.Serialization;
using Owin;

namespace ComboSurf.Api
{
	//[assembly: OwinStartup(typeof(ComboSurf.Api.Startup))]
    public class Startup
    {	
        public void Configuration(IAppBuilder app)
        {
           Config.Invoke(app);
        }

	    public static Action<IAppBuilder> Config = app =>
	    {
		    var configuration = new HttpConfiguration();
		    var builder = new ContainerBuilder();
		    builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).InstancePerRequest();
		    builder.RegisterType<SpotService>().As<ISpotService>().InstancePerRequest();
		    var container = builder.Build();
			configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
			configuration.MapHttpAttributeRoutes();
		    var JsonFormatter = configuration.Formatters.OfType<JsonMediaTypeFormatter>().First();
		    JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
		    configuration.Formatters.Remove(configuration.Formatters.OfType<XmlMediaTypeFormatter>().First());
		    app.UseWebApi(configuration);
	    };
    }
}
