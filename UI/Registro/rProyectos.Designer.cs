
namespace Parcial2_Aplicada1_2017_0485.UI.Registro
{
    partial class rProyectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.DetalleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DesComboBox = new System.Windows.Forms.ComboBox();
            this.RequerimientoLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TiempoLabel = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.rDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.TiempoTLabel = new System.Windows.Forms.Label();
            this.TiempoTTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(35, 31);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(22, 20);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "Id";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(35, 54);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(150, 27);
            this.IdNumericUpDown.TabIndex = 1;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::Parcial2_Aplicada1_2017_0485.Properties.Resources.Buscar1;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(191, 54);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 30);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(35, 87);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(150, 27);
            this.FechaDateTimePicker.TabIndex = 3;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(35, 126);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(87, 20);
            this.DescripcionLabel.TabIndex = 4;
            this.DescripcionLabel.Text = "Descripcion";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(35, 150);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(355, 83);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // DetalleLabel
            // 
            this.DetalleLabel.AutoSize = true;
            this.DetalleLabel.Location = new System.Drawing.Point(35, 256);
            this.DetalleLabel.Name = "DetalleLabel";
            this.DetalleLabel.Size = new System.Drawing.Size(132, 20);
            this.DetalleLabel.TabIndex = 6;
            this.DetalleLabel.Text = "Detalle de la tarea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipos de tarea";
            // 
            // DesComboBox
            // 
            this.DesComboBox.FormattingEnabled = true;
            this.DesComboBox.Location = new System.Drawing.Point(35, 310);
            this.DesComboBox.Name = "DesComboBox";
            this.DesComboBox.Size = new System.Drawing.Size(151, 28);
            this.DesComboBox.TabIndex = 8;
            // 
            // RequerimientoLabel
            // 
            this.RequerimientoLabel.AutoSize = true;
            this.RequerimientoLabel.Location = new System.Drawing.Point(221, 287);
            this.RequerimientoLabel.Name = "RequerimientoLabel";
            this.RequerimientoLabel.Size = new System.Drawing.Size(107, 20);
            this.RequerimientoLabel.TabIndex = 9;
            this.RequerimientoLabel.Text = "Requerimiento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 27);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(549, 310);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 11;
            // 
            // TiempoLabel
            // 
            this.TiempoLabel.AutoSize = true;
            this.TiempoLabel.Location = new System.Drawing.Point(578, 287);
            this.TiempoLabel.Name = "TiempoLabel";
            this.TiempoLabel.Size = new System.Drawing.Size(60, 20);
            this.TiempoLabel.TabIndex = 12;
            this.TiempoLabel.Text = "Tiempo";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = global::Parcial2_Aplicada1_2017_0485.Properties.Resources.agregar;
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(680, 309);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(94, 29);
            this.AgregarButton.TabIndex = 13;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // rDataGridView
            // 
            this.rDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rDataGridView.Location = new System.Drawing.Point(35, 359);
            this.rDataGridView.Name = "rDataGridView";
            this.rDataGridView.RowHeadersWidth = 51;
            this.rDataGridView.RowTemplate.Height = 29;
            this.rDataGridView.Size = new System.Drawing.Size(739, 205);
            this.rDataGridView.TabIndex = 14;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = global::Parcial2_Aplicada1_2017_0485.Properties.Resources.Remover;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(35, 570);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(87, 31);
            this.RemoverButton.TabIndex = 15;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::Parcial2_Aplicada1_2017_0485.Properties.Resources.Nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(35, 622);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(87, 43);
            this.NuevoButton.TabIndex = 16;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::Parcial2_Aplicada1_2017_0485.Properties.Resources.Guardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(145, 620);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(95, 45);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::Parcial2_Aplicada1_2017_0485.Properties.Resources.eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(261, 620);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(96, 45);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // TiempoTLabel
            // 
            this.TiempoTLabel.AutoSize = true;
            this.TiempoTLabel.Location = new System.Drawing.Point(609, 607);
            this.TiempoTLabel.Name = "TiempoTLabel";
            this.TiempoTLabel.Size = new System.Drawing.Size(97, 20);
            this.TiempoTLabel.TabIndex = 19;
            this.TiempoTLabel.Text = "Tiempo Total";
            // 
            // TiempoTTextBox
            // 
            this.TiempoTTextBox.Location = new System.Drawing.Point(712, 604);
            this.TiempoTTextBox.Name = "TiempoTTextBox";
            this.TiempoTTextBox.Size = new System.Drawing.Size(125, 27);
            this.TiempoTTextBox.TabIndex = 20;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 676);
            this.Controls.Add(this.TiempoTTextBox);
            this.Controls.Add(this.TiempoTLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.rDataGridView);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.TiempoLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RequerimientoLabel);
            this.Controls.Add(this.DesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetalleLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.IdLabel);
            this.Name = "rProyectos";
            this.Text = "rProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label DetalleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DesComboBox;
        private System.Windows.Forms.Label RequerimientoLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label TiempoLabel;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DataGridView rDataGridView;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label TiempoTLabel;
        private System.Windows.Forms.TextBox TiempoTTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}