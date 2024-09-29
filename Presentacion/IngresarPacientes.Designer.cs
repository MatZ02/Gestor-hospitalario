namespace Presentacion
{
    partial class IngresarPacientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnIngresarPaciente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEps = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.groupBox1.Controls.Add(this.TxtEps);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtGenero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtApellido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtEdad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnRegresar);
            this.groupBox1.Controls.Add(this.BtnIngresarPaciente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(350, 287);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(110, 33);
            this.BtnRegresar.TabIndex = 4;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // BtnIngresarPaciente
            // 
            this.BtnIngresarPaciente.Location = new System.Drawing.Point(212, 287);
            this.BtnIngresarPaciente.Name = "BtnIngresarPaciente";
            this.BtnIngresarPaciente.Size = new System.Drawing.Size(110, 33);
            this.BtnIngresarPaciente.TabIndex = 2;
            this.BtnIngresarPaciente.Text = "Ingresar ";
            this.BtnIngresarPaciente.UseVisualStyleBackColor = true;
            this.BtnIngresarPaciente.Click += new System.EventHandler(this.BtnIngresarPaciente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(255, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pacientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(288, 120);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(141, 20);
            this.TxtCodigo.TabIndex = 6;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(288, 198);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(141, 20);
            this.TxtEdad.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edad";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(288, 146);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(141, 20);
            this.TxtNombre.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(208, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(288, 172);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(141, 20);
            this.TxtApellido.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(208, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apellido";
            // 
            // TxtGenero
            // 
            this.TxtGenero.Location = new System.Drawing.Point(288, 224);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(141, 20);
            this.TxtGenero.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(208, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Genero";
            // 
            // TxtEps
            // 
            this.TxtEps.Location = new System.Drawing.Point(288, 250);
            this.TxtEps.Name = "TxtEps";
            this.TxtEps.Size = new System.Drawing.Size(141, 20);
            this.TxtEps.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(208, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Eps";
            // 
            // IngresarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(725, 409);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngresarPacientes";
            this.Text = "IngresarPacientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnIngresarPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEps;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label3;
    }
}