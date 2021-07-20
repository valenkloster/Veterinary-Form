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
    public partial class ModificarMascota : Form
    {
        public int ID_Cliente { get; set; }
        public int Id { get; set; }
        public ModificarMascota(int ID_Cliente)
        {
            this.ID_Cliente = ID_Cliente;
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            app.appMascota mas = new app.appMascota();
            Enti.entiMascota m = new Enti.entiMascota();

           
            m.Estado = true;
            m.Nombre = txtNombre.Text.ToString();
            m.TipoAnimal = txtTipoAnimal.Text.ToString();
            m.Raza = textRaza.Text.ToString(); 
            m.ID_Cliente = this.ID_Cliente;
            m.Detalle = textDetalle.Text.ToString();
            
            int i= mas.Agregar(m);
            MessageBox.Show("La operacion se completo con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtNombre.Text = ""; //blanqueo las celdas
            this.txtTipoAnimal.Text = "";
            this.textRaza.Text = "";
            this.textDetalle.Text = "";
            this.txtNombre.Focus(); //le doy el foco al detalle

            this.Close();
            mas = null;
            m = null;

        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            app.appMascota mascota = new app.appMascota();
            Enti.entiMascota mas = new Enti.entiMascota();
            int R = mascota.Borrar(this.Id);
            MessageBox.Show("Su mascota ha sido borrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mascota = null;
            this.Close();
          
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            app.appMascota mascota = new app.appMascota();
            Enti.entiMascota m = new Enti.entiMascota();
            m.ID_Mascota = this.Id;
            m.Nombre = txtNombre.Text.ToString();
            m.TipoAnimal = txtTipoAnimal.Text.ToString();
            m.Raza = textRaza.Text.ToString();
            m.ID_Cliente = this.ID_Cliente;
            m.Detalle = textDetalle.Text.ToString();
            mascota.Actualizar(m);
            MessageBox.Show("Los datos han sido actualizados. Por favor vuelva a cargar la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mascota = null;
            m = null;
            this.Close();

        }

        private void ModificarMascota_Load(object sender, EventArgs e)
        {

            if (this.Id != 0)
            {
                app.appMascota mascota = new app.appMascota();
                Enti.entiMascota m = new Enti.entiMascota();

                m = mascota.Traer(this.Id);//el ID que recibe, s lo va a pasar desde el formulario de carga
                txtNombre.Text = m.Nombre.ToString();
                txtTipoAnimal.Text = m.TipoAnimal.ToString();
                textRaza.Text = m.Raza.ToString();
                textDetalle.Text = m.Detalle.ToString();

                mascota = null;
                m = null;

                app.appReserva reserva = new app.appReserva();
                Enti.entiReserva r = new Enti.entiReserva();
            }
            else
            {
                //como es nuevo desabilito los que no me sirven
                this.Borrar.Enabled = false;
                this.Actualizar.Enabled = false;
            }
        }
        
    }
}
