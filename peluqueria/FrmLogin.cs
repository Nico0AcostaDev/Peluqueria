using peluqueria.Models;
using peluqueria.Validations;

namespace peluqueria
{
    public partial class FrmLogin : Form
    {
        private readonly PeluqueriaContext _dbcontext;
        public FrmLogin(PeluqueriaContext dbcontext)
        {
            InitializeComponent();
            _dbcontext = dbcontext;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string user = usuario_textbox.Text;
            string pass = contraseña_textbox.Text;

            bool validacionOk = Validation.loginValidate(user, pass);

            if (validacionOk == true)
            {
                OutputParameter<int?> response = new OutputParameter<int?>();
                await _dbcontext.Procedures.sp_ValidarUsuarioAsync(user, pass, response);

                if (response.Value == 0)
                {
                    MessageBox.Show($"Usuario o contraseña incorrecta");
                }
                else
                {
                    this.Hide();
                    FrmMain menu = new FrmMain(_dbcontext);
                    menu.ShowDialog();

                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
