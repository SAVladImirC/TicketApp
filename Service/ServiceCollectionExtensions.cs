using Microsoft.Extensions.DependencyInjection;
using Service.Implementation;
using Service.Interface;

namespace Service
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<ICartService, CartService>();
            return services;
        }
    }
}
