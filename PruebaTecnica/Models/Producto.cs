using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Models
{
    public class Producto
    {
        [Key]
        public int CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public int CodigoCategoria { get; set; }

        [ForeignKey("CodigoCategoria")]
        public Categoria Categoria { get; set; }
        public List<Venta> Ventas { get; set; } = new();

    }
}
