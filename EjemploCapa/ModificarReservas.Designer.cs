
namespace EjemploCapa
{
    partial class ModificarReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarReservas));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DGServicios = new System.Windows.Forms.DataGridView();
            this.FechadeReserva = new System.Windows.Forms.TextBox();
            this.IDServicio = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.veterinariaDataSet = new EjemploCapa.VeterinariaDataSet();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioTableAdapter = new EjemploCapa.VeterinariaDataSetTableAdapters.ServicioTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Detalle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Servicios Disponibles";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha de Reserva";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DGServicios);
            this.groupBox1.Controls.Add(this.FechadeReserva);
            this.groupBox1.Controls.Add(this.IDServicio);
            this.groupBox1.Controls.Add(this.txtDetalle);
            this.groupBox1.Location = new System.Drawing.Point(260, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(816, 490);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 29;
            // 
            // DGServicios
            // 
            this.DGServicios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGServicios.Location = new System.Drawing.Point(23, 121);
            this.DGServicios.Margin = new System.Windows.Forms.Padding(4);
            this.DGServicios.Name = "DGServicios";
            this.DGServicios.Size = new System.Drawing.Size(751, 289);
            this.DGServicios.TabIndex = 31;
            // 
            // FechadeReserva
            // 
            this.FechadeReserva.Location = new System.Drawing.Point(23, 30);
            this.FechadeReserva.Margin = new System.Windows.Forms.Padding(4);
            this.FechadeReserva.Name = "FechadeReserva";
            this.FechadeReserva.Size = new System.Drawing.Size(749, 23);
            this.FechadeReserva.TabIndex = 6;
            this.FechadeReserva.Text = "Ej:17/08/21";
            // 
            // IDServicio
            // 
            this.IDServicio.Location = new System.Drawing.Point(23, 434);
            this.IDServicio.Margin = new System.Windows.Forms.Padding(4);
            this.IDServicio.Name = "IDServicio";
            this.IDServicio.Size = new System.Drawing.Size(749, 23);
            this.IDServicio.TabIndex = 3;
            this.IDServicio.TextChanged += new System.EventHandler(this.textServicio_TextChanged);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(23, 66);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(749, 23);
            this.txtDetalle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 23;
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(795, 556);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(139, 63);
            this.Actualizar.TabIndex = 22;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(601, 556);
            this.Borrar.Margin = new System.Windows.Forms.Padding(4);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(139, 63);
            this.Borrar.TabIndex = 21;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(409, 556);
            this.Agregar.Margin = new System.Windows.Forms.Padding(4);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(139, 63);
            this.Agregar.TabIndex = 20;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // veterinariaDataSet
            // 
            this.veterinariaDataSet.DataSetName = "VeterinariaDataSet";
            this.veterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            this.servicioBindingSource.DataSource = this.veterinariaDataSet;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 449);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Ingrese el ID del Servicio";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ModificarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1112, 650);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Agregar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModificarReservas";
            this.Text = "Administrar Reservas";
            this.Load += new System.EventHandler(this.ModificarReservas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IDServicio;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Agregar;
        private VeterinariaDataSet veterinariaDataSet;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private VeterinariaDataSetTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.TextBox FechadeReserva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGServicios;
        private System.Windows.Forms.Label label8;
    }
}