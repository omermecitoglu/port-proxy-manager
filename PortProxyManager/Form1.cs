using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortProxyManager {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.GetList();
        }

        private void GetList() {
            string arguments = "interface portproxy show all";
            ProcessStartInfo procStartInfo = new ProcessStartInfo("netsh", arguments);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            Process proc = Process.Start(procStartInfo);
            this.results.Text = "";
            while(!proc.StandardOutput.EndOfStream) {
                this.results.Text += proc.StandardOutput.ReadLine();
                this.results.Text += "\r\n";
            }
        }

        private void ResetList() {
            string arguments = "interface portproxy reset";
            ProcessStartInfo procStartInfo = new ProcessStartInfo("netsh", arguments);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            Process proc = Process.Start(procStartInfo);
            this.results.Text = "";
            while(!proc.StandardOutput.EndOfStream) {
                this.results.Text += proc.StandardOutput.ReadLine();
                this.results.Text += "\r\n";
            }
        }

        private void Add() {
            string arguments = "interface portproxy add v4tov4 listenport=" + listenPort.Text + " listenaddress=" + listenIP.Text + " connectaddress=" + connectIP.Text + " connectport=" + connectPort.Text;
            ProcessStartInfo procStartInfo = new ProcessStartInfo("netsh", arguments);

            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = true;

            Process proc = Process.Start(procStartInfo);
            this.results.Text = "";
            while(!proc.StandardOutput.EndOfStream) {
                this.results.Text += proc.StandardOutput.ReadLine();
                this.results.Text += "\r\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            ResetList();
            GetList();
        }

        private void addButton_Click(object sender, EventArgs e) {
            Add();
            GetList();
        }
    }
}
