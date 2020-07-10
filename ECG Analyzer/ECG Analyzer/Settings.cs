using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECG_Analyzer
{
    public partial class Settings : MasterLayoutForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        MainClass mClass=new MainClass();

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (intigratedSecurityCBox.Checked)
            {
                if (dataSourceTBox.Text == "") { dataSourceErrorLabel.Visible = true; } else { dataSourceErrorLabel.Visible = false; }
                if (databaseTBox.Text == "") { databaseErrorLabel.Visible = true; } else { databaseErrorLabel.Visible = false; }

                if (databaseErrorLabel.Visible || dataSourceErrorLabel.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    
                    sb.Append("Data Source=" + dataSourceTBox.Text + "; Initial Catalog=" + databaseTBox.Text +
                              ";Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(mClass.path+"\\connect",sb.ToString());

                    DialogResult dr = MessageBox.Show("Settings Save Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        mClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (dataSourceTBox.Text == "") { dataSourceErrorLabel.Visible = true; } else { dataSourceErrorLabel.Visible = false; }
                if (databaseTBox.Text == "") { databaseErrorLabel.Visible = true; } else { databaseErrorLabel.Visible = false; }
                if (usernameTBox.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
                if (passwrodTBox.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }

                if (databaseErrorLabel.Visible || dataSourceErrorLabel.Visible || usernameErrorLabel.Visible || passwordErrorLabel.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }
                else
                {
                    sb.Append("Data Source=" + dataSourceTBox.Text + "; Initial Catalog=" + databaseTBox.Text +
                              ";User Id="+usernameTBox.Text+";Password="+passwrodTBox.Text+ ";MultipleActiveResultSets=true");
                    File.WriteAllText(mClass.path + "\\connect", sb.ToString());

                    DialogResult dr = MessageBox.Show("Settings Save Successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (dr==DialogResult.OK)
                    {
                        Login log=new Login();
                        mClass.showWindow(log,this,MDI.ActiveForm);
                    }
                }
            }
        }

        private void dataSourceTBox_TextChanged(object sender, EventArgs e)
        {
            if (dataSourceTBox.Text == "") { dataSourceErrorLabel.Visible = true; } else { dataSourceErrorLabel.Visible = false; }
        }

        private void databaseTBox_TextChanged(object sender, EventArgs e)
        {
            if (databaseTBox.Text == "") { databaseErrorLabel.Visible = true; } else { databaseErrorLabel.Visible = false; }
        }

        private void usernameTBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameTBox.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
        }

        private void passwrodTBox_TextChanged(object sender, EventArgs e)
        {
            if (passwrodTBox.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
        }

        private void intigratedSecurityCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (intigratedSecurityCBox.Checked)
            {
                usernameTBox.Text = "";
                usernameTBox.Enabled = false;
                usernameErrorLabel.Visible = false;

                passwrodTBox.Text = "";
                passwrodTBox.Enabled = false;
                passwordErrorLabel.Visible = false;
            }
            else
            {

                usernameTBox.Enabled = true;
                

                passwrodTBox.Enabled = true;
            }
        }
    }
}
