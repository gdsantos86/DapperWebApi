using DapperWebApi.Entities;
using DapperWebApi.Repositories;
using DapperWebApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionariosController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetFuncionarios() 
        {
            try
            {
                var funcionarios = await _funcionarioRepository.GetAll();
                if (funcionarios == null) return NotFound();

                return Ok(funcionarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFuncionario(int id) 
        {
            try
            {
                var funcionario = await _funcionarioRepository.GetById(id);
                if (funcionario == null) return NotFound();

                return Ok(funcionario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
