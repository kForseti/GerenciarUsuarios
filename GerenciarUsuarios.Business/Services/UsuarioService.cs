using GerenciarUsuarios.Business.DTOs;
using GerenciarUsuarios.Repository.Context;
using GerenciarUsuarios.Repository.Entities.Usuario;
using Microsoft.EntityFrameworkCore;

namespace GerenciarUsuarios.Business.Services
{
    public class UsuarioService
    {
        private readonly UsuarioContext _UsuarioContext;

        public UsuarioService(UsuarioContext usuarioContext)
        {
            _UsuarioContext = usuarioContext;
        }
        public List<Usuario> ListarTodosUsuarios()
        {
            return _UsuarioContext.usuario.ToList();
        }

        public List<Usuario> ListarUsuarioPorCPFouNome(string usuario, string cpf)
        {
            return _UsuarioContext.usuario
                .Where(e => e.cpf == cpf || e.usuario.Equals(usuario)).ToList();
        }
    }
}

