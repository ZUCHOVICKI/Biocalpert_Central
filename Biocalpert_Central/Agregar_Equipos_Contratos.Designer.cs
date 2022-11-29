namespace Biocalpert_Central
{
    partial class Agregar_Equipos_Contratos
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
            this.Equipo_BOX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Agregar_Equipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Equipo_BOX
            // 
            this.Equipo_BOX.FormattingEnabled = true;
            this.Equipo_BOX.Location = new System.Drawing.Point(2, 57);
            this.Equipo_BOX.Name = "Equipo_BOX";
            this.Equipo_BOX.Size = new System.Drawing.Size(306, 23);
            this.Equipo_BOX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipos";
            // 
            // Agregar_Equipo
            // 
            this.Agregar_Equipo.Location = new System.Drawing.Point(194, 115);
            this.Agregar_Equipo.Name = "Agregar_Equipo";
            this.Agregar_Equipo.Size = new System.Drawing.Size(105, 23);
            this.Agregar_Equipo.TabIndex = 2;
            this.Agregar_Equipo.Text = "Agregar";
            this.Agregar_Equipo.UseVisualStyleBackColor = true;
            this.Agregar_Equipo.Click += new System.EventHandler(this.Agregar_Equipo_Click);
            // 
            // Agregar_Equipos_Contratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 160);
            this.Controls.Add(this.Agregar_Equipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Equipo_BOX);
            this.Name = "Agregar_Equipos_Contratos";
            this.Text = "Agregar_Equipos_Contratos";
            this.Load += new System.EventHandler(this.Agregar_Equipos_Contratos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Equipo_BOX;
        private Label label1;
        private Button Agregar_Equipo;
    }
}