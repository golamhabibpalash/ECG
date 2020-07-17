using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECG_Analyzer
{
    public partial class HomeScreen : MasterLayoutForm
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        MainClass mc = new MainClass();

        private void dataAnalysisBtn_Click(object sender, EventArgs e)
        {
            DataAnalysis da = new DataAnalysis();
            mc.showWindow(da, this, MDI.ActiveForm);
        }

        private void leftMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
