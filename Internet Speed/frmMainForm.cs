using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Internet_Speed
{
    public partial class frmMainForm : Form
    {
        NetworkInterface networkInterface;
        long lngBytesSend = 0;
        long lngBtyesReceived = 0;
        public frmMainForm()
        {
            InitializeComponent();
            foreach (NetworkInterface currentNetworkInterface in NetworkInterface.GetAllNetworkInterfaces())
                if (currentNetworkInterface.Name.ToLower() == "langaton verkkoyhteys")
                {
                    networkInterface = currentNetworkInterface;
                    break;
                }
            ShowNetworkInterfaceTraffice();
        }


        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

        private void ShowNetworkInterfaceTraffice()
        {
            IPv4InterfaceStatistics interfaceStatistic = networkInterface.GetIPv4Statistics();
            
            int bytesSentSpeed = (int)(interfaceStatistic.BytesSent - lngBytesSend) / 1024;
            int bytesReceivedSpeed = (int)(interfaceStatistic.BytesReceived - lngBtyesReceived) / 1024;

            lblSpeed.Text = (networkInterface.Speed / 1000000).ToString() + " Mbps";
            lblPacketReceived.Text = interfaceStatistic.UnicastPacketsReceived.ToString();
            lblPacketSend.Text = interfaceStatistic.UnicastPacketsSent.ToString();
            lblUpload.Text = bytesSentSpeed.ToString() + " KB/s" ;
            lblDownLoad.Text = bytesReceivedSpeed.ToString() + " KB/s ";
            lngBytesSend = interfaceStatistic.BytesSent;
            lngBtyesReceived = interfaceStatistic.BytesReceived;
            SendBroadcast(5851, userName + ":   Sent: " + bytesSentSpeed / 5 + " KB/s     Received: " + bytesReceivedSpeed / 5 + " KB/s");
        }
        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            ShowNetworkInterfaceTraffice();
        }
        public static void SendBroadcast(int port, string message)
        {
            UdpClient client = new UdpClient();
            byte[] packet = Encoding.ASCII.GetBytes(message);

            try
            {
                client.Send(packet, packet.Length, IPAddress.Broadcast.ToString(), port);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
        }

    }
}
