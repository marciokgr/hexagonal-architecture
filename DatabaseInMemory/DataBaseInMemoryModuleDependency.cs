using Microsoft.Extensions.DependencyInjection;
using DatabaseInMemory.Repositories;
using Domain.Adapters.Interfaces;

namespace Infrastructure.DatabaseInMemory
{
    public static class DataBaseInMemoryModuleDependency
    {
        public static void AddDataBaseInMemoryModule(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioRepository>();
        }
    }
}
