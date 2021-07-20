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
    public partial class ListarMascotas : Form
    {
        public int ID_Cliente { get; set; }

        public ListarMascotas(int ID_Cliente)
        {
            this.ID_Cliente = ID_Cliente;
            InitializeComponent();
        }

        private void ListarMascotas_Load(object sender, EventArgs e)
        {
            app.appMascota mascota = new app.appMascota();
            this.DGmascota.DataSource = mascota.Traer_mascota(this.ID_Cliente); //traemos las mascotas que tiene el cliente

            mascota = null;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            app.appMascota mascota = new app.appMascota();
            ModificarMascota ModificarMascota = new ModificarMascota(ID_Cliente);
            ModificarMascota.MdiParent = this.MdiParent;
            if (mascota.Traer_mascota(this.ID_Cliente).Count == 0)
            {
                MessageBox.Show("Usted no tiene ninguna mascota", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModificarMascota.Id = int.Parse(this.DGmascota.Rows[this.DGmascota.CurrentRow.Index].Cells[0].Value.ToString()); 
                ModificarMascota.Show();

                /*para que quede centrado*/
                ModificarMascota.Left = (this.Left + this.Width - ModificarMascota.Width) / 2;
                ModificarMascota.Top = (this.Top + this.Height - ModificarMascota.Height) / 2;

            }

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            ModificarMascota ModificarMascota = new ModificarMascota(ID_Cliente);
            ModificarMascota.MdiParent = this.MdiParent;

            ModificarMascota.Id = 0;
            ModificarMascota.Show();

            /*para que quede centrado*/
            ModificarMascota.Left = (this.Left + this.Width - ModificarMascota.Width) / 2;
            ModificarMascota.Top = (this.Top + this.Height - ModificarMascota.Height) / 2;
        }

    }
}
