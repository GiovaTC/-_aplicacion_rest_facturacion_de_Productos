// Entities/FacturaDetalle.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturacionAPI.Entities
{
    [Table("FACTURA_DETALLE")]
    public class FacturaDetalle
    {
        [Key]
        [Column("ID_DETALLE")]
        public int IdDetalle { get; set; }

        [Column("ID_FACTURA")]
        public int IdFactura { get; set; }

        [Column("PRODUCTO")]
        public string Producto { get; set; } = string.Empty;

        [Column("CANTIDAD")]
        public int Cantidad { get; set; }

        [Column("PRECIO")]
        public decimal Precio { get; set; }

        [Column("SUBTOTAL")]
        public decimal Subtotal { get; set; }

        [ForeignKey("IdFactura")]
        public Factura? Factura { get; set; }
    }
}