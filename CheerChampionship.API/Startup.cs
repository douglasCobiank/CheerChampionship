using CheerChampionship.Core.Handler.Championships.Interface;
using CheerChampionship.Core.Handler;
using CheerChampionship.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using CheerChampionship.Infrastructure.Repositories.Campeonato;
using CheerChampionship.Core.Handler.Championships.Services;
using CheerChampionship.Core.Handler.Championships.Mappers;
using CheerChampionship.Core.Handler.Teams.Mappers;
using CheerChampionship.Core.Handler.Teams.Interface;
using CheerChampionship.Core.Handler.Teams.Service;
using CheerChampionship.Core.Handler.Teams;
using CheerChampionship.Infrastructure.Repositories.Equipe;

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
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            // registra AutoMapper e procura os profiles no assembly
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Injeção de dependência
            services.AddScoped<ICampeonatoHandler, CampeonatoHandler>();
            services.AddScoped<ICampeonatoRepository, CampeonatoRepository>();
            services.AddScoped<ICampeonatoService, CampeonatoService>();

            services.AddScoped<ITeamHandler, TeamHandler>();
            services.AddScoped<IEquipeRepository, EquipeRepository>();
            services.AddScoped<ITeamService, TeamService>();
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
