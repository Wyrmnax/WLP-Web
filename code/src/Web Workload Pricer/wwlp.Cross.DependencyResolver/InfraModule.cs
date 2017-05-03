using Microsoft.Extensions.DependencyInjection;
using wwlp.Domain.Interfaces.Repository;
using wwlp.Infra.Data.Repositories;

namespace wwlp.Cross.DependencyResolver
{
    public class InfraModule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
