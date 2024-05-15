using peluqueria.Models;
using peluqueria.Validations;

namespace peluqueria
{
    public partial class Login : Form
    {
        private readonly PeluqueriaContext _dbcontext;
        public Login(PeluqueriaContext dbcontext)
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

            bool validacionOk = Validation.loginValidate(user,pass);

            if (validacionOk == true)
            {
                OutputParameter<int?> response = new OutputParameter<int?>();
                await _dbcontext.Procedures.ValidarUsuarioAsync(user,pass,response); 

                if (response.Value == 0)
                {
                    MessageBox.Show($"El usuario {user} no existe en nuestra base de datos"); 
                } else
                {
                    this.usuario_textbox.Clear();
                    this.contraseña_textbox.Clear(); 
                }
            }    
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
