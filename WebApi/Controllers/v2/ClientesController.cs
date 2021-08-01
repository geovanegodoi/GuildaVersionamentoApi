using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers.v2
{
    [ApiVersion("2.0")]
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
        public IActionResult GetById(int id)
        {
            if (id <= 0 || id > 3)
                return NotFound("Id de Cliente Invalido");
            else
            {
                var cliente = $"Cliente-{id}";
                return Ok(cliente);
            }
        }

        // POST api/<ClientesController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            _ = int.TryParse(value, out int id);
            var cliente = $"Cliente-{value}";
            return CreatedAtAction(nameof(GetById), new { id = id }, cliente);
        }
    }
}
