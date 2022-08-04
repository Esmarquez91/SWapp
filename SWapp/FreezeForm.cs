using System;
using SWapp.Clases;
using System.Windows.Forms;

namespace SWapp
{
    public partial class FreezeForm : Form
    {
        public FreezeForm()
        {
            InitializeComponent();            
        }

        private void FreezeForm_Load(object sender, EventArgs e)
        {
            DataGridFreeze.RowHeadersVisible = false;
            
            BaseDeDatos.GetTableFreeze(DataGridFreeze);
            DataGridFreeze.Columns[0].Visible = false;
        }

        string FechaInicioFreeze;
        string FechaFinFreeze;
        string HoraInicioFreeze;
        string HoraFinFreeze;
        private void BtnAddFreeze_Click(object sender, EventArgs e)
        {
            FechaInicioFreeze = DateFreezeInicio.Text.Split(' ')[0];
            HoraInicioFreeze = DateFreezeInicio.Text.Split(' ')[1];
            FechaFinFreeze = DateFreezeFin.Text.Split(' ')[0];
            HoraFinFreeze = DateFreezeFin.Text.Split(' ')[1];
            BaseDeDatos.AgregarFreeze(TxtCRTCliente.Text, HoraInicioFreeze, FechaInicioFreeze, HoraFinFreeze, FechaFinFreeze);
            MessageBox.Show(TxtCRTCliente.Text + " agregado a un período de Freezing");
            TxtCRTCliente.Clear();
            BaseDeDatos.GetTableFreeze(DataGridFreeze);
        }

        private void BtnDeleteFreeze_Click(object sender, EventArgs e)
        {
            int IdFreeze = (int)DataGridFreeze.CurrentRow.Cells["Id"].Value;
            BaseDeDatos.DeleteFreeze(IdFreeze);
            BaseDeDatos.GetTableFreeze(DataGridFreeze);
        }
    }
}
