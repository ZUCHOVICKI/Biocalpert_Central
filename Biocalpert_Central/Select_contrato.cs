using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biocalpert_Central
{
    public partial class Select_contrato : Form
    {
        public static string itemSplit = "";
        public Select_contrato()
        {
            InitializeComponent();
            initValues();
        }


        private void initValues() {

            
          
            
            Medico_box.Visible = true;
            Vendedor_Box.Visible = false;
        }

        private void Medico_button_CheckedChanged(object sender, EventArgs e)
        {
            Results.Items.Clear();
            if (Medico_button.Checked == true)
            {

                
              
               
                Medico_box.Visible = true;
                Vendedor_Box.Visible = false;
            }
            
        }

       

       

       
        private void Vendedor_button_CheckedChanged(object sender, EventArgs e)
        {
            Results.Items.Clear();
            if (Vendedor_button.Checked == true)
            {
                Medico_box.Visible = false;
             
                
               
                Vendedor_Box.Visible = true;
            }
        }

        private void ID_BOX_TextChanged(object sender, EventArgs e)
        {
            Medico_box.SelectedItem = null;

           
           
            Vendedor_Box.SelectedItem = null;

            Results.Items.Clear();
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select Num_Contrato  from Contratos where Num_Contrato like '%" + ID_BOX.Text + "%'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString()!;
                Results.Items.Add(Output);
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        

      

        private void Vendedor_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Medico_box.SelectedItem = null;

            ID_BOX.Clear();
           
            

            Results.Items.Clear();
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            String vendedorID = Vendedor_Box.Text.Split(" - ")[0];

            sql = "Select Num_Contrato  from Contratos where Vendedor like '%" + vendedorID + "%'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString()!;
                Results.Items.Add(Output);
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

       

        private void Medico_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vendedor_Box.SelectedItem = null;

            ID_BOX.Clear();
           
            

            Results.Items.Clear();
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            String medicoID = Medico_box.Text.Split(" - ")[0];

            sql = "Select Num_Contrato  from Contratos where Medico like '%" + medicoID + "%'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString()!;
                Results.Items.Add(Output);
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void Select_contrato_Load(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            //EQUIPO COMBO BOX
            sql = "Select ID , Nombre from Equipos where ID like '%" + ID_BOX.Text + "%'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                
            }

            dataReader.Close();
            command.Dispose();
            //MEDICO COMBO BOX
            sql = "Select ID , Nombre from Medicos where ID like '%" + ID_BOX.Text + "%'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                Medico_box.Items.Add(Output);
            }
            dataReader.Close();
            command.Dispose();
            //VENDEDOR COMBO BOX
            sql = "Select ID , Nombre from Vendedor where ID like '%" + ID_BOX.Text + "%'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                Vendedor_Box.Items.Add(Output);
            }
            dataReader.Close();
            command.Dispose();

            cnn.Close();
        }

        private void Results_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Results.SelectedItem != null)
            {
                itemSplit = Results.SelectedItem.ToString()!.Split(" - ")[0];

                Editar_Contrato editar_Contrato = new Editar_Contrato();

                editar_Contrato.Show();
                this.Close();
            }
        }
    }
}
