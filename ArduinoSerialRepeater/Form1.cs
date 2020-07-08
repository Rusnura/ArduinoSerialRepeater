using System;
using System.IO;
using System.Windows.Forms;

namespace ArduinoSerialRepeater
{
    public partial class Form1 : Form
    {
        private WebServer webServer;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_webServer_start_Click(object sender, EventArgs e)
        {
            if (webServer == null)
            {
                try
                {
                    webServer = new WebServer(txt_webServer_address.Text);
                    webServer.OnWebServerConnectedEvent += WebServer_OnWebServerConnectedEvent;
                    webServer.Start();
                    btn_webServer_start.Enabled = false;
                    btn_webServer_stop.Enabled = true;
                    txt_webServer_address.ReadOnly = true;
                    __log(txt_webServer_log, "Веб сервер запущен: " + txt_webServer_address.Text + "!");
                } 
                catch (Exception ex)
                {
                    if (webServer != null)
                    {
                        webServer = null;
                    }
                    MessageBox.Show("Не удалось запустить сервер: " + ex.Message, "Обработка запуска сервера - ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void WebServer_OnWebServerConnectedEvent(System.Net.HttpListenerRequest request, System.Net.HttpListenerResponse response)
        {
            __log(txt_webServer_log, "Получено новое сообщение: " + request.RawUrl);
            string serialResponse = __tryToSendToCOMAndRead(request.RawUrl);
            if (serialResponse == null)
            {
                serialResponse = "Serial порт не прислал ответ!";
            }
            string responseStr = "<html><head><meta charset='utf8'></head><body>" + serialResponse + "</body></html>";
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseStr);
            response.ContentLength64 = buffer.Length;
            using (Stream output = response.OutputStream)
            {
                output.Write(buffer, 0, buffer.Length);
            }
        }

        private void btn_webServer_stop_Click(object sender, EventArgs e)
        {
            if (webServer != null)
            {
                try
                {
                    webServer.Stop();
                    webServer = null;
                    btn_webServer_start.Enabled = true;
                    btn_webServer_stop.Enabled = false;
                    txt_webServer_address.ReadOnly = false;
                    __log(txt_webServer_log, "Веб сервер успешно остановлен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось остановить сервер: " + ex.Message, "Обработка остановки сервера - ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_webServer_logClear_Click(object sender, EventArgs e)
        {
            txt_webServer_log.Clear();
        }

        private void btn_serial_start_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.BaudRate = int.Parse(txt_serial_baudRate.Text);
                    serialPort.PortName = txt_serial_comPort.Text;
                    serialPort.ReadTimeout = 3000;
                    serialPort.Open();
                    __log(txt_serial_log, "Порт: " + serialPort.PortName + "(" + serialPort.BaudRate + ") открыт!");
                    btn_serial_start.Enabled = false;
                    btn_serial_stop.Enabled = true;
                    txt_serial_comPort.ReadOnly = true;
                    txt_serial_baudRate.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось открыть COM-порт: " + ex.Message, "Обработка открытия COM порта - ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_serial_stop_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                btn_serial_stop.Enabled = false;
                btn_serial_start.Enabled = true;
                txt_serial_comPort.ReadOnly = false;
                txt_serial_baudRate.ReadOnly = false;
                __log(txt_serial_log, "Порт: " + serialPort.PortName + "(" + serialPort.BaudRate + ") закрыт!");
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось закрыть COM-порт: " + ex.Message, "Обработка закрытия COM порта - ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_serial_logClear_Click(object sender, EventArgs e)
        {
            txt_serial_log.Clear();
        }

        private string __tryToSendToCOMAndRead(string message)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.WriteLine(message);
                    __log(txt_serial_log, "-> " + message);
                    string receivedData = serialPort.ReadExisting();
                    __log(txt_serial_log, "<- " + receivedData);
                    return receivedData;
                }
                catch (Exception e)
                {
                    __log(txt_serial_log, "X Не удалось: " + e.Message);
                }
            }
            return null;
        }

        private void __log(TextBox element, string message)
        {
            element.BeginInvoke((MethodInvoker)delegate ()
            {
                element.AppendText(message + Environment.NewLine);
            });
        }
    }
}
