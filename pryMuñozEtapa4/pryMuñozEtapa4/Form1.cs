using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace pryMuñozEtapa4
{
    public partial class Form1 : Form
    {

        private List<string> listaVehiculos = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdAuto_Click(object sender, EventArgs e)
        {
            listaVehiculos.Add("Auto");
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            lstVehiculos.Items.Clear();
            foreach (string vehiculo in listaVehiculos)
            {
                lstVehiculos.Items.Add(vehiculo);
            }

        }

        private void cmdAvion_Click(object sender, EventArgs e)
        {
            listaVehiculos.Add("Avión");
        }

        private void cmdBarco_Click(object sender, EventArgs e)
        {
            listaVehiculos.Add("Barco");
        }
    }
}
