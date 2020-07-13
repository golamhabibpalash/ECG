using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECG_Analyzer
{
    class MainClass
    {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public void showWindow(Form openWin, Form closeWin, Form MDI)
        {
            closeWin.Close();
            openWin.MdiParent = MDI;
            openWin.Show();
            openWin.WindowState = FormWindowState.Maximized;
        }

    }
}
