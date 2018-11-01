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
    public partial class RTipMercancia : Form
    {
       private RepositorioBase<Tipo> repositorio;

        public RTipMercancia()
        {
            InitializeComponent();

        }
        private void Limpiar()
        {
            SuperErrorProvider.Clear();
            TipoIDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }
        private Tipo LlenaClase()
        {
            Tipo tipos = new Tipo()
            {
                IdTipo = Convert.ToInt32(TipoIDnumericUpDown.Value),
                Descripcion = DescripciontextBox.Text
            };
            return tipos;
        }
        private void LlenaCampo(Tipo tipos)
        {
            TipoIDnumericUpDown.Value = tipos.IdTipo;
            DescripciontextBox.Text = tipos.Descripcion;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Tipo>(new Contexto());
            Tipo tipos = repositorio.Buscar((int)TipoIDnumericUpDown.Value);
            return (tipos != null);
        }
        private bool GuardarValidar()
        {
            bool paso = true;
            if (string.IsNullOrEmpty(DescripciontextBox.Text))
            {
                SuperErrorProvider.SetError(DescripciontextBox, "El Campo Descripcion No puede Estar Vacio!");
                DescripciontextBox.Focus();
                paso = false;
            }
            return paso;
        }
        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Tipo>(new Contexto());
            Tipo tipos;
            bool paso = false;
            tipos = LlenaClase();
            if (!GuardarValidar())
                return;
            if (TipoIDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(tipos);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar un Tipo de cuenta no Existente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(tipos);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //RCuentas.pas = 1;
                Limpiar();
            }
            else
                MessageBox.Show("No se Guardo el Tipo De Cuenta!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
           // int id;
            repositorio = new RepositorioBase<Tipo>(new Contexto());
            int.TryParse(TipoIDnumericUpDown.Text, out int id);
            Tipo tipos = new Tipo();
            tipos = repositorio.Buscar(id);

            if (tipos != null)
            {
                MessageBox.Show("Tipo de Cuenta Encontrada.!!", "Exito!!!", MessageBoxButtons.OK);
                LlenaCampo(tipos);
            }
            else
                MessageBox.Show("Tipo de Cuenta no Encontrada", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            //int id;
            repositorio = new RepositorioBase<Tipo>(new Contexto());
            int.TryParse(TipoIDnumericUpDown.Text, out int id);
            if (!ExisteEnLaBaseDeDatos())
            {
                SuperErrorProvider.SetError(TipoIDnumericUpDown, "Esta Cuenta No Existe");
                TipoIDnumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Tipo De Cuenta Eliminada!!", "Exitoso!!!", MessageBoxButtons.OK);
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo eliminar El Tipo De Cuenta!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DescripciontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}
