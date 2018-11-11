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
            RepositorioBase<Cliente> cliente = new RepositorioBase<Cliente>(new Contexto());
            RepositorioBase<Mercancia> merca = new RepositorioBase<Mercancia>(new Contexto());
           
            ProductoComboBox.DataSource = merca.GetList(c => true);
            ProductoComboBox.ValueMember = "MercanciaID";
            ProductoComboBox.DisplayMember = "Descripcion";
            ProductoComboBox.DataSource = cliente.GetList(c => true);
            ProductoComboBox.ValueMember = "ClienteId";
            ProductoComboBox.DisplayMember = "NombreCliente";

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

        private void BuscarButton_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt32(FacturaIdNumericUpDown.Value);
            Factura Factura = FacturaBLL.Buscar(id);

            if(Factura != null)
            {
            //    LlenarCampo(Factura);
            }
            else
            {
                MessageBox.Show("No se encontró!!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenaCampo(Factura factura)
        {
            FacturaIdNumericUpDown.Value = factura.FacturaID;
            ClienteComboBox.SelectedIndex = factura.ClienteId;
            FechaDateTimePicker.Value = factura.Fecha;
            SubTotalTextBox.Text = factura.SubTotal.ToString();
            ItbisTextBox.Text = factura.Itbis.ToString();
            TotalTextBox.Text = factura.Total.ToString();
            FacturaDetalleDataGridView.DataSource = factura.Detalle;
            FacturaDetalleDataGridView.Columns["id"].Visible = false;
            FacturaDetalleDataGridView.Columns["FacturaID"].Visible = false;

        }
    }

   
}
