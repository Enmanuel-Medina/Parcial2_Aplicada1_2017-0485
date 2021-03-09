using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Parcial2_Aplicada1_2017_0485.BLL;
using Parcial2_Aplicada1_2017_0485.Entidad;

namespace Parcial2_Aplicada1_2017_0485.UI.Consultas
{
    public partial class cProyectos : Form
    {
        public cProyectos()
        {
            InitializeComponent();
        }


      
        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            var lista = new List<Proyectos>();

            if (!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = ProyectosBLL.GetList(r => r.ProyectoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    case 1:
                        lista = ProyectosBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text.ToUpper()) || r.Descripcion.Contains(CriterioTextBox.Text.ToLower()));
                        break;
                    case 2:
                        lista = ProyectosBLL.GetList(r => r.Tiempo == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                    default:
                        break;
                }
            }
            else
                lista = ProyectosBLL.GetList(r => true);

            cDataGridView.DataSource = null;
            cDataGridView.DataSource = lista;
        }

    }
    }
