using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_BarberShop_Code.Models.DTOs;

namespace Projeto_BarberShop_Code.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<bool> CadastrarCliente(ClienteDto clienteDto);
        Task<bool> CadastrarBarbeiro(BarbeiroDto barbeiroDto);
        Task<bool> AtualizarCliente(ClienteDto clienteDto);
        Task<bool> AtualizarBarbeiro(BarbeiroDto barbeiroDto);
        Task<bool> DeletarUsuario(int id);
        Task<List<Models.UsuarioModel>> ObterTodosUsuarios();
        Task<List<Models.UsuarioModel>> ObterTodosBarbeiros();
        Task<List<Models.UsuarioModel>> ObterTodosClientes();    
    }
}