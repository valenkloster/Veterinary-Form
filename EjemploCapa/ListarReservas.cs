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
    public partial class ListarReservas : Form
    {
          public int ID_Cliente { get; set; }

        public ListarReservas(int ID_Cliente)
        {
            this.ID_Cliente = ID_Cliente;
            InitializeComponent();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            app.appReserva reserva = new app.appReserva();
            ModificarReservas ModificarReservas = new ModificarReservas(ID_Cliente);
            ModificarReservas.MdiParent = this.MdiParent;
            if(reserva.Traer_reserva(this.ID_Cliente).Count==0)
            {
                MessageBox.Show("Usted no ha hecho reservas aún", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ModificarReservas.Id = int.Parse(this.DGReservas.Rows[this.DGReservas.CurrentRow.Index].Cells[0].Value.ToString());
                ModificarReservas.Show();

                /*para que quede centrado*/
                ModificarReservas.Left = (this.Left + this.Width - ModificarReservas.Width) / 2;
                ModificarReservas.Top = (this.Top + this.Height - ModificarReservas.Height) / 2; 
            }

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {

            ModificarReservas ModificarReservas = new ModificarReservas(ID_Cliente);
            ModificarReservas.MdiParent = this.MdiParent;

            ModificarReservas.Id = 0;
            ModificarReservas.Show();

            /*para que quede centrado*/
            ModificarReservas.Left = (this.Left + this.Width - ModificarReservas.Width) / 2;
            ModificarReservas.Top = (this.Top + this.Height - ModificarReservas.Height) / 2;
        }
        private void ListarReservas_Load(object sender, EventArgs e)
        {
            app.appReserva reserva = new app.appReserva();
            this.DGReservas.DataSource = reserva.Traer_reserva(this.ID_Cliente); //traemos las reservas que tiene el cliente

            reserva = null;
        }

      
      


      

       
    }
}
