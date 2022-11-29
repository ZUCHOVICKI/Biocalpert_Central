namespace Biocalpert_Central
{
    partial class Editar_Vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Vendedor));
            this.Agregar_button = new System.Windows.Forms.Button();
            this.VENDEDOR = new System.Windows.Forms.GroupBox();
            this.Borrar_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DATOS_BOX = new System.Windows.Forms.RichTextBox();
            this.ID_BOX = new System.Windows.Forms.TextBox();
            this.NOMBRE_BOX = new System.Windows.Forms.TextBox();
            this.VENDEDOR.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregar_button
            // 
            this.Agregar_button.Location = new System.Drawing.Point(524, 399);
            this.Agregar_button.Name = "Agregar_button";
            this.Agregar_button.Size = new System.Drawing.Size(253, 36);
            this.Agregar_button.TabIndex = 9;
            this.Agregar_button.Text = "Editar";
            this.Agregar_button.UseVisualStyleBackColor = true;
            this.Agregar_button.Click += new System.EventHandler(this.Agregar_button_Click);
            // 
            // VENDEDOR
            // 
            this.VENDEDOR.Controls.Add(this.NOMBRE_BOX);
            this.VENDEDOR.Controls.Add(this.Borrar_Button);
            this.VENDEDOR.Controls.Add(this.label6);
            this.VENDEDOR.Controls.Add(this.label2);
            this.VENDEDOR.Controls.Add(this.label1);
            this.VENDEDOR.Controls.Add(this.DATOS_BOX);
            this.VENDEDOR.Controls.Add(this.ID_BOX);
            this.VENDEDOR.Location = new System.Drawing.Point(12, 16);
            this.VENDEDOR.Name = "VENDEDOR";
            this.VENDEDOR.Size = new System.Drawing.Size(776, 377);
            this.VENDEDOR.TabIndex = 8;
            this.VENDEDOR.TabStop = false;
            this.VENDEDOR.Text = "Vendedor";
            // 
            // Borrar_Button
            // 
            this.Borrar_Button.Image = ((System.Drawing.Image)(resources.GetObject("Borrar_Button.Image")));
            this.Borrar_Button.Location = new System.Drawing.Point(732, 13);
            this.Borrar_Button.Name = "Borrar_Button";
            this.Borrar_Button.Size = new System.Drawing.Size(33, 36);
            this.Borrar_Button.TabIndex = 12;
            this.Borrar_Button.UseVisualStyleBackColor = true;
            this.Borrar_Button.Click += new System.EventHandler(this.Borrar_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 102);
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
            this.DATOS_BOX.Location = new System.Drawing.Point(19, 120);
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
            // NOMBRE_BOX
            // 
            this.NOMBRE_BOX.Location = new System.Drawing.Point(331, 52);
            this.NOMBRE_BOX.Name = "NOMBRE_BOX";
            this.NOMBRE_BOX.Size = new System.Drawing.Size(252, 23);
            this.NOMBRE_BOX.TabIndex = 16;
            // 
            // Editar_Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Agregar_button);
            this.Controls.Add(this.VENDEDOR);
            this.Name = "Editar_Vendedor";
            this.Text = "Editar_Vendedor";
            this.Load += new System.EventHandler(this.Editar_Vendedor_Load);
            this.VENDEDOR.ResumeLayout(false);
            this.VENDEDOR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Agregar_button;
        private GroupBox VENDEDOR;
        private Label label6;
        private Label label2;
        private Label label1;
        private RichTextBox DATOS_BOX;
        private TextBox ID_BOX;
        private Button Borrar_Button;
        private TextBox NOMBRE_BOX;
    }
}