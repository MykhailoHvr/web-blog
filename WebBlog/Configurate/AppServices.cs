using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        }

        public static void AddCustomServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IBlogBusinessManager, BlogBusinessManager>();

            serviceCollection.AddScoped<IBlogService, BlogService>();
        }
    }
}
