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
    public partial class CambiarClave : Form
    {
        public int ID_Cliente { get; set; }
        public CambiarClave(int ID_Cliente)
        {
            this.ID_Cliente = ID_Cliente;
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(txtClaveNueva.Text == txtRepClave.Text)
            {
                app.appCliente cliente = new app.appCliente();
                Enti.entiCliente c = new Enti.entiCliente();
                c.ID = this.ID_Cliente;
                c.Clave = txtClaveNueva.Text;
                int i =cliente.CambiarClave(c);
                MessageBox.Show("La clave se ha modificado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Las claves no son iguales", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClaveNueva.Text = "";
                txtRepClave.Text = "";
                txtClaveNueva.Focus();
            }
            
        }

        private void CambiarClave_Load(object sender, EventArgs e)
        {

        }
    }
}
