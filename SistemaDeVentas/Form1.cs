using SistemaDeVentas.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/// <summary>
/// https://github.com/ingMendez/proyectoFinal.git
/// </summary>
namespace SistemaDeVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RMercancia rm = new RMercancia();
            rm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RFacturacion f = new RFacturacion();
            f.ShowDialog();
        }
    }
}
