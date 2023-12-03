using IUJP.Modules.Post.Services;

namespace UIJP.Modules.Post
{
    public static class PostModule
    {
        public static IServiceCollection AddPostModule(this IServiceCollection services)
        {
            // Register controllers
            services.AddControllers();
            // Register services
            services.AddScoped<IPostService, PostService>();

            Console.WriteLine("Mapping Post Module");

            return services;
        }
    }
}
