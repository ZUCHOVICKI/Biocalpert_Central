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
    public partial class Agregar_Vendedor : Form
    {
        public Agregar_Vendedor()
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
            sql = "Insert into Vendedor(Nombre,Datos_adicionales)VALUES('" + NOMBRE_BOX.Text + "','" + DATOS_BOX.Text + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            NOMBRE_BOX.Clear();
            
            DATOS_BOX.Clear();

            MessageBox.Show("Vendedor Creado!");


            command.Dispose();
            cnn.Close();
        }
    }
}
