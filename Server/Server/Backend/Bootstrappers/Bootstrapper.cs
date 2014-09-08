using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Nancy.Authentication.Token;
using Backend.Repositories;
using Backend.Repositories.GPSRepository;
using Backend.Gateways;
using Domain.GPS;

namespace Backend.Bootstrappers
{
    public sealed class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureApplicationContainer(TinyIoCContainer c)
        {
            c.Register<ITokenizer>(new Tokenizer());
            c.Register<IUserValidator, UserValidator>();
            c.Register<IUserRepository, UserRepository>();
            c.Register<IGPSRepository, GPSRepository>();
            c.Register<IGPSGateway, GPSGateway>();
            c.Register<IGPSDataFactory, GPSDataFactory>();
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