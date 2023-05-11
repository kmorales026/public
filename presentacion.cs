using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion.Reportes
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            DataGridReportesEnlacesMostrar();
            CargarClientes();
        }

        private void DataGridReportesEnlacesMostrar()
        {
            try
            {
                dgvReportesGeneral.DataSource = NReportes.ReportesEnlacesMostrar();
                this.FormatoDGEnlaces();
                lblTotalGeneral.Text = "N° Registros: " + Convert.ToString(dgvReportesGeneral.Rows.Count);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FormatoDGEnlaces() //DataGrid Datos Generales
        {
            dgvReportesGeneral.Columns[0].Visible = true; // ID Enlace
            dgvReportesGeneral.Columns[1].Visible = true; // Nombre del Cliente
            //dgvReportesGeneral.Columns[2].Visible = true; // Nombre del Enlace
            //dgvReportesGeneral.Columns[3].Visible = true; // Tipo de Servicio
            //dgvReportesGeneral.Columns[4].Visible = true; // Red Transporte
            //dgvReportesGeneral.Columns[5].Visible = true; // Ancho Banda
            //dgvReportesGeneral.Columns[6].Visible = true; // VLAN
            //dgvReportesGeneral.Columns[7].Visible = true; // CPE
            //dgvReportesGeneral.Columns[8].Visible = true; // ONU Modelo
            //dgvReportesGeneral.Columns[9].Visible = true; // ONU No Serie
            //dgvReportesGeneral.Columns[10].Visible = true; // IP ONU Gestion
            //dgvReportesGeneral.Columns[11].Visible = true; // Municipio
            //dgvReportesGeneral.Columns[12].Visible = true; // Departamento
            //dgvReportesGeneral.Columns[13].Visible = true; // Fecha Activacion

            dgvReportesGeneral.Columns[0].Width = 62;  // ID Enlace
            dgvReportesGeneral.Columns[1].Width = 228; // Nombre del Cliente
            //dgvReportesGeneral.Columns[2].Width = 228; // Nombre del Enlace
            //dgvReportesGeneral.Columns[3].Width = 80;  // Tipo de Servicio
            //dgvReportesGeneral.Columns[4].Width = 90;  // Red Transporte
            //dgvReportesGeneral.Columns[5].Width = 60;  // Ancho Banda
            //dgvReportesGeneral.Columns[6].Width = 40;  // VLAN
            //dgvReportesGeneral.Columns[7].Width = 100; // CPE
            //dgvReportesGeneral.Columns[8].Width = 90;  // ONU Modelo
            //dgvReportesGeneral.Columns[9].Width = 95;  // ONU No Serie
            //dgvReportesGeneral.Columns[10].Width = 90;  // IP ONU Gestion
            //dgvReportesGeneral.Columns[11].Width = 130;  // Municipio
            //dgvReportesGeneral.Columns[12].Width = 95;  // Departamento
            dgvReportesGeneral.Columns[13].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Fecha Activacion
        }

        private void FiltrarDataGridView()
        {

        }

        private void cboxClientesGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FiltrarDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CargarClientes()
        {
            try
            {
                cboxClientesGeneral.DataSource = NReportes.ReportesClientesMostrar();
                cboxClientesGeneral.ValueMember = "ID";
                cboxClientesGeneral.DisplayMember = "Nombre de Cliente";
                cboxClientesGeneral.SelectedValue = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
