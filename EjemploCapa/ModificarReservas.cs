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

    public partial class ModificarReservas : Form
    {
        public int ID_Cliente { get; set; }
        public int Id { get; set; }
        public ModificarReservas(int ID_Cliente)
        {
            this.ID_Cliente = ID_Cliente;
            InitializeComponent();
        }

        private void ModificarReservas_Load(object sender, EventArgs e)
        {
            if (this.Id != 0)
            {


                app.appReserva reserva = new app.appReserva();
                Enti.entiReserva r = new Enti.entiReserva();

                r = reserva.Traer(this.Id);//el ID que recibe, s lo va a pasar desde el formulario de carga
                FechadeReserva.Text = r.Fecha_reserva.ToString();
                txtDetalle.Text = r.Detalle;
                IDServicio.Text = r.ID_Servicio.ToString();
              
                reserva = null;
                r = null;
            }
            else
            {
                //como es nuevo desabilito los que no me sirven
                this.Borrar.Enabled = false;
                this.Actualizar.Enabled = false;
            }
            
            app.appServicios ser = new app.appServicios();
            this.DGServicios.DataSource = ser.Traer();
            ser = null;
        }


        private void Agregar_Click(object sender, EventArgs e)
        {
            app.appReserva res = new app.appReserva();
            Enti.entiReserva r = new Enti.entiReserva();
            Enti.entiReserva aux = new Enti.entiReserva();

            r.Estado = true;
            r.Detalle = txtDetalle.Text.ToString();
            r.Fecha_reserva = DateTime.Parse(FechadeReserva.Text.ToString());
            r.Fecha_mod = DateTime.Now;
            r.ID_Cliente = this.ID_Cliente;
            r.ID_Servicio= int.Parse(IDServicio.Text.ToString());

            aux = res.Traer(r.Fecha_reserva);

            //comparamos si la fecha esta disponible o no
            if (aux.Detalle != null || r.Fecha_reserva < DateTime.Now)

            {
                MessageBox.Show("La fecha no esta disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = res.Agregar(r);
                MessageBox.Show("La operacion se completo con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtDetalle.Text = ""; //blanqueo las celdas
                this.FechadeReserva.Text = "";
                this.IDServicio.Text = "";
                this.txtDetalle.Focus(); //le doy el foco al detalle
                this.Close();
            }
            res = null;
            r = null;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            app.appReserva reserva = new app.appReserva();
            Enti.entiReserva res = new Enti.entiReserva();
            int R = reserva.Borrar(DateTime.Parse(FechadeReserva.Text.ToString()));
            MessageBox.Show("La reserva ha sido cancelada. Por favor vuelva a cargar la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reserva = null;
            this.Close();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            app.appReserva reserva = new app.appReserva();
            Enti.entiReserva r = new Enti.entiReserva();
            r.ID_Reserva = this.Id;
            r.Fecha_reserva = DateTime.Parse(FechadeReserva.Text.ToString());
            r.Detalle = txtDetalle.Text.ToString();
            r.ID_Servicio= int.Parse(IDServicio.Text.ToString());
            reserva.Actualizar(r);
            MessageBox.Show("Los datos han sido actualizados. Por favor vuelva a cargar la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            reserva = null;
            r = null;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textServicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

