namespace CzujnikTempDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxDeviceID = new System.Windows.Forms.ComboBox();
            this.cbxRefreshRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStartRead = new System.Windows.Forms.Button();
            this.cbAutoRefresh = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxComBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSerialPort = new System.Windows.Forms.ComboBox();
            this.lblUnitHum = new System.Windows.Forms.Label();
            this.lblUnitTemp = new System.Windows.Forms.Label();
            this.lblHum = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExpandHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.cbxDeviceID);
            this.splitContainer1.Panel1.Controls.Add(this.cbxRefreshRate);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.btnStartRead);
            this.splitContainer1.Panel1.Controls.Add(this.cbAutoRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbxComBaudRate);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbxSerialPort);
            this.splitContainer1.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseClick);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblUnitHum);
            this.splitContainer1.Panel2.Controls.Add(this.lblUnitTemp);
            this.splitContainer1.Panel2.Controls.Add(this.lblHum);
            this.splitContainer1.Panel2.Controls.Add(this.lblTemp);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnExpandHide);
            this.splitContainer1.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseClick);
            this.splitContainer1.Size = new System.Drawing.Size(636, 278);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Device ID";
            // 
            // cbxDeviceID
            // 
            this.cbxDeviceID.FormattingEnabled = true;
            this.cbxDeviceID.Location = new System.Drawing.Point(13, 121);
            this.cbxDeviceID.Name = "cbxDeviceID";
            this.cbxDeviceID.Size = new System.Drawing.Size(121, 24);
            this.cbxDeviceID.TabIndex = 6;
            // 
            // cbxRefreshRate
            // 
            this.cbxRefreshRate.FormattingEnabled = true;
            this.cbxRefreshRate.Location = new System.Drawing.Point(12, 168);
            this.cbxRefreshRate.Name = "cbxRefreshRate";
            this.cbxRefreshRate.Size = new System.Drawing.Size(121, 24);
            this.cbxRefreshRate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Refresh Rate (s)";
            // 
            // btnStartRead
            // 
            this.btnStartRead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartRead.Location = new System.Drawing.Point(0, 243);
            this.btnStartRead.Name = "btnStartRead";
            this.btnStartRead.Size = new System.Drawing.Size(188, 23);
            this.btnStartRead.TabIndex = 1;
            this.btnStartRead.Text = "Start";
            this.btnStartRead.UseVisualStyleBackColor = true;
            this.btnStartRead.Click += new System.EventHandler(this.btnStartRead_Click);
            // 
            // cbAutoRefresh
            // 
            this.cbAutoRefresh.AutoSize = true;
            this.cbAutoRefresh.Location = new System.Drawing.Point(3, 216);
            this.cbAutoRefresh.Name = "cbAutoRefresh";
            this.cbAutoRefresh.Size = new System.Drawing.Size(108, 21);
            this.cbAutoRefresh.TabIndex = 1;
            this.cbAutoRefresh.Text = "Auto refresh";
            this.cbAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // cbxComBaudRate
            // 
            this.cbxComBaudRate.FormattingEnabled = true;
            this.cbxComBaudRate.Location = new System.Drawing.Point(13, 74);
            this.cbxComBaudRate.Name = "cbxComBaudRate";
            this.cbxComBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cbxComBaudRate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Name";
            // 
            // cbxSerialPort
            // 
            this.cbxSerialPort.FormattingEnabled = true;
            this.cbxSerialPort.Location = new System.Drawing.Point(13, 27);
            this.cbxSerialPort.Name = "cbxSerialPort";
            this.cbxSerialPort.Size = new System.Drawing.Size(121, 24);
            this.cbxSerialPort.TabIndex = 0;
            // 
            // lblUnitHum
            // 
            this.lblUnitHum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitHum.AutoSize = true;
            this.lblUnitHum.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnitHum.Location = new System.Drawing.Point(344, 180);
            this.lblUnitHum.Name = "lblUnitHum";
            this.lblUnitHum.Size = new System.Drawing.Size(34, 49);
            this.lblUnitHum.TabIndex = 6;
            this.lblUnitHum.Text = "-";
            // 
            // lblUnitTemp
            // 
            this.lblUnitTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnitTemp.AutoSize = true;
            this.lblUnitTemp.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUnitTemp.Location = new System.Drawing.Point(344, 72);
            this.lblUnitTemp.Name = "lblUnitTemp";
            this.lblUnitTemp.Size = new System.Drawing.Size(34, 49);
            this.lblUnitTemp.TabIndex = 5;
            this.lblUnitTemp.Text = "-";
            this.lblUnitTemp.Click += new System.EventHandler(this.lblUnitTemp_Click);
            // 
            // lblHum
            // 
            this.lblHum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHum.AutoSize = true;
            this.lblHum.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHum.Location = new System.Drawing.Point(247, 180);
            this.lblHum.Name = "lblHum";
            this.lblHum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHum.Size = new System.Drawing.Size(34, 49);
            this.lblHum.TabIndex = 4;
            this.lblHum.Text = "-";
            this.lblHum.DoubleClick += new System.EventHandler(this.lblHum_DoubleClick_1);
            // 
            // lblTemp
            // 
            this.lblTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemp.Location = new System.Drawing.Point(247, 72);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTemp.Size = new System.Drawing.Size(34, 49);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "-";
            this.lblTemp.DoubleClick += new System.EventHandler(this.lblTemp_DoubleClick_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(-5, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 49);
            this.label4.TabIndex = 2;
            this.label4.Text = "Humidity:";
            this.label4.DoubleClick += new System.EventHandler(this.label4_DoubleClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(-5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 49);
            this.label3.TabIndex = 1;
            this.label3.Text = "Temperature:";
            this.label3.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // btnExpandHide
            // 
            this.btnExpandHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExpandHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandHide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExpandHide.Location = new System.Drawing.Point(3, 0);
            this.btnExpandHide.Name = "btnExpandHide";
            this.btnExpandHide.Size = new System.Drawing.Size(45, 27);
            this.btnExpandHide.TabIndex = 0;
            this.btnExpandHide.Text = "<>";
            this.btnExpandHide.UseVisualStyleBackColor = false;
            this.btnExpandHide.Click += new System.EventHandler(this.btnExpandHide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(636, 278);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FormName";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnStartRead;
        private System.Windows.Forms.CheckBox cbAutoRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxComBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSerialPort;
        private System.Windows.Forms.Label lblHum;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExpandHide;
        private System.Windows.Forms.ComboBox cbxRefreshRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxDeviceID;
        private System.Windows.Forms.Label lblUnitHum;
        private System.Windows.Forms.Label lblUnitTemp;
    }
}

