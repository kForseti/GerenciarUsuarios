using GerenciarUsuarios.Business.Services;
using GerenciarUsuarios.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace GerenciarUsuarios
{
    public static class DependencyInjection
    {
        public static WebApplicationBuilder ConfigureDI(this WebApplicationBuilder Builder)
        {
            Builder.Services.AddDbContext<UsuarioContext>(options =>
                options.UseSqlServer(Builder.Configuration.GetConnectionString("UsuarioConnectionString")));

            Builder.Services.AddScoped<UsuarioService>();
            return Builder;
        }
    }
}
