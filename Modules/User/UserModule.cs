using UIJP.Modules.User.Services;

namespace UIJP.Modules.User
{
    public static class UserModule
    {
        public static IServiceCollection AddUserModule(this IServiceCollection services)
        {
            // Register controllers
            services.AddControllers();
            // Register services
            services.AddScoped<IUserService, UserService>();

            Console.WriteLine("Mapping User Module");

            return services;
        }
    }
}
