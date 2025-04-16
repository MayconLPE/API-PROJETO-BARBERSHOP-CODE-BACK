using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_BarberShop_Code.Models.DTOs;
using Projeto_BarberShop_Code.Services.Interfaces;

namespace Projeto_BarberShop_Code.Controllers
{
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService iUsuarioService)
        {
            _usuarioService = iUsuarioService;
        }

        [HttpGet("ObterTodosUsuarios")]
        public async Task<IActionResult> ObterTodosUsuarios()
        {
            // Aqui você chamaria o serviço para obter todos os usuários
            var usuarios = await _usuarioService.ObterTodosUsuarios();
            return Ok(usuarios);
        }
        
        [HttpPost("CadastrarBarbeiro")]
        public async Task<IActionResult> CadastrarBarbeiro([FromBody] BarbeiroDto barbeiroDto)
        {
            if (barbeiroDto == null)
            {
                return BadRequest("Dados inválidos."); 
            }

            var resultado = await _usuarioService.CadastrarBarbeiro(barbeiroDto);
            if (resultado)
            {
                return Ok("Barbeiro cadastrado com sucesso.");
            }
            else
            {
                return BadRequest("Erro ao cadastrar barbeiro.");
            }

        }

        [HttpPost("CadastrarCliente")]
        public async Task<IActionResult> CadastrarCliente([FromBody] ClienteDto clienteDto)
        {
            if (clienteDto == null)
            {
                return BadRequest("Dados inválidos."); 
            }

            var resultado = await _usuarioService.CadastrarCliente(clienteDto);
            if (resultado)
            {
                return Ok("Cliente cadastrado com sucesso.");
            }
            else
            {
                return BadRequest("Erro ao cadastrar cliente.");
            }
        }

        [HttpPut("AtualizarBarbeiro")]
        public async Task<IActionResult> AtualizarBarbeiro([FromBody] BarbeiroDto barbeiroDto)
        {
            if (barbeiroDto == null)
            {
                return BadRequest("Dados inválidos."); 
            }

            var resultado = await _usuarioService.AtualizarBarbeiro(barbeiroDto);
            if (resultado)
            {
                return Ok("Barbeiro atualizado com sucesso.");
            }
            else
            {
                return BadRequest("Erro ao atualizar barbeiro.");
            }
        }

        [HttpPut("AtualizarCliente")]
        public async Task<IActionResult> AtualizarCliente([FromBody] ClienteDto clienteDto)
        {
            if (clienteDto == null)
            {
                return BadRequest("Dados inválidos."); 
            }

            var resultado = await _usuarioService.AtualizarCliente(clienteDto);
            if (resultado)
            {
                return Ok("Cliente atualizado com sucesso.");
            }
            else
            {
                return BadRequest("Erro ao atualizar cliente.");
            }
        }
        [HttpDelete("DeletarUsuario/{id}")]
        public async Task<IActionResult> DeletarUsuario(int id)
        {
            var resultado = await _usuarioService.DeletarUsuario(id);
            if (resultado)
            {
                return Ok("Usuário deletado com sucesso.");
            }
            else
            {
                return BadRequest("Erro ao deletar usuário.");
            }
        }
        [HttpGet("ObterTodosBarbeiros")]
        public async Task<IActionResult> ObterTodosBarbeiros()
        {
            var barbeiros = await _usuarioService.ObterTodosBarbeiros();
            return Ok(barbeiros);
        }
        [HttpGet("ObterTodosClientes")]
        public async Task<IActionResult> ObterTodosClientes()
        {
            var clientes = await _usuarioService.ObterTodosClientes();
            return Ok(clientes);
        }

    }
}