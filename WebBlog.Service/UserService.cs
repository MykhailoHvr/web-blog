﻿using System.Threading.Tasks;
using WebBlog.Data;
using WebBlog.Data.Models;
using WebBlog.Service.Interfaces;

namespace WebBlog.Service
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public UserService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<ApplicationUser> Update(ApplicationUser applicationUser)
        {
            applicationDbContext.Update(applicationUser);
            await applicationDbContext.SaveChangesAsync();
            return applicationUser;
        }
    }
}
