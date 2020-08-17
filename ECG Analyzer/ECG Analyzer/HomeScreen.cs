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
        MDI mdi = new MDI();
        public HomeScreen()
        {
            InitializeComponent();            
            
        }

        MainClass mc = new MainClass();

        private void dataAnalysisBtn_Click(object sender, EventArgs e)
        {
            DataAnalysisForm da = new DataAnalysisForm();
            mc.showWindow(da, this, MDI.ActiveForm);
        }

        private void leftMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            mc.showWindow(uf, this, MDI.ActiveForm);
        }



        private void doctorBtn_Click(object sender, EventArgs e)
        {
            DoctorForm uf = new DoctorForm();
            mc.showWindow(uf, this, MDI.ActiveForm);
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            SettingForm uf = new SettingForm();
            mc.showWindow(uf, this, MDI.ActiveForm);
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            PatientForm uf = new PatientForm();
            mc.showWindow(uf, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            mdi.MainMenuStrip.Enabled = true;
        }

        private void dataBtn_Click(object sender, EventArgs e)
        {
            DataForm uf = new DataForm();
            mc.showWindow(uf, this, MDI.ActiveForm);
        }

    }
}