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

        private void CargarClientes()
        {
            try
            {
                cboxClientesGeneral.DataSource = NReportes.ReportesClientesMostrar();
                cboxClientesGeneral.ValueMember = "ID";
                cboxClientesGeneral.DisplayMember = "Nombre de Cliente";
                cboxClientesGeneral.SelectedValueChanged += new EventHandler(cboxClientesGeneral_SelectedValueChanged);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cboxClientesGeneral_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)cboxClientesGeneral.SelectedItem;
                int clienteid = int.Parse(selectedRow["ID"].ToString());
                //dgvReportesGeneral.DataSource = NReportes.ReportesClientesFiltro(clienteid);

                if (clienteid != 0)
                {
                    dgvReportesGeneral.DataSource = NReportes.ReportesClientesFiltro(clienteid);
                }
                else
                {
                    DataGridReportesEnlacesMostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
