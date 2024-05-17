using peluqueria.Models;
using System.Data; 

namespace peluqueria
{
    public partial class FrmVentaServicio : Form
    {
        private readonly PeluqueriaContext _dbcontext;
        public FrmVentaServicio(PeluqueriaContext dbcontext)
        {
            InitializeComponent();
            _dbcontext = dbcontext;
        }

        private void FrmVentaServicio_Load(object sender, EventArgs e)
        {  
            CargarGrid();
        }
        private async void CargarGrid()
        {
            DataTable dtServicios = new DataTable(); 
            dtServicios.Columns.Add("Nombre Producto", typeof(string));
            dtServicios.Columns.Add("Descripcion", typeof(string));
            dtServicios.Columns.Add("Precio", typeof(decimal));

            DataTable dtServiciosCarrito = new DataTable();
            dtServiciosCarrito.Columns.Add("Nombre Producto", typeof(string));
            dtServiciosCarrito.Columns.Add("Descripcion", typeof(string));
            dtServiciosCarrito.Columns.Add("Precio", typeof(decimal));

            DataTable dtProductos = new DataTable(); 
            dtProductos.Columns.Add("Nombre Producto", typeof(string));
            dtProductos.Columns.Add("Descripcion", typeof(string));
            dtProductos.Columns.Add("Precio", typeof(decimal));
            dtProductos.Columns.Add("Stock", typeof(int));

            DataTable dtProductosCarrito = new DataTable();
            dtProductosCarrito.Columns.Add("Nombre Producto", typeof(string));
            dtProductosCarrito.Columns.Add("Descripcion", typeof(string));
            dtProductosCarrito.Columns.Add("Precio", typeof(decimal));
            dtProductosCarrito.Columns.Add("Stock", typeof(int));
              
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


            dgvServicios.DataSource = dtServicios;
            dgvProductos.DataSource = dtProductos;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvProductos.SelectedRows[0]; 
            
            string value1 = row.Cells["Nombre Producto"].Value.ToString();  
            string value2 = row.Cells["Descripcion"].Value.ToString(); 
            var precio = row.Cells["Precio"].Value; 



               
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

    }
}
