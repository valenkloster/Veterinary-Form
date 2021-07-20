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
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            app.appCliente cliente = new app.appCliente(); //creo objeto
            Enti.entiCliente c = new Enti.entiCliente(); //creo objeto 
            Enti.entiCliente aux = new Enti.entiCliente();

            c.Email = txtEmail.Text.ToString();
            c.Clave = txtClave.Text.ToString();

            aux = cliente.Traer(c.Email, c.Clave);

            if (aux.Email != null || aux.Clave != null) //si cargo un ID que ya existe me salta este error
            {
                MessageBox.Show("Error: email o clave invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensaje de error
            }
            else
            {
                SistamaUsuario SistamaUsuario = new SistamaUsuario();
                SistamaUsuario.MdiParent = this;
                SistamaUsuario.Show();
                //centro la ventana
                SistamaUsuario.Left = (this.Left + this.Width - SistamaUsuario.Height) / 2;
                SistamaUsuario.Left = (this.Top + this.Height - SistamaUsuario.Width) / 2;
            }
        }
    }
}
