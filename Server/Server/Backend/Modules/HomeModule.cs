using Nancy;
using Nancy.Security;

namespace Backend.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            this.RequiresAuthentication();

            Get["/"] = _ =>
            {
                return Response.AsJson(new { ServerState = "Running"});
            };
        }
    }
}