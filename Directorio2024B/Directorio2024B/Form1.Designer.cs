namespace Directorio2024B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            lblCorreo = new Label();
            lblTel = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTel = new TextBox();
            txtCorreo = new TextBox();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dgvDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14F);
            lblNombre.Location = new Point(76, 43);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";            
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14F);
            lblApellido.Location = new Point(76, 118);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 14F);
            lblCorreo.Location = new Point(90, 272);
            lblCorreo.Margin = new Padding(4, 0, 4, 0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(70, 25);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe UI", 14F);
            lblTel.Location = new Point(77, 196);
            lblTel.Margin = new Padding(4, 0, 4, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(84, 25);
            lblTel.TabIndex = 3;
            lblTel.Text = "Teléfono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 46);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(323, 29);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(199, 120);
            txtApellido.Margin = new Padding(4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(323, 29);
            txtApellido.TabIndex = 5;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(199, 199);
            txtTel.Margin = new Padding(4);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(323, 29);
            txtTel.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(199, 274);
            txtCorreo.Margin = new Padding(4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(323, 29);
            txtCorreo.TabIndex = 7;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(255, 192, 255);
            btnNuevo.Location = new Point(617, 46);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 39);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 192, 255);
            btnGuardar.Location = new Point(617, 118);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 39);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 192, 255);
            btnEliminar.Location = new Point(617, 199);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 39);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDatos.Location = new Point(90, 349);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(628, 239);
            dgvDatos.TabIndex = 11;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            dgvDatos.DoubleClick += dataGridView1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(dgvDatos);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCorreo);
            Controls.Add(txtTel);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblTel);
            Controls.Add(lblCorreo);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            DoubleClick += Form1_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblCorreo;
        private Label lblTel;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTel;
        private TextBox txtCorreo;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridView dgvDatos;
    }
}
