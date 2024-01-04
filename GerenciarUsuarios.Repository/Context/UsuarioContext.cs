using GerenciarUsuarios.Repository.Entities.Usuario;
using Microsoft.EntityFrameworkCore;

namespace GerenciarUsuarios.Repository.Context
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {
        }

        public DbSet<Usuario> usuario { get; set; }
    }
}
