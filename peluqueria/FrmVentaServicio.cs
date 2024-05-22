using peluqueria.Dto;
using peluqueria.Models; 
using System.Data; 

namespace peluqueria
{
    public partial class FrmVentaServicio : Form
    {
        private readonly PeluqueriaContext _dbcontext;
        private DataTable dtProductosCarrito = new DataTable();
        private DataTable dtProductos = new DataTable();
        private DataTable dtServicios = new DataTable();
        private DataTable dtServiciosCarrito = new DataTable();
        private List<ProductoCarrito> prodCarrito = new List<ProductoCarrito>();
        private List<ServicioCarrito> servCarrito = new List<ServicioCarrito>();
        public FrmVentaServicio(PeluqueriaContext dbcontext)
        {
            InitializeComponent();
            _dbcontext = dbcontext;

            dtServicios.Columns.Add("Nombre Servicios", typeof(string));
            dtServicios.Columns.Add("Descripcion", typeof(string));
            dtServicios.Columns.Add("Precio", typeof(decimal));

            dtProductos.Columns.Add("Nombre Producto", typeof(string));
            dtProductos.Columns.Add("Descripcion", typeof(string));
            dtProductos.Columns.Add("Precio", typeof(decimal));
            dtProductos.Columns.Add("Stock", typeof(int));

            dtServiciosCarrito.Columns.Add("Nombre Servicios", typeof(string));
            dtServiciosCarrito.Columns.Add("Descripcion", typeof(string));
            dtServiciosCarrito.Columns.Add("Cantidad", typeof(string));
            dtServiciosCarrito.Columns.Add("Precio", typeof(decimal));

            dtProductosCarrito.Columns.Add("Nombre Producto", typeof(string));
            dtProductosCarrito.Columns.Add("Descripcion", typeof(string));
            dtProductosCarrito.Columns.Add("Cantidad", typeof(int));
            dtProductosCarrito.Columns.Add("Precio", typeof(decimal));

            dgvServicios.DataSource = dtServicios;
            dgvProductos.DataSource = dtProductos;
            dgvServicioCarrito.DataSource = dtServiciosCarrito;
            dgvProductoCarrito.DataSource = dtProductosCarrito;
        }

        private void FrmVentaServicio_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private async void CargarGrid()
        {
            var servicios = await _dbcontext.Procedures.sp_ObtenerServiciosAsync();
            var productos = await _dbcontext.Procedures.sp_ObtenerProductosAsync();

            foreach (var product in productos)
            {
                dtProductos.Rows.Add(product.nombre_producto, product.descripcion, product.precio, product.stock);
            }

            foreach (var servic in servicios)
            {
                dtServicios.Rows.Add(servic.nombre_servicio, servic.descripcion, servic.precio);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            //PRODUCTO CARRITO 
            DataGridViewRow row = dgvProductos.SelectedRows[0];

            string nombre_producto = row.Cells["Nombre Producto"].Value.ToString();
            string descripcion = row.Cells["Descripcion"].Value.ToString();
            var precio = Convert.ToDecimal(row.Cells["Precio"].Value);

            //verificamos si existe el producto en el carrito...
            ProductoCarrito productoExistente = prodCarrito.FirstOrDefault(x => x.NombreProducto == nombre_producto);

            if (productoExistente != null)
            {
                productoExistente.Cantidad += 1;
                productoExistente.Precio += precio;

                foreach (DataRow dr in dtProductosCarrito.Rows)
                {
                    if (dr["Nombre Producto"].ToString() == nombre_producto)
                    {
                        dr["Cantidad"] = Convert.ToInt32(dr["Cantidad"]) + 1;
                        dr["Precio"] = Convert.ToDecimal(dr["Precio"]) + precio;
                        break;
                    }
                }
            }
            else
            {
                ProductoCarrito producto = new ProductoCarrito();
                producto.NombreProducto = nombre_producto;
                producto.Descripcion = descripcion;
                producto.Precio = precio;
                producto.Cantidad = 1;

                prodCarrito.Add(producto);

                dtProductosCarrito.Rows.Add(producto.NombreProducto, producto.Descripcion, producto.Cantidad, producto.Precio);
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvServicios.SelectedRows[0];

            string nombre_servicio = row.Cells["Nombre Servicios"].Value.ToString();
            string descripcion = row.Cells["Descripcion"].Value.ToString();
            var precio = Convert.ToDecimal(row.Cells["Precio"].Value);

            //verificamos si existe el producto en el carrito...
            ServicioCarrito servicioExistente = servCarrito.FirstOrDefault(x => x.NombreServicio == nombre_servicio);

            if (servicioExistente != null)
            {
                servicioExistente.Cantidad += 1;
                servicioExistente.Precio += precio;

                foreach (DataRow dr in dtServiciosCarrito.Rows)
                {
                    if (dr["Nombre Servicios"].ToString() == nombre_servicio)
                    {
                        dr["Cantidad"] = Convert.ToInt32(dr["Cantidad"]) + 1;
                        dr["Precio"] = Convert.ToDecimal(dr["Precio"]) + precio;
                        break;
                    }
                }
            }
            else
            {
                ServicioCarrito servicio = new ServicioCarrito();
                servicio.NombreServicio = nombre_servicio;
                servicio.Descripcion = descripcion;
                servicio.Precio = precio;
                servicio.Cantidad = 1;

                servCarrito.Add(servicio);

                dtServiciosCarrito.Rows.Add(servicio.NombreServicio, servicio.Descripcion, servicio.Cantidad, servicio.Precio);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
