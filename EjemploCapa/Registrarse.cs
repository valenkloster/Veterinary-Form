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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            app.appCliente cliente = new app.appCliente(); //creo objeto
            Enti.entiCliente c = new Enti.entiCliente(); //creo objeto 
            Enti.entiCliente aux = new Enti.entiCliente();


            c.Nombre = txtNombre.Text.ToString();
            c.Apellido = txtApellido.Text.ToString();
            c.Email = txtEmail.Text.ToString();
            c.Estado = true;
            c.Clave = txtClave.Text.ToString();
            c.Fecha_ingreso = DateTime.Now;
            c.Fecha_mod = DateTime.Now;
            aux = cliente.Traer(c.Email);

            if (aux.Email != null) //si cargo un Mail que ya existe me salta este error
            {
                MessageBox.Show("Ese email ya ha sido registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); //mensaje de error
            }
            else
            {
                int i = cliente.Agregar(c);
                MessageBox.Show("La operación se completó con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); //mensaje de exito
                this.txtNombre.Text = ""; //blanqueo las celdas
                this.txtApellido.Text = "";
                this.txtEmail.Text = "";
                this.txtClave.Text = "";
                this.txtNombre.Focus(); //le doy el foco al Nombre
            }
            cliente = null;
            c = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }
    }
}
