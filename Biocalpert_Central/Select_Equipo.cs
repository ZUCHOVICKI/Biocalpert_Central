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

    public partial class Select_Equipo : Form
    {
        public static string itemSplit = "";
        public Select_Equipo()
        {
            InitializeComponent();
        }

        private void ID_BOX_TextChanged(object sender, EventArgs e)
        {
            Nombre_Box.Clear();
  
            Results.Items.Clear();
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql,Output = "";

            sql = "Select ID , Nombre , Costo , Datos_adicionales from Equipos where ID like '%" + ID_BOX.Text + "%'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            
            while(dataReader.Read())
            {
                Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                Results.Items.Add(Output);
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void Nombre_Box_TextChanged(object sender, EventArgs e)
        {
            ID_BOX.Clear();
            Results.Items.Clear();
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "Select ID , Nombre , Costo , Datos_adicionales from Equipos where Nombre like '%" + Nombre_Box.Text + "%'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                Results.Items.Add(Output);
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

                Editar_Equipo editar_Equipo = new Editar_Equipo();

                editar_Equipo.Show();
                this.Close();
            }
        }
    }
}
