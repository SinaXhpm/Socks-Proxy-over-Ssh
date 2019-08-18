using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using MaterialSkin;
using Renci.SshNet;
using System.Net.NetworkInformation;
namespace Azir
{
    public partial class azir : MaterialSkin.Controls.MaterialForm
    {
        bool status = false;
        Thread run;
        SshClient client;
        ForwardedPortDynamic port;
        public azir()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

            if (!status)
            {
                statusLabel.Text = "Connecting...";
                IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
                TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();
                bool isAvailable = true;
                bool internetconnection = false;
                foreach (TcpConnectionInformation tcpi in tcpConnInfoArray)
                {
                    if (tcpi.LocalEndPoint.Port == int.Parse(Lport.Text))
                    {
                        statusLabel.Text = "port is using by another proccess..!";
                        break;
                    }
                }
                try
                {
                    using (var client = new WebClient())
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        internetconnection = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Failed.Check Your Internet connection!");
                }
                if (isAvailable && internetconnection)
                {
                    client = new SshClient(sshHost.Text, sshUser.Text,sshPASS.Text);
                    client.KeepAliveInterval = new TimeSpan(0, 0, 30);
                    client.ConnectionInfo.Timeout = new TimeSpan(0, 0, 20);
                    client.Connect();
                    port = new ForwardedPortDynamic(Lhost.Text, uint.Parse(Lport.Text));
                    client.AddForwardedPort(port);
                    try
                    {
                        run = new Thread(() => port.Start());
                        run.Start();
                        statusLabel.Text = "Connected✅";
                        status = true;
                        MessageBox.Show("listener is active!\nhost:" + Lhost.Text + "\nport:" + Lport.Text);
                        buttonConnect.Text = "DisConnect";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                port.Stop();
                run.Abort();
                status = false;
                client.Disconnect();
                statusLabel.Text = "DisConnected❌";
                buttonConnect.Text = "Connect";
            } 
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("tg://socks?server=" + Lhost.Text + "&port="+Lport.Text); 
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("tg://resolve?domain=sin_chi"); 
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
