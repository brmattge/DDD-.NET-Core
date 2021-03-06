using Microsoft.AspNetCore.Mvc;
using Restaurante.Aplicacao.DTO;
using Restaurante.Aplicacao.Interfaces;
using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Servicos.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ControllerBase<Entidade, EntidadeDTO> : Controller
        where Entidade : EntidadeBase
        where EntidadeDTO : DTOBase
    {
        readonly protected IAppBase<Entidade, EntidadeDTO> app;

        public ControllerBase(IAppBase<Entidade, EntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("SelecionarTodos")]
        public IActionResult SelecionarTodos()
        {
            try
            {
                var restaurantes = app.SelecionarTodos();
                return new OkObjectResult(restaurantes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("SelecionarPorId/{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                var restaurantes = app.SelecionarPorId(id);
                return new OkObjectResult(restaurantes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Incluir")]
        public IActionResult Incluir([FromBody] EntidadeDTO dado)
        {
            try
            {
                return new OkObjectResult(app.Incluir(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("Alterar")]
        public IActionResult Alterar([FromBody] EntidadeDTO dado)
        {
            try
            {
                app.Alterar(dado);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("ExcluirPorId/{id}")]
        public IActionResult ExcluirPorId(int id)
        {
            try
            {
                app.ExcluirPorId(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
