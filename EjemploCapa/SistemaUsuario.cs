using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCapa
{
    public partial class SistemaUsuario : Form
    {
        public int ID_Cliente { get; set; }

        public SistemaUsuario(int ID_Cliente)
        {
            this.ID_Cliente = ID_Cliente;
            InitializeComponent();
        }
      

        private void SistemaUsuario_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        //CUENTA
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarClave CambiarClave = new CambiarClave(this.ID_Cliente);

            CambiarClave.Show();
            //centro la ventana
            CambiarClave.Left = (this.Left + this.Width - CambiarClave.Height) / 2;
            CambiarClave.Left = (this.Top + this.Height - CambiarClave.Width) / 2;
        }

        //MASCOTA
        private void verMisMascotas_Click(object sender, EventArgs e)
        {
            ListarMascotas ListarMascotas = new ListarMascotas(this.ID_Cliente);

            ListarMascotas.Show();
            //centro la ventana
            ListarMascotas.Left = (this.Left + this.Width - ListarMascotas.Height) / 2;
            ListarMascotas.Left = (this.Top + this.Height - ListarMascotas.Width) / 2;
        }


        //RESERVAS
        private void verMisReservas_Click(object sender, EventArgs e)
        {
            ListarReservas ListarReservas = new ListarReservas(this.ID_Cliente);
          
            ListarReservas.Show();
            //centro la ventana
            ListarReservas.Left = (this.Left + this.Width - ListarReservas.Height) / 2;
            ListarReservas.Left = (this.Top + this.Height - ListarReservas.Width) / 2;

        }


        //SERVICIOS
        private void servicios_Click(object sender, EventArgs e)
        {
            ListarServicios ListarServicios = new ListarServicios();
            ListarServicios.MdiParent = this;
            ListarServicios.Show();
            //centro la ventana
            ListarServicios.Left = (this.Left + this.Width - ListarServicios.Height) / 2;
            ListarServicios.Left = (this.Top + this.Height - ListarServicios.Width) / 2;
        }
    }
}
