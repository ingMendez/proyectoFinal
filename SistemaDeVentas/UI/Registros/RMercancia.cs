﻿using System;
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
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void AddButon_Click(object sender, EventArgs e)
        {
            RTipMercancia r = new  RTipMercancia();
            r.ShowDialog();
        }

        private void MercanciaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
