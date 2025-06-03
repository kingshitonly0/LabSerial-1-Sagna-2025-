using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialSender
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
            buttonSend.Click += ButtonSend_Click;
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
        private void ButtonSend_Click(object? sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                string d1 = textBoxD1.Text;
                string d2 = textBoxD2.Text;
                string data = $"{d1},{d2}\n";
                try
                {
                    serialPort.Write(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur d'envoi : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ouvre le port d'abord !");
            }
        }

        private void buttonSend_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonList_Click_1(object sender, EventArgs e)
        {

        }
    }
}
