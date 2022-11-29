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
    public partial class Editar_Equipo : Form
    {
        public Editar_Equipo()
        {
            InitializeComponent();
        }

        private void Editar_Equipo_Load(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";


            sql = "Select ID , Nombre , Costo , Datos_adicionales from Equipos where ID = '" + Select_Equipo.itemSplit + "'";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                ID_BOX.Text = dataReader.GetValue(0).ToString();
                NOMBRE_BOX.Text = dataReader.GetValue(1).ToString();
                COSTO_BOX.Value = Decimal.Parse(dataReader.GetValue(2).ToString()!);
                DATOS_BOX.Text = dataReader[3].ToString();
                
               
                

            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void Borrar_Button_Click(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;

            var confirmResult = MessageBox.Show("Desea Borrar este Equipo??",
                                     "Borrar Equipo!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.



                SqlConnection cnn = new SqlConnection(str);

                cnn.Open();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";
                sql = "Delete  Equipos where ID =" + "'" + ID_BOX.Text + "'";
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
            sql = "Update  Equipos SET  Nombre = '" + NOMBRE_BOX.Text + "',Costo = " + COSTO_BOX.Value + ", Datos_adicionales = '" + DATOS_BOX.Text + "' where ID = "+"'"+ID_BOX.Text+"'";
            command = new SqlCommand(sql, cnn);

            adapter.UpdateCommand = new SqlCommand(sql, cnn);
            adapter.UpdateCommand.ExecuteNonQuery();

            

            MessageBox.Show("Equipo Editado!");


            command.Dispose();
            cnn.Close();
        }
    }
}
