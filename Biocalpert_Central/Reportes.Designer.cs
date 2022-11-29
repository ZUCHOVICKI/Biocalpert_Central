namespace Biocalpert_Central
{
    partial class Reportes
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
            this.Vendedor_BOX = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Select_Vendedores = new System.Windows.Forms.Button();
            this.Select_Medicos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Medicos_BOX = new System.Windows.Forms.CheckedListBox();
            this.Initial_date = new System.Windows.Forms.DateTimePicker();
            this.Final_date = new System.Windows.Forms.DateTimePicker();
            this.Fecha_inicial = new System.Windows.Forms.Label();
            this.fecha_final = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Dates = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vendedor_BOX
            // 
            this.Vendedor_BOX.FormattingEnabled = true;
            this.Vendedor_BOX.Location = new System.Drawing.Point(12, 48);
            this.Vendedor_BOX.Name = "Vendedor_BOX";
            this.Vendedor_BOX.Size = new System.Drawing.Size(309, 76);
            this.Vendedor_BOX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vendedores";
            // 
            // Select_Vendedores
            // 
            this.Select_Vendedores.Location = new System.Drawing.Point(201, 22);
            this.Select_Vendedores.Name = "Select_Vendedores";
            this.Select_Vendedores.Size = new System.Drawing.Size(120, 23);
            this.Select_Vendedores.TabIndex = 2;
            this.Select_Vendedores.Text = "Seleccionar Todos";
            this.Select_Vendedores.UseVisualStyleBackColor = true;
            this.Select_Vendedores.Click += new System.EventHandler(this.Select_Vendedores_Click);
            // 
            // Select_Medicos
            // 
            this.Select_Medicos.Location = new System.Drawing.Point(567, 22);
            this.Select_Medicos.Name = "Select_Medicos";
            this.Select_Medicos.Size = new System.Drawing.Size(120, 23);
            this.Select_Medicos.TabIndex = 5;
            this.Select_Medicos.Text = "Seleccionar Todos";
            this.Select_Medicos.UseVisualStyleBackColor = true;
            this.Select_Medicos.Click += new System.EventHandler(this.Select_Medicos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Médicos";
            // 
            // Medicos_BOX
            // 
            this.Medicos_BOX.FormattingEnabled = true;
            this.Medicos_BOX.Location = new System.Drawing.Point(378, 48);
            this.Medicos_BOX.Name = "Medicos_BOX";
            this.Medicos_BOX.Size = new System.Drawing.Size(309, 76);
            this.Medicos_BOX.TabIndex = 3;
            // 
            // Initial_date
            // 
            this.Initial_date.Enabled = false;
            this.Initial_date.Location = new System.Drawing.Point(368, 232);
            this.Initial_date.Name = "Initial_date";
            this.Initial_date.Size = new System.Drawing.Size(338, 23);
            this.Initial_date.TabIndex = 9;
            // 
            // Final_date
            // 
            this.Final_date.Enabled = false;
            this.Final_date.Location = new System.Drawing.Point(368, 305);
            this.Final_date.Name = "Final_date";
            this.Final_date.Size = new System.Drawing.Size(338, 23);
            this.Final_date.TabIndex = 10;
            // 
            // Fecha_inicial
            // 
            this.Fecha_inicial.AutoSize = true;
            this.Fecha_inicial.Enabled = false;
            this.Fecha_inicial.Location = new System.Drawing.Point(368, 214);
            this.Fecha_inicial.Name = "Fecha_inicial";
            this.Fecha_inicial.Size = new System.Drawing.Size(72, 15);
            this.Fecha_inicial.TabIndex = 11;
            this.Fecha_inicial.Text = "Fecha Inicial";
            // 
            // fecha_final
            // 
            this.fecha_final.AutoSize = true;
            this.fecha_final.Enabled = false;
            this.fecha_final.Location = new System.Drawing.Point(368, 282);
            this.fecha_final.Name = "fecha_final";
            this.fecha_final.Size = new System.Drawing.Size(66, 15);
            this.fecha_final.TabIndex = 12;
            this.fecha_final.Text = "Fecha Final";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(263, 389);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(227, 49);
            this.Buscar.TabIndex = 13;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Dates
            // 
            this.Dates.AutoSize = true;
            this.Dates.Location = new System.Drawing.Point(461, 165);
            this.Dates.Name = "Dates";
            this.Dates.Size = new System.Drawing.Size(121, 19);
            this.Dates.TabIndex = 14;
            this.Dates.Text = "Especificar Fechas";
            this.Dates.UseVisualStyleBackColor = true;
            this.Dates.CheckedChanged += new System.EventHandler(this.Dates_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(740, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(552, 298);
            this.dataGridView1.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(293, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(375, 280);
            this.dataGridView2.TabIndex = 16;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(859, 46);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(375, 280);
            this.dataGridView4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Vendedores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(859, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Médicos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 492);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 362);
            this.panel1.TabIndex = 23;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 866);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Dates);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.fecha_final);
            this.Controls.Add(this.Fecha_inicial);
            this.Controls.Add(this.Final_date);
            this.Controls.Add(this.Initial_date);
            this.Controls.Add(this.Select_Medicos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Medicos_BOX);
            this.Controls.Add(this.Select_Vendedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vendedor_BOX);
            this.Controls.Add(this.panel1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox Vendedor_BOX;
        private Label label1;
        private Button Select_Vendedores;
        private Button Select_Medicos;
        private Label label2;
        private CheckedListBox Medicos_BOX;
        private DateTimePicker Initial_date;
        private DateTimePicker Final_date;
        private Label Fecha_inicial;
        private Label fecha_final;
        private Button Buscar;
        private CheckBox Dates;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView4;
        private Label label5;
        private Label label6;
        private Button Imprimir;
        private Panel panel1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private PrintPreviewDialog printPreviewDialog1;
    }
}