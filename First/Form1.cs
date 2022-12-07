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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace First
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Disconnect();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.Connect("127.0.0.1", 8910);
            
        }

        private void Button_cBox_CheckedChanged(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("1",TimeSpan.FromMilliseconds(1));
        }

        private void Label_cBox_CheckedChanged(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("2", TimeSpan.FromMilliseconds(1));
        }

        private void Standard_rB_CheckedChanged(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("3", TimeSpan.FromMilliseconds(1));
        }

        private void Red_rB_CheckedChanged(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("4", TimeSpan.FromMilliseconds(1));
        }

        private void Yellow_rB_CheckedChanged(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply("5", TimeSpan.FromMilliseconds(1));
        }
    }
}
