using Acme.ProjectManagement.Core.Interfaces;
using Acme.ProjectManagement.Core.Services;

using Autofac;

namespace Acme.ProjectManagement.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}