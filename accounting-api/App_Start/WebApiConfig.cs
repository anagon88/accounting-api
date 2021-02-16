using System.Web.Http;
using Accounting.Unity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Accounting
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var resolver = new UnityResolver(UnityConfig.GetConfiguredContainer());
            config.DependencyResolver = resolver;
            
            //I change the json serialization in order to match the required in the challenge (json snake_case)
            JsonSerializerSettings serializer = config.Formatters.JsonFormatter.SerializerSettings;
            serializer.ContractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
