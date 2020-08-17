using ECG_Analyzer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Linq;
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
        public int averageData=50;
        public bool startButtonClick = false;

        List<int> pData = new List<int>();
        List<int> qData = new List<int>();
        List<int> rData = new List<int>();
        List<int> sData = new List<int>();
        List<int> tData = new List<int>();
        List<int> dayCount = new List<int>();
        List<int> cycle = new List<int>();
        List<int> averageRowData = new List<int>();
        List<int> rowDataList = new List<int>();




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
     
                if (portCBox.Text == "") { portErrorLabel.Visible = true; } else { portErrorLabel.Visible = false; }
                if (boudCBox.Text == "") { boudeErrorLabel.Visible = true; } else { boudeErrorLabel.Visible = false; }
                if (patientIdTBox.Text == "") { patientIdErrorLabel.Visible = true; } else { patientIdErrorLabel.Visible = false; }
                if (dayCountTBox.Text == "") { dayCountTBoxErrorLabel.Visible = true; } else { dayCountTBoxErrorLabel.Visible = false; }
                if (portErrorLabel.Visible || boudeErrorLabel.Visible ||patientIdErrorLabel.Visible || dayCountTBoxErrorLabel.Visible)
                {
                    MessageBox.Show("Fields with * are Mandetory", "Error");
                }
                else
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
                
                        
        }

        private void myport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(displadata_event));
            in_data = myPort.ReadLine();
            if (!string.IsNullOrEmpty(in_data))
            {
                rowData = Convert.ToInt32(in_data.Trim());
                rowDataList.Add(rowData);
                averageData=getAverage(rowDataList);
                if (rowData>averageData)
                {
                    if (rowData > (1.2 * averageData))
                    {
                        rData.Add(rowData);
                    }
                    else
                    {
                        pData.Add(rowData);
                    }
                }
                else
                {
                    if (rowData < (1.2 * averageData))
                    {
                        qData.Add(rowData);
                    }
                    else
                    {
                        sData.Add(rowData);
                    }
                }

                
            }
            
                       
        }



        private void displadata_event(object sender, EventArgs e)
        {
            dateTime = DateTime.Now;
            string time = dateTime.Hour + ":" + dateTime.Minute + ":" + dateTime.Second;
            dataTBox.AppendText(time+"\t\t  "+in_data+"\n");

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
        int cycleCount = 0;
        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.Enabled==true)
            {
                try
                {

                    SqlConnection con = new SqlConnection(@"server=GH-PALASH\SQLEXPRESS;database=ccmsDB;Integrated Security=True");
                    string dataInsertQuery ="INSERT INTO PQRST"+
                        "(patientId,TestDate,Cycle,DayCount,PData,QData,RData,SData,TData) values(@patientId,@TestDate,@Cycle,@DayCount,@PData,@QData,@RData,@SData,@TData)";

                    SqlCommand cmd = new SqlCommand(dataInsertQuery, con);

                    cmd.Parameters.AddWithValue("@patientId", patientIdTBox.Text);
                    cmd.Parameters.AddWithValue("@TestDate", DateTime.Today);
                    cmd.Parameters.AddWithValue("@Cycle", ++cycleCount);
                    cmd.Parameters.AddWithValue("@DayCount", dayCountTBox.Text);
                    cmd.Parameters.AddWithValue("@PData", 45);
                    cmd.Parameters.AddWithValue("@QData", 52);
                    cmd.Parameters.AddWithValue("@RData", 60);
                    cmd.Parameters.AddWithValue("@SData", 72);
                    cmd.Parameters.AddWithValue("@TData", 42);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    con.Close();

                    //if (i != 0)
                    //{
                    //    MessageBox.Show(i + "Data Saved");
                    //}

                    
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
        
        public int getAverage(List<int> T)
        {
            double a = T.Average();
            int av = Convert.ToInt32(a);
            return av;
        }

        private void portCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (portCBox.Text == "") { portErrorLabel.Visible = true; } else { portErrorLabel.Visible = false; }
        }

        private void boudCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boudCBox.Text == "") { boudeErrorLabel.Visible = true; } else { boudeErrorLabel.Visible = false; }
        }

        private void patientIdTBox_TextChanged(object sender, EventArgs e)
        {
            if (patientIdTBox.Text == "") { patientIdErrorLabel.Visible = true; } else { patientIdErrorLabel.Visible = false; }
        }

        private void dayCountTBox_TextChanged(object sender, EventArgs e)
        {
            if (dayCountTBox.Text == "") { dayCountTBoxErrorLabel.Visible = true; } else { dayCountTBoxErrorLabel.Visible = false; }
        }
    }
}
