using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; // Asegúrate de que este using esté presente

namespace SistemaPedidos.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Nombre { get; set; } = string.Empty;
        
        [Required]
        [StringLength(30)]
        public string Apellido { get; set; } = string.Empty;
        
        [StringLength(20)]
        public string? Telefono { get; set; }
        
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        [StringLength(30)]
        public string Nick { get; set; } = string.Empty;
        
        [Required]
        [StringLength(200)]
        public string Pass { get; set; } = string.Empty;
        
        [StringLength(200)]
        public string? Direccion { get; set; }
        
        public DateTime FechaRegistro { get; set; }
        
        public int RolId { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Estado { get; set; } = "Activo";
        
        // Navegación
        public virtual Rol? Rol { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}