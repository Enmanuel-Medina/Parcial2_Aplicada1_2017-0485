using Parcial2_Aplicada1_2017_0485.UI.Consultas;
using Parcial2_Aplicada1_2017_0485.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Aplicada1_2017_0485.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Registros
            this.rProyectosToolStripMenuItem.Click += new EventHandler(this.rProyectosToolStripMenuItem_ItemClicked);

            //Consultas
            this.cProyectosToolStripMenuItem.Click += new EventHandler(this.cProyectosToolStripMenuItem_ItemClicked);
        }
        private void cProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var proyecto = new cProyectos();
            proyecto.MdiParent = this;
            proyecto.Show();
        }

        private void rProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var proyecto = new rProyectos();
            proyecto.MdiParent = this;
            proyecto.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
