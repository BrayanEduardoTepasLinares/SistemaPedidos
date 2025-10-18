using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaPedidos.Infrastructure.Data; // Importa tu DbContext
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaPedidos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        // Campo privado para inyectar el DbContext
        private readonly AppDbContext _context;

        // Inyección de Dependencias del DbContext
        public ProductosController(AppDbContext context)
        {
            _context = context;
        }

        // Endpoint: GET /api/Productos/nombres
        [HttpGet("nombres")]
        public async Task<ActionResult<IEnumerable<string>>> GetNombresProductos()
        {
            // Nota: Este código asume que el DbSet<Producto> se llama 'Productos' en AppDbContext.
            // Si la tabla remota no tiene productos, devolverá un array vacío.
            try
            {
                var nombres = await _context.Productos
                    .Select(p => p.Nombre)
                    .ToListAsync();
                    
                return Ok(nombres);
            }
            catch (Exception ex)
            {
                // Devolver un error 500 si hay problemas con la base de datos o la consulta
                return StatusCode(500, $"Error al acceder a la base de datos: {ex.Message}");
            }
        }
    }
}