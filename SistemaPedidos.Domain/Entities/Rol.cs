using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SistemaPedidos.Domain.Entities
{
    public class Rol
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        
        [StringLength(200)]
        public string? Descripcion { get; set; }
        
        [Required]
        [StringLength(20)]
        public string Estado { get; set; } = "Activo";
        
        public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}