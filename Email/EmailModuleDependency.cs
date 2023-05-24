using Domain.Adapters.Interfaces;
using Email.Operations;
using Microsoft.Extensions.DependencyInjection;

namespace Email
{
    public static class EmailModuleDependency
    {
        public static void AddEmailModule(this IServiceCollection services)
        {
            services.AddTransient<IEmailAdapter, EmailManager>();
        }
    }
}
