using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        // GET: api/<ProdutosController>
        [HttpGet]
        public IActionResult Get()
        {
            var produtos = new string[] { "Produto-1", "Produto-2", "Produto-3" };
            return Ok(produtos);
        }

        // GET api/<ProdutosController>/5
        [HttpGet("{id}")]
        public IActionResult Get_v1(int id)
        {
            var produto = $"Produto-{id}";
            return Ok(produto);
        }

        //// GET api/<ProdutosController>/5
        //[HttpGet("{id}"), MapToApiVersion("2.0")]
        //public IActionResult Get_v2(int id)
        //{
        //    if (id <= 0 || id > 3)
        //        return NotFound("Id de Produto Invalido");
        //    else
        //    {
        //        var produto = $"Produto-{id}";
        //        return Ok(produto);
        //    }
        //}
    }
}
