using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto_BarberShop_Code.Models;
using Projeto_BarberShop_Code.Models.DTOs;
using Projeto_BarberShop_Code.Services.Interfaces;

namespace Projeto_BarberShop_Code.Services
{
    public class UsuarioService : IUsuarioService
    {
        public Task<bool> AtualizarBarbeiro(BarbeiroDto barbeiroDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtualizarCliente(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CadastrarBarbeiro(BarbeiroDto barbeiroDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CadastrarCliente(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> ObterTodosBarbeiros()
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> ObterTodosClientes()
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> ObterTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> ObterUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> ObterUsuarioPorNome(string nomeUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> ObterUsuarioPorNomeUsuario(string nomeUsuario)
        {
            throw new NotImplementedException();
        }
    }
}