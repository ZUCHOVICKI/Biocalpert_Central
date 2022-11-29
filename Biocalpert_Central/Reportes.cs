using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Biocalpert_Central
{
    
    public partial class Reportes : Form
    {
        
    
        public Reportes()
        {
            InitializeComponent();
            
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            

            sql = "Select ID,Nombre  from Vendedor";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString()+"--"+dataReader.GetValue(1).ToString()!;
                Vendedor_BOX.Items.Add(Output);
            }

            dataReader.Close();
            command.Dispose();

            sql = "Select ID,Nombre  from Medicos";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString() + "--" + dataReader.GetValue(1).ToString()!;
                Medicos_BOX.Items.Add(Output);
            }

            dataReader.Close();
            command.Dispose();

            
            cnn.Close();

           
        }

        private void Select_Vendedores_Click(object sender, EventArgs e)
        {
            if (Select_Vendedores.Text == "Seleccionar Todos")
            {

                for (int i = 0; i < Vendedor_BOX.Items.Count; i++) 
                {
                    Vendedor_BOX.SetItemChecked(i, true);
                }
                Select_Vendedores.Text = "Borrar Todos";
            }
            else {
                for (int i = 0; i < Vendedor_BOX.Items.Count; i++)
                {
                    Vendedor_BOX.SetItemChecked(i, false);
                }
                Select_Vendedores.Text = "Seleccionar Todos";
            }
            }

        private void Dates_CheckedChanged(object sender, EventArgs e)
        {
            if (Dates.Checked == true)
            {

                Initial_date.Enabled = true;
                Final_date.Enabled = true;
                fecha_final.Enabled = true;
                Fecha_inicial.Enabled = true;

            }
            else {
                Initial_date.Enabled = false;
                Final_date.Enabled = false;
                fecha_final.Enabled = false;
                Fecha_inicial.Enabled = false;
            }
        }

        private void Select_Medicos_Click(object sender, EventArgs e)
        {
            if (Select_Medicos.Text == "Seleccionar Todos")
            {

                for (int i = 0; i < Medicos_BOX.Items.Count; i++)
                {
                    Medicos_BOX.SetItemChecked(i, true);
                }
                Select_Medicos.Text = "Borrar Todos";
            }
            else
            {
                for (int i = 0; i < Medicos_BOX.Items.Count; i++)
                {
                    Medicos_BOX.SetItemChecked(i, false);
                }
                Select_Medicos.Text = "Seleccionar Todos";
            }
        }

       

        private void Buscar_Click(object sender, EventArgs e)
        {
            string constring = MainMenu.connectStr;
            using (SqlConnection con = new SqlConnection(constring))
            {

                
                string finalMedico = "";
                string finalVendedor = "";
               
                foreach (Object item in Medicos_BOX.CheckedItems)
                {
                    string itemSplitM = item.ToString()!.Split("--")[0];
                    if (finalMedico == "")
                    {
                        finalMedico += itemSplitM;
                    }
                    else
                    {
                        finalMedico += "," + itemSplitM;
                    }



                }
                foreach (Object item in Vendedor_BOX.CheckedItems)
                {
                    string itemSplitV = item.ToString()!.Split("--")[0];
                    if (finalVendedor == "")
                    {
                        finalVendedor += itemSplitV;
                    }
                    else
                    {
                        finalVendedor += "," + itemSplitV;
                    }


                }
               

               
               
                if(finalMedico == "")
                {
                    finalMedico += "0";
                }
                if(finalVendedor == "")
                {
                    finalVendedor += "0";
                }

                string extraData = "";
                if (Dates.Checked==true)
                {
                    extraData = "and c.Fecha_contrato <= '" + Final_date.Value.ToString("yyyy-MM-dd") + "' and c.Fecha_contrato >= '" + Initial_date.Value.ToString("yyyy-MM-dd") + "'";
                }


                using (SqlCommand cmd = new SqlCommand("SELECT c.ID , m.Nombre as Médico , v.Nombre as Vendedor , c.Cantidad as CostoFinal, c.Cantidad_LAP, c.Margen, c.Margen_perc ,c.Anticipo,c.Enganche,c.Fecha_contrato,c.Fecha_anticipo,c.Fecha_enganche" +
                    " FROM Contratos c " +
                    " INNER JOIN medicos m on c.Medico = m.ID" +
                    " INNER JOIN vendedor v on c.Vendedor = v.ID" +
                    " and Vendedor in (" + finalVendedor + ")" +
                    " and Medico in (" + finalMedico + ")" + extraData
                    , con))

               
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("SELECT  v.Nombre as Vendedor , SUM(c.Cantidad) as Cantidad , SUM(c.Margen) as Margen , (100-(Sum(c.Margen)*100/Sum(c.Cantidad))) as Procentaje" +
                    " FROM Contratos c " +
                    " INNER JOIN medicos m on c.Medico = m.ID" +
                    " INNER JOIN vendedor v on c.Vendedor = v.ID" +
                    " and Vendedor in (" + finalVendedor + ")" +
                    " and Medico in (" + finalMedico + ")" + extraData+
                    " Group BY v.Nombre"
                    , con))


                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView2.DataSource = dt;
                        }
                    }
                }
 
                using (SqlCommand cmd = new SqlCommand("SELECT m.Nombre as Médico , SUM(c.Cantidad) as Cantidad, SUM(c.Margen) as Margen , (100-(Sum(c.Margen)*100/Sum(c.Cantidad))) as Procentaje" +
                    " FROM Contratos c " +
                    " INNER JOIN medicos m on c.Medico = m.ID" +
                    " INNER JOIN vendedor v on c.Vendedor = v.ID" +
                    " and Vendedor in (" + finalVendedor + ")" +
                    " and Medico in (" + finalMedico + ")" + extraData +
                    " Group BY m.Nombre"
                    , con))


                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView4.DataSource = dt;
                        }
                    }
                }
            }
        }
       
    }
    }
   
 
