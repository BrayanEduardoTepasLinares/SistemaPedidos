using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SistemaPedidos.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        
        public DateTime Fecha { get; set; }
        
        public int UsuarioId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string MetodoPago { get; set; } = "Efectivo";
        
        [StringLength(200)]
        public string? DireccionEnvio { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Estado { get; set; } = "Pendiente";
        
        // Navegación
        public virtual Usuario? Usuario { get; set; }
        public virtual ICollection<DetallePedido> DetallesPedido { get; set; } = new List<DetallePedido>();
    }
}