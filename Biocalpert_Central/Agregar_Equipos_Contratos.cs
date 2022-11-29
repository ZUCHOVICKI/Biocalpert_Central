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
    public partial class Agregar_Equipos_Contratos : Form
    {
        public Agregar_Equipos_Contratos()
        {
            InitializeComponent();
        }

        private void Agregar_Equipos_Contratos_Load(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            ////EQUIPO COMBO BOX
            sql = "Select ID , Nombre from Equipos ";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(1).ToString()!;
                Equipo_BOX.Items.Add(Output);
            }

            dataReader.Close();
            command.Dispose();
            cnn.Close();
        }

        private void Agregar_Equipo_Click(object sender, EventArgs e)
        {
            Agregar_contratos agregar_Contratos = new Agregar_contratos();

            

            agregar_Contratos.equipos_Datos.Add(Equipo_BOX.Text, 1);

           // agregar_Contratos.UpdateBOX();



            //this.Close();
        }
    }
}
