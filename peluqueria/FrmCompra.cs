using Microsoft.EntityFrameworkCore;
using peluqueria.Dto;
using peluqueria.Models;
using System.Data;

namespace peluqueria
{
    public partial class FrmCompra : Form
    {
        private readonly PeluqueriaContext _dbcontext;
        private DataTable dtProductos = new DataTable();
        private DataTable dtProveedores = new DataTable();
        private List<Producto> productos = new List<Producto>();
        private List<Proveedor> proveedores = new List<Proveedor>();
        private Producto producto = new Producto();
        private Proveedor proveedor = new Proveedor();
        private Compra compra = new Compra();
        public FrmCompra(PeluqueriaContext dbcontext)
        {
            _dbcontext = dbcontext; 

            dtProductos.Columns.Add("Id_Productos", typeof(int));
            dtProductos.Columns.Add("Nombre Producto", typeof(string));
            dtProductos.Columns.Add("Descripcion", typeof(string));
            dtProductos.Columns.Add("Precio", typeof(decimal));
            dtProductos.Columns.Add("Stock", typeof(int));

            dtProveedores.Columns.Add("Id_Proveedor", typeof(string));
            dtProveedores.Columns.Add("Razon Social", typeof(string));
            dtProveedores.Columns.Add("cuit_cuil", typeof(string));
            dtProveedores.Columns.Add("correo_electronico", typeof(string));
            dtProveedores.Columns.Add("direccion", typeof(string));

            dgvProveedores.DataSource = dtProveedores;
            dgvProductos.DataSource = dtProductos;  

            ajustesFormatoDiseñoDgv();
        }
        private void ajustesFormatoDiseñoDgv()
        {
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
             
            dgvProveedores.AllowUserToAddRows = false;
            dgvProductos.AllowUserToAddRows = false;

            dgvProveedores.Columns[0].Visible = false; 
            dgvProductos.Columns[0].Visible = false;
        }

        private void FrmCompra_Load(object sender, EventArgs e)
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
                //dtClientes.Rows.Add(cli.id_cliente, cli.nombre, cli.apellido, cli.direccion);
            } 

            foreach (var servic in servicios)
            {
                //dtServicios.Rows.Add(servic.servicio_id, servic.nombre_servicio, servic.descripcion, servic.precio);
            }

        }
    }
}
