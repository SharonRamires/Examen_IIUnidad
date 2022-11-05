namespace Vista
{
    partial class UsuariosForm
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
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.modificarbutton = new System.Windows.Forms.Button();
            this.usuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.estaactivocheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rolcomboBox = new System.Windows.Forms.ComboBox();
            this.clavetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(411, 192);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(72, 28);
            this.cancelarbutton.TabIndex = 35;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(333, 192);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(72, 28);
            this.eliminarbutton.TabIndex = 34;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Location = new System.Drawing.Point(255, 192);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(72, 28);
            this.guardarbutton.TabIndex = 33;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // modificarbutton
            // 
            this.modificarbutton.Location = new System.Drawing.Point(177, 192);
            this.modificarbutton.Name = "modificarbutton";
            this.modificarbutton.Size = new System.Drawing.Size(72, 28);
            this.modificarbutton.TabIndex = 32;
            this.modificarbutton.Text = "Modificar";
            this.modificarbutton.UseVisualStyleBackColor = true;
            this.modificarbutton.Click += new System.EventHandler(this.modificarbutton_Click);
            // 
            // usuariosdataGridView
            // 
            this.usuariosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosdataGridView.Location = new System.Drawing.Point(35, 236);
            this.usuariosdataGridView.Name = "usuariosdataGridView";
            this.usuariosdataGridView.RowTemplate.Height = 25;
            this.usuariosdataGridView.Size = new System.Drawing.Size(533, 119);
            this.usuariosdataGridView.TabIndex = 31;
            // 
            // nuevobutton
            // 
            this.nuevobutton.Location = new System.Drawing.Point(99, 192);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(72, 28);
            this.nuevobutton.TabIndex = 30;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // estaactivocheckBox
            // 
            this.estaactivocheckBox.AutoSize = true;
            this.estaactivocheckBox.Enabled = false;
            this.estaactivocheckBox.Location = new System.Drawing.Point(168, 141);
            this.estaactivocheckBox.Name = "estaactivocheckBox";
            this.estaactivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.estaactivocheckBox.TabIndex = 29;
            this.estaactivocheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Esta Activo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Rol";
            // 
            // rolcomboBox
            // 
            this.rolcomboBox.Enabled = false;
            this.rolcomboBox.FormattingEnabled = true;
            this.rolcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.rolcomboBox.Location = new System.Drawing.Point(168, 112);
            this.rolcomboBox.Name = "rolcomboBox";
            this.rolcomboBox.Size = new System.Drawing.Size(202, 23);
            this.rolcomboBox.TabIndex = 26;
            // 
            // clavetextBox
            // 
            this.clavetextBox.Enabled = false;
            this.clavetextBox.Location = new System.Drawing.Point(170, 83);
            this.clavetextBox.Name = "clavetextBox";
            this.clavetextBox.PasswordChar = '*';
            this.clavetextBox.Size = new System.Drawing.Size(200, 23);
            this.clavetextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Clave";
            // 
            // nombretextBox
            // 
            this.nombretextBox.Enabled = false;
            this.nombretextBox.Location = new System.Drawing.Point(170, 52);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(200, 23);
            this.nombretextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // codigotextBox
            // 
            this.codigotextBox.Enabled = false;
            this.codigotextBox.Location = new System.Drawing.Point(170, 21);
            this.codigotextBox.Name = "codigotextBox";
            this.codigotextBox.Size = new System.Drawing.Size(200, 23);
            this.codigotextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Codigo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 367);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.modificarbutton);
            this.Controls.Add(this.usuariosdataGridView);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.estaactivocheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rolcomboBox);
            this.Controls.Add(this.clavetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigotextBox);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelarbutton;
        private Button eliminarbutton;
        private Button guardarbutton;
        private Button modificarbutton;
        private DataGridView usuariosdataGridView;
        private Button nuevobutton;
        private CheckBox estaactivocheckBox;
        private Label label6;
        private Label label5;
        private ComboBox rolcomboBox;
        private TextBox clavetextBox;
        private Label label3;
        private TextBox nombretextBox;
        private Label label2;
        private TextBox codigotextBox;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}