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
    public partial class SettingForm : MasterLayout2
    {
        public SettingForm()
        {
            InitializeComponent();
        }
        MainClass mc=new MainClass();
        private void DatabaseSettingBtn_Click(object sender, EventArgs e)
        {
            Settings settings=new Settings();
            mc.showWindow(settings,this,MDI.ActiveForm);
        }
    }
}
