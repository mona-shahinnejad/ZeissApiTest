﻿using ZeissApiTest.WebApi.Controllers;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using ZeissApiTest.WebApi.Listener;

namespace ZeissApiTest.WebApi
{
    public class ServiceInstaller
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new Business.AutoMapperInstaller());
            builder.RegisterModule(new Business.ServiceInstaller());
            builder.RegisterType<MachineWebSocketListener>().InstancePerRequest();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); //Set the MVC DependencyResolver
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver
        }
    }
}