using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Implementation;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TicketAppDbContext>(o =>
            {
                o.UseSqlServer(configuration.GetConnectionString("Main"));
                o.EnableDetailedErrors();
                o.EnableSensitiveDataLogging();
            });

            services.AddTransient(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));
            services.AddTransient<IMovieRepository, MovieRepository>();
            services.AddTransient<ICartRepository, CartRepository>();
            services.AddTransient<ITicketRepository, TicketRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
