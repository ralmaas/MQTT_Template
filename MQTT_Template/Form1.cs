using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.IO;
using System.Threading;
using Microsoft.Win32;

namespace MQTT_Template
{
    public partial class Form1 : Form
    {
        public string MQTT_Host;
        public int MQTT_Port;
        public string MQTT_User;
        public string MQTT_Pwd;
        public string MQTT_Monitor;
        public static MqttClient myClient;
        public static bool isConneced = false;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            MQTT_Host = "192.168.2.200";
            MQTT_Port = 1883;
            tbMQTTstatus.Text = "Not Connected";
            tbTopicOut.Enabled = false;
            tbPayloadOut.Enabled = false;
            this.FormClosing += Form1_FormClosing;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\mqtt_template");
            if (key != null)
            {
                // Fetch values
                MQTT_Host = (string)key.GetValue("MQTT_Host");
                MQTT_Port = (int)key.GetValue("MQTT_Port");
                MQTT_User = (string)key.GetValue("MQTT_User");
                MQTT_Pwd = (string)key.GetValue("MQTT_Pwd");

                key.Close();
            }
            else
            {
                // Force user into the Config dialog
                configMQTT();
            }
        }

        private void disconnectMQTT()
        {
            try
            {
                myClient.Disconnect();
            }
            catch
            {
                // Do nothing - already closed
            }
        }
        private void Form1_FormClosing(object Sender, FormClosingEventArgs e)
        {
            if (isConneced)
                disconnectMQTT();
            // If any unsaved work - handle it NOW
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isConneced)
                disconnectMQTT();

            this.Close();
        }

        private void client_recievedMessage(object sender, MqttMsgPublishEventArgs e)
        {
            // Handle message received

            string message = System.Text.Encoding.Default.GetString(e.Message);
            string topic = e.Topic;
            tbTopic.Text = topic;
            tbPayload.Text = message;
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Connect
            if (isConneced)
                disconnectMQTT();
            myClient = new MqttClient(MQTT_Host, MQTT_Port, false, null, null, MqttSslProtocols.None);
            // Register to message received
            myClient.MqttMsgPublishReceived += client_recievedMessage;
            string clientId = Guid.NewGuid().ToString();
            if (MQTT_User.Length > 0)
                myClient.Connect(clientId, MQTT_User, MQTT_Pwd);
            else
                myClient.Connect(clientId);
            isConneced = true;
            tbMQTTstatus.BackColor = Color.LightGreen;
            tbMQTTstatus.Text = "Connected";
            tbTopicOut.Enabled = true;
            tbPayloadOut.Enabled = true;
            // Subscribe to topic ?
            if (tbMonitor.Text.Length > 0)
            {
                myClient.Subscribe(new String[] { tbMonitor.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            }
            string strValue = Convert.ToString("On");
            myClient.Publish("MQTT_Template/status", Encoding.UTF8.GetBytes(strValue));
        }

        public void configMQTT()
        {
            var form = new Config(MQTT_Host, MQTT_Port, MQTT_User, MQTT_Pwd);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MQTT_Host = form.MQTT_Host;
                MQTT_Port = form.MQTT_Port;
                MQTT_User = form.MQTT_User;
                MQTT_Pwd = form.MQTT_Pwd;
                // Save
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\mqtt_template", true);
                if (key == null)
                {
                    // Create folder
                    key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\mqtt_template");
                }
                else
                {
                    key.DeleteValue("MQTT_Host");
                    key.DeleteValue("MQTT_Port");
                    key.DeleteValue("MQTT_User");
                    key.DeleteValue("MQTT_Pwd");
                }
                key.SetValue("MQTT_Host", MQTT_Host);
                key.SetValue("MQTT_Port", MQTT_Port);
                key.SetValue("MQTT_User", MQTT_User);
                key.SetValue("MQTT_Pwd", MQTT_Pwd);
            }

        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            configMQTT();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isConneced)
            {
                if ((tbTopicOut.Text.Length > 0) && (tbPayloadOut.Text.Length > 0))
                    myClient.Publish(tbTopicOut.Text, Encoding.UTF8.GetBytes(tbPayloadOut.Text));
                else
                    MessageBox.Show("Please enter Topic AND payload values", "Error");
            }
        }
    }
}
