// Entities/Factura.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturacionAPI.Entities
{
    [Table("FACTURAS")]
    public class Factura
    {
        [Key]
        [Column("ID_FACTURA")]
        public int IdFactura { get; set; }

        [Column("CLIENTE")]
        public string Cliente { get; set; } = string.Empty;

        [Column("FECHA_FACTURA")]
        public DateTime FechaFactura { get; set; }

        [Column("TOTAL")]
        public decimal Total { get; set; }

        public List<FacturaDetalle> Detalles { get; set; }
            = new List<FacturaDetalle>();
    }
}   