using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPedidos.Domain.Entities
{
    public class DetallePedido
    {
        public int Id { get; set; }
        
        public int PedidoId { get; set; }
        
        public int ProductoId { get; set; }
        
        [Required]
        [Range(1, int.MaxValue)]
        public int Cantidad { get; set; }
        
        [Required]
        [Column(TypeName = "money")]
        public decimal PrecioUnitario { get; set; }
        
        [Column(TypeName = "money")]
        public decimal Subtotal { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Estado { get; set; } = "Activo";
        
        // Navegación
        public virtual Pedido? Pedido { get; set; }
        public virtual Producto? Producto { get; set; }
    }
}