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
    public partial class Agregar_Equipo : Form
    {
        public Agregar_Equipo()
        {
            InitializeComponent();
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;

            

            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Insert into Equipos(Nombre,Costo,Datos_adicionales)VALUES('"+NOMBRE_BOX.Text+"',"+COSTO_BOX.Value+",'"+DATOS_BOX.Text+"')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            NOMBRE_BOX.Clear();
            COSTO_BOX.Value = 0;
            DATOS_BOX.Clear();

            MessageBox.Show("Equipo Creado!");


            command.Dispose();
            cnn.Close();
        }
    }
}
