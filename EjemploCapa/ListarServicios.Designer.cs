
namespace EjemploCapa
{
    partial class ListarServicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarServicios));
            this.DGRol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGRol)).BeginInit();
            this.SuspendLayout();
            // 
            // DGRol
            // 
            this.DGRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGRol.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRol.Location = new System.Drawing.Point(56, 82);
            this.DGRol.Name = "DGRol";
            this.DGRol.ReadOnly = true;
            this.DGRol.Size = new System.Drawing.Size(1034, 311);
            this.DGRol.TabIndex = 2;
            this.DGRol.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGRol_CellContentClick);
            // 
            // ListarServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1158, 469);
            this.Controls.Add(this.DGRol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListarServicios";
            this.Text = "Listar Servicios";
            this.Load += new System.EventHandler(this.frmRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGRol;
    }
}