using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Models
{
    public class Categoria
    {
        [Key]
        public int CodigoCategoria { get; set; }
        public string Nombre { get; set; }
        public List<Producto> Producto { get; set; } = new();
    }
}
