// AppDbContext.cs in Infrastructures.Database
using IUJP.Modules.Post.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<PostModel> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDbModule(this IServiceCollection services)
    {

        IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                   .AddJsonFile("appsettings.json")
                   .Build();

        string connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";

        Console.WriteLine(connectionString);
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString)
        );


        // Other database-related services or configurations

        return services;
    }
}
