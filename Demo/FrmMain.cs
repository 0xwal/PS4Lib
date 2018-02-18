using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS4Lib;

namespace Demo
{
    public partial class FrmMain : Form
    {

        private readonly PS4API ps4 = new PS4API();
        private const string Hex = "0123456789ABCDEFabcdef";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ps4.IsConnected)
            {
                MessageBox.Show("Already Connected");
                return;
            }
            if (!ps4.ConnectTarget(txtIp.Text))
                MessageBox.Show("Connection field!");
            else MessageBox.Show("Connected..");
        }
        private void btnAttach_Click(object sender, EventArgs e)
        {

            if (!ps4.AttachProcess())
                MessageBox.Show("Attach field!");
            else MessageBox.Show("Attached..");
        }
      
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (!ps4.IsConnected)
            {
                MessageBox.Show("Connect first!");
                return;
            }
            ps4.DisconnectTarget();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Connection Status: {ps4.IsConnected}");
        }
    
        private void btnDetach_Click(object sender, EventArgs e)
        {
            if (ps4.DetachProcess())
                MessageBox.Show("Detached!");
            else MessageBox.Show("No Process attached!");
        }
        
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (ps4.Resume())
                MessageBox.Show("Process resumed!");
            else MessageBox.Show("Can not resume the process!");
        }
        private void btnNotify_Click(object sender, EventArgs e)
        {
            ps4.Notify(cmbNotifyType.SelectedIndex, txtNotify.Text);
        }
        private static string HexValues(string hex)
        {
            hex = hex.Replace("0x", "");
            var values = Regex.Matches(hex, "[a-fA-F0-9]+");
            return values.Cast<object>().Aggregate("", (current, item) => current + item);
        }
        public static byte[] HexString(string hex)
        {
            if (hex == "")
                return null;
            hex = HexValues(hex);
            hex = (((hex.Length % 2) == 1) ? "0" : "") + hex;
            return (from x in Enumerable.Range(0, hex.Length)
                    where (x % 2) == 0
                    select Convert.ToByte(hex.Substring(x, 2), 0x10)).ToArray();
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (txtOffset.Text == "")
            {
                MessageBox.Show("there is no offset, fill offset box.");
                return;
            }

            ulong address = ulong.Parse(txtOffset.Text, NumberStyles.HexNumber);
            int length = (int) numLength.Value;

            if (rdoPeak.Checked)
            {
                byte[] buffer = ps4.Extension.ReadBytes(address, length);
                richBox.Text = BitConverter.ToString(buffer);
                return;
            }
            if (richBox.Text == "")
            {
                MessageBox.Show("Need data input to write!");
                return;
            }
            ps4.SetMemory(address, HexString(richBox.Text), length);
        }
        private void txtOffset_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Hex.Contains(e.KeyChar.ToString()) 
                && e.KeyChar != (char)Keys.Back 
                && e.KeyChar != (char)Keys.Delete)
                e.Handled = true;
        }
    }
}
