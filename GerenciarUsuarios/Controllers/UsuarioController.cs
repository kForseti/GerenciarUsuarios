using GerenciarUsuarios.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace GerenciarUsuarios.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        public ActionResult ListarTodosUsuarios()
        {
            var usuarios = _usuarioService.ListarTodosUsuarios();
            return View(usuarios);
        }
        public ActionResult ListarUsuarioPorCPFouNome(string usuario, string cpf)
        {
            var testar = _usuarioService.ListarUsuarioPorCPFouNome(usuario, cpf);
            return View();
        }
    }
}
