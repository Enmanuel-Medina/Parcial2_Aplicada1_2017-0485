using Parcial2_Aplicada1_2017_0485.BLL;
using Parcial2_Aplicada1_2017_0485.Entidad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Aplicada1_2017_0485.UI.Registro
{


    public partial class rProyectos : Form
    {
        public List<Proyectos_Detalles> Detalles { get; set; }

        public rProyectos()
        {
            InitializeComponent();
            this.Detalles = new List<Proyectos_Detalles>();
           
        }

        private void LlenarGrid()
        {
            rDataGridView.DataSource = null;
            rDataGridView.DataSource = this.Detalles;
        }

        private bool Validar()
        {
            bool validado = true;

            if (DescripcionTextBox.Text == "")
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Este campo no puede estar bacio ");
                DescripcionTextBox.Focus();
                validado = false;
            }
            if (Detalles.Count == 0)
            {
                MyErrorProvider.SetError(rDataGridView, "No puede esatar bacio");
                DescripcionTextBox.Focus();
                validado = false;
            }
            if (ProyectosBLL.Existe(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Esta descripcion ya existe");
                DescripcionTextBox.Focus();
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
            proyecto.Tiempo = Convert.ToInt32(TiemTextBox.Text);
            proyecto.Detalles = this.Detalles;

            return proyecto;
        }

        private void LlenaCampos(Proyectos proyecto)
        {
            IdNumericUpDown.Value = proyecto.ProyectoId;
            DescripcionTextBox.Text = proyecto.Descripcion;
            FechaDateTimePicker.Value = proyecto.Fecha;
            TiempoTTextBox.Text = Convert.ToString(proyecto.Tiempo);
            Detalles = proyecto.Detalles;
            LlenarGrid();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            MyErrorProvider.Clear();
            FechaDateTimePicker.Value = DateTime.Now;
            TiempoTTextBox.Clear();
            Detalles = new List<Proyectos_Detalles>();
            LlenarGrid();
        }


       

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            Proyectos proyecto;

            if (!Validar())
                return;

            proyecto = LlenaClase();
            var paso = ProyectosBLL.Guardar(proyecto);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Se guardo con exito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se a podido guardado", "Error Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("No se a podido encontrar el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)IdNumericUpDown.Value;
            MyErrorProvider.Clear();

            if (ProyectosBLL.Eliminar(id))
            {
                MessageBox.Show("Se  eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show(" No ha sido eliminado", "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (rDataGridView.DataSource != null)
               this.Detalles = (List<Proyectos_Detalles>)rDataGridView.DataSource;

             this.Detalles.Add(new Proyectos_Detalles
            ( 
                 detalleid:0,
                proyectoId:(int)IdNumericUpDown.Value,
                tareaId: Convert.ToInt32(DesComboBox.SelectedIndex) + 1,
                requerimiento:ReqTextBox.Text,
                tiempo:Convert.ToInt32(TiemTextBox.Text)
             )
            );

            LlenarGrid();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if ((rDataGridView.Rows.Count > 0) && rDataGridView.CurrentRow != null)
            {
                Detalles.RemoveAt(rDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }

        private void DesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DesComboBox.SelectedIndex == 0)
            {
                ReqTextBox.Text = TareasBLL.BuscarRequerimiento(1);
                TiemTextBox.Text = Convert.ToString(TareasBLL.BuscarTiempo(1));
            }
            else if (DesComboBox.SelectedIndex == 1)
            {
                ReqTextBox.Text = TareasBLL.BuscarRequerimiento(2);
                TiemTextBox.Text = Convert.ToString(TareasBLL.BuscarTiempo(2));
            }
            else if (DesComboBox.SelectedIndex == 2)
            {
                ReqTextBox.Text = TareasBLL.BuscarRequerimiento(3);
                TiemTextBox.Text = Convert.ToString(TareasBLL.BuscarTiempo(3));
            }
            else if (DesComboBox.SelectedIndex == 3)
            {
                ReqTextBox.Text = TareasBLL.BuscarRequerimiento(4);
                TiemTextBox.Text = Convert.ToString(TareasBLL.BuscarTiempo(4));
            }
        }

        private void rProyectos_Load_1(object sender, EventArgs e)
        {
            DesComboBox.DataSource = TareasBLL.GetTareas();
            DesComboBox.DisplayMember = "Descripcion";
            DesComboBox.ValueMember = "TareaId";

        }
    }
  }
  



          
