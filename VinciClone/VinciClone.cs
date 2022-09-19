using System;
using System.Threading;
using lib60870.CS104;
using lib60870.CS101;
using lib60870;

namespace VinciClone
{
    public partial class VinciClone : Form
    {
        Connection con;
        string address = "127.0.0.1";
        bool start = false;
        ConnectionEvent conEvent;


        public VinciClone()
        {
			InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setupListView();
            CheckForIllegalCrossThreadCalls = false;
        }
        public void setupListView()
        {
            lv_stats.View = View.Details;
            lv_stats.Columns.Add("TI");
            lv_stats.Columns.Add("Course");
            lv_stats.Columns.Add("ASDU");
            lv_stats.Columns.Add("IOA");
            lv_stats.Columns.Add("Value");
            lv_stats.Columns.Add("Status");
            lv_stats.Columns.Add("Time Tag");
            lv_stats.Columns.Add("Count");
            lv_stats.Columns.Add("Name");

            lv_stats.Columns[0].Width = -1;
        }
        public void resizeColumns()
        {
            lv_stats.Columns[0].Width = -2;
            lv_stats.Columns[1].Width = -2;
            lv_stats.Columns[2].Width = -2;
            lv_stats.Columns[3].Width = -2;
            lv_stats.Columns[4].Width = -2;
            lv_stats.Columns[5].Width = -2;
            lv_stats.Columns[6].Width = -2;
            lv_stats.Columns[7].Width = -2;
            lv_stats.Columns[8].Width = -2;
        }
        public void addItem(string[] values)
        {
            ListViewItem item = new ListViewItem();
            item.Text = values[0];
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = values[1] });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = values[2] });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = values[3] });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = values[4] });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = values[5] });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = values[6] });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = values[7] });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = values[8] });

            lv_stats.Items.Add(item);
        }
        public void ConnectionHandler(object parameter, ConnectionEvent _connectionEvent)
		{
            this.conEvent = _connectionEvent;
                switch (conEvent)
                {
                    case ConnectionEvent.OPENED:
                        this.btnStart.BackColor = Color.LightGreen;
                        this.btnStart.Text = "Connected";
                        break;
                    case ConnectionEvent.CLOSED:
                        this.btnStart.BackColor = Color.Red;
                        this.btnStart.Text = "Disconnected";
                        break;
                    case ConnectionEvent.STARTDT_CON_RECEIVED:
                        this.btnStart.BackColor = Color.Green;
                        break;
                    case ConnectionEvent.STOPDT_CON_RECEIVED:
                        this.btnStart.BackColor = Color.OrangeRed;
                        break;
                }
		}
        public bool AsduReceivedHandler(object parameter, ASDU asdu)
        {
            try
            {
                //type 70
                if (asdu.TypeId == TypeID.M_EI_NA_1)
                {
                    for(int i = 0; i < asdu.NumberOfElements; i++)
                    {
                        var val = (EndOfInitialization)asdu.GetElement(i);

                        string[] values = { val.Type.ToString(), val.COI.ToString(), asdu.Ca.ToString(), asdu.Oa.ToString(), "-", "-", "-", "-", "-"};
                        addItem(values);
                    }
                }
                //type 1
                else if (asdu.TypeId == TypeID.M_SP_NA_1)
                {

                    for (int i = 0; i < asdu.NumberOfElements; i++)
                    {
                        string status = "";
                        var val = (SinglePointInformation)asdu.GetElement(i);
                        if(!val.Quality.Invalid && !val.Quality.NonTopical && !val.Quality.Substituted && !val.Quality.Blocked)
                        {
                            status = "OK";
                        }
                        else
                        {
                            if (val.Quality.Invalid)
                            {
                                status += " IV";
                            }
                            if (val.Quality.NonTopical)
                            {
                                status += " NT";
                            }
                            if (val.Quality.Substituted)
                            {
                                status += " SB";
                            }
                            if (val.Quality.Blocked)
                            {
                                status += " BL";
                            }
                        }

                        string[] values = { val.Type.ToString(), asdu.Cot.ToString(), asdu.Ca.ToString(), asdu.Oa.ToString(),"", status, "", asdu.NumberOfElements.ToString(), "" };
                        addItem(values);
                    }
                }
                //type 30
                else if (asdu.TypeId == TypeID.M_SP_TB_1)
                {

                    for (int i = 0; i < asdu.NumberOfElements; i++)
                    {

                        var val = (SinglePointWithCP56Time2a)asdu.GetElement(i);

                        Console.WriteLine("  IOA: " + val.ObjectAddress + " SP value: " + val.Value);
                        Console.WriteLine("   " + val.Quality.ToString());
                        Console.WriteLine("   " + val.Timestamp.ToString());
                    }
                }
                //type 13
                else if (asdu.TypeId == TypeID.M_ME_NC_1)
                {

                    for (int i = 0; i < asdu.NumberOfElements; i++)
                    {
                        var mfv = (MeasuredValueShort)asdu.GetElement(i);

                        Console.WriteLine("  IOA: " + mfv.ObjectAddress + " float value: " + mfv.Value);
                        Console.WriteLine("   " + mfv.Quality.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Unknown message type!");
                }
                resizeColumns();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            return true;
        }
        public void btnStart_Click(object sender, EventArgs e)
        {
            address = tb_IP.Text;
            con = new Connection(address);
            con.SetASDUReceivedHandler(AsduReceivedHandler, this);
            con.SetConnectionHandler(ConnectionHandler, this);
            try
            {
                con.Connect();
            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }
        private void btn_Gi_Click(object sender, EventArgs e)
        {
            lv_stats.Items.Clear();
            try
            {
                con.SendInterrogationCommand(CauseOfTransmission.ACTIVATION, 1, QualifierOfInterrogation.STATION);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}