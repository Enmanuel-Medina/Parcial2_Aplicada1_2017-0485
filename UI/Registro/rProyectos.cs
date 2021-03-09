using Parcial2_Aplicada1_2017_0485.BLL;
using Parcial2_Aplicada1_2017_0485.Entidad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Aplicada1_2017_0485.UI.Registro
{
   

        public partial class rProyectos : Form
        {
            public List<Proyectos_Detalles> DetalleProyecto { get; set; }

            public rProyectos()
            {
                InitializeComponent();
                this.DetalleProyecto = new List<Proyectos_Detalles>();
            }

            private void LlenarGrid()
            {
                rDataGridView.DataSource = null;
                rDataGridView.DataSource = this.DetalleProyecto;
            }

            private bool Validar()
            {
                bool validado = true;

                if (DescripcionTextBox.Text == "")
                {
                    MyErrorProvider.SetError(DescripcionTextBox, "Campo obligatorio");
                    validado = false;
                }

                return validado;
            }

            private Proyectos LlenaClase()
            {
                var proyecto = new Proyectos();
                proyecto.Descripcion = DescripcionTextBox.Text;
                proyecto.ProyectoId = (int)IdNumericUpDown.Value;
                proyecto.Fecha = FechaDateTimePicker.Value;
                proyecto.Tiempo += Convert.ToInt32(TiempoTTextBox.Text);
                proyecto.Detalles = this.DetalleProyecto;

                return proyecto;
            }

            private void LlenaCampos(Proyectos proyecto)
            {
                IdNumericUpDown.Value = proyecto.ProyectoId;
                DescripcionTextBox.Text = proyecto.Descripcion;
                FechaDateTimePicker.Value = proyecto.Fecha;
                TiempoTTextBox.Text = Convert.ToString(proyecto.Tiempo);
            }

            private void Limpiar()
            {
                IdNumericUpDown.Value = 0;
                DescripcionTextBox.Clear();
                MyErrorProvider.Clear();
                FechaDateTimePicker.Value = DateTime.Now;
                TiempoTTextBox.Clear();
                DetalleProyecto = new List<Proyectos_Detalles>();
                LlenarGrid();
            }

            private void GuardarButton_Click(object sender, EventArgs e)
            {

            }

            private void rProyectos_Load(object sender, EventArgs e)
            {
                DesComboBox.DataSource = TareasBLL.GetTareas();
                DesComboBox.DisplayMember = "Descripcion";
                DesComboBox.ValueMember = "TipoId";
            }

            private void BuscarButton_Click(object sender, EventArgs e)
            {
                var proyecto = new Proyectos();
                int id = (int)IdNumericUpDown.Value;

                Limpiar();
                proyecto = ProyectosBLL.Buscar(id);
                if (proyecto != null)
                    LlenaCampos(proyecto);
                else
                    MessageBox.Show("Proyecto no encontrado en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {

        }
    }


    }

          
