using Autofac;
using System.Reflection;
using Autofac.Integration.WebApi;
using SocialSlider.Interfaces;
using SocialSlider.Servants;
using SocialSlider.Api.Servants;

namespace SocialSlider.Api.App_Start
{
    public class AutofacConfig
    {
        private const string AutofacConfigSection = "autofac";

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();
            
            Assembly executingAssembly = Assembly.GetExecutingAssembly();            
            builder.RegisterApiControllers(executingAssembly);
            builder.RegisterType<ImageServant>().As<IImageServant>().InstancePerRequest();
            builder.RegisterType<GoogleDriveServant>().As<IGoogleDriveServant>().InstancePerRequest();
            builder.RegisterType<InstagramServant>().As<IInstagramServant>().InstancePerRequest();

            var container = builder.Build();
            
            System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}