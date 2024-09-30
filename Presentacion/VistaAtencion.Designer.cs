using System;

namespace Presentacion
{
    partial class VistaAtencion
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnEliminarAtencion = new System.Windows.Forms.Button();
            this.BtnMostrarDatos = new System.Windows.Forms.Button();
            this.BtnActualizarAtencion = new System.Windows.Forms.Button();
            this.BtnIngresarAtencion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.TxtCodigoMedico = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtCodigoPaciente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ListaAtencion = new System.Windows.Forms.DataGridView();
            this.CodigoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListaMedicos = new System.Windows.Forms.DataGridView();
            this.ListaPacientes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAtencion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaMedicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.groupBox2.Controls.Add(this.BtnRegresar);
            this.groupBox2.Controls.Add(this.BtnEliminarAtencion);
            this.groupBox2.Controls.Add(this.BtnMostrarDatos);
            this.groupBox2.Controls.Add(this.BtnActualizarAtencion);
            this.groupBox2.Controls.Add(this.BtnIngresarAtencion);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.FechaAtencion);
            this.groupBox2.Controls.Add(this.TxtCodigoMedico);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TxtCodigoPaciente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtConsulta);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtCodigo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ListaAtencion);
            this.groupBox2.Controls.Add(this.ListaMedicos);
            this.groupBox2.Controls.Add(this.ListaPacientes);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(-113, -13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1113, 545);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(224, 405);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(94, 35);
            this.BtnRegresar.TabIndex = 20;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.button6_Click);
            // 
            // BtnEliminarAtencion
            // 
            this.BtnEliminarAtencion.Location = new System.Drawing.Point(179, 364);
            this.BtnEliminarAtencion.Name = "BtnEliminarAtencion";
            this.BtnEliminarAtencion.Size = new System.Drawing.Size(94, 35);
            this.BtnEliminarAtencion.TabIndex = 19;
            this.BtnEliminarAtencion.Text = "Eliminar Atencion";
            this.BtnEliminarAtencion.UseVisualStyleBackColor = true;
            this.BtnEliminarAtencion.Click += new System.EventHandler(this.BtnEliminarAtencion_Click);
            // 
            // BtnMostrarDatos
            // 
            this.BtnMostrarDatos.Location = new System.Drawing.Point(279, 364);
            this.BtnMostrarDatos.Name = "BtnMostrarDatos";
            this.BtnMostrarDatos.Size = new System.Drawing.Size(94, 35);
            this.BtnMostrarDatos.TabIndex = 18;
            this.BtnMostrarDatos.Text = "Mostrar Datos";
            this.BtnMostrarDatos.UseVisualStyleBackColor = true;
            this.BtnMostrarDatos.Click += new System.EventHandler(this.BtnMostrarDatos_Click);
            // 
            // BtnActualizarAtencion
            // 
            this.BtnActualizarAtencion.Location = new System.Drawing.Point(279, 323);
            this.BtnActualizarAtencion.Name = "BtnActualizarAtencion";
            this.BtnActualizarAtencion.Size = new System.Drawing.Size(94, 35);
            this.BtnActualizarAtencion.TabIndex = 17;
            this.BtnActualizarAtencion.Text = "Actualizar Atencion";
            this.BtnActualizarAtencion.UseVisualStyleBackColor = true;
            this.BtnActualizarAtencion.Click += new System.EventHandler(this.BtnActualizarAtencion_Click);
            // 
            // BtnIngresarAtencion
            // 
            this.BtnIngresarAtencion.Location = new System.Drawing.Point(179, 323);
            this.BtnIngresarAtencion.Name = "BtnIngresarAtencion";
            this.BtnIngresarAtencion.Size = new System.Drawing.Size(94, 35);
            this.BtnIngresarAtencion.TabIndex = 16;
            this.BtnIngresarAtencion.Text = "Ingresar Atencion";
            this.BtnIngresarAtencion.UseVisualStyleBackColor = true;
            this.BtnIngresarAtencion.Click += new System.EventHandler(this.BtnIngresarAtencion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FechaAtencion
            // 
            this.FechaAtencion.Location = new System.Drawing.Point(254, 160);
            this.FechaAtencion.Name = "FechaAtencion";
            this.FechaAtencion.Size = new System.Drawing.Size(119, 20);
            this.FechaAtencion.TabIndex = 14;
            // 
            // TxtCodigoMedico
            // 
            this.TxtCodigoMedico.Location = new System.Drawing.Point(254, 266);
            this.TxtCodigoMedico.Name = "TxtCodigoMedico";
            this.TxtCodigoMedico.Size = new System.Drawing.Size(119, 20);
            this.TxtCodigoMedico.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(189, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Medico";
            // 
            // TxtCodigoPaciente
            // 
            this.TxtCodigoPaciente.Location = new System.Drawing.Point(254, 231);
            this.TxtCodigoPaciente.Name = "TxtCodigoPaciente";
            this.TxtCodigoPaciente.Size = new System.Drawing.Size(119, 20);
            this.TxtCodigoPaciente.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(177, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Paciente";
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(254, 196);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(119, 20);
            this.TxtConsulta.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(176, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Consulta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(189, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "fecha";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(254, 125);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(119, 20);
            this.TxtCodigo.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(189, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Codigo";
            // 
            // ListaAtencion
            // 
            this.ListaAtencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAtencion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAtencion,
            this.Fecha,
            this.TipoConsulta,
            this.CodigoPaciente,
            this.CodigoMedico});
            this.ListaAtencion.Location = new System.Drawing.Point(405, 113);
            this.ListaAtencion.Name = "ListaAtencion";
            this.ListaAtencion.Size = new System.Drawing.Size(226, 338);
            this.ListaAtencion.TabIndex = 3;
            // 
            // CodigoAtencion
            // 
            this.CodigoAtencion.HeaderText = "CodigoAtencion";
            this.CodigoAtencion.Name = "CodigoAtencion";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // TipoConsulta
            // 
            this.TipoConsulta.HeaderText = "TipoConsulta";
            this.TipoConsulta.Name = "TipoConsulta";
            // 
            // CodigoPaciente
            // 
            this.CodigoPaciente.HeaderText = "CodigoPaciente";
            this.CodigoPaciente.Name = "CodigoPaciente";
            // 
            // CodigoMedico
            // 
            this.CodigoMedico.HeaderText = "CodigoMedico";
            this.CodigoMedico.Name = "CodigoMedico";
            // 
            // ListaMedicos
            // 
            this.ListaMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaMedicos.Location = new System.Drawing.Point(869, 113);
            this.ListaMedicos.Name = "ListaMedicos";
            this.ListaMedicos.Size = new System.Drawing.Size(226, 338);
            this.ListaMedicos.TabIndex = 2;
            // 
            // ListaPacientes
            // 
            this.ListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPacientes.Location = new System.Drawing.Point(637, 113);
            this.ListaPacientes.Name = "ListaPacientes";
            this.ListaPacientes.Size = new System.Drawing.Size(226, 338);
            this.ListaPacientes.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(69)))), ((int)(((byte)(96)))));
            this.label8.Location = new System.Drawing.Point(398, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 39);
            this.label8.TabIndex = 0;
            this.label8.Text = "Atencion";
            // 
            // VistaAtencion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1012, 544);
            this.Controls.Add(this.groupBox2);
            this.Name = "VistaAtencion";
            this.Text = "VistaAtencion";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAtencion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaMedicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPacientes)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker FechaAtencion;
        private System.Windows.Forms.TextBox TxtCodigoMedico;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtCodigoPaciente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView ListaAtencion;
        private System.Windows.Forms.DataGridView ListaMedicos;
        private System.Windows.Forms.DataGridView ListaPacientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnEliminarAtencion;
        private System.Windows.Forms.Button BtnMostrarDatos;
        private System.Windows.Forms.Button BtnActualizarAtencion;
        private System.Windows.Forms.Button BtnIngresarAtencion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoMedico;
    }
}