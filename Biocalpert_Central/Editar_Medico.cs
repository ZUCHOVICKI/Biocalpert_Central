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
    public partial class Editar_Medico : Form
    {
        public Editar_Medico()
        {
            InitializeComponent();
        }

        private void Editar_Medico_Load(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";


            sql = "Select ID , Nombre , Direccion , Datos_adicionales from Medicos where ID = '" + Select_Medico.itemSplit + "'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ID_BOX.Text = dataReader.GetValue(0).ToString();
                NOMBRE_BOX.Text = dataReader.GetValue(1).ToString();
                DIRECCION_BOX.Text = dataReader.GetValue(2).ToString();
                DATOS_BOX.Text = dataReader[3].ToString();




            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void Borrar_Button_Click(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;

            var confirmResult = MessageBox.Show("Desea Borrar este Médico??",
                                     "Borrar Médico!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.



                SqlConnection cnn = new SqlConnection(str);

                cnn.Open();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";
                sql = "Delete  Medicos where ID =" + "'" + ID_BOX.Text + "'";
                command = new SqlCommand(sql, cnn);

                adapter.DeleteCommand = new SqlCommand(sql, cnn);
                adapter.DeleteCommand.ExecuteNonQuery();





                command.Dispose();
                cnn.Close();
                this.Close();
            }
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;



            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Update  Medicos SET  Nombre = '" + NOMBRE_BOX.Text + "',Direccion = '" + DIRECCION_BOX.Text + "', Datos_adicionales = '" + DATOS_BOX.Text + "' where ID = " + "'" + ID_BOX.Text + "'";
            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();



            MessageBox.Show("Médico Editado!");


            command.Dispose();
            cnn.Close();
        }
    }
}
