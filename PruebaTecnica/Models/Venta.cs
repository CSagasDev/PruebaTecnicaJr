using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Models
{
    public class Venta
    {
        [Key]
        public int CodigoVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int CodigoProducto { get; set; }

        [ForeignKey("CodigoProducto")]
        public Producto Producto { get; set; }
    }
}
