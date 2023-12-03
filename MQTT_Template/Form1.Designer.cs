
namespace MQTT_Template
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.tbPayload = new System.Windows.Forms.TextBox();
            this.tbMQTTstatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMonitor = new System.Windows.Forms.TextBox();
            this.tbPayloadOut = new System.Windows.Forms.TextBox();
            this.tbTopicOut = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(325, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(215, 190);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(75, 23);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(105, 190);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "(Re)Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(60, 20);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.ReadOnly = true;
            this.tbTopic.Size = new System.Drawing.Size(100, 20);
            this.tbTopic.TabIndex = 3;
            // 
            // tbPayload
            // 
            this.tbPayload.Location = new System.Drawing.Point(60, 50);
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.ReadOnly = true;
            this.tbPayload.Size = new System.Drawing.Size(100, 20);
            this.tbPayload.TabIndex = 4;
            // 
            // tbMQTTstatus
            // 
            this.tbMQTTstatus.Location = new System.Drawing.Point(104, 162);
            this.tbMQTTstatus.Name = "tbMQTTstatus";
            this.tbMQTTstatus.ReadOnly = true;
            this.tbMQTTstatus.Size = new System.Drawing.Size(76, 20);
            this.tbMQTTstatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Topic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Payload:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monitor topic:";
            // 
            // tbMonitor
            // 
            this.tbMonitor.Location = new System.Drawing.Point(104, 130);
            this.tbMonitor.Name = "tbMonitor";
            this.tbMonitor.Size = new System.Drawing.Size(174, 20);
            this.tbMonitor.TabIndex = 10;
            // 
            // tbPayloadOut
            // 
            this.tbPayloadOut.Location = new System.Drawing.Point(83, 50);
            this.tbPayloadOut.Name = "tbPayloadOut";
            this.tbPayloadOut.Size = new System.Drawing.Size(100, 20);
            this.tbPayloadOut.TabIndex = 12;
            // 
            // tbTopicOut
            // 
            this.tbTopicOut.Location = new System.Drawing.Point(83, 20);
            this.tbTopicOut.Name = "tbTopicOut";
            this.tbTopicOut.Size = new System.Drawing.Size(100, 20);
            this.tbTopicOut.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(108, 77);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send!";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTopic);
            this.groupBox1.Controls.Add(this.tbPayload);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.tbTopicOut);
            this.groupBox2.Controls.Add(this.tbPayloadOut);
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 112);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Topic:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payload:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 221);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbMonitor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMQTTstatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "MQTT Template";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.TextBox tbPayload;
        private System.Windows.Forms.TextBox tbMQTTstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMonitor;
        private System.Windows.Forms.TextBox tbPayloadOut;
        private System.Windows.Forms.TextBox tbTopicOut;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

