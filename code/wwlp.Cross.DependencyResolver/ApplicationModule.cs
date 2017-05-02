using Microsoft.Extensions.DependencyInjection;
using wwlp.Application;
using wwlp.Application.Interfaces;

namespace wwlp.Cross.DependencyResolver
{
    public class ApplicationModule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IAppObjectsBase<>), typeof(AppObjectsBase<>));
            services.AddScoped<IUserAppObject, UserAppObject>();
        }
    }
}
