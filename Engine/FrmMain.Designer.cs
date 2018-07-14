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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTargetId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetTarget = new System.Windows.Forms.Button();
            this.btnSetDestObj = new System.Windows.Forms.Button();
            this.btnMeleeAttack = new System.Windows.Forms.Button();
            this.txtAtkMsg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSetTargetBClear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSetDestObjRange = new System.Windows.Forms.TextBox();
            this.btnLoadFocusedObjId = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(12, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 51);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raw Packet";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadFocusedObjId);
            this.groupBox3.Controls.Add(this.txtSetDestObjRange);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSetTargetBClear);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtAtkMsg);
            this.groupBox3.Controls.Add(this.btnMeleeAttack);
            this.groupBox3.Controls.Add(this.btnSetDestObj);
            this.groupBox3.Controls.Add(this.btnSetTarget);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtTargetId);
            this.groupBox3.Location = new System.Drawing.Point(12, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1082, 231);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Targeting, Attacking...";
            // 
            // txtTargetId
            // 
            this.txtTargetId.Location = new System.Drawing.Point(62, 19);
            this.txtTargetId.Name = "txtTargetId";
            this.txtTargetId.Size = new System.Drawing.Size(100, 20);
            this.txtTargetId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target Id";
            // 
            // btnSetTarget
            // 
            this.btnSetTarget.Location = new System.Drawing.Point(168, 45);
            this.btnSetTarget.Name = "btnSetTarget";
            this.btnSetTarget.Size = new System.Drawing.Size(112, 23);
            this.btnSetTarget.TabIndex = 2;
            this.btnSetTarget.Text = "Send SetTarget";
            this.btnSetTarget.UseVisualStyleBackColor = true;
            this.btnSetTarget.Click += new System.EventHandler(this.btnSetTarget_Click);
            // 
            // btnSetDestObj
            // 
            this.btnSetDestObj.Location = new System.Drawing.Point(168, 74);
            this.btnSetDestObj.Name = "btnSetDestObj";
            this.btnSetDestObj.Size = new System.Drawing.Size(112, 23);
            this.btnSetDestObj.TabIndex = 3;
            this.btnSetDestObj.Text = "Send SetDestObj";
            this.btnSetDestObj.UseVisualStyleBackColor = true;
            this.btnSetDestObj.Click += new System.EventHandler(this.btnSetDestObj_Click);
            // 
            // btnMeleeAttack
            // 
            this.btnMeleeAttack.Location = new System.Drawing.Point(168, 103);
            this.btnMeleeAttack.Name = "btnMeleeAttack";
            this.btnMeleeAttack.Size = new System.Drawing.Size(112, 23);
            this.btnMeleeAttack.TabIndex = 4;
            this.btnMeleeAttack.Text = "Melee Attack";
            this.btnMeleeAttack.UseVisualStyleBackColor = true;
            this.btnMeleeAttack.Click += new System.EventHandler(this.btnMeleeAttack_Click);
            // 
            // txtAtkMsg
            // 
            this.txtAtkMsg.Location = new System.Drawing.Point(62, 106);
            this.txtAtkMsg.Name = "txtAtkMsg";
            this.txtAtkMsg.Size = new System.Drawing.Size(100, 20);
            this.txtAtkMsg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Atk Msg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "bClear";
            // 
            // txtSetTargetBClear
            // 
            this.txtSetTargetBClear.Location = new System.Drawing.Point(62, 47);
            this.txtSetTargetBClear.Name = "txtSetTargetBClear";
            this.txtSetTargetBClear.Size = new System.Drawing.Size(100, 20);
            this.txtSetTargetBClear.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "flrange";
            // 
            // txtSetDestObjRange
            // 
            this.txtSetDestObjRange.Location = new System.Drawing.Point(62, 76);
            this.txtSetDestObjRange.Name = "txtSetDestObjRange";
            this.txtSetDestObjRange.Size = new System.Drawing.Size(100, 20);
            this.txtSetDestObjRange.TabIndex = 10;
            // 
            // btnLoadFocusedObjId
            // 
            this.btnLoadFocusedObjId.Location = new System.Drawing.Point(168, 17);
            this.btnLoadFocusedObjId.Name = "btnLoadFocusedObjId";
            this.btnLoadFocusedObjId.Size = new System.Drawing.Size(112, 23);
            this.btnLoadFocusedObjId.TabIndex = 11;
            this.btnLoadFocusedObjId.Text = "Load From Memory";
            this.btnLoadFocusedObjId.UseVisualStyleBackColor = true;
            this.btnLoadFocusedObjId.Click += new System.EventHandler(this.btnLoadFocusedObjId_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 446);
            this.Controls.Add(this.groupBox3);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.TextBox txtChatText;
        private System.Windows.Forms.Button btnSendPacket;
        private System.Windows.Forms.TextBox txtRawPacketData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTargetId;
        private System.Windows.Forms.Button btnSetTarget;
        private System.Windows.Forms.Button btnSetDestObj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAtkMsg;
        private System.Windows.Forms.Button btnMeleeAttack;
        private System.Windows.Forms.TextBox txtSetTargetBClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSetDestObjRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoadFocusedObjId;
    }
}