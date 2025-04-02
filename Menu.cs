using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Yu_Gi_Oh
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void botonDuelo_Click(object sender, EventArgs e)
        {
            Form1 Duelo = new Form1();
            Duelo.Show();
            this.Hide();
        }

        private void botonMazos_Click(object sender, EventArgs e)
        {
            CualMazo cualMazo = new CualMazo();
            cualMazo.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
