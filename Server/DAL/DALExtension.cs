using DAL.Repository;
using DAL.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAL
{
    public static class DALExtension
    {
        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            // Ses propres services
            services.AddScoped<DbSession>((services) => new DbSession(services.GetRequiredService<IConfiguration>(), "DefaultConnection"));

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Repositories
            
          
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();
           
            services.AddTransient<IReservationRepository, ReservationRepository>();
            services.AddTransient<ITypeRepasRepository, TypeRepasRepository>();
          
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();

            services.AddTransient<IMetsRepository, MetRepository>();
            services.AddTransient<IMetsIngredientsRepository, MetsIngredientsRepository>();
            services.AddTransient<ICommandeRepository, CommandeRepository>();

            return services;
        }
    }
}
