namespace peluqueria.Validations
{
    public class Validation
    { 
        public static bool loginValidate(string user, string pass)
        {
            if (user.Trim() == "")
            {
                MessageBox.Show("Por favor, completar el campo usuario");
                return false;
            }

            if (pass.Trim() == "")
            {
                MessageBox.Show("Por favor, completar el campo contraseña");
                return false;
            } 
            else
            {
                return true;
            }   
        }
    }
}
