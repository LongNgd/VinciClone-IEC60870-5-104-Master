using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib60870.CS104;
using lib60870.CS101;
using System.IO.Ports;
using lib60870.linklayer;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private lib60870.CS101.ASDUReceivedHandler asduReceivedHandler;
        private LinkLayerStateChanged linkLayerStateChanged;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create connection
            Connection con = new Connection("127.0.0.1");
            con.Connect();

            //create serial port
            SerialPort port = new SerialPort();
            port.PortName = "/dev/ttyUSB1";
            port.BaudRate = 9600;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.None;
            port.Open();

            //create unbalamced master
            CS101Master master = new CS101Master(port, LinkLayerMode.UNBALANCED);
            master.OwnAddress = 1;
            master.SlaveAddress = 2;
            master.SetASDUReceivedHandler(asduReceivedHandler, null);
            master.SetLinkLayerStateChangedHandler(linkLayerStateChanged, null);
        }
    }
}
