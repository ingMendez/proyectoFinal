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
        private void Limpiar()
        {
            mercanciaIDNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            nombreProductoTextBox.Clear();
            descripcionComboBox.SelectedIndex = 0;
            CostonumericUpDown.Value = 0;
            precioProductoNumericUpDown.Value = 0;
            cantidadProductoNumericUpDown.Value = 0;
            GanaciatextBox.Clear();
        }

        private bool HayErrores()
        {
            bool paso = false;

            if (String.IsNullOrEmpty(nombreProductoTextBox.Text))
            {
                SuperErrorProvider.SetError(nombreProductoTextBox,
                    "Debe escribir nombre para el Producto");
                paso = true;
            }
            if ( CostonumericUpDown.Value ==0)
            {
                SuperErrorProvider.SetError(CostonumericUpDown,
                    "Debe ingresar un Costo para el Producto");
                paso = true;
            }
            if (precioProductoNumericUpDown.Value ==0)
            {
                SuperErrorProvider.SetError(precioProductoNumericUpDown,
                    "Debe ingresar un Precio para el Producto");
                paso = true;
            }

            return paso;
        }


        private double ToDouble(object valor)
        {
            double.TryParse(valor.ToString(), out double returno);
            return Convert.ToDouble(returno);
        }
        private void CarcularGanacia()
        {
            double costo, precio;
            costo = ToDouble(CostonumericUpDown.Value);
            precio = ToDouble(precioProductoNumericUpDown.Value);
          // GanaciatextBox.Text = MercanciaBLL.PorcientoGanancia(costo, precio).ToString();
        }
        private void MercanciaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(precioProductoNumericUpDown.Value != 0)
            {
                CarcularGanacia();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            /*int id = Convert.ToInt32(mercanciaIDNumericUpDown.Value);
             Mercancia mercancia = MercanciaBLL.Buscar(id);
            */
            Mercancia mercancia;
            bool paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Debe Llenar los Campos Indicados","Vlidacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mercancia = LlenaClase();

            if(mercanciaIDNumericUpDown.Value == 0)
            {
                paso = MercanciaBLL.Guardar(mercancia);
                MessageBox.Show("Guardado!!","Exito", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(mercanciaIDNumericUpDown.Value);
                 mercancia = MercanciaBLL.Buscar(id);
                  
                if(mercancia != null)
                {
                    paso = MercanciaBLL.Modificar(LlenaClase());
                    MessageBox.Show("Modificado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Id no existe", "Falló",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (paso)
            {
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PrecioProductoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (precioProductoNumericUpDown.Value != 0)
            {
                CarcularGanacia();
            }
        }

        private void PrecioProductoNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede digitar Números", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(mercanciaIDNumericUpDown.Value);

            Mercancia mercancia = MercanciaBLL.Buscar(id);
            if (mercancia != null)
            {
                if (MercanciaBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(mercanciaIDNumericUpDown.Value);
            Mercancia mercancia = MercanciaBLL.Buscar(id);

            if (mercancia != null)
            {
                /*epartamentoComboBox.SelectedValue = producto.DepartamentoId;
                DescripcionTextBox.Text = producto.Descripcion;
                CostoTextBox.Text = producto.Costo.ToString();
                PrecioTextBox.Text = producto.Precio.ToString();
                PctGananciaTextBox.Text = producto.PorCientoGanancia.ToString();
                InventarioTextBox.Text = producto.CantidadIventario.ToString();*/
               // LlnenaCampo();
            }
        }
    }
}
