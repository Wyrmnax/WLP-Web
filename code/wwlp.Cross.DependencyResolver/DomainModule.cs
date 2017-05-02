using Microsoft.Extensions.DependencyInjection;
using wwlp.Domain.Interfaces.BusinessObject;

namespace wwlp.Cross.DependencyResolver
{
    public class DomainModule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IBusinessObjectBase<>), typeof(BusinessObjectBase<>));
            services.AddScoped<IUserBO, IUserBO>();
        }
    }
}
