namespace Biocalpert_Central
{
    partial class Agregar_Medico
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
            this.Agregar_button = new System.Windows.Forms.Button();
            this.MEDICOS = new System.Windows.Forms.GroupBox();
            this.NOMBRE_BOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DIRECCION_BOX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DATOS_BOX = new System.Windows.Forms.RichTextBox();
            this.ID_BOX = new System.Windows.Forms.TextBox();
            this.MEDICOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregar_button
            // 
            this.Agregar_button.Location = new System.Drawing.Point(524, 399);
            this.Agregar_button.Name = "Agregar_button";
            this.Agregar_button.Size = new System.Drawing.Size(253, 36);
            this.Agregar_button.TabIndex = 5;
            this.Agregar_button.Text = "Agregar";
            this.Agregar_button.UseVisualStyleBackColor = true;
            this.Agregar_button.Click += new System.EventHandler(this.Agregar_button_Click);
            // 
            // MEDICOS
            // 
            this.MEDICOS.Controls.Add(this.NOMBRE_BOX);
            this.MEDICOS.Controls.Add(this.label3);
            this.MEDICOS.Controls.Add(this.DIRECCION_BOX);
            this.MEDICOS.Controls.Add(this.label6);
            this.MEDICOS.Controls.Add(this.label2);
            this.MEDICOS.Controls.Add(this.label1);
            this.MEDICOS.Controls.Add(this.DATOS_BOX);
            this.MEDICOS.Controls.Add(this.ID_BOX);
            this.MEDICOS.Location = new System.Drawing.Point(12, 16);
            this.MEDICOS.Name = "MEDICOS";
            this.MEDICOS.Size = new System.Drawing.Size(776, 377);
            this.MEDICOS.TabIndex = 4;
            this.MEDICOS.TabStop = false;
            this.MEDICOS.Text = "Medicos";
            // 
            // NOMBRE_BOX
            // 
            this.NOMBRE_BOX.Location = new System.Drawing.Point(332, 52);
            this.NOMBRE_BOX.Name = "NOMBRE_BOX";
            this.NOMBRE_BOX.Size = new System.Drawing.Size(244, 23);
            this.NOMBRE_BOX.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dirección";
            // 
            // DIRECCION_BOX
            // 
            this.DIRECCION_BOX.Location = new System.Drawing.Point(19, 164);
            this.DIRECCION_BOX.Name = "DIRECCION_BOX";
            this.DIRECCION_BOX.Size = new System.Drawing.Size(227, 23);
            this.DIRECCION_BOX.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datos Adicionales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // DATOS_BOX
            // 
            this.DATOS_BOX.Location = new System.Drawing.Point(331, 117);
            this.DATOS_BOX.Name = "DATOS_BOX";
            this.DATOS_BOX.Size = new System.Drawing.Size(245, 160);
            this.DATOS_BOX.TabIndex = 4;
            this.DATOS_BOX.Text = "";
            // 
            // ID_BOX
            // 
            this.ID_BOX.Enabled = false;
            this.ID_BOX.Location = new System.Drawing.Point(19, 52);
            this.ID_BOX.Name = "ID_BOX";
            this.ID_BOX.Size = new System.Drawing.Size(227, 23);
            this.ID_BOX.TabIndex = 0;
            // 
            // Agregar_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Agregar_button);
            this.Controls.Add(this.MEDICOS);
            this.Name = "Agregar_Medico";
            this.Text = "Agregar_Medico";
            this.MEDICOS.ResumeLayout(false);
            this.MEDICOS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Agregar_button;
        private GroupBox MEDICOS;
        private Label label6;
        private Label label2;
        private RichTextBox DATOS_BOX;
        private Label label3;
        private TextBox DIRECCION_BOX;
        private Label label1;
        private TextBox ID_BOX;
        private TextBox NOMBRE_BOX;
    }
}