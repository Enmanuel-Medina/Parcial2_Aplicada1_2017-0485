
namespace Parcial2_Aplicada1_2017_0485.UI.Consultas
{
    partial class cProyectos
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
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(170, 51);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(499, 27);
            this.CriterioTextBox.TabIndex = 0;
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Location = new System.Drawing.Point(13, 25);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(43, 20);
            this.FiltroLabel.TabIndex = 1;
            this.FiltroLabel.Text = "Filtro";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Proyecto Id",
            "Descripción",
            "Tiempo Total"});
            this.comboBox1.Location = new System.Drawing.Point(13, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(198, 25);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(58, 20);
            this.CriterioLabel.TabIndex = 3;
            this.CriterioLabel.Text = "Criterio";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::Parcial2_Aplicada1_2017_0485.Properties.Resources.Buscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(675, 51);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 29);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(804, 380);
            this.dataGridView1.TabIndex = 5;
            // 
            // cProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.FiltroLabel);
            this.Controls.Add(this.CriterioTextBox);
            this.Name = "cProyectos";
            this.Text = "cProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}