using IUJP.Modules.Post.Services;

namespace UIJP.Modules.Post.Module
{
    public static class PostModule
    {
        public static IServiceCollection AddPostModule(this IServiceCollection services)
        {

            services.AddDbModule();

            // Register controllers
            services.AddControllers();
            // Register services
            services.AddScoped<IPostService, PostService>();

            Console.WriteLine("Mapping Post Module");

            return services;
        }
    }
}
