using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialReceive
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            labelPOC.Text = "POC-Mouhamed-Sagna-2025";
            buttonList.Click += ButtonList_Click;
            buttonOpen.Click += ButtonOpen_Click;
            buttonClose.Click += ButtonClose_Click;
        }

        private void ButtonList_Click(object? sender, EventArgs e)
        {
            comboBoxPorts.Items.Clear();
            comboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            if (comboBoxPorts.Items.Count > 0)
                comboBoxPorts.SelectedIndex = 0;
        }

        private void ButtonOpen_Click(object? sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedItem != null)
            {
                serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                serialPort.BaudRate = 9600;
                serialPort.DataReceived += SerialPort_DataReceived;
                try
                {
                    serialPort.Open();
                    MessageBox.Show("Port ouvert !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void ButtonClose_Click(object? sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                MessageBox.Show("Port fermé !");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine(); // attend une ligne terminée par \n
                string[] parts = data.Trim().Split(',');
                if (parts.Length == 2)
                {
                    this.Invoke(new Action(() =>
                    {
                        textBoxD1.Text = parts[0];
                        textBoxD2.Text = parts[1];
                    }));
                }
            }
            catch (Exception ex)
            {
                // Optionnel : afficher une erreur ou ignorer
            }
        }

        private void labelPOC_Click(object sender, EventArgs e)
        {

        }
    }
}
