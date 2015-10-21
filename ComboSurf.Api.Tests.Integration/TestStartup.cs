using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Owin;

namespace ComboSurf.Api.Tests.Integration
{
	public class TestStartup
	{
		public void Configuration(IAppBuilder app)
		{
			Startup.Config.Invoke(app);
		}
	}
}
