using ECG_Analyzer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Windows.Forms;

namespace ECG_Analyzer
{
    public partial class DataAnalysisForm : MasterLayout2
    {
        public DataAnalysisForm()
        {
            InitializeComponent();
        }

        //Initial Variable Calling
        private SerialPort myPort;
        private DateTime dateTime;
        public string in_data;
        public int rowData;
        public bool startButtonClick = false;

        List<int> PData = new List<int>();
        List<int> QData = new List<int>();
        List<int> RData = new List<int>();
        List<int> SData = new List<int>();
        List<int> TData = new List<int>();
        List<int> PatientId = new List<int>();
        List<int> DayCount = new List<int>();
        List<int> Cycle = new List<int>();
        List<int> AverageRowData = new List<int>();

        


        //Create Object for Other Class



        private void DataAnalysis_Load(object sender, EventArgs e)
        {
            //Code for Find Auto Port Name in Port List
            string[] ports = SerialPort.GetPortNames();
            portCBox.Items.Clear();
            foreach (string comport in ports)
            {
                portCBox.Items.Add(comport);
            }

            saveDataBtn.Enabled = false;

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
                saveDataBtn.Enabled = false;
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
            if (!string.IsNullOrEmpty(in_data))
            {
                rowData = Convert.ToInt32(in_data.Trim());
                PData.Add(rowData);
                QData.Add(rowData);
                RData.Add(rowData);
                SData.Add(rowData);
                TData.Add(rowData);
                
            }
            
                       
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
                    saveDataBtn.Enabled = true;
                    myPort.Close();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM pqrst", "server = GH-PALASH\\SQLEXPRESS; database = ccmsDB; Integrated Security=true;");
                    DataSet ds = new DataSet();
                    da.Fill(ds, "pqrst");
                    dataGridView.DataSource = ds.Tables["pqrst"].DefaultView;
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




                    SqlConnection con = new SqlConnection(@"server=GH-PALASH\SQLEXPRESS;database=ccmsDB;Integrated Security=True");
                    string dataInsertQuery ="INSERT INTO PQRST"+
                        "(patientId,Cycle,DayCount,PData,QData,RData,SData,TData) values(@patientId,@Cycle,@DayCount,@PData,@QData,@RData,@SData,@TData)";

                    SqlCommand cmd = new SqlCommand(dataInsertQuery, con);

                    cmd.Parameters.AddWithValue("@patientId", 1);
                    cmd.Parameters.AddWithValue("@Cycle", 1);
                    cmd.Parameters.AddWithValue("@DayCount", 1);
                    cmd.Parameters.AddWithValue("@PData", 61);
                    cmd.Parameters.AddWithValue("@QData", 49);
                    cmd.Parameters.AddWithValue("@RData", 76);
                    cmd.Parameters.AddWithValue("@SData", 45);
                    cmd.Parameters.AddWithValue("@TData", 62);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show(i + "Data Saved");
                    }

                    
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
    }
}
