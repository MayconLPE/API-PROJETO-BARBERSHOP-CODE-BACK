using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_BarberShop_Code.Models.DTOs
{
    public class ClienteDto
    {
        // public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string NomeUsuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public object?[]? Id { get; internal set; }
    }
}