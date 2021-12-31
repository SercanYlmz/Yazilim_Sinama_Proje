using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //btnConnect.Enabled = false;
            btnConnect.Enabled = false;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
            client.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += ("/n" + e.MessageString + "/n");
            });
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sha sha256 = new sha();
            if(cboxSHA.Checked==true)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(txtMessage.Text);
                System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();

                byte[] hash = sha256hashstring.ComputeHash(bytes);
                string hashstring = string.Empty;
                foreach (byte x in hash)
                {
                    hashstring += String.Format("{0:x2}", x);
                }
                txtStatus.Text = hashstring ;
            }
            client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(1));
            txtMessage.Clear();
        }
    }
}
