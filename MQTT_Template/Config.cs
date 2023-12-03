using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MQTT_Template
{
    public partial class Config : Form
    {
        public string MQTT_Host { get; set; }
        public int MQTT_Port { get; set; }
        public string MQTT_User { get; set; }
        public string MQTT_Pwd { get; set; }

        public Config(string host, int port, string user, string pwd)
        {
            InitializeComponent();
            tbHost.Text = host;
            tbPort.Text = port.ToString();
            tbUser.Text = user;
            tbPasswd.Text = pwd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MQTT_Host = tbHost.Text;
            MQTT_Port = int.Parse(tbPort.Text);
            MQTT_User = tbUser.Text;
            MQTT_Pwd = tbPasswd.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
