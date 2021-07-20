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
   
    public partial class Veterinaria : Form
    {
        
        public Veterinaria()
        {
            InitializeComponent();
        }
      

        private void Veterinaria_Load(object sender, EventArgs e)
        {

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //maximizo el fomrulario principal

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarSesion IniciarSesion = new IniciarSesion();
          
            IniciarSesion.Show();
            //centro la ventana
            IniciarSesion.Left = (this.Left + this.Width - IniciarSesion.Height) / 2;
            IniciarSesion.Left = (this.Top + this.Height - IniciarSesion.Width) / 2;

           
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrarse Registrarse = new Registrarse();
            Registrarse.MdiParent = this;
            Registrarse.Show();
            //centro la ventana
            Registrarse.Left = (this.Left + this.Width - Registrarse.Height) / 2;
            Registrarse.Left = (this.Top + this.Height - Registrarse.Width) / 2;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
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
