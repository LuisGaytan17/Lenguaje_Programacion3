using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Kamil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Consultas = new FrmCemp();
            Consultas.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Registro = new FrmRE();
            Registro.Show();
        }

        private void directivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Registro = new FrmRDirec();
            Registro.Show();
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Registro = new FrmRSuc();
            Registro.Show();
        }

        private void datosDeEmpladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Modificar = new FrmMDEmp();
            Modificar.Show();
        }

        private void datosDeDirectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Modificar = new FrmMDDirec();
            Modificar.Show();
        }

        private void modificarDatosDeSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Modificar = new FrmMDSuc();
            Modificar.Show();
        }

        private void directivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Consultas = new FrmCDirec();
            Consultas.Show();
        }

        private void tiendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Consultas = new FrmCTienda();
            Consultas.Show();
        }
    }
}
