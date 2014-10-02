using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Runtime.InteropServices;

namespace Mac
{
    public partial class F_Mac : Form
    {
        private int startIP = 12;
        private int endIP = 16;
        private string ipPrefix = "192.168.0";
        private ArrayList computerList =new ArrayList();// null;

        //public AllPc(string ipPrefix, int startIP, int endIP)
        //{
        //    this.startIP = startIP;
        //    this.endIP = endIP;
        //    this.ipPrefix = ipPrefix;
        //    computerList = new ArrayList();
        //}
        public F_Mac()
        {
            InitializeComponent();
            ListBox.CheckForIllegalCrossThreadCalls = false;
        }

        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);

        public void ScanComputers()
        {
            for (int i = startIP; i <= endIP; i++)
            {
                Thread.Sleep(10);
                int r = 0,len=0;
                string scanIP = ipPrefix + "." + i.ToString();
                IPAddress myScanIP = IPAddress.Parse(scanIP),ipAddress;
                IPHostEntry myScanHost = null;
                IPHostEntry iPHostEntry=null;
                string[] arr = new string[2];
                string MAC = null,IP=null;

                try
                {
                    myScanHost = Dns.GetHostByAddress(myScanIP);
                    iPHostEntry = Dns.GetHostEntry(myScanIP);
                    //IP = iPHostEntry.AddressList[1].ToString();
                    ipAddress = myScanIP;
                    byte[] ab = new byte[6];
                    len = ab.Length;
                    r = SendARP((int)ipAddress.Address, 0, ab, ref len);
                    MAC = BitConverter.ToString(ab, 0, 6);

                }
                catch
                {
                    Console.WriteLine(myScanIP);
                    continue;
                }
                if (myScanHost != null)
                {
                    arr[0] = myScanHost.HostName;
                    arr[1] = scanIP;
                    computerList.Add(arr);
                    LB_lista1.Items.Add(myScanHost.HostName.ToString() + " IP:" + myScanIP+" MAC: "+MAC);
                    Console.Write(myScanHost.HostName.ToString() + "\t");
                    Console.WriteLine(scanIP.ToString());
                }
            }
            LB_lista1.Items.Add("fin");
        }
        private void F_Mac_Load(object sender, EventArgs e)
        {
            LB_lista1.Items.Add("holi");
            Thread hilo1 = new Thread(new ThreadStart(ScanComputers));
            hilo1.Start();
            //ScanComputers();
        }

        private void ObtenerDispositivos() 
        { 
            
        }

        private void F_Mac_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
