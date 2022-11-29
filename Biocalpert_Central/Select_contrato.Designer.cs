namespace Biocalpert_Central
{
    partial class Select_contrato
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
            this.ID_BOX = new System.Windows.Forms.TextBox();
            this.Medico_button = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Medico_box = new System.Windows.Forms.ComboBox();
            this.Vendedor_Box = new System.Windows.Forms.ComboBox();
            this.Vendedor_button = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID_BOX
            // 
            this.ID_BOX.Location = new System.Drawing.Point(30, 23);
            this.ID_BOX.Name = "ID_BOX";
            this.ID_BOX.Size = new System.Drawing.Size(384, 23);
            this.ID_BOX.TabIndex = 0;
            this.ID_BOX.TextChanged += new System.EventHandler(this.ID_BOX_TextChanged);
            // 
            // Medico_button
            // 
            this.Medico_button.AutoSize = true;
            this.Medico_button.Checked = true;
            this.Medico_button.Location = new System.Drawing.Point(30, 66);
            this.Medico_button.Name = "Medico_button";
            this.Medico_button.Size = new System.Drawing.Size(65, 19);
            this.Medico_button.TabIndex = 2;
            this.Medico_button.TabStop = true;
            this.Medico_button.Text = "Médico";
            this.Medico_button.UseVisualStyleBackColor = true;
            this.Medico_button.CheckedChanged += new System.EventHandler(this.Medico_button_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Num. Contrato";
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 15;
            this.Results.Location = new System.Drawing.Point(30, 197);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(402, 94);
            this.Results.TabIndex = 7;
            this.Results.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Results_MouseDoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Medico_box);
            this.flowLayoutPanel1.Controls.Add(this.Vendedor_Box);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(437, 100);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Medico_box
            // 
            this.Medico_box.FormattingEnabled = true;
            this.Medico_box.Location = new System.Drawing.Point(3, 3);
            this.Medico_box.Name = "Medico_box";
            this.Medico_box.Size = new System.Drawing.Size(434, 23);
            this.Medico_box.TabIndex = 1;
            this.Medico_box.SelectedIndexChanged += new System.EventHandler(this.Medico_box_SelectedIndexChanged);
            // 
            // Vendedor_Box
            // 
            this.Vendedor_Box.FormattingEnabled = true;
            this.Vendedor_Box.Location = new System.Drawing.Point(3, 32);
            this.Vendedor_Box.Name = "Vendedor_Box";
            this.Vendedor_Box.Size = new System.Drawing.Size(434, 23);
            this.Vendedor_Box.TabIndex = 4;
            this.Vendedor_Box.Visible = false;
            this.Vendedor_Box.SelectedIndexChanged += new System.EventHandler(this.Vendedor_Box_SelectedIndexChanged);
            // 
            // Vendedor_button
            // 
            this.Vendedor_button.AutoSize = true;
            this.Vendedor_button.Location = new System.Drawing.Point(101, 66);
            this.Vendedor_button.Name = "Vendedor_button";
            this.Vendedor_button.Size = new System.Drawing.Size(75, 19);
            this.Vendedor_button.TabIndex = 9;
            this.Vendedor_button.Text = "Vendedor";
            this.Vendedor_button.UseVisualStyleBackColor = true;
            this.Vendedor_button.CheckedChanged += new System.EventHandler(this.Vendedor_button_CheckedChanged);
            // 
            // Select_contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 313);
            this.Controls.Add(this.Vendedor_button);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Medico_button);
            this.Controls.Add(this.ID_BOX);
            this.Name = "Select_contrato";
            this.Text = "Select_contrato";
            this.Load += new System.EventHandler(this.Select_contrato_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ID_BOX;
        private RadioButton Medico_button;
        private Label label1;
        private ListBox Results;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox Medico_box;
        private ComboBox Vendedor_Box;
        private RadioButton Vendedor_button;
    }
}