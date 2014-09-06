using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Nancy.Authentication.Token;
using Backend.Repositories;

namespace Backend.Bootstrappers
{
    public sealed class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer c)
        {
            c.Register<ITokenizer>(new Tokenizer());
            c.Register<IUserValidator, UserValidator>();
            c.Register<IUserRepository, UserRepository>();
        }

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            TokenAuthentication.Enable(
                pipelines, 
                new TokenAuthenticationConfiguration(container.Resolve<ITokenizer>())
            );
        }
    }
}