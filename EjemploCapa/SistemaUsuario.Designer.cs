
namespace EjemploCapa
{
    partial class SistemaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaUsuario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.servicios = new System.Windows.Forms.ToolStripMenuItem();
            this.mASCOTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisMascotas = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verMisReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClave = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servicios,
            this.mASCOTAToolStripMenuItem,
            this.reservasToolStripMenuItem1,
            this.cuentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // servicios
            // 
            this.servicios.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.servicios.Name = "servicios";
            this.servicios.Size = new System.Drawing.Size(101, 32);
            this.servicios.Text = "Servicios";
            this.servicios.Click += new System.EventHandler(this.servicios_Click);
            // 
            // mASCOTAToolStripMenuItem
            // 
            this.mASCOTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMisMascotas});
            this.mASCOTAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.mASCOTAToolStripMenuItem.Name = "mASCOTAToolStripMenuItem";
            this.mASCOTAToolStripMenuItem.Size = new System.Drawing.Size(98, 32);
            this.mASCOTAToolStripMenuItem.Text = "Mascota";
            // 
            // verMisMascotas
            // 
            this.verMisMascotas.Name = "verMisMascotas";
            this.verMisMascotas.Size = new System.Drawing.Size(233, 32);
            this.verMisMascotas.Text = "Ver mis mascotas";
            this.verMisMascotas.Click += new System.EventHandler(this.verMisMascotas_Click);
            // 
            // reservasToolStripMenuItem1
            // 
            this.reservasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMisReservas});
            this.reservasToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.reservasToolStripMenuItem1.Name = "reservasToolStripMenuItem1";
            this.reservasToolStripMenuItem1.Size = new System.Drawing.Size(98, 32);
            this.reservasToolStripMenuItem1.Text = "Reservas";
            // 
            // verMisReservas
            // 
            this.verMisReservas.Name = "verMisReservas";
            this.verMisReservas.Size = new System.Drawing.Size(222, 32);
            this.verMisReservas.Text = "Ver mis reservas";
            this.verMisReservas.Click += new System.EventHandler(this.verMisReservas_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarClave,
            this.cerrarSesión});
            this.cuentasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(110, 32);
            this.cuentasToolStripMenuItem.Text = "Mi cuenta";
            // 
            // cambiarClave
            // 
            this.cambiarClave.Name = "cambiarClave";
            this.cambiarClave.Size = new System.Drawing.Size(206, 32);
            this.cambiarClave.Text = "Cambiar clave";
            this.cambiarClave.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // cerrarSesión
            // 
            this.cerrarSesión.Name = "cerrarSesión";
            this.cerrarSesión.Size = new System.Drawing.Size(206, 32);
            this.cerrarSesión.Text = "Cerrar Sesión";
            this.cerrarSesión.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // SistemaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "SistemaUsuario";
            this.Text = "Sistema Usuario";
            this.Load += new System.EventHandler(this.SistemaUsuario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem servicios;
        private System.Windows.Forms.ToolStripMenuItem mASCOTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cambiarClave;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesión;
        private System.Windows.Forms.ToolStripMenuItem verMisMascotas;
        private System.Windows.Forms.ToolStripMenuItem verMisReservas;
    }
}