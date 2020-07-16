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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MainClass mClass = new MainClass();

        private void enterBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            mClass.showWindow(hs, this, MDI.ActiveForm);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
