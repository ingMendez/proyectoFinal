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
                descripcion = DescripciontextBox.Text
            };
            return tipos;
        }
        private void LlenaCampo(Tipo tipos)
        {
            TipoIDnumericUpDown.Value = tipos.IdTipo;
            DescripciontextBox.Text = tipos.descripcion;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Tipo>(new Contexto());
            Tipo tipos = repositorio.Buscar((int)TipoIDnumericUpDown.Value);
            return (tipos != null);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }
    }
}
