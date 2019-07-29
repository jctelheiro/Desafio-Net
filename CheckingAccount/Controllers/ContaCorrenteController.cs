using CheckingAccount.API.Application.Commands;
using CheckingAccount.API.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CheckingAccount.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IMediator _mediator;
        
        public ContaCorrenteController(
            ILogger<ContaCorrenteController> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CriarContaCorrente([FromBody] CriarContaCorrenteCommand criarContaCorrenteCommand)
        {
            var commandResult = await _mediator.Send(criarContaCorrenteCommand);

            if (!commandResult.Success)
            {
                return BadRequest(commandResult.Mensagem);
            }

            return CreatedAtAction(nameof(CriarContaCorrente), criarContaCorrenteCommand.Id);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ContaCorrenteViewModel>> ObterContaCorrente([FromRoute]Guid id)
        {
            var obterContaCorrenteCommand = new ObterContaCorrenteCommand(id);
            var result = await _mediator.Send(obterContaCorrenteCommand);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }
    }
}