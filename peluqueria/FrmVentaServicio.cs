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
        private DataTable dtClientes = new DataTable();
        private DataTable dtEmpleados = new DataTable();
        private List<ProductoCarrito> prodCarrito = new List<ProductoCarrito>();
        private List<ServicioCarrito> servCarrito = new List<ServicioCarrito>();
        private Cliente cliente = new Cliente();
        private Empleados empleados = new Empleados();
        private Venta venta = new Venta();
        private List<DetalleVentaServicio> DetalleServicios = new List<DetalleVentaServicio>();
        private List<DetalleVentaProducto> DetalleProductos = new List<DetalleVentaProducto>();
        public FrmVentaServicio(PeluqueriaContext dbcontext)
        {
            InitializeComponent();
            _dbcontext = dbcontext;

            dtServicios.Columns.Add("Id_Servicios", typeof(int));
            dtServicios.Columns.Add("Nombre Servicios", typeof(string));
            dtServicios.Columns.Add("Descripcion", typeof(string));
            dtServicios.Columns.Add("Precio", typeof(decimal));

            dtClientes.Columns.Add("Id_Cliente", typeof(int));
            dtClientes.Columns.Add("Nombre Cliente", typeof(string));
            dtClientes.Columns.Add("Apellido", typeof(string));
            dtClientes.Columns.Add("Direccion", typeof(string));

            dtEmpleados.Columns.Add("Id_Empleado", typeof(int));
            dtEmpleados.Columns.Add("Nombre", typeof(string));
            dtEmpleados.Columns.Add("Apellido", typeof(string));

            dtProductos.Columns.Add("Id_Productos", typeof(int));
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

            dgvEmpleados.DataSource = dtEmpleados;
            dgvClientes.DataSource = dtClientes;
            dgvServicios.DataSource = dtServicios;
            dgvProductos.DataSource = dtProductos;
            dgvServicioCarrito.DataSource = dtServiciosCarrito;
            dgvProductoCarrito.DataSource = dtProductosCarrito;

            ajustesFormatoDiseñoDgv();
        }
        private void ajustesFormatoDiseñoDgv()
        {
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicioCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductoCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmpleados.AllowUserToAddRows = false;
            dgvClientes.AllowUserToAddRows = false;
            dgvServicios.AllowUserToAddRows = false;
            dgvProductos.AllowUserToAddRows = false;
            dgvServicioCarrito.AllowUserToAddRows = false;
            dgvProductoCarrito.AllowUserToAddRows = false; 

            dgvEmpleados.Columns[0].Visible = false;
            dgvClientes.Columns[0].Visible = false;
            dgvServicios.Columns[0].Visible = false;
            dgvProductos.Columns[0].Visible = false;
        }
        private void FrmVentaServicio_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private async void CargarGrid()
        {
            var servicios = await _dbcontext.Procedures.sp_ObtenerServiciosAsync();
            var productos = await _dbcontext.Procedures.sp_ObtenerProductosAsync();
            var clientes = await _dbcontext.Procedures.sp_obtener_clientesAsync();
            var empleados = await _dbcontext.Procedures.sp_obtener_empleadosAsync();

            foreach (var cli in clientes)
            {
                dtClientes.Rows.Add(cli.id_cliente, cli.nombre, cli.apellido, cli.direccion);
            }

            foreach (var emp in empleados)
            {
                dtEmpleados.Rows.Add(emp.id_empleado, emp.nombre, emp.apellido);
            }

            foreach (var product in productos)
            {
                dtProductos.Rows.Add(product.id_producto, product.nombre_producto, product.descripcion, product.precio, product.stock);
            }

            foreach (var servic in servicios)
            {
                dtServicios.Rows.Add(servic.servicio_id, servic.nombre_servicio, servic.descripcion, servic.precio);
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvServicios.SelectedRows[0];

            string nombre_servicio = row.Cells["Nombre Servicios"].Value.ToString();
            string descripcion = row.Cells["Descripcion"].Value.ToString();
            var precio = Convert.ToDecimal(row.Cells["Precio"].Value);
            var idServicio = Convert.ToInt32(row.Cells["Id_Servicios"].Value);

            //verificamos si existe el producto en el carrito...
            ServicioCarrito servicioExistente = servCarrito.FirstOrDefault(x => x.NombreServicio == nombre_servicio);

            if (servicioExistente != null)
            {
                servicioExistente.Cantidad += 1;
                servicioExistente.Precio += precio;
                venta.Total += servicioExistente.Precio;
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
                servicio.idServicios = idServicio;
                venta.Total += servicio.Precio;
                servCarrito.Add(servicio);

                dtServiciosCarrito.Rows.Add(servicio.NombreServicio, servicio.Descripcion, servicio.Cantidad, servicio.Precio);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvEmpleados.SelectedRows[0];

            empleados.IdEmpleado = Convert.ToInt32(row.Cells["Id_Empleado"].Value);
            empleados.Nombre = row.Cells["Nombre"].Value.ToString();
            empleados.Apellido = row.Cells["Apellido"].Value.ToString();
            labelEmpleado.Text = empleados.Nombre + " " + empleados.Apellido;
            venta.IdEmpleado = empleados.IdEmpleado;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvClientes.SelectedRows[0];

            cliente.IdCliente = Convert.ToInt32(row.Cells["Id_Cliente"].Value);
            cliente.Nombre = row.Cells["Nombre Cliente"].Value.ToString();
            cliente.Apellido = row.Cells["Apellido"].Value.ToString();
            labelCliente.Text = cliente.Nombre + " " + cliente.Apellido;
            venta.IdCliente = cliente.IdCliente;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //PRODUCTO CARRITO 
            DataGridViewRow row = dgvProductos.SelectedRows[0];

            string nombre_producto = row.Cells["Nombre Producto"].Value.ToString();
            string descripcion = row.Cells["Descripcion"].Value.ToString();
            var precio = Convert.ToDecimal(row.Cells["Precio"].Value);
            var idproducto = Convert.ToInt32(row.Cells["Id_Productos"].Value);

            //verificamos si existe el producto en el carrito...
            ProductoCarrito productoExistente = prodCarrito.FirstOrDefault(x => x.NombreProducto == nombre_producto);

            if (productoExistente != null)
            {
                productoExistente.Cantidad += 1;
                productoExistente.Precio += precio;
                venta.Total += precio;
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
                producto.IdProducto = idproducto;
                venta.Total += producto.Precio;

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
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            venta.DetalleProductos = new List<DetalleVentaProducto>();
            venta.DetalleServicios= new List<DetalleVentaServicio>();

            foreach (var pd in prodCarrito)
            {
                DetalleVentaProducto det = new DetalleVentaProducto();
                det.Cantidad = pd.Cantidad;
                det.MontoProducto = pd.Precio;
                det.IdProducto = pd.IdProducto;
                
                venta.DetalleProductos.Add(det);
            }

            foreach (var sv in servCarrito)
            {
                DetalleVentaServicio ser = new DetalleVentaServicio();
                ser.MontoServicio = sv.Precio;
                ser.IdServicio = sv.idServicios;

                venta.DetalleServicios.Add(ser);
            }


            Console.WriteLine(venta);//segui aca
        }
    }
}
