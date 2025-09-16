using CheerChampionship.Core.Handler.Championships.Interface;
using CheerChampionship.Core.Handler;
using CheerChampionship.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using CheerChampionship.Infrastructure.Repositories.Championship;
using CheerChampionship.Core.Handler.Championships.Services;
using CheerChampionship.Core.Handler.Teams.Interface;
using CheerChampionship.Core.Handler.Teams.Service;
using CheerChampionship.Core.Handler.Teams;
using CheerChampionship.Infrastructure.Repositories.Team;
using CheerChampionship.Core.Handler.Athletes.Interface;
using CheerChampionship.Core.Handler.Athletes;
using CheerChampionship.Infrastructure.Repositories.Athlete;
using CheerChampionship.Core.Handler.Athletes.Services;

namespace CheerChampionship.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // Aqui configuramos os serviços
        public void ConfigureServices(IServiceCollection services)
        {
            // Controllers
            services.AddControllers();

            // Swagger
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "CheerChampionship API",
                    Version = "v1",
                    Description = "API para gerenciamento de campeonatos de Cheerleading"
                });
            });

            // Banco de dados (PostgreSQL) - ajuste a ConnectionString no appsettings.json
            services.AddDbContext<CheerDbContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"),
                    o => o.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)));

            // registra AutoMapper e procura os profiles no assembly
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Injeção de dependência
            services.AddScoped<IChampionshipHandler, ChampionshipHandler>();
            services.AddScoped<IChampionshipRepository, ChampionshipRepository>();
            services.AddScoped<IChampionshipService, ChampionshipService>();

            services.AddScoped<ITeamHandler, TeamHandler>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<ITeamService, TeamService>();

            services.AddScoped<IAthleteHandler, AthleteHandler>();
            services.AddScoped<IAthleteRepository, AthleteRepository>();
            services.AddScoped<IAthleteService, AthleteService>();
        }

        // Aqui configuramos o pipeline de execução
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                // Swagger só no Dev (se quiser em prod, pode manter)
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CheerChampionship API v1");
                    c.RoutePrefix = string.Empty; // abre direto no Swagger
                });
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
