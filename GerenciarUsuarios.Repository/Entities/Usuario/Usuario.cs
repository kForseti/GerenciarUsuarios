using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciarUsuarios.Repository.Entities.Usuario
{
    public class Usuario
    {
        [Key]
        public long id { get; set; }
        public string usuario { get; set; }
        public DateTime dataNascimento { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public long? telefone { get; set; }
        public long celular { get; set; }
        public bool isWhatsApp { get; set; }
        public DateTime dataInclusao { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public DateTime? dataExclusao { get; set; }
        public bool isExcluido { get; set; }
    }
}
