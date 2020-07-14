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
    public partial class MasterLayoutForm : Form
    {
        public MasterLayoutForm()
        {
            InitializeComponent();
        }

        public void pageTitleLabel_Click(object sender, EventArgs e)
        {
            pageTitleLabel.Text = Form.ActiveForm.Name;
        }
    }
}
