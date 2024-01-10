using ApiEntrega6.Data;
using ApiEntrega6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiEntrega6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly Datacontext _dataContext;

        public ClienteController(Datacontext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes() 
        {
            return await _dataContext.Clientes.ToListAsync();
        
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Cliente>> GetClienteById(int id)
        {
            var cliente = await _dataContext.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

  
    }

}
