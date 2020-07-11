using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace ECG_Analyzer
{
    public partial class DataAnalysis : MasterLayoutForm
    {
        private SerialPort myPort;
        private DateTime dateTime;
        private string in_data;

        public DataAnalysis()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            myPort=new SerialPort();
            myPort.BaudRate = Convert.ToInt32(boudCBox.Text);
            myPort.PortName = portCBox.Text;
            myPort.Parity = Parity.None;
            myPort.DataBits = 8;
            myPort.StopBits = StopBits.One;
            myPort.DataReceived += myport_DataReceived;
            try
            {
                myPort.Open();
                dataTBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                throw;
            }
        }

        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            

            this.Invoke(new EventHandler(displadata_event));

            in_data = myPort.ReadLine();
            
        }

        private void displadata_event(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            string time = dateTime.Hour + ":" + dateTime.Minute + ":" + dateTime.Second;
            dataTBox.AppendText(time+"\t\t"+in_data+"\n");

            //Progressbar Code
            int data_value = Convert.ToInt32(in_data);
            progressBar.Value = data_value;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                myPort.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
                throw;
            }
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string pathfile = @"C:\Users\golam\Desktop\Data\";
                string filename = "light_data.txt";
                File.WriteAllText(pathfile+filename,dataTBox.Text);
                MessageBox.Show("Data has been Saved to " + pathfile, "Save file");
            }
            catch (Exception exception3)
            {
                MessageBox.Show(exception3.Message, "Error");
            }
            
        }
    }
}
