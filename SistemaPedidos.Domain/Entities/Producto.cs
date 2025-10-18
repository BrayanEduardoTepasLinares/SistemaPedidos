using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SistemaPedidos.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;
        
        [StringLength(300)]
        public string? Descripcion { get; set; }
        
        [Required]
        [Column(TypeName = "money")]
        public decimal Precio { get; set; }
        
        public int Stock { get; set; }
        
        [StringLength(50)]
        public string? Categoria { get; set; }
        
        [StringLength(200)]
        public string? Imagen { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Estado { get; set; } = "Disponible";
        
        public virtual ICollection<DetallePedido> DetallesPedido { get; set; } = new List<DetallePedido>();
    }
}