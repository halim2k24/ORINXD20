using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace ORINXD20
{
    public partial class COM3Settings : Form
    {
        private SerialPort serialPort; // This should be used throughout the class

        public COM3Settings()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current instance of Main form
            Main x = new Main();
            x.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = comboBox2.SelectedItem.ToString(); // Get the selected COM port
                int baudRate = int.Parse(comboBox1.SelectedItem.ToString()); // Convert baud rate to integer
                int bitBox = int.Parse(DataBitBox.SelectedItem.ToString()); // Convert data bits to integer
                int bitStopBox = int.Parse(BitStopBox.SelectedItem.ToString()); // Convert stop bits to integer

                // 🔹 If the serial port is already open, close it before changing the settings
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                    serialPort.Dispose();
                }

                // 🔹 Create a new SerialPort instance with the newly selected COM port
                serialPort = new SerialPort(comPort, baudRate, Parity.None, bitBox, (StopBits)bitStopBox);

                // 🔹 Open the newly configured port
                serialPort.Open();
                Serial_Port_Status.Text = "Open"; // Update the label text
                MessageBox.Show($"{comPort} is now open!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Serial Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Serial_port_Click(object sender, EventArgs e)
        {
            CloseSerialPort();
        }

        private void CloseSerialPort()
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                    Serial_Port_Status.Text = "Close"; // Update the label text
                    //MessageBox.Show("Serial port closed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Serial port is already closed or not initialized.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while closing the port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsSerialPortOpen()
        {
            return serialPort != null && serialPort.IsOpen;
        }

        public SerialPort GetSerialPort()
        {
            return serialPort;
        }
    }
}
