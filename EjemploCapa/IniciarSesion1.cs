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

            if (aux.Email == null || aux.Clave == null) 
            {
                MessageBox.Show("Error: email o clave invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensaje de error
                this.txtEmail.Text = "";
                this.txtClave.Text = "";
                this.txtEmail.Focus();

            }
            else
            {
                MessageBox.Show("Se ha ingresado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SistemaUsuario SistemaUsuario = new SistemaUsuario(aux.ID); //le pasamos el ID del cliente que inició sesión
                
                SistemaUsuario.Show();
                //centro la ventana
                SistemaUsuario.Left = (this.Left + this.Width - SistemaUsuario.Height) / 2;
                SistemaUsuario.Left = (this.Top + this.Height - SistemaUsuario.Width) / 2;

                this.Close();

            }
        
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
           
        }
    }
}
