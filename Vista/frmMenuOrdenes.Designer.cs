namespace Vista
{
    partial class frmMenuOrdenes
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
            this.dgvClien = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtidclient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescri = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInform = new System.Windows.Forms.Button();
            this.btnEnviarOrdenes = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClien
            // 
            this.dgvClien.AllowUserToAddRows = false;
            this.dgvClien.AllowUserToDeleteRows = false;
            this.dgvClien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColFecha,
            this.ColEstado,
            this.ColDescripcion});
            this.dgvClien.Location = new System.Drawing.Point(29, 12);
            this.dgvClien.Name = "dgvClien";
            this.dgvClien.ReadOnly = true;
            this.dgvClien.Size = new System.Drawing.Size(409, 164);
            this.dgvClien.TabIndex = 0;
            this.dgvClien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClien_CellDoubleClick);
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "ColID";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 73;
            // 
            // ColNombre
            // 
            this.ColNombre.DataPropertyName = "ColNombre";
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 73;
            // 
            // ColFecha
            // 
            this.ColFecha.DataPropertyName = "ColFecha";
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.ReadOnly = true;
            this.ColFecha.Width = 74;
            // 
            // ColEstado
            // 
            this.ColEstado.DataPropertyName = "ColEstado";
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            this.ColEstado.Width = 73;
            // 
            // ColDescripcion
            // 
            this.ColDescripcion.DataPropertyName = "ColDescripcion";
            this.ColDescripcion.HeaderText = "Descripcion";
            this.ColDescripcion.Name = "ColDescripcion";
            this.ColDescripcion.ReadOnly = true;
            this.ColDescripcion.Width = 73;
            // 
            // txtidclient
            // 
            this.txtidclient.Enabled = false;
            this.txtidclient.Location = new System.Drawing.Point(53, 198);
            this.txtidclient.Name = "txtidclient";
            this.txtidclient.Size = new System.Drawing.Size(42, 20);
            this.txtidclient.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion:";
            // 
            // txtDescri
            // 
            this.txtDescri.Location = new System.Drawing.Point(29, 272);
            this.txtDescri.Multiline = true;
            this.txtDescri.Name = "txtDescri";
            this.txtDescri.Size = new System.Drawing.Size(531, 170);
            this.txtDescri.TabIndex = 8;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Abierto",
            "Cerrado"});
            this.cmbEstado.Location = new System.Drawing.Point(377, 232);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(61, 21);
            this.cmbEstado.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(332, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Estado:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(226, 195);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(212, 20);
            this.dtpFecha.TabIndex = 33;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(226, 233);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(276, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(178, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cliente:";
            // 
            // btnInform
            // 
            this.btnInform.BackgroundImage = global::Vista.Properties.Resources.icono_de_la_muestra_información_letra_i_124770027;
            this.btnInform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInform.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInform.Location = new System.Drawing.Point(475, 167);
            this.btnInform.Name = "btnInform";
            this.btnInform.Size = new System.Drawing.Size(60, 51);
            this.btnInform.TabIndex = 37;
            this.btnInform.UseVisualStyleBackColor = true;
            this.btnInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // btnEnviarOrdenes
            // 
            this.btnEnviarOrdenes.BackgroundImage = global::Vista.Properties.Resources.descarga;
            this.btnEnviarOrdenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviarOrdenes.Location = new System.Drawing.Point(507, 97);
            this.btnEnviarOrdenes.Name = "btnEnviarOrdenes";
            this.btnEnviarOrdenes.Size = new System.Drawing.Size(57, 51);
            this.btnEnviarOrdenes.TabIndex = 4;
            this.btnEnviarOrdenes.UseVisualStyleBackColor = true;
            this.btnEnviarOrdenes.Click += new System.EventHandler(this.btnEnviarOrdenes_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::Vista.Properties.Resources._1828843;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(507, 32);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 49);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::Vista.Properties.Resources.pngtree_vector_edit_icon_png_image_313587;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(444, 97);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(57, 51);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.BackgroundImage = global::Vista.Properties.Resources.vector_add_icon;
            this.btnNueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNueva.Location = new System.Drawing.Point(444, 32);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(57, 49);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // frmMenuOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(592, 473);
            this.Controls.Add(this.btnInform);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidclient);
            this.Controls.Add(this.btnEnviarOrdenes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.dgvClien);
            this.Name = "frmMenuOrdenes";
            this.Text = "Listado de ordnes de servicio";
            this.Load += new System.EventHandler(this.frmMenuOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClien;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEnviarOrdenes;
        private System.Windows.Forms.TextBox txtidclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescri;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescripcion;
        private System.Windows.Forms.Button btnInform;
    }
}

