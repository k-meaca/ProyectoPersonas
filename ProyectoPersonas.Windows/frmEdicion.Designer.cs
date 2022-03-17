
namespace ProyectoPersonas.Windows
{
    partial class frmEdicion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAceptar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpckFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.mostradorErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.descriptor = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmboxSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cmboxLocalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostradorErrores)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 312);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 35);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAceptar,
            this.btnEditar,
            this.btnCancelar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(355, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 19);
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 19);
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 19);
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 277);
            this.panel3.TabIndex = 2;
            // 
            // dtpckFecha
            // 
            this.dtpckFecha.Location = new System.Drawing.Point(142, 7);
            this.dtpckFecha.Name = "dtpckFecha";
            this.dtpckFecha.Size = new System.Drawing.Size(201, 20);
            this.dtpckFecha.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(8, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "FECHA";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtApellido);
            this.panel10.Controls.Add(this.lblApellido);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(355, 38);
            this.panel10.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(142, 6);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(201, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(8, 13);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(67, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "APELLIDO";
            // 
            // mostradorErrores
            // 
            this.mostradorErrores.ContainerControl = this;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPrimerNombre);
            this.panel4.Controls.Add(this.lblPrimerNombre);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 38);
            this.panel4.TabIndex = 1;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(142, 10);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(201, 20);
            this.txtPrimerNombre.TabIndex = 1;
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerNombre_KeyPress);
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(8, 13);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(112, 13);
            this.lblPrimerNombre.TabIndex = 0;
            this.lblPrimerNombre.Text = "PRIMER NOMBRE";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSegundoNombre);
            this.panel5.Controls.Add(this.lblSegundoNombre);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 38);
            this.panel5.TabIndex = 2;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(142, 10);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(201, 20);
            this.txtSegundoNombre.TabIndex = 1;
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(8, 13);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(125, 13);
            this.lblSegundoNombre.TabIndex = 0;
            this.lblSegundoNombre.Text = "SEGUNDO NOMBRE";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtDNI);
            this.panel6.Controls.Add(this.lblDNI);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 114);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(355, 38);
            this.panel6.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(142, 10);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(201, 20);
            this.txtDNI.TabIndex = 1;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(8, 13);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpckFecha);
            this.panel7.Controls.Add(this.lblFecha);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 152);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(355, 38);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cmboxSexo);
            this.panel8.Controls.Add(this.lblSexo);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 190);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(355, 38);
            this.panel8.TabIndex = 6;
            // 
            // cmboxSexo
            // 
            this.cmboxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxSexo.FormattingEnabled = true;
            this.cmboxSexo.Location = new System.Drawing.Point(142, 10);
            this.cmboxSexo.Name = "cmboxSexo";
            this.cmboxSexo.Size = new System.Drawing.Size(201, 21);
            this.cmboxSexo.TabIndex = 0;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(8, 13);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 13);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "SEXO";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cmboxLocalidad);
            this.panel9.Controls.Add(this.lblLocalidad);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 228);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(355, 38);
            this.panel9.TabIndex = 6;
            // 
            // cmboxLocalidad
            // 
            this.cmboxLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxLocalidad.FormattingEnabled = true;
            this.cmboxLocalidad.Location = new System.Drawing.Point(142, 10);
            this.cmboxLocalidad.Name = "cmboxLocalidad";
            this.cmboxLocalidad.Size = new System.Drawing.Size(201, 21);
            this.cmboxLocalidad.TabIndex = 1;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(8, 13);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(76, 13);
            this.lblLocalidad.TabIndex = 1;
            this.lblLocalidad.Text = "LOCALIDAD";
            // 
            // frmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 312);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEdicion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Texto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostradorErrores)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem btnAceptar;
        private System.Windows.Forms.ToolStripMenuItem btnEditar;
        private System.Windows.Forms.ToolStripMenuItem btnCancelar;
        private System.Windows.Forms.ErrorProvider mostradorErrores;
        private System.Windows.Forms.ToolTip descriptor;
        private System.Windows.Forms.DateTimePicker dtpckFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cmboxLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cmboxSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
    }
}