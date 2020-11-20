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

namespace ECG_Analyzer
{
    public partial class DataForm : MasterLayout2
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select Cycle,PData,QData,RData,SData, TData from pqrst where PatientId='"+patientIdTBox.Text+"' and DayCount='"+dayTestCount.Text+"'",
                    "server = .; database = ccmsDB; Integrated Security=true;");
                DataSet ds = new DataSet();
                da.Fill(ds, "pqrst");
                dataGridView.DataSource = ds.Tables["pqrst"].DefaultView;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                throw;
            }
        }
    }
}
