namespace PortProxyManager {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.results = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.listenIP = new System.Windows.Forms.TextBox();
            this.listenPort = new System.Windows.Forms.TextBox();
            this.connectIP = new System.Windows.Forms.TextBox();
            this.connectPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.Color.White;
            this.results.Enabled = false;
            this.results.ForeColor = System.Drawing.Color.Black;
            this.results.Location = new System.Drawing.Point(13, 13);
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(274, 205);
            this.results.TabIndex = 0;
            this.results.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(13, 224);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(274, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listenIP
            // 
            this.listenIP.Location = new System.Drawing.Point(68, 266);
            this.listenIP.Name = "listenIP";
            this.listenIP.Size = new System.Drawing.Size(122, 20);
            this.listenIP.TabIndex = 2;
            this.listenIP.Text = "0.0.0.0";
            this.listenIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listenPort
            // 
            this.listenPort.Location = new System.Drawing.Point(196, 266);
            this.listenPort.Name = "listenPort";
            this.listenPort.Size = new System.Drawing.Size(91, 20);
            this.listenPort.TabIndex = 3;
            this.listenPort.Text = "7777";
            // 
            // connectIP
            // 
            this.connectIP.Location = new System.Drawing.Point(68, 301);
            this.connectIP.Name = "connectIP";
            this.connectIP.Size = new System.Drawing.Size(121, 20);
            this.connectIP.TabIndex = 5;
            this.connectIP.Text = "127.0.0.1";
            this.connectIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // connectPort
            // 
            this.connectPort.Location = new System.Drawing.Point(196, 301);
            this.connectPort.Name = "connectPort";
            this.connectPort.Size = new System.Drawing.Size(91, 20);
            this.connectPort.TabIndex = 6;
            this.connectPort.Text = "7777";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Listen:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Connect:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "IP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Port";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(212, 334);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 366);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectPort);
            this.Controls.Add(this.connectIP);
            this.Controls.Add(this.listenPort);
            this.Controls.Add(this.listenIP);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.results);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PortProxy Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox listenIP;
        private System.Windows.Forms.TextBox listenPort;
        private System.Windows.Forms.TextBox connectIP;
        private System.Windows.Forms.TextBox connectPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
    }
}

