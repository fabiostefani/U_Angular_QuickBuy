using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fabiostefani.io.QuickBuy.Dominio.Contratos;
using fabiostefani.io.QuickBuy.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace fabiostefani.io.QuickBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }            
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioExiste = _usuarioRepositorio.UsuarioJaCadastrado(usuario.Email);
                if (usuarioExiste)
                {
                    return BadRequest("Usuário já cadastrado no sistema.");
                }

                _usuarioRepositorio.Adicionar(usuario);
                return Created("api/usuario", usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Validar")]
        public IActionResult Validar([FromBody] Usuario usuario)
        {
            try
            {
                var usuarioCadastrado = _usuarioRepositorio.ExisteUsuarioPorUsuarioSenha(usuario);
                if (usuarioCadastrado != null)
                {                    
                    return Ok(usuarioCadastrado);
                }
                return BadRequest("Usuário ou senha inválidos");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
