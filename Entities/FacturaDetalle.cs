using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturacionAPI.Entities
{
    public class FacturaDetalle
    {
        [Key]
        public int Id_Detalle { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
        
        [ForeignKey("Factura")]
        public int Id_Factura { get; set; }
        public Factura Factura { get; set; }
    }   
}
