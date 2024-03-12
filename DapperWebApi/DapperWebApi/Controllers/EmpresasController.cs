﻿using DapperWebApi.Repositories;
using DapperWebApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EmpresasController(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmpresas()
        {
            try
            {
                var empresas = await _empresaRepository.GetAll();

                if (empresas == null) { return NotFound(); }

                return Ok(empresas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
