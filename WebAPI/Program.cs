using Microsoft.EntityFrameworkCore;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Repositories;
using Infrastructure.DBContext;
using Application.Validation;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Validation
            builder.Services.AddControllers()
              //.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<GadgetValidator>());
                 .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<GadgetDtoValidator>());

           // builder.Services.AddValidatorsFromAssemblyContaining<GadgetValidator>();
            builder.Services.AddValidatorsFromAssemblyContaining<GadgetDtoValidator>();



            // Register DbContext with a specific connection string
            builder.Services.AddDbContext<Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("BD")));

            // Register generic repository
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // Register services
            builder.Services.AddScoped<IGadgetService, GadgetService>();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddScoped<IGadgetRepository, GadgetRepository>();



            // Register AutoMapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
