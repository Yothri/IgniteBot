namespace Engine
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendChat = new System.Windows.Forms.Button();
            this.txtChatText = new System.Windows.Forms.TextBox();
            this.btnSendPacket = new System.Windows.Forms.Button();
            this.txtRawPacketData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendChat);
            this.groupBox1.Controls.Add(this.txtChatText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // btnSendChat
            // 
            this.btnSendChat.Location = new System.Drawing.Point(235, 17);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(75, 23);
            this.btnSendChat.TabIndex = 2;
            this.btnSendChat.Text = "Send";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // txtChatText
            // 
            this.txtChatText.Location = new System.Drawing.Point(6, 19);
            this.txtChatText.Name = "txtChatText";
            this.txtChatText.Size = new System.Drawing.Size(223, 20);
            this.txtChatText.TabIndex = 1;
            // 
            // btnSendPacket
            // 
            this.btnSendPacket.Location = new System.Drawing.Point(940, 16);
            this.btnSendPacket.Name = "btnSendPacket";
            this.btnSendPacket.Size = new System.Drawing.Size(136, 23);
            this.btnSendPacket.TabIndex = 1;
            this.btnSendPacket.Text = "Send Packet";
            this.btnSendPacket.UseVisualStyleBackColor = true;
            this.btnSendPacket.Click += new System.EventHandler(this.btnSendPacket_Click);
            // 
            // txtRawPacketData
            // 
            this.txtRawPacketData.Location = new System.Drawing.Point(6, 19);
            this.txtRawPacketData.Name = "txtRawPacketData";
            this.txtRawPacketData.Size = new System.Drawing.Size(928, 20);
            this.txtRawPacketData.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRawPacketData);
            this.groupBox2.Controls.Add(this.btnSendPacket);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 51);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raw Packet";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 128);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IgniteBot";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.TextBox txtChatText;
        private System.Windows.Forms.Button btnSendPacket;
        private System.Windows.Forms.TextBox txtRawPacketData;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}