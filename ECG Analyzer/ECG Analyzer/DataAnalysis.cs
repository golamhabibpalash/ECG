using System;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Windows.Forms;

namespace ECG_Analyzer
{
    public partial class DataAnalysis : MasterLayout2
    {
        private SerialPort myPort;
        private DateTime dateTime;
        public string in_data;
        public int rowData;
        public bool startButtonClick = false;
        bool portBoutSelected = false;

        public DataAnalysis()
        {
            InitializeComponent();
        }
        private void DataAnalysis_Load(object sender, EventArgs e)
        {
            //Code for Find Auto Port Name in Port List
            string[] ports = SerialPort.GetPortNames();
            portCBox.Items.Clear();
            foreach (string comport in ports)
            {
                portCBox.Items.Add(comport);
            }

        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            
                myPort = new SerialPort();
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
                    startButtonClick = true;
                    dataGridView.Enabled = false;
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
            rowData = Convert.ToInt32(in_data);
        }

        private void displadata_event(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            string time = dateTime.Hour + ":" + dateTime.Minute + ":" + dateTime.Second;
            dataTBox.AppendText(time+"\t\t"+in_data+"\n");

            //Progressbar Code
            //int data_value = Convert.ToInt32(in_data);
            //progressBar.Value = data_value;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (startButtonClick == true)
            {
                try
                {
                    dataGridView.Enabled = true;
                    myPort.Close();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM pqrstTable", "server=.;database=ccmsDB;Trusted_Connection=True");
                    DataSet ds = new DataSet();
                    da.Fill(ds, "pqrstTable");
                    dataGridView.DataSource = ds.Tables["pqrstTable"].DefaultView;

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Please Click Start Button First");
                startBtn.Focus();
            }
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.Enabled==true)
            {
                try
                {
                    //string pathfile = @"C:\Users\GH Palash\Desktop\Data\";
                    //string filename = "light_data.txt";
                    //File.WriteAllText(pathfile+filename,dataTBox.Text);
                    //MessageBox.Show("Data has been Saved to " + pathfile, "Save file");

                    String str = "server=.;database=ccmsDB;Trusted_Connection=True";
                    //String query = "select * from pqrstTable";
                    String insertQuery = "INSERT INTO pqrstTable VALUES('" + rowData + "', '" + rowData + "', '" + rowData + "','" + rowData + "','" + rowData + "')";
                    SqlConnection con = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    con.Open();
                    //DataSet ds = new DataSet();
                    MessageBox.Show("connect with sql server");

                    con.Close();
                }
                catch (Exception exception3)
                {
                    MessageBox.Show(exception3.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Click Start Button First");
            }
            
            
        }

        private void portCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void boudCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
