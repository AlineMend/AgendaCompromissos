using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompromissosController : ControllerBase
    {
        private readonly IRepository _repo;

        public CompromissosController(IRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Buscar um compromisso pelo seu Id
        /// </summary>
        /// <param name="CompromissosId">Id do compromisso buscado</param>
        /// <response code="200">Retorna o compromisso  filtrado</response>
        /// <response code="204">Caso não haja compromisso  com este id</response> 

        [HttpGet("{CompromissosId}")]
        public async Task<IActionResult> GetByCompromissosId(int CompromissosId)
        {
            try
            {
                var result = await _repo.GetCompromissosAsyncById(CompromissosId, true);
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        /// <summary>
        /// Inserir um compromisso na agenda
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     POST /Modelo
        ///     {
        ///        "tarefa": "Reunião",
        ///        "local": "Escritorio",
        ///        "dia": "02/08/2021",
        ///        "hora": "08:30"
        ///     }
        /// </remarks>
        /// <param name="model">Dados do compromisso a ser inserido</param>
        /// <response code="200">Caso o compromisso seja inserido com sucesso</response>
        /// <response code="422">Caso já exista um compromisso com a mesma tarefa para a mesma data</response>

        [HttpPost]
        public async Task<IActionResult> post(Compromissos model)
        {
            try
            {
                _repo.Add(model);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

         /// <summary>
        /// Atualizar um compromisso na agenda
        /// </summary>
        /// /// <param name="compromissosId">Id do compromisso  a ser atualizado</param>
        /// <param name="model">Novos dados para atualizar o compromisso indicado</param>
        /// <response code="200">Cao o compromisso seja atualizado com sucesso</response>
        /// <response code="404">Caso não exista um compromisso com este Id</response>   

        [HttpPut("{compromissosId}")]
        public async Task<IActionResult> put(int compromissosId, Compromissos model)
        {
            try
            {
                var compromissos = await _repo.GetCompromissosAsyncById(compromissosId, false);
                if(compromissos == null) return NotFound();

                _repo.Update(model);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

         /// <summary>
        /// Excluir um compromisso da agenda
        /// </summary>
        /// /// <param name="compromissosId">Id do compromisso a ser excluído</param>
        /// <response code="200">Cao o compromisso seja excluido com sucesso</response>
        /// <response code="404">Caso não exista um compromisso com este Id</response>  

        [HttpDelete("{compromissosId}")]
        public async Task<IActionResult> delete(int compromissosId)
        {
            try
            {
                var compromissos = await _repo.GetCompromissosAsyncById(compromissosId, false);
                if(compromissos == null) return NotFound();

                _repo.Delete(compromissos);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok("Deletado");
                }                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

    }
}