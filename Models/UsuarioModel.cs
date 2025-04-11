using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_BarberShop_Code.Models.Enum;

namespace Projeto_BarberShop_Code.Models
{
    public class UsuarioModel
    {
    public int Id { get; set; }
    public TipoUsuario TipoUsuario { get; set; } // <- Barbeiro ou Cliente.
    public string Nome { get; set; } = string.Empty;
    public string NomeUsuario { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string NomeBarbearia { get; set; } = string.Empty; // <- Somente barbeiro.
    public string Telefone { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    }

    // public class Barbeiro : UsuarioModel
    // {
    // public string NomeBarbearia { get; set; } = string.Empty;
    // }

    // public class Cliente : UsuarioModel
    // {
    //     // ...
    // }


}