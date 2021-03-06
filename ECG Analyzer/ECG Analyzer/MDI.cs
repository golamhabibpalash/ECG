﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ECG_Analyzer
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        MainClass mPath=new MainClass();

        private void MDI_Load(object sender, EventArgs e)
        {

           
            if (File.Exists(mPath.path+"\\connect"))
            {                
                Login obj = new Login();
                obj.MdiParent = this;
                obj.Show();
                obj.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                Settings obj = new Settings();
                obj.MdiParent = this;
                obj.Show();
                obj.WindowState = FormWindowState.Maximized;
                
            }
            
        }
        
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
