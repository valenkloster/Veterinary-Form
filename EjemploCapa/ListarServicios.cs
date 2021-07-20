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
    public partial class ListarServicios : Form
    {
        public ListarServicios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void frmRol_Load(object sender, EventArgs e)
        {
            app.appServicios ser = new app.appServicios();
            this.DGRol.DataSource = ser.Traer();
            ser = null;
        }

       

        private void DGRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
