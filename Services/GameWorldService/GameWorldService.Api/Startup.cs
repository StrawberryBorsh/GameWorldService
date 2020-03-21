using GameWorldService.Domain.Logic;
using GameWorldService.Logic;
using GameWorldService.Logic.Clients;
using GameWorldService.Logic.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace GameWorldService.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "GameWorld API", Version = "v0" });
            });

            services.AddTransient<IInitializerServiceClient, InitializerServiceClient>();
            services.AddSingleton<GameWorldServiceContext>();
            services.AddSingleton<IDatabaseService, DatabaseService>();
            services.AddSingleton<IGameWorldService, Domain.Logic.Impl.GameWorldService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "GameWorld API V0");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}");
            });
        }
    }
}
