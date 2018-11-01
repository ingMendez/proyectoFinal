using SistemaDeVentas.BLL;
using SistemaDeVentas.DAL;
using SistemaDeVentas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaDeVentas.UI.Registros
{
    public partial class RFacturacion : Form
    {
        public RFacturacion()
        {
            InitializeComponent();
            LlenarCombobox();
            CargarUsuario();
        }
        private void LlenarCombobox()
        {
           // Repositorio<Cliente> CliRepositorio = new Repositorio<Cliente>(new Contexto());
            RepositorioBase<Mercancia> merca = new RepositorioBase<Mercancia>(new Contexto());
            ProductoComboBox.DataSource = merca.GetList(c => true);
            ProductoComboBox.ValueMember = "MercanciaID";
            ProductoComboBox.DisplayMember = "Descripcion";
        }
        private void CargarUsuario()
        {
            UsuarioTextBox.DataBindings.Clear();
            var Usuario = UsuarioBLL.GetList(c => true);
            Binding doBinding = new Binding("Text", Usuario, "Nombres");

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
