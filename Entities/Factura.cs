using System.ComponentModel.DataAnnotations;

namespace FacturacionAPI.Entities
{
    public class Factura
    {
        [Key]
        public int Id_Factura { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha_Factura { get; set; }
        public decimal Total { get; set; }
        public List<FacturaDetalle> Detalles { get; set; }
    }
}   
