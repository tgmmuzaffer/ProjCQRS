namespace ProjCQRS.Api
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using ProjCQRS.Api.DataAccess;
    using ProjCQRS.Api.Entity;
    using ProjCQRS.Api.Medatr.Command;
    using ProjCQRS.Api.Medatr.Query;
    using ProjCQRS.Api.RepoCqrs;
    using ProjCQRS.Api.RepoCqrs.IRepoCqrs;
    using MediatR;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string applocal = "applocal";
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddCors(opt =>
            //{
            //    opt.AddPolicy(name: applocal, builder =>
            //    {
            //        builder.WithOrigins("https://localhost:44353/")
            //        .AllowAnyHeader()
            //        .WithMethods("GET")
            //        .WithMethods("POST")
            //        .WithMethods("DELETE");
            //    });
            //});

            services.AddDbContext<ProjCQRSDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IProductRepoCqrs, ProductRepoCqrs>();
            services.AddScoped<ICategoryRepoCqrs, CategoryRepoCqrs>();
            services.AddTransient<IRequestHandler<CreateCategoryCommand, Category>, CreateCategoryCommandHandler>();
            services.AddTransient<IRequestHandler<CreateProductCommand, Product>, CreateProductCommandHandler>();
            services.AddTransient<IRequestHandler<UpdateCategoryCommand, Category>, UpdateCategoryCommandHandler>();
            services.AddTransient<IRequestHandler<UpdateProductCommand, Product>, UpdateProductCommandHandler>();
            services.AddTransient<IRequestHandler<DeleteProductCommand, bool>, DeleteProductCommandHandler>();
            services.AddTransient<IRequestHandler<DeleteCategoryCommand, bool>, DeleteCategoryCommandHandler>();
            services.AddTransient<IRequestHandler<GetAllCategoryQuery, ICollection<Category>>, GetAllCategoryQueryHandler>();
            services.AddTransient<IRequestHandler<GetAllProductQuery, ICollection<Product>>, GetAllProductQueryHandler>();
            services.AddTransient<IRequestHandler<GetCategoryQuery, Category>, GetCategoryQueryHandler>();
            services.AddTransient<IRequestHandler<GetProductQuery, Product>, GetProductQueryHandler>();
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "ProjCQRS API",
                    Version = "v1",
                    Description = "Code Challange",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Yusuf Muzaffer Deveci",
                        Email = "ym.dvc@hotmail.com",
                        Url = new Uri("https://www.linkedin.com/in/yusuf-muzaffer-deveci-913954186")
                    }
                });
            });
            services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjCQRS v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            //app.UseCors(applocal);
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
