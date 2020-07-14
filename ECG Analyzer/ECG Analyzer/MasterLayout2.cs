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
    public partial class MasterLayout2 : MasterLayoutForm
    {
        public MasterLayout2()
        {
            InitializeComponent();
        }

        private void MasterLayout2_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainClass mc = new MainClass();
            HomeScreen hs = new HomeScreen();
            mc.showWindow(hs,this,MDI.ActiveForm);
        }
    }
}
