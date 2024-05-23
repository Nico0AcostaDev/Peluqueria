namespace peluqueria.Dto
{ 
        public class Venta 
        {
            public int IdVenta { get; set; }
            public int IdCliente { get; set; }
            public DateTime FechaVenta { get; set; }
            public int IdEmpleado { get; set; }
            public decimal Total { get; set; }
            public List<DetalleVentaServicio> DetalleServicios { get; set; }
            public List<DetalleVentaProducto> DetalleProductos { get; set; }
        }

        public class DetalleVentaServicio
        {
            public int IdDetalleServicio { get; set; }
            public int IdVenta { get; set; }
            public int IdServicio { get; set; }
            public decimal MontoServicio { get; set; }
        }

        public class DetalleVentaProducto
        {
            public int IdDetalleProducto { get; set; }
            public int IdVenta { get; set; }
            public int IdProducto { get; set; }
            public int Cantidad { get; set; }
            public decimal MontoProducto { get; set; }
        }

    
}
