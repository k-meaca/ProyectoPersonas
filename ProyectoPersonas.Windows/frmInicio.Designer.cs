
namespace ProyectoPersonas.Windows
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.sexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmboxFiltrarPorSexo = new System.Windows.Forms.ToolStripComboBox();
            this.localidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmboxFiltrarPorLocalidad = new System.Windows.Forms.ToolStripComboBox();
            this.btnOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.paginasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrdenarAscendenteEdad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrdenarDescendenteEdad = new System.Windows.Forms.ToolStripMenuItem();
            this.porApellidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrdenarAscendenteApellido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrdenarDescendenteApellido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCantidadPersonas = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datosPersonas = new System.Windows.Forms.DataGridView();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrimerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 69);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.btnFiltrar,
            this.btnOrdenar,
            this.btnActualizar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(12, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(753, 69);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ProyectoPersonas.Windows.Properties.Resources.plus;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 66);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ProyectoPersonas.Windows.Properties.Resources.pencil;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(44, 66);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::ProyectoPersonas.Windows.Properties.Resources.remove;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(54, 66);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sexoToolStripMenuItem,
            this.localidadToolStripMenuItem});
            this.btnFiltrar.Image = global::ProyectoPersonas.Windows.Properties.Resources.filter;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(53, 66);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sexoToolStripMenuItem
            // 
            this.sexoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmboxFiltrarPorSexo});
            this.sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            this.sexoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sexoToolStripMenuItem.Text = "Por Sexo";
            // 
            // cmboxFiltrarPorSexo
            // 
            this.cmboxFiltrarPorSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxFiltrarPorSexo.Name = "cmboxFiltrarPorSexo";
            this.cmboxFiltrarPorSexo.Size = new System.Drawing.Size(180, 23);
            this.cmboxFiltrarPorSexo.SelectedIndexChanged += new System.EventHandler(this.cmboxFiltrarPorSexo_SelectedIndexChanged);
            // 
            // localidadToolStripMenuItem
            // 
            this.localidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmboxFiltrarPorLocalidad});
            this.localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            this.localidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localidadToolStripMenuItem.Text = "Por Localidad";
            // 
            // cmboxFiltrarPorLocalidad
            // 
            this.cmboxFiltrarPorLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxFiltrarPorLocalidad.Name = "cmboxFiltrarPorLocalidad";
            this.cmboxFiltrarPorLocalidad.Size = new System.Drawing.Size(180, 23);
            this.cmboxFiltrarPorLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmboxFiltrarPorLocalidad_SelectedIndexChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginasToolStripMenuItem,
            this.porApellidoToolStripMenuItem});
            this.btnOrdenar.Image = global::ProyectoPersonas.Windows.Properties.Resources.sort;
            this.btnOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(63, 66);
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // paginasToolStripMenuItem
            // 
            this.paginasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOrdenarAscendenteEdad,
            this.btnOrdenarDescendenteEdad});
            this.paginasToolStripMenuItem.Name = "paginasToolStripMenuItem";
            this.paginasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.paginasToolStripMenuItem.Text = "Por Edad";
            // 
            // btnOrdenarAscendenteEdad
            // 
            this.btnOrdenarAscendenteEdad.Name = "btnOrdenarAscendenteEdad";
            this.btnOrdenarAscendenteEdad.Size = new System.Drawing.Size(142, 22);
            this.btnOrdenarAscendenteEdad.Text = "Ascendente";
            this.btnOrdenarAscendenteEdad.Click += new System.EventHandler(this.btnOrdenarAscendenteEdad_Click);
            // 
            // btnOrdenarDescendenteEdad
            // 
            this.btnOrdenarDescendenteEdad.Name = "btnOrdenarDescendenteEdad";
            this.btnOrdenarDescendenteEdad.Size = new System.Drawing.Size(142, 22);
            this.btnOrdenarDescendenteEdad.Text = "Descendente";
            this.btnOrdenarDescendenteEdad.Click += new System.EventHandler(this.btnOrdenarDescendenteEdad_Click);
            // 
            // porApellidoToolStripMenuItem
            // 
            this.porApellidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOrdenarAscendenteApellido,
            this.btnOrdenarDescendenteApellido});
            this.porApellidoToolStripMenuItem.Name = "porApellidoToolStripMenuItem";
            this.porApellidoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.porApellidoToolStripMenuItem.Text = "Por Apellido";
            // 
            // btnOrdenarAscendenteApellido
            // 
            this.btnOrdenarAscendenteApellido.Name = "btnOrdenarAscendenteApellido";
            this.btnOrdenarAscendenteApellido.Size = new System.Drawing.Size(142, 22);
            this.btnOrdenarAscendenteApellido.Text = "Ascendente";
            this.btnOrdenarAscendenteApellido.Click += new System.EventHandler(this.btnOrdenarAscendenteApellido_Click);
            // 
            // btnOrdenarDescendenteApellido
            // 
            this.btnOrdenarDescendenteApellido.Name = "btnOrdenarDescendenteApellido";
            this.btnOrdenarDescendenteApellido.Size = new System.Drawing.Size(142, 22);
            this.btnOrdenarDescendenteApellido.Text = "Descendente";
            this.btnOrdenarDescendenteApellido.Click += new System.EventHandler(this.btnOrdenarDescendenteApellido_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::ProyectoPersonas.Windows.Properties.Resources.refresh;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(63, 66);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoPersonas.Windows.Properties.Resources.exit;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 66);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 69);
            this.panel5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblCantidadPersonas);
            this.panel2.Controls.Add(this.lblCantidad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 32);
            this.panel2.TabIndex = 1;
            // 
            // lblCantidadPersonas
            // 
            this.lblCantidadPersonas.AutoSize = true;
            this.lblCantidadPersonas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCantidadPersonas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonas.Location = new System.Drawing.Point(171, 9);
            this.lblCantidadPersonas.Name = "lblCantidadPersonas";
            this.lblCantidadPersonas.Size = new System.Drawing.Size(23, 15);
            this.lblCantidadPersonas.TabIndex = 1;
            this.lblCantidadPersonas.Text = "Nº";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 10);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(155, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "PERSONAS MOSTRADAS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 349);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(753, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 349);
            this.panel4.TabIndex = 3;
            // 
            // datosPersonas
            // 
            this.datosPersonas.AllowUserToAddRows = false;
            this.datosPersonas.AllowUserToDeleteRows = false;
            this.datosPersonas.AllowUserToResizeColumns = false;
            this.datosPersonas.AllowUserToResizeRows = false;
            this.datosPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colApellido,
            this.colPrimerNombre,
            this.colSegundoNombre,
            this.colDNI,
            this.colEdad,
            this.colSexo,
            this.colLocalidad});
            this.datosPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datosPersonas.Location = new System.Drawing.Point(12, 69);
            this.datosPersonas.MultiSelect = false;
            this.datosPersonas.Name = "datosPersonas";
            this.datosPersonas.ReadOnly = true;
            this.datosPersonas.RowHeadersVisible = false;
            this.datosPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosPersonas.Size = new System.Drawing.Size(741, 349);
            this.datosPersonas.TabIndex = 4;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            this.colApellido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPrimerNombre
            // 
            this.colPrimerNombre.HeaderText = "Primer Nombre";
            this.colPrimerNombre.Name = "colPrimerNombre";
            this.colPrimerNombre.ReadOnly = true;
            this.colPrimerNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSegundoNombre
            // 
            this.colSegundoNombre.HeaderText = "Segundo Nombre";
            this.colSegundoNombre.Name = "colSegundoNombre";
            this.colSegundoNombre.ReadOnly = true;
            this.colSegundoNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDNI
            // 
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            this.colDNI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEdad
            // 
            this.colEdad.HeaderText = "Edad";
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            this.colEdad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLocalidad
            // 
            this.colLocalidad.HeaderText = "Localidad";
            this.colLocalidad.Name = "colLocalidad";
            this.colLocalidad.ReadOnly = true;
            this.colLocalidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.ControlBox = false;
            this.Controls.Add(this.datosPersonas);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINAL";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCantidadPersonas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView datosPersonas;
        private System.Windows.Forms.ToolStripDropDownButton btnFiltrar;
        private System.Windows.Forms.ToolStripMenuItem localidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton btnOrdenar;
        private System.Windows.Forms.ToolStripMenuItem paginasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmboxFiltrarPorSexo;
        private System.Windows.Forms.ToolStripComboBox cmboxFiltrarPorLocalidad;
        private System.Windows.Forms.ToolStripMenuItem btnOrdenarAscendenteEdad;
        private System.Windows.Forms.ToolStripMenuItem btnOrdenarDescendenteEdad;
        private System.Windows.Forms.ToolStripMenuItem porApellidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOrdenarAscendenteApellido;
        private System.Windows.Forms.ToolStripMenuItem btnOrdenarDescendenteApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrimerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalidad;
    }
}

