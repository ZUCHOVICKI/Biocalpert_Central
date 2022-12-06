using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biocalpert_Central
{
    
    public partial class Agregar_contratos : Form
    {
        public Dictionary<string, dynamic> equipos_Datos = new Dictionary<string, dynamic>();
        public Dictionary<string, dynamic> equipos_Datos_ID = new Dictionary<string, dynamic>();

        decimal CostoLap = 0;

       

        public Agregar_contratos()
        {
            InitializeComponent();
        }
       
        private void Agregar_contratos_Load(object sender, EventArgs e)
        {


            
            String str = MainMenu.connectStr;
            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";
            ////EQUIPO COMBO BOX
            sql = "Select ID , Nombre , Costo from Equipos";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (equipos_Datos.ContainsKey(dataReader.GetValue(1).ToString()!)){ }
                else
                {
                    Output = dataReader.GetValue(1).ToString()!;
                    Equipo_SELECT.Items.Add(Output);
                    equipos_Datos.Add(dataReader.GetValue(1).ToString()!, dataReader.GetValue(2).ToString()!);
                    equipos_Datos_ID.Add(dataReader.GetValue(1).ToString()!, dataReader.GetValue(0));
                }

            }

            dataReader.Close();
            command.Dispose();
            //MEDICO COMBO BOX
            sql = "Select ID , Nombre from Medicos ";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                MEDICO_BOX.Items.Add(Output);
            }
            dataReader.Close();
            command.Dispose();
            //VENDEDOR COMBO BOX
            sql = "Select ID , Nombre from Vendedor";
            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                VENDEDOR_BOX.Items.Add(Output);
            }
            dataReader.Close();
            command.Dispose();

            cnn.Close();
        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            String str = MainMenu.connectStr;

            
            String medicoID = MEDICO_BOX.Text.Split(" - ")[0];
            String VendedorID = VENDEDOR_BOX.Text.Split(" - ")[0];

            SqlConnection cnn = new SqlConnection(str);

            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "Insert into Contratos(Num_Contrato,Medico,Plazos,Vendedor,Cantidad_Lap,Margen,Margen_perc,Cantidad,Anticipo,Enganche,Fecha_Contrato,Fecha_Anticipo,Fecha_Enganche,Datos_adicionales)" +
                "VALUES(" + ID_BOX.Text + ",'" + medicoID + "','" + PLAZOS_BOX.Value + "','" + VendedorID + "'" +
                "," + Costo_LAP_BOX.Value + "," + MARGEN_BOX.Value + "," + MARGEN_PERC_BOX.Value + "," + CANTIDAD_BOX.Value + "," + ANTICIPO_BOX.Text + "," + ENGANCHE_BOX.Text + ",'"
                + FECHA_CONTRATO.Value.ToString("yyyy-MM-dd") + "','" + FECHA_ANTICIPO.Value.ToString("yyyy-MM-dd") + "','" + FECHA_ENGANCHE.Value.ToString("yyyy-MM-dd") + "','"
                + DATOS_BOX.Text + "')";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();


            CANTIDAD_BOX.Value = 0;
            ANTICIPO_BOX.Value = 0;
            ENGANCHE_BOX.Value = 0;
            PLAZOS_BOX.Value = 0;

            DATOS_BOX.Clear();

            MessageBox.Show("Contrato Creado!");


            command.Dispose();

            foreach (var item in EQUIPOS_BOX.Items)
            {
                sql = "Insert into ContratosEquipos Values('"+ equipos_Datos_ID[item.ToString()!] + "',"+ID_BOX.Text+")";
                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
            }

            //[0].Name = "# de Pago";
            //[1].Name = "Cantidad Faltante";
            //[2].Name = "Cantidad Pagada";
            //[3].Name = "Fecha De Pago";

            foreach (DataGridViewRow row in Plazos_grid.Rows)
            {

                try
                {
                    sql = "Insert into ContratoPlazos Values('" + ID_BOX.Text + "','" + row.Cells["# de Pago"].Value.ToString()! +
                        "','" + row.Cells["Cantidad Faltante"].Value.ToString()! + "','" + row.Cells["Cantidad Pagada"].Value.ToString()! + "','" + (DateTime.Parse(row.Cells["Fecha De Pago"].Value.ToString()!)).ToString("yyyy-MM-dd") + "')";
                    command = new SqlCommand(sql, cnn);

                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                catch (Exception ex) { }
            }

            EQUIPOS_BOX.Items.Clear();
            Costo_LAP_BOX.Value = 0;
            MARGEN_BOX.Value = 0;
            MARGEN_PERC_BOX.Value = 0;



            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EQUIPOS_BOX.Items.Add(Equipo_SELECT.Text);

            
            CostoLap += decimal.Parse( equipos_Datos[Equipo_SELECT.Text]);
            Costo_LAP_BOX.Value = CostoLap;
        }

        private void EQUIPOS_BOX_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Desea Borrar este Equipo?",
                                     "¿Borrar Equipo?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // If 'Yes', do something here.
                CostoLap -= decimal.Parse(equipos_Datos[EQUIPOS_BOX.SelectedItem.ToString()!]);
                Costo_LAP_BOX.Value = CostoLap;
                EQUIPOS_BOX.Items.RemoveAt(EQUIPOS_BOX.SelectedIndex);
                
            }
        }

        private void CANTIDAD_BOX_ValueChanged(object sender, EventArgs e)
        {
            if (Costo_LAP_BOX.Value != 0 && CANTIDAD_BOX.Value != 0) {

                MARGEN_BOX.Value = CANTIDAD_BOX.Value - Costo_LAP_BOX.Value;
                MARGEN_PERC_BOX.Value =100-( (Costo_LAP_BOX.Value / CANTIDAD_BOX.Value) * 100);
            }
        }

        private void Costo_LAP_BOX_ValueChanged(object sender, EventArgs e)
        {
            if (Costo_LAP_BOX.Value != 0 && CANTIDAD_BOX.Value != 0)
            {

                MARGEN_BOX.Value = CANTIDAD_BOX.Value - Costo_LAP_BOX.Value;
                MARGEN_PERC_BOX.Value = 100 - ((Costo_LAP_BOX.Value / CANTIDAD_BOX.Value) * 100);
            }
        }

        private void Agregar_contratos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                String str = MainMenu.connectStr;
                SqlConnection cnn = new SqlConnection(str);

                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                String sql, Output = "";
                ////EQUIPO COMBO BOX
                sql = "Select ID , Nombre , Costo from Equipos";
                command = new SqlCommand(sql, cnn);

                dataReader = command.ExecuteReader();
                Equipo_SELECT.Items.Clear();
                equipos_Datos.Clear();
                equipos_Datos_ID.Clear();

                while (dataReader.Read())
                {
                    Output = dataReader.GetValue(1).ToString()!;
                    Equipo_SELECT.Items.Add(Output);
                    
                    equipos_Datos.Add(dataReader.GetValue(1).ToString()!, dataReader.GetValue(2).ToString()!);
                    equipos_Datos_ID.Add(dataReader.GetValue(1).ToString()!, dataReader.GetValue(0));

                }

                dataReader.Close();
                command.Dispose();
                //MEDICO COMBO BOX
                sql = "Select ID , Nombre from Medicos ";
                command = new SqlCommand(sql, cnn);

                dataReader = command.ExecuteReader();
                MEDICO_BOX.Items.Clear();
                while (dataReader.Read())
                {
                    Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                    MEDICO_BOX.Items.Add(Output);
                }
                dataReader.Close();
                command.Dispose();
                //VENDEDOR COMBO BOX
                sql = "Select ID , Nombre from Vendedor";
                command = new SqlCommand(sql, cnn);

                dataReader = command.ExecuteReader();
                VENDEDOR_BOX.Items.Clear();
                while (dataReader.Read())
                {
                    Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                    VENDEDOR_BOX.Items.Add(Output);
                }
                dataReader.Close();
                command.Dispose();

                cnn.Close();
                
            }
        }

        private void Quick_medico_Click(object sender, EventArgs e)
        {
            string value = "";

            if (InputBox("Agregar Médico", "Agregar Médico", ref value) == DialogResult.OK)
            {
                String str = MainMenu.connectStr;



                SqlConnection cnn = new SqlConnection(str);

                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql, Output = "";
                sql = "Insert into Medicos(Nombre)VALUES('"+value+"')";
                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();

                

               


                command.Dispose();

                //MEDICO COMBO BOX
                MEDICO_BOX.Items.Clear();
                sql = "Select ID , Nombre from Medicos ";
                command = new SqlCommand(sql, cnn);

                dataReader = command.ExecuteReader();
                int index = -1;
                while (dataReader.Read())
                {
                    Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                    MEDICO_BOX.Items.Add(Output);
                    index++;
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();

               MEDICO_BOX.SelectedIndex = index;
            }
        }


        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(255, 36, 250, 13);
            textBox.SetBounds(10, 86, 580, 20);
            buttonOk.SetBounds(150, 160, 100, 60);
            buttonCancel.SetBounds(350, 160, 100, 60);

            label.AutoSize = true;
            form.ClientSize = new Size(600, 300);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
        }

        private void Quick_vendedor_Click(object sender, EventArgs e)
        {
            string value = "";

            if (InputBox("Agregar Vendedor", "Agregar Vendedor", ref value) == DialogResult.OK)
            {
                String str = MainMenu.connectStr;



                SqlConnection cnn = new SqlConnection(str);

                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql, Output = "";
                sql = "Insert into Vendedor(Nombre)VALUES('" + value + "')";
                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();






                command.Dispose();

                //Vendedor COMBO BOX
                VENDEDOR_BOX.Items.Clear();
                sql = "Select ID , Nombre from Vendedor ";
                command = new SqlCommand(sql, cnn);

                dataReader = command.ExecuteReader();
                int index = -1;
                while (dataReader.Read())
                {
                    Output = dataReader.GetValue(0) + " - " + dataReader.GetValue(1);
                    VENDEDOR_BOX.Items.Add(Output);
                    index++;
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();

                VENDEDOR_BOX.SelectedIndex = index;
            }
        }

        private void Quick_equipo_Click(object sender, EventArgs e)
        {
            string value = "";

            if (InputBox("Agregar Equipo", "Agregar Equipo", ref value) == DialogResult.OK)
            {
                String str = MainMenu.connectStr;



                SqlConnection cnn = new SqlConnection(str);

                cnn.Open();

                SqlCommand command;
                SqlDataReader dataReader;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql, Output = "";
                sql = "Insert into Equipos(Nombre,Costo)VALUES('" + value + "',"+0+")";
                command = new SqlCommand(sql, cnn);

                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();






                command.Dispose();

                //Equipo COMBO BOX
                Equipo_SELECT.Items.Clear();
                equipos_Datos.Clear();
                equipos_Datos_ID.Clear();
                sql = "Select ID , Nombre,Costo from Equipos ";
                command = new SqlCommand(sql, cnn);

                dataReader = command.ExecuteReader();
                int index = -1;
                while (dataReader.Read())
                {
                    if (equipos_Datos.ContainsKey(dataReader.GetValue(1).ToString())) { }
                    else
                    {
                        Output = dataReader.GetValue(1).ToString()!;
                        Equipo_SELECT.Items.Add(Output);
                        equipos_Datos.Add(dataReader.GetValue(1).ToString()!, dataReader.GetValue(2).ToString()!);
                        equipos_Datos_ID.Add(dataReader.GetValue(1).ToString()!, dataReader.GetValue(0));
                        index++;
                    }
                    
                }
                dataReader.Close();
                command.Dispose();
                cnn.Close();

                Equipo_SELECT.SelectedIndex = index;
            }
        }

        private void Agregar_plazos_Click(object sender, EventArgs e)
        {
            if (CANTIDAD_BOX.Value > 0)
                Plazos_grid.ColumnCount = 4;
            Plazos_grid.Columns[0].Name = "# de Pago";
            Plazos_grid.Columns[1].Name = "Cantidad Faltante";
            Plazos_grid.Columns[2].Name = "Cantidad Pagada";
            Plazos_grid.Columns[3].Name = "Fecha De Pago";
            Plazos_grid.Rows.Clear();


            if (Mensual_check.Checked)
            {

                decimal cantidadMensual = ((CANTIDAD_BOX.Value-ANTICIPO_BOX.Value)-ENGANCHE_BOX.Value) / PLAZOS_BOX.Value;
                decimal cantidadRestante = ((CANTIDAD_BOX.Value - ANTICIPO_BOX.Value) - ENGANCHE_BOX.Value);
                DateTime fechaActual = FECHA_CONTRATO.Value;
                int pagoActual = 0;
                dynamic[] dataRow = { };
                while (cantidadRestante > 0)
                {

                    pagoActual = pagoActual + 1;
                    cantidadRestante = cantidadRestante - cantidadMensual;
                  
                    fechaActual = fechaActual.AddMonths(1);
                    dataRow = new dynamic[] { pagoActual, cantidadRestante, cantidadMensual, fechaActual };


                    Plazos_grid.Rows.Add(dataRow);

                    Array.Clear(dataRow);

                }

                


            }
            if (Quincenal_Check.Checked)
            {
                decimal cantidadQuincena = ((CANTIDAD_BOX.Value - ANTICIPO_BOX.Value) - ENGANCHE_BOX.Value) / PLAZOS_BOX.Value;
                decimal cantidadRestante = ((CANTIDAD_BOX.Value - ANTICIPO_BOX.Value) - ENGANCHE_BOX.Value);
                DateTime fechaActual = FECHA_CONTRATO.Value;
                DateTime fechaActualFirst = FECHA_CONTRATO.Value;
                int pagoActual = 0;
                dynamic[] dataRow = { };
                while (cantidadRestante > 0)
                {

                    pagoActual = pagoActual + 1;
                    cantidadRestante = cantidadRestante - cantidadQuincena;

                    //CHECK IF OVER 15TH DAY

                    if (fechaActual.Day >= 15)
                    {
                        fechaActualFirst = fechaActual.AddMonths(1);
                        fechaActual = new DateTime(fechaActualFirst.Year, fechaActualFirst.Month, 1);
                    }
                    else
                    {

                        fechaActual = new DateTime(fechaActual.Year, fechaActual.Month, 15);
                    }


                    dataRow = new dynamic[] { pagoActual, cantidadRestante, cantidadQuincena, fechaActual };


                    Plazos_grid.Rows.Add(dataRow);

                    Array.Clear(dataRow);
                }
            }
                if (Especifico_Check.Checked)
                {
                    decimal cantidadMensual = ((CANTIDAD_BOX.Value - ANTICIPO_BOX.Value) - ENGANCHE_BOX.Value) / PLAZOS_BOX.Value;
                    decimal cantidadRestante = ((CANTIDAD_BOX.Value - ANTICIPO_BOX.Value) - ENGANCHE_BOX.Value);
                    DateTime fechaActual = FECHA_CONTRATO.Value;
                    int pagoActual = 0;
                    dynamic[] dataRow = { };
                    while (cantidadRestante > 0)
                    {

                        pagoActual = pagoActual + 1;
                        cantidadRestante = cantidadRestante - cantidadMensual;
                        fechaActual = fechaActual.AddDays(Double.Parse(PERIODO_BOX.Value.ToString()));
                        dataRow = new dynamic[] { pagoActual, cantidadRestante, cantidadMensual, fechaActual };


                        Plazos_grid.Rows.Add(dataRow);

                        Array.Clear(dataRow);

                    }
                }

            }
        
        

        private void Mensual_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Mensual_check.Checked)
            {

                Quincenal_Check.Checked = false;
                Especifico_Check.Checked = false;

                PERIODO_BOX.Enabled = false;
                Periodo_label.Enabled = false;

            }
        }

        private void Quincenal_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Quincenal_Check.Checked)
            {
                Mensual_check.Checked = false;
                Especifico_Check.Checked = false;

                PERIODO_BOX.Enabled = false;
                Periodo_label.Enabled = false;

            }
           
        }

        private void Especifico_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Especifico_Check.Checked)
            {
                Quincenal_Check.Checked = false;
                Mensual_check.Checked = false;

                PERIODO_BOX.Enabled = true;
                Periodo_label.Enabled = true;

            }
        }

        
    }
}
