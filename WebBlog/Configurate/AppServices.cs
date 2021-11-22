using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using System.IO;
using WebBlog.Authorization;
using WebBlog.BusinessManager;
using WebBlog.BusinessManager.Interfaces;
using WebBlog.Data;
using WebBlog.Data.Models;
using WebBlog.Service;
using WebBlog.Service.Interfaces;

namespace WebBlog.Configurate
{
    public static class AppServices
    {
        public static void AddDefaultServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));
            serviceCollection.AddDatabaseDeveloperPageExceptionFilter();

            serviceCollection.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            serviceCollection.AddControllersWithViews().AddRazorRuntimeCompilation();

            serviceCollection.AddSingleton<IFileProvider>(new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));
        }

        public static void AddCustomServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IBlogBusinessManager, BlogBusinessManager>();
            serviceCollection.AddScoped<IAdminBusinessManager, AdminBusinessManager>();

            serviceCollection.AddScoped<IBlogService, BlogService>();
        }

        public static void AddCustomAuthorization(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IAuthorizationHandler, BlogAuthoriazationHandler>();
        }
    }
}
