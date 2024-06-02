using peluqueria.Models;

namespace peluqueria
{
    public partial class FrmMain : Form
    {
        private readonly PeluqueriaContext _dbcontext;
        public FrmMain(PeluqueriaContext dbcontext)
        {
            InitializeComponent();
            _dbcontext = dbcontext;
        }

        private void generarServicioVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentaServicio frmVenta = new FrmVentaServicio(_dbcontext);
            frmVenta.ShowDialog();
            this.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
