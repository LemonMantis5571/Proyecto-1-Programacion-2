using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace clase4
{
    public partial class promedios : Form
    {
        private string userName;
        private string userRole;
        public promedios(string userName, string userRole)
        {
            InitializeComponent();
            this.userName = userName;
            this.userRole = userRole;

        }

        public int getLength(string cadena)
        {
            int Total = 0;

            char[] delimiters = new char[] { ' ', '\r', '\n' };

            Total = cadena.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

            return Total;

        }

        public static int mostFrequent(int[] arr, int n)
        {
            int maxcount = 0;
            int element_having_max_freq = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count > maxcount)
                {
                    maxcount = count;
                    element_having_max_freq = arr[i];
                }
            }

            return element_having_max_freq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PromedioExampleLabel_Click(object sender, EventArgs e)
        {

        }

        private void PromedioBTN_Click(object sender, EventArgs e)
        {
            string Values = PromedioTextBox.Text;

            int Total = getLength(Values);

            string[] CapsulaNumeros = Values.Split(',');

            int[] NumerosSeparados = CapsulaNumeros.Select(int.Parse).ToArray();
            int TotalPromedio = NumerosSeparados.Sum();

            int Promedio = TotalPromedio / Total;

            string Resultado = Promedio.ToString();

            PromedioResltTextBox.Text = Resultado;
        }

        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            PromedioResltTextBox.Text = "";
            PromedioTextBox.Text = "";
            MedianaResltTextBox.Text = "";
            MedianaTextBox.Text = "";
            ModaResltTextBox.Text = "";
            ModaTextBox.Text = "";
        }

        private void MedianaBTN_Click(object sender, EventArgs e)
        {
            string Values = MedianaTextBox.Text;
            int Total = getLength(Values);

            string[] CapsulaNumeros = Values.Split(",");

            int[] NumerosSeparados = CapsulaNumeros.Select(int.Parse).ToArray();
            Array.Sort(NumerosSeparados);

            double mediana;

            if (Total % 2 == 0)
            {
                // Si hay un número par de elementos, promediamos los dos del medio
                mediana = (NumerosSeparados[Total / 2 - 1] + NumerosSeparados[Total / 2] / 2.0);
            }
            else
            {
                // Si hay un número impar de elementos, la mediana es el valor del medio
                mediana = (NumerosSeparados[Total / 2]);
            }

            MedianaResltTextBox.Text = mediana.ToString();
        }

        private void ModaBTN_Click(object sender, EventArgs e)
        {
            String Values = ModaTextBox.Text;
            int Total = getLength(Values);

            string[] CapsulaNumeros = Values.Split(",");

            int[] NumerosSeparados = CapsulaNumeros.Select(int.Parse).ToArray();

            int Moda = mostFrequent(NumerosSeparados, Total);

            ModaResltTextBox.Text = Moda.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new opciones(userName, userRole).Show();
            this.Close();
        }

     
    }
}
