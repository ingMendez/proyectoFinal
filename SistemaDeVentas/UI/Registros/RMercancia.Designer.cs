﻿namespace SistemaDeVentas.UI.Registros
{
    partial class RMercancia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RMercancia));
            System.Windows.Forms.Label cantidadProductoLabel;
            System.Windows.Forms.Label mercanciaIDLabel;
            System.Windows.Forms.Label nombreProductoLabel;
            System.Windows.Forms.Label precioProductoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label label1;
            this.mercanciaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mercanciaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cantidadProductoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mercanciaIDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreProductoTextBox = new System.Windows.Forms.TextBox();
            this.precioProductoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descripcionComboBox = new System.Windows.Forms.ComboBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.AddButon = new System.Windows.Forms.Button();
            this.BusquedacomboBox = new System.Windows.Forms.ComboBox();
            this.SuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mercanciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cantidadProductoLabel = new System.Windows.Forms.Label();
            mercanciaIDLabel = new System.Windows.Forms.Label();
            nombreProductoLabel = new System.Windows.Forms.Label();
            precioProductoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingNavigator)).BeginInit();
            this.mercanciaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProductoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaIDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioProductoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mercanciaBindingNavigator
            // 
            this.mercanciaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mercanciaBindingNavigator.BindingSource = this.mercanciaBindingSource;
            this.mercanciaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mercanciaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mercanciaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mercanciaBindingNavigatorSaveItem});
            this.mercanciaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mercanciaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mercanciaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mercanciaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mercanciaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mercanciaBindingNavigator.Name = "mercanciaBindingNavigator";
            this.mercanciaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mercanciaBindingNavigator.Size = new System.Drawing.Size(309, 25);
            this.mercanciaBindingNavigator.TabIndex = 0;
            this.mercanciaBindingNavigator.Text = "BindingNavigator1";
            this.mercanciaBindingNavigator.RefreshItems += new System.EventHandler(this.MercanciaBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.BindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // mercanciaBindingNavigatorSaveItem
            // 
            this.mercanciaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mercanciaBindingNavigatorSaveItem.Enabled = false;
            this.mercanciaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mercanciaBindingNavigatorSaveItem.Image")));
            this.mercanciaBindingNavigatorSaveItem.Name = "mercanciaBindingNavigatorSaveItem";
            this.mercanciaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mercanciaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cantidadProductoLabel
            // 
            cantidadProductoLabel.AutoSize = true;
            cantidadProductoLabel.Location = new System.Drawing.Point(23, 158);
            cantidadProductoLabel.Name = "cantidadProductoLabel";
            cantidadProductoLabel.Size = new System.Drawing.Size(97, 13);
            cantidadProductoLabel.TabIndex = 1;
            cantidadProductoLabel.Text = "cantidad Producto:";
            // 
            // cantidadProductoNumericUpDown
            // 
            this.cantidadProductoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mercanciaBindingSource, "cantidadProducto", true));
            this.cantidadProductoNumericUpDown.Location = new System.Drawing.Point(121, 156);
            this.cantidadProductoNumericUpDown.Name = "cantidadProductoNumericUpDown";
            this.cantidadProductoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadProductoNumericUpDown.TabIndex = 2;
            // 
            // mercanciaIDLabel
            // 
            mercanciaIDLabel.AutoSize = true;
            mercanciaIDLabel.Location = new System.Drawing.Point(23, 62);
            mercanciaIDLabel.Name = "mercanciaIDLabel";
            mercanciaIDLabel.Size = new System.Drawing.Size(74, 13);
            mercanciaIDLabel.TabIndex = 3;
            mercanciaIDLabel.Text = "Mercancia ID:";
            // 
            // mercanciaIDNumericUpDown
            // 
            this.mercanciaIDNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mercanciaBindingSource, "MercanciaID", true));
            this.mercanciaIDNumericUpDown.Location = new System.Drawing.Point(121, 62);
            this.mercanciaIDNumericUpDown.Name = "mercanciaIDNumericUpDown";
            this.mercanciaIDNumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.mercanciaIDNumericUpDown.TabIndex = 4;
            // 
            // nombreProductoLabel
            // 
            nombreProductoLabel.AutoSize = true;
            nombreProductoLabel.Location = new System.Drawing.Point(26, 96);
            nombreProductoLabel.Name = "nombreProductoLabel";
            nombreProductoLabel.Size = new System.Drawing.Size(93, 13);
            nombreProductoLabel.TabIndex = 5;
            nombreProductoLabel.Text = "Nombre Producto:";
            // 
            // nombreProductoTextBox
            // 
            this.nombreProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mercanciaBindingSource, "NombreProducto", true));
            this.nombreProductoTextBox.Location = new System.Drawing.Point(121, 92);
            this.nombreProductoTextBox.Name = "nombreProductoTextBox";
            this.nombreProductoTextBox.Size = new System.Drawing.Size(120, 20);
            this.nombreProductoTextBox.TabIndex = 6;
            // 
            // precioProductoLabel
            // 
            precioProductoLabel.AutoSize = true;
            precioProductoLabel.Location = new System.Drawing.Point(23, 194);
            precioProductoLabel.Name = "precioProductoLabel";
            precioProductoLabel.Size = new System.Drawing.Size(85, 13);
            precioProductoLabel.TabIndex = 7;
            precioProductoLabel.Text = "precio Producto:";
            // 
            // precioProductoNumericUpDown
            // 
            this.precioProductoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mercanciaBindingSource, "precioProducto", true));
            this.precioProductoNumericUpDown.Location = new System.Drawing.Point(121, 194);
            this.precioProductoNumericUpDown.Name = "precioProductoNumericUpDown";
            this.precioProductoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.precioProductoNumericUpDown.TabIndex = 8;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(23, 122);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 9;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionComboBox
            // 
            this.descripcionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mercanciaBindingSource, "Descripcion", true));
            this.descripcionComboBox.FormattingEnabled = true;
            this.descripcionComboBox.Location = new System.Drawing.Point(121, 119);
            this.descripcionComboBox.Name = "descripcionComboBox";
            this.descripcionComboBox.Size = new System.Drawing.Size(121, 21);
            this.descripcionComboBox.TabIndex = 10;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(224, 259);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(51, 36);
            this.Eliminarbutton.TabIndex = 14;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(121, 259);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(57, 36);
            this.Guardarbutton.TabIndex = 13;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(32, 259);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(57, 36);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(246, 49);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(51, 39);
            this.Buscarbutton.TabIndex = 15;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // AddButon
            // 
            this.AddButon.Location = new System.Drawing.Point(248, 119);
            this.AddButon.Name = "AddButon";
            this.AddButon.Size = new System.Drawing.Size(33, 21);
            this.AddButon.TabIndex = 16;
            this.AddButon.Text = "+";
            this.AddButon.UseVisualStyleBackColor = true;
            this.AddButon.Click += new System.EventHandler(this.AddButon_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 13);
            label1.TabIndex = 17;
            label1.Text = "Opcion de Busqueda";
            // 
            // BusquedacomboBox
            // 
            this.BusquedacomboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mercanciaBindingSource, "Descripcion", true));
            this.BusquedacomboBox.FormattingEnabled = true;
            this.BusquedacomboBox.Items.AddRange(new object[] {
            "",
            "por ID",
            "por Nombre",
            " por Precio"});
            this.BusquedacomboBox.Location = new System.Drawing.Point(144, 33);
            this.BusquedacomboBox.Name = "BusquedacomboBox";
            this.BusquedacomboBox.Size = new System.Drawing.Size(96, 21);
            this.BusquedacomboBox.TabIndex = 18;
            // 
            // SuperErrorProvider
            // 
            this.SuperErrorProvider.ContainerControl = this;
            // 
            // mercanciaBindingSource
            // 
            this.mercanciaBindingSource.DataSource = typeof(SistemaDeVentas.Entidades.Mercancia);
            // 
            // RMercancia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 311);
            this.Controls.Add(label1);
            this.Controls.Add(this.BusquedacomboBox);
            this.Controls.Add(this.AddButon);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionComboBox);
            this.Controls.Add(precioProductoLabel);
            this.Controls.Add(this.precioProductoNumericUpDown);
            this.Controls.Add(nombreProductoLabel);
            this.Controls.Add(this.nombreProductoTextBox);
            this.Controls.Add(mercanciaIDLabel);
            this.Controls.Add(this.mercanciaIDNumericUpDown);
            this.Controls.Add(cantidadProductoLabel);
            this.Controls.Add(this.cantidadProductoNumericUpDown);
            this.Controls.Add(this.mercanciaBindingNavigator);
            this.Name = "RMercancia";
            this.Text = "RMercancia";
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingNavigator)).EndInit();
            this.mercanciaBindingNavigator.ResumeLayout(false);
            this.mercanciaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadProductoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaIDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioProductoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mercanciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mercanciaBindingSource;
        private System.Windows.Forms.BindingNavigator mercanciaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton mercanciaBindingNavigatorSaveItem;
        private System.Windows.Forms.NumericUpDown cantidadProductoNumericUpDown;
        private System.Windows.Forms.NumericUpDown mercanciaIDNumericUpDown;
        private System.Windows.Forms.TextBox nombreProductoTextBox;
        private System.Windows.Forms.NumericUpDown precioProductoNumericUpDown;
        private System.Windows.Forms.ComboBox descripcionComboBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button AddButon;
        private System.Windows.Forms.ComboBox BusquedacomboBox;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider;
    }
}