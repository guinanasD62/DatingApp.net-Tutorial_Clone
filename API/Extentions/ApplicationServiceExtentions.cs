using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extentions
{
    public static class ApplicationServiceExtentions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
//we add dbcontext from lesson13 to 14, update edited in vid. 47
        services.AddDbContext<DataContext>(options =>
            {
                 options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}