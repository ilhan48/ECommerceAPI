namespace ECommerceAPI.Domain.Entities
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ECommerceAPIDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ECommerceAPIDbContext")));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));
        }
    }
}