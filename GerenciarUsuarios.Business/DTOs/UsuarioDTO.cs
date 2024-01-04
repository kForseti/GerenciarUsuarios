using GerenciarUsuarios.Repository.Entities.Usuario;

namespace GerenciarUsuarios.Business.DTOs
{
    public class UsuarioDTO
    {
        public string Usuario { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public long? Telefone { get; set; }
        public long Celular { get; set; }
        public bool IsWhatsApp { get; set; }

        public UsuarioDTO()
        {

        }

        public UsuarioDTO(Usuario usuario)
        {
            Usuario = usuario.usuario;
            DataNascimento = usuario.dataNascimento;
            Cpf = usuario.cpf;
            Email = usuario.email;
            Telefone = usuario.telefone;
            Celular = usuario.celular;
            IsWhatsApp = usuario.isWhatsApp;
        }
    }
}
