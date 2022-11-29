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
    public partial class MainMenu : Form
    {
        public static String connectStr = "server=localhost\\SQLEXPRESS;database=Admin_BIO;UID=admin;password=123";

        public MainMenu()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            ContratosArea.Visible = false;
            EquiposArea.Visible = false;
            MedicosArea.Visible = false;
            
            Vendedor_Area.Visible = false;
        }

        private void showArea(Panel submenu)
        {
            if (submenu.Visible) {
                submenu.Visible = false;
            }
            else
            {
                submenu.Visible=true;
            }
            



            
        }

        private void Contratos_Click(object sender, EventArgs e)
        {
            showArea(ContratosArea);
        }

        private void Equipos_Click(object sender, EventArgs e)
        {
            showArea(EquiposArea);
        }

        private void Médicos_Click(object sender, EventArgs e)
        {
            showArea(MedicosArea);
        }

       

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void Vendedores_Click(object sender, EventArgs e)
        {
            showArea(Vendedor_Area);
        }

        private void Agregar_Contrato_Click(object sender, EventArgs e)
        {
            Agregar_contratos agregar_Contratos = new Agregar_contratos();
            agregar_Contratos.Show();
        }

        private void Agregar_Equipo_Click(object sender, EventArgs e)
        {
            Agregar_Equipo equipo_Contratos = new Agregar_Equipo();
            equipo_Contratos.Show();
        }

        private void Agregar_Medicos_Click(object sender, EventArgs e)
        {
            Agregar_Medico agregar_Medico = new Agregar_Medico();
            agregar_Medico.Show();
        }

        private void Agregar_vendedores_Click(object sender, EventArgs e)
        {
            Agregar_Vendedor agregar_Vendedor = new Agregar_Vendedor();
            agregar_Vendedor.Show();
        }

        private void Editar_Contrato_Click(object sender, EventArgs e)
        {
            Select_contrato select_Contrato = new Select_contrato();
            select_Contrato.Show();
        }

        private void Editar_Equipos_Click(object sender, EventArgs e)
        {
            Select_Equipo select_Equipo = new Select_Equipo();
            select_Equipo.Show();
        }

        private void Editar_Medicos_Click(object sender, EventArgs e)
        {
            Select_Medico select_Medico = new Select_Medico();
            select_Medico.Show();
        }

        private void Editar_Vendedores_Click(object sender, EventArgs e)
        {
            Select_Vendedor select_Vendedor = new Select_Vendedor();
            select_Vendedor.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
        }
    }
}
