namespace Internet_Speed
{
    partial class frmMainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPacketSend = new System.Windows.Forms.Label();
            this.lblPacketReceived = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDownLoad = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(120, 14);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(100, 23);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "0000";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Packet Send :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Packet Received :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPacketSend
            // 
            this.lblPacketSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacketSend.Location = new System.Drawing.Point(120, 45);
            this.lblPacketSend.Name = "lblPacketSend";
            this.lblPacketSend.Size = new System.Drawing.Size(100, 23);
            this.lblPacketSend.TabIndex = 4;
            this.lblPacketSend.Text = "0000";
            this.lblPacketSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPacketReceived
            // 
            this.lblPacketReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacketReceived.Location = new System.Drawing.Point(120, 76);
            this.lblPacketReceived.Name = "lblPacketReceived";
            this.lblPacketReceived.Size = new System.Drawing.Size(100, 23);
            this.lblPacketReceived.TabIndex = 5;
            this.lblPacketReceived.Text = "0000";
            this.lblPacketReceived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 5000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "DownLoad :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Upload :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDownLoad
            // 
            this.lblDownLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownLoad.Location = new System.Drawing.Point(120, 107);
            this.lblDownLoad.Name = "lblDownLoad";
            this.lblDownLoad.Size = new System.Drawing.Size(100, 23);
            this.lblDownLoad.TabIndex = 8;
            this.lblDownLoad.Text = "0000";
            this.lblDownLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUpload
            // 
            this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpload.Location = new System.Drawing.Point(120, 138);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(100, 23);
            this.lblUpload.TabIndex = 9;
            this.lblUpload.Text = "0000";
            this.lblUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 175);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblDownLoad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPacketReceived);
            this.Controls.Add(this.lblPacketSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Speed";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPacketSend;
        private System.Windows.Forms.Label lblPacketReceived;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDownLoad;
        private System.Windows.Forms.Label lblUpload;
    }
}

