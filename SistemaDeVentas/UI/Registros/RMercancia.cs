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
    public partial class RMercancia : Form
    {
        public RMercancia()
        {
            InitializeComponent();
            LlenarComboBox();
        }
        private void LlenarComboBox()
        {
            RepositorioBase<Tipo> tipos = new RepositorioBase<Tipo>(new Contexto());
            descripcionComboBox.DataSource = tipos.GetList(c => true);
            descripcionComboBox.ValueMember = "IdTipo";
            descripcionComboBox.DisplayMember = "descripcion";
        }

        private  Mercancia LlenaClase()
        {
            Mercancia merca = new Mercancia
            {
                MercanciaID = Convert.ToInt32(mercanciaIDNumericUpDown.Value),
                IdTipo = Convert.ToInt32(descripcionComboBox.SelectedValue),
                FechaVencimiento = FechaDateTimePicker.Value,
                NombreProducto = nombreProductoTextBox.Text,
                PrecioProducto = Convert.ToDouble(precioProductoNumericUpDown.Value),
                CantidadProducto = Convert.ToInt32(cantidadProductoNumericUpDown.Value),
                PorCientoGanancia = Convert.ToDouble(GanaciatextBox.Text),
                Costo = Convert.ToDouble(CostonumericUpDown.Value)
            };
            return merca;
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void AddButon_Click(object sender, EventArgs e)
        {
            RTipMercancia r = new  RTipMercancia();
            r.ShowDialog();
            LlenarComboBox();
        }

        internal void ShowDialong()
        {
            throw new NotImplementedException();
        }

        private void MercanciaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }
    }
}
