using ExpenseAPI.Repository.UserRepository;
using ExpensesProject;
using ExpensesProject.Common.Exception;
using ExpensesProject.Common.Repository.ChitsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace ExpenseAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Filters.Add(new ExceptionHandling());
            //config.Filters.Add(new AuthorizeAttribute());
            config.MessageHandlers.Add(new TokenValidationHandler());
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IChitsRepository, ChitsRepository>();
            config.DependencyResolver = new UnityResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
