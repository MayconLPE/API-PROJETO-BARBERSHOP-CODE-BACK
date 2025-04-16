using Microsoft.EntityFrameworkCore;
using Projeto_BarberShop_Code.Data;
using Projeto_BarberShop_Code.Models;
using Projeto_BarberShop_Code.Models.DTOs;
using Projeto_BarberShop_Code.Services.Interfaces;

namespace Projeto_BarberShop_Code.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;
        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        // Implementação dos métodos da interface IUsuarioService
        public Task<bool> AtualizarBarbeiro(BarbeiroDto barbeiroDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AtualizarCliente(ClienteDto clienteDto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CadastrarBarbeiro(BarbeiroDto barbeiroDto)
        {
            // Verifica se o barbeiro já existe
            var barbeiroExistente = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NomeUsuario == barbeiroDto.NomeUsuario && u.TipoUsuario == Models.Enum.TipoUsuario.Barbeiro);

            if (barbeiroExistente != null)
            {
                return false; // Barbeiro já existe
            }

            // Cria um novo barbeiro
            var barbeiro = new UsuarioModel
            {
                // Atribui os valores do DTO ao modelo de usuário
                Nome = barbeiroDto.Nome,
                NomeUsuario = barbeiroDto.NomeUsuario,
                Senha = barbeiroDto.Senha,
                Email = barbeiroDto.Email,
                Telefone = barbeiroDto.Telefone,
                TipoUsuario = Models.Enum.TipoUsuario.Barbeiro,
                NomeBarbearia = barbeiroDto.NomeBarbearia,
                Bio = barbeiroDto.Bio
            };

            // Adiciona o barbeiro ao contexto e salva as alterações
            await _context.Usuarios.AddAsync(barbeiro);
            await _context.SaveChangesAsync();

            return true;           

        }
        public async Task<bool> CadastrarCliente(ClienteDto clienteDto)
        {
            // Verifica se o cliente já existe
            var clienteExistente = await _context.Usuarios
                .FirstOrDefaultAsync(u => u.NomeUsuario == clienteDto.NomeUsuario && u.TipoUsuario == Models.Enum.TipoUsuario.Cliente);

            if (clienteExistente != null)
            {
                return false; // Cliente já existe
            }

            // Cria um novo cliente
            var cliente = new UsuarioModel
            {
                // Atribui os valores do DTO ao modelo de usuário
                Nome = clienteDto.Nome,
                NomeUsuario = clienteDto.NomeUsuario,
                Senha = clienteDto.Senha,
                Email = clienteDto.Email,
                Telefone = clienteDto.Telefone,
                TipoUsuario = Models.Enum.TipoUsuario.Cliente,
                Bio = clienteDto.Bio
            };

            // Adiciona o cliente ao contexto e salva as alterações
            await _context.Usuarios.AddAsync(cliente);
            await _context.SaveChangesAsync();

            return true;
   
        }

        public Task<bool> DeletarUsuario(int id)
        {
            // Verifica se o usuário existe
            var usuario = _context.Usuarios.Find(id);
            if (usuario == null)
            {
                return Task.FromResult(false); // Usuário não encontrado
            }

            // Remove o usuário do contexto e salva as alterações
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();

            return Task.FromResult(true); // Usuário removido com sucesso
        }

        public async Task<List<UsuarioModel>> ObterTodosBarbeiros()
        {
            // Obtém todos os barbeiros do banco de dados
            var barbeiros = await _context.Usuarios
                .Where(u => u.TipoUsuario == Models.Enum.TipoUsuario.Barbeiro)
                .ToListAsync();
            return barbeiros; 

        }

        public async Task<List<UsuarioModel>> ObterTodosClientes()
        {
            // Obtém todos os clientes do banco de dados
            var clientes = await _context.Usuarios
                .Where(u => u.TipoUsuario == Models.Enum.TipoUsuario.Cliente)
                .ToListAsync();
            return clientes;
        }

        public async Task<List<UsuarioModel>> ObterTodosUsuarios()
        {
            // Obtém todos os usuários do banco de dados
            var usuarios = await _context.Usuarios.ToListAsync();
            return usuarios;
        }
    }
}