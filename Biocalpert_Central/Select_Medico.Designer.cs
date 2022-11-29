namespace Biocalpert_Central
{
    partial class Select_Medico
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Nombre_Box = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre_button = new System.Windows.Forms.RadioButton();
            this.ID_BOX = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Nombre_Box);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(437, 100);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // Nombre_Box
            // 
            this.Nombre_Box.Location = new System.Drawing.Point(3, 3);
            this.Nombre_Box.Name = "Nombre_Box";
            this.Nombre_Box.Size = new System.Drawing.Size(434, 23);
            this.Nombre_Box.TabIndex = 6;
            this.Nombre_Box.TextChanged += new System.EventHandler(this.Nombre_Box_TextChanged);
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 15;
            this.Results.Location = new System.Drawing.Point(27, 203);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(402, 94);
            this.Results.TabIndex = 21;
            this.Results.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Results_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // Nombre_button
            // 
            this.Nombre_button.AutoSize = true;
            this.Nombre_button.Checked = true;
            this.Nombre_button.Location = new System.Drawing.Point(27, 72);
            this.Nombre_button.Name = "Nombre_button";
            this.Nombre_button.Size = new System.Drawing.Size(69, 19);
            this.Nombre_button.TabIndex = 19;
            this.Nombre_button.TabStop = true;
            this.Nombre_button.Text = "Nombre";
            this.Nombre_button.UseVisualStyleBackColor = true;
            // 
            // ID_BOX
            // 
            this.ID_BOX.Location = new System.Drawing.Point(27, 29);
            this.ID_BOX.Name = "ID_BOX";
            this.ID_BOX.Size = new System.Drawing.Size(384, 23);
            this.ID_BOX.TabIndex = 18;
            this.ID_BOX.TextChanged += new System.EventHandler(this.ID_BOX_TextChanged);
            // 
            // Select_Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 313);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre_button);
            this.Controls.Add(this.ID_BOX);
            this.Name = "Select_Medico";
            this.Text = "Select_Medico";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ListBox Results;
        private Label label1;
        private RadioButton Nombre_button;
        private TextBox ID_BOX;
        private TextBox Nombre_Box;
    }
}