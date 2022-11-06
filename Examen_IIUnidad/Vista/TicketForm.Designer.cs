namespace Vista
{
    partial class TicketForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.preciotextBox = new System.Windows.Forms.TextBox();
            this.respuestatextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.solicitudtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tipotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.usuariotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.soportedataGridView = new System.Windows.Forms.DataGridView();
            this.isvtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.descuentotextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.totaltextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guardarButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soportedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.preciotextBox);
            this.groupBox2.Controls.Add(this.respuestatextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.solicitudtextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tipotextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 192);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE";
            // 
            // preciotextBox
            // 
            this.preciotextBox.Location = new System.Drawing.Point(581, 30);
            this.preciotextBox.Name = "preciotextBox";
            this.preciotextBox.Size = new System.Drawing.Size(75, 23);
            this.preciotextBox.TabIndex = 13;
            // 
            // respuestatextBox
            // 
            this.respuestatextBox.Location = new System.Drawing.Point(16, 152);
            this.respuestatextBox.Name = "respuestatextBox";
            this.respuestatextBox.ReadOnly = true;
            this.respuestatextBox.Size = new System.Drawing.Size(639, 23);
            this.respuestatextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "RESPUESTA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(528, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "PRECIO";
            // 
            // solicitudtextBox
            // 
            this.solicitudtextBox.Location = new System.Drawing.Point(16, 95);
            this.solicitudtextBox.Name = "solicitudtextBox";
            this.solicitudtextBox.ReadOnly = true;
            this.solicitudtextBox.Size = new System.Drawing.Size(639, 23);
            this.solicitudtextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "SOLICITUD";
            // 
            // tipotextBox
            // 
            this.tipotextBox.Location = new System.Drawing.Point(147, 30);
            this.tipotextBox.Name = "tipotextBox";
            this.tipotextBox.ReadOnly = true;
            this.tipotextBox.Size = new System.Drawing.Size(287, 23);
            this.tipotextBox.TabIndex = 7;
            this.tipotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipotextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "TIPO DE SOPORTE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientetextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.usuariotextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // clientetextBox
            // 
            this.clientetextBox.Location = new System.Drawing.Point(92, 46);
            this.clientetextBox.Name = "clientetextBox";
            this.clientetextBox.ReadOnly = true;
            this.clientetextBox.Size = new System.Drawing.Size(268, 23);
            this.clientetextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "FECHA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(538, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // usuariotextBox
            // 
            this.usuariotextBox.Location = new System.Drawing.Point(92, 17);
            this.usuariotextBox.Name = "usuariotextBox";
            this.usuariotextBox.ReadOnly = true;
            this.usuariotextBox.Size = new System.Drawing.Size(268, 23);
            this.usuariotextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO";
            // 
            // soportedataGridView
            // 
            this.soportedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soportedataGridView.Location = new System.Drawing.Point(12, 306);
            this.soportedataGridView.Name = "soportedataGridView";
            this.soportedataGridView.RowTemplate.Height = 25;
            this.soportedataGridView.Size = new System.Drawing.Size(671, 150);
            this.soportedataGridView.TabIndex = 7;
            // 
            // isvtextBox
            // 
            this.isvtextBox.Location = new System.Drawing.Point(57, 486);
            this.isvtextBox.Name = "isvtextBox";
            this.isvtextBox.Size = new System.Drawing.Size(72, 23);
            this.isvtextBox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "ISV";
            // 
            // descuentotextBox
            // 
            this.descuentotextBox.Location = new System.Drawing.Point(247, 486);
            this.descuentotextBox.Name = "descuentotextBox";
            this.descuentotextBox.Size = new System.Drawing.Size(70, 23);
            this.descuentotextBox.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 489);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "DESCUENTO";
            // 
            // totaltextBox
            // 
            this.totaltextBox.Location = new System.Drawing.Point(413, 486);
            this.totaltextBox.Name = "totaltextBox";
            this.totaltextBox.Size = new System.Drawing.Size(75, 23);
            this.totaltextBox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "TOTAL";
            // 
            // guardarButton
            // 
            this.guardarButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.guardarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guardarButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.guardarButton.Location = new System.Drawing.Point(593, 478);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(90, 36);
            this.guardarButton.TabIndex = 21;
            this.guardarButton.Text = "GUARDAR";
            this.guardarButton.UseVisualStyleBackColor = false;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 538);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.totaltextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descuentotextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.isvtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.soportedataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soportedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox2;
        private TextBox respuestatextBox;
        private Label label6;
        private TextBox solicitudtextBox;
        private Label label4;
        private TextBox tipotextBox;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox clientetextBox;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox usuariotextBox;
        private Label label1;
        private TextBox preciotextBox;
        private Label label11;
        private DataGridView soportedataGridView;
        private TextBox isvtextBox;
        private Label label9;
        private TextBox descuentotextBox;
        private Label label12;
        private TextBox totaltextBox;
        private Label label7;
        private Button guardarButton;
    }
}