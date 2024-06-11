 
namespace peluqueria.Dto
{
    public class ProductoComprados 
    {
        public int ProductoCompraId { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}
