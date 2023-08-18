using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase4
{
    public partial class opciones : Form
    {
        private string userRole;
        private string userName;

        public opciones(string userName, string userRole)
        {

            InitializeComponent();
            this.userRole = userRole;
            this.userName = userName;
            // con estos valores podemos personalizar las forms dependiendo del usuario.
            UsernameLabel.Text = userName;
            RolLabel.Text = userRole;
            LoadButtonBasedOnRole();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            new promedios(userName, userRole).Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadButtonBasedOnRole()
        {
            // Con esta lógica se pueden bloquear más funcionalidades solo para administradores.
            if(userRole ==  "admin") {
                ConversorFormBTN.Enabled = true;
            }

            else
            {
                ConversorFormBTN.Enabled = false;
            }
        }
       

        private void ConversorFormBTN_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Close();
        }
    }
}
