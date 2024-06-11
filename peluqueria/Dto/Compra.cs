namespace peluqueria.Dto
{
    public class Compra
    {
        public int CompraId { get; set; }
        public int ProveedorId { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal TotalCompra { get; set; }
    }
}
