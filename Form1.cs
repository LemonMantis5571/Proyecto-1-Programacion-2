using System.Windows.Forms;

namespace clase4
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            // Aqui puedes inicializar más valores por default pero recuerda agregarlos a la lista si no fallará la comparación.
            UserNameComboBox.Items.Add("Maria");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IngresarBTN_Click_1(object sender, EventArgs e)
        {
            String enteredUsername = UserNameComboBox.Text;
            String enteredPassword = PasswordTextBox.Text;

            UserAuth AuthService = new UserAuth(); // Clase para manejar el objeto de usuario.
            User ValidUser = AuthService.Auth(enteredUsername, enteredPassword); // Retornamos true si es valida con la lista de usuarios.

            if (ValidUser != null)
            {
                new opciones(ValidUser?.Username, ValidUser?.Role).Show();
                this.Hide();
                return;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            UserNameComboBox.Text = "";
            PasswordTextBox.Text = "";
            return;
        }
    }
}