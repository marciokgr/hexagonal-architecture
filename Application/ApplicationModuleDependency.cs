using Application.Services;
using Domain.Adapters.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationModuleDependency
    {
        public static void AddApplicationModule(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioService, UsuarioServiceManager>();
        }
    }
}
