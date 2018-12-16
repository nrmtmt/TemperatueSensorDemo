using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus;
using Modbus.Device;
using System.Timers;
using System.Runtime.InteropServices;
//CzujnikTempDemo
namespace CzujnikTempDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool AutoRefresh;
        int DefaultWidth;
        int DefaultHeight;
        System.Timers.Timer ReadTimer;

        private struct Value
        {
            public float value;
            public DateTime date;
        }
        Value TemperatureMax;
        Value HumidityMax;
        Value TemperatureMin;
        Value HumidityMin;
        static Exception exception;
        static bool Fahrenheits = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] baudRate = { 2400, 4800, 9600, 19200, 38400, 57600, 115200 };

            Dictionary<string, SerialPort> serialports = new Dictionary<string, SerialPort>();
            foreach (var _port in SerialPort.GetPortNames())
            {
                serialports.Add(_port, new SerialPort(_port));
            }
            if (serialports.Count > 0)
            {
                cbxSerialPort.DataSource = new BindingSource(serialports, null);
                cbxSerialPort.DisplayMember = "Key";
                cbxSerialPort.ValueMember = "Value";

                for (int i = 1; i <= 255; i++)
                {
                    cbxDeviceID.Items.Add(i);
                }

                foreach (var rate in baudRate)
                {
                    cbxComBaudRate.Items.Add(rate);
                }
                float[] RefreshRate = { 0.1f, 0.2f, 0.5f, 1, 2, 5, 10, 30, 60, 120, 300, 600 };

                foreach (var rate in RefreshRate)
                {
                    cbxRefreshRate.Items.Add(rate);
                }
                cbxSerialPort.SelectedIndex = 0;
                cbxComBaudRate.SelectedIndex = 2;
                cbxRefreshRate.SelectedIndex = 3;
                cbxDeviceID.SelectedIndex = 0;
            }
            else
            {
                btnStartRead.Enabled = false;
            }
            btnExpandHide.Text = "<<";
            AutoRefresh = cbAutoRefresh.Checked;
            this.Text = "TempSensor";
            DefaultWidth = this.Size.Width;
            DefaultHeight = this.Size.Height;
        }

        private void btnExpandHide_Click(object sender, EventArgs e)
        {
            if (HideLeftPane() == true)
            {
                btnExpandHide.Text = ">>";
            }
            else
            {
                btnExpandHide.Text = "<<";
            }

        }

        private void btnStartRead_Click(object sender, EventArgs e)
        {
            byte slaveId = Convert.ToByte(cbxDeviceID.Text);
            ushort startAddress = 0;
            ushort numRegisters = 2;

            if (btnStartRead.Text == "Start")
            {
                try
                {
                    var master = GetMaster();
                    btnStartRead.Text = "Stop";

                    ReadTimer = new System.Timers.Timer();
                    ReadTimer.Interval = Convert.ToSingle(cbxRefreshRate.Text) * 1000;
                    ReadTimer.Elapsed += (sender2, e2) => ConstantRead(sender2, e2, slaveId, startAddress, numRegisters, master);
                    if (cbAutoRefresh.Checked)
                    {
                        ReadTimer.Enabled = true;
                        ReadTimer.Start();
                        if (HideLeftPane() == true)
                        {
                            btnExpandHide.Text = ">>";
                        }
                        else
                        {
                            btnExpandHide.Text = "<<";
                        }
                    }
                    else
                    {
                        ReadTimer.Stop();
                        ReadTimer.Enabled = false;
                        Display(slaveId, startAddress, numRegisters, master);
                        btnStartRead.Text = "Start";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                ReadTimer.Elapsed -= (sender2, e2) => ConstantRead(sender2, e2, slaveId, startAddress, numRegisters, null);
                ReadTimer.Stop();
                ReadTimer.Enabled = false;
                btnStartRead.Text = "Start";
            }
        }
        private void ConstantRead(Object source, ElapsedEventArgs e, byte ID, ushort startAddress, ushort numRegisters, IModbusSerialMaster master)
        {
            Display(ID, startAddress, numRegisters, master);
        }

        public async void Display(byte slaveId, ushort startAddress, ushort numRegisters, IModbusSerialMaster master)
        {
            try
            {
                exception = null;
                master.Transport.ReadTimeout = 500;
                var registers = await master.ReadHoldingRegistersAsync(slaveId, startAddress, numRegisters);

                BeginInvoke((Action)(() =>
                {
                    if (!Fahrenheits)
                    {
                        lblUnitTemp.Text = "°C";
                    }
                    else
                    {
                        lblUnitTemp.Text = "°F";
                    }
                    lblUnitHum.Text = " %";
                    var humRaw = BitConverter.GetBytes(registers[0]);
                    var humidity = (float)(BitConverter.ToInt16(humRaw, 0)) / 10;

                    lblHum.Text = humidity.ToString("0.0");

                    var tempRaw = BitConverter.GetBytes(registers[1]);
                    var temperature = (float)(BitConverter.ToInt16(tempRaw, 0)) / 10;
                    lblTemp.Text = GetTemperature(temperature).ToString("0.0"); 

                    if (HumidityMin.date < new DateTime(2018))
                    {
                        HumidityMin.value = humidity;
                        HumidityMin.date = DateTime.Now;
                        TemperatureMin.value = temperature;
                        TemperatureMin.date = DateTime.Now;
                        HumidityMax.value = humidity;
                        HumidityMax.date = DateTime.Now;
                        TemperatureMax.value = temperature;
                        TemperatureMax.date = DateTime.Now;
                    }
                    if (humidity > HumidityMax.value)
                    {
                        HumidityMax.value = humidity;
                        HumidityMax.date = DateTime.Now;
                    }
                    if (temperature > TemperatureMax.value)
                    {
                        TemperatureMax.value = temperature;
                        TemperatureMax.date = DateTime.Now;
                    }
                    if (humidity < HumidityMin.value)
                    {
                        HumidityMin.value = humidity;
                        HumidityMin.date = DateTime.Now;
                    }
                    if (temperature < TemperatureMin.value)
                    {
                        TemperatureMin.value = temperature;
                        TemperatureMin.date = DateTime.Now;
                    }
                }));

            }
            catch(Exception ex)
            {
                BeginInvoke((Action)(() =>
                {
                    lblHum.Text = "Err";
                    lblTemp.Text = Convert.ToString("Err");
                    exception = ex;
                }));
            }
        }

        private IModbusSerialMaster GetMaster()
        {
            var port = ((KeyValuePair<string, SerialPort>)cbxSerialPort.SelectedItem).Value;
            port.BaudRate = Convert.ToInt16(cbxComBaudRate.Text);
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            if (!port.IsOpen)
            {
                port.Open();
            }
            IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(port);
            return master;
        }

 
        private void splitContainer1_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            HideShowBorder();
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            ShowTemperatureInfo();
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            ShowHumidityInfo();
        }
           

        private void ShowTemperatureInfo()
        {
            MessageBox.Show($" Max temperature: {GetTemperature(TemperatureMax.value)} {lblUnitTemp.Text} at {TemperatureMax.date}" + System.Environment.NewLine + System.Environment.NewLine +
              $" Min temperature: {GetTemperature(TemperatureMin.value)} {lblUnitTemp.Text} at {TemperatureMin.date}" + System.Environment.NewLine);
        }
        private void ShowHumidityInfo()
        {
            MessageBox.Show($" Max humidity: {HumidityMax.value} % at {HumidityMax.date}" + System.Environment.NewLine + System.Environment.NewLine +
              $" Min humidity: {HumidityMin.value} % at {HumidityMin.date}" + System.Environment.NewLine);
        }
    
        private void splitContainer1_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            HideShowBorder();
        }
        private void HideShowBorder()
        {
            if (this.FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Opacity = 1;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Opacity = 0.8;
            }
        }
        private void ShowException()
        {
            if (exception != null)
            {
                MessageBox.Show(exception.Message + System.Environment.NewLine + exception.StackTrace);
                exception = null;
            }
        }
        private bool HideLeftPane()
        {
            if (splitContainer1.Panel1Collapsed == false)
            {
                this.Size = new Size(DefaultWidth - this.splitContainer1.Panel1.Width, this.Size.Height);
                splitContainer1.Panel1Collapsed = true;
                splitContainer1.Panel1.Hide();
                splitContainer1.Panel1.Visible = false;
                return true;
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel1.Visible = true;
                splitContainer1.Panel1.Show();
                this.Size = new Size(DefaultWidth, this.Size.Height);
                return false;
            }
        }

        private void lblUnitTemp_Click(object sender, EventArgs e)
        {
            if (!Fahrenheits)
            {
                Fahrenheits = true;
            }
            else
            {
                Fahrenheits = false;
            }
        }
        private float GetTemperature(float temperature)
        {
            if (Fahrenheits)
            {
                float tempF = (float)((temperature * 1.8) + 32);
                return(float) Math.Round(tempF, 1);
            }else
            {
                return temperature;
            }
        }

        private void lblTemp_DoubleClick_1(object sender, EventArgs e)
        {
          if(exception != null)
            {
                ShowException();
            }else
            {
                ShowTemperatureInfo();
            }
        }

        private void lblHum_DoubleClick_1(object sender, EventArgs e)
        {
            if (exception != null)
            {
                ShowException();
            }
            else
            {
                ShowHumidityInfo();
            }   
        }
    }
}
