using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Device; // Add the necessary using directive for the Modbus library

namespace ORINXD20
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current instance of Main form
            COM3Settings x = new COM3Settings();
            x.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            COM3Settings com3Settings = Application.OpenForms.OfType<COM3Settings>().FirstOrDefault();
            if (com3Settings != null && com3Settings.IsSerialPortOpen())
            {
                try
                {
                    SerialPort port = com3Settings.GetSerialPort();
                    if (!port.IsOpen)
                    {
                        MessageBox.Show("Serial port is not open!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    string inputValue = SendInput.Text;
                    
                    // Send raw hex command (1B)
                    //byte[] command = new byte[] { 0x1B };  // HEX value to send

                    byte[] command = StringToHexBytes(inputValue);
                    port.Write(command, 0, command.Length);


                    // Small delay to allow response
                    Thread.Sleep(100);

                    // Read response
                    int bytesToRead = port.BytesToRead;
                    if (bytesToRead > 0)
                    {
                        byte[] buffer = new byte[bytesToRead];
                        port.Read(buffer, 0, bytesToRead);

                        // Convert received bytes to HEX string
                        string responseHex = BitConverter.ToString(buffer);

                        // Convert received bytes to HEX string
                        //string responseHex = BitConverter.ToString(buffer);

                        // Display the response in the label
                        Respons.Text = $" {responseHex}";

                        //MessageBox.Show($"Response: {responseHex}", "Received Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No response received!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("COM3 is not open!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private byte[] StringToHexBytes(string hex)
        {
            try
            {
                hex = hex.Replace(" ", "").Replace("-", ""); // Remove spaces & dashes
                if (hex.Length % 2 != 0) hex = "0" + hex; // Ensure even length

                byte[] bytes = new byte[hex.Length / 2];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
                return bytes;
            }
            catch
            {
                return new byte[0]; // Return empty array on error
            }
        }

    }
}



