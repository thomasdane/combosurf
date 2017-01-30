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
