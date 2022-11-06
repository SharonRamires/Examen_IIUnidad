namespace Vista
{
    partial class SoporteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoporteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipotextBox = new System.Windows.Forms.TextBox();
            this.soluciontextBox = new System.Windows.Forms.TextBox();
            this.descripciontextBox = new System.Windows.Forms.TextBox();
            this.preciotextBox = new System.Windows.Forms.TextBox();
            this.soportesdataGridView = new System.Windows.Forms.DataGridView();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.modificarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.soportesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE SOPORTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPCION ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(48, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOLUCION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRECIO";
            // 
            // tipotextBox
            // 
            this.tipotextBox.Location = new System.Drawing.Point(159, 8);
            this.tipotextBox.Name = "tipotextBox";
            this.tipotextBox.Size = new System.Drawing.Size(182, 23);
            this.tipotextBox.TabIndex = 4;
            // 
            // soluciontextBox
            // 
            this.soluciontextBox.Location = new System.Drawing.Point(159, 70);
            this.soluciontextBox.Name = "soluciontextBox";
            this.soluciontextBox.Size = new System.Drawing.Size(368, 23);
            this.soluciontextBox.TabIndex = 5;
            // 
            // descripciontextBox
            // 
            this.descripciontextBox.Location = new System.Drawing.Point(159, 39);
            this.descripciontextBox.Name = "descripciontextBox";
            this.descripciontextBox.Size = new System.Drawing.Size(368, 23);
            this.descripciontextBox.TabIndex = 6;
            // 
            // preciotextBox
            // 
            this.preciotextBox.Location = new System.Drawing.Point(159, 101);
            this.preciotextBox.Name = "preciotextBox";
            this.preciotextBox.Size = new System.Drawing.Size(132, 23);
            this.preciotextBox.TabIndex = 7;
            // 
            // soportesdataGridView
            // 
            this.soportesdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soportesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soportesdataGridView.Location = new System.Drawing.Point(30, 229);
            this.soportesdataGridView.Name = "soportesdataGridView";
            this.soportesdataGridView.RowTemplate.Height = 25;
            this.soportesdataGridView.Size = new System.Drawing.Size(673, 153);
            this.soportesdataGridView.TabIndex = 30;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(494, 186);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(72, 28);
            this.cancelarbutton.TabIndex = 29;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(416, 186);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(72, 28);
            this.eliminarbutton.TabIndex = 28;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Location = new System.Drawing.Point(338, 186);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(72, 28);
            this.guardarbutton.TabIndex = 27;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // modificarbutton
            // 
            this.modificarbutton.Location = new System.Drawing.Point(260, 186);
            this.modificarbutton.Name = "modificarbutton";
            this.modificarbutton.Size = new System.Drawing.Size(72, 28);
            this.modificarbutton.TabIndex = 26;
            this.modificarbutton.Text = "Modificar";
            this.modificarbutton.UseVisualStyleBackColor = true;
            this.modificarbutton.Click += new System.EventHandler(this.modificarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Location = new System.Drawing.Point(182, 186);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(72, 28);
            this.nuevobutton.TabIndex = 25;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(570, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 130);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SoporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.soportesdataGridView);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.modificarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.preciotextBox);
            this.Controls.Add(this.descripciontextBox);
            this.Controls.Add(this.soluciontextBox);
            this.Controls.Add(this.tipotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SoporteForm";
            this.Text = "SoporteForm";
            this.Load += new System.EventHandler(this.SoporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soportesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tipotextBox;
        private TextBox soluciontextBox;
        private TextBox descripciontextBox;
        private TextBox preciotextBox;
        private DataGridView soportesdataGridView;
        private Button cancelarbutton;
        private Button eliminarbutton;
        private Button guardarbutton;
        private Button modificarbutton;
        private Button nuevobutton;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
    }
}