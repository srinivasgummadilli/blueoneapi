using BlueAPI.IRepository;
using BlueAPI.IService;
using BlueAPI.Repository;
using BlueAPI.Service;

namespace BlueAPI
{
    public static class StartupExtension
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            // Add all services           
            services.AddHttpContextAccessor();
            services.AddScoped<IMasterRepository, MasterRepository>();
            services.AddScoped<IMasterService, MasterService>();

            return services;
        }
     }
}
