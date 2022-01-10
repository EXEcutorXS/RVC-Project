using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RVC_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portNameSelector.Items.Clear();
            portNameSelector.Items.AddRange(SerialPort.GetPortNames());
            if (portNameSelector.Items.Count > 0)
                portNameSelector.SelectedIndex = 0;
            
        }

        private void portButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
             
                serialPort.Close();
                portButton.Text = "Open";
            }
            else
            {
                serialPort.PortName = portNameSelector.SelectedItem.ToString();
                serialPort.Open();
                portButton.Text = "Close";
            }
        }

    }
}
