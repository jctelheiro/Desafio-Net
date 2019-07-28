using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CheckingAccount.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly ILogger logger;

        public ContaCorrenteController(ILogger<ContaCorrenteController> logger)
        {
            this.logger = logger;
        }
    }
}