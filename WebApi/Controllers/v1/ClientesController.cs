using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET: api/<ClientesController>
        [HttpGet]
        public IActionResult Get()
        {
            var clientes = new string[] { "Cliente-1", "Cliente-2", "Cliente-3" };
            return Ok(clientes);
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cliente = $"Cliente-{id}";
            return Ok(cliente);
        }
    }
}
