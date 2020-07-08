namespace ArduinoSerialRepeater
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_webServer_logClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_webServer_log = new System.Windows.Forms.TextBox();
            this.txt_webServer_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_webServer_start = new System.Windows.Forms.Button();
            this.btn_webServer_stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_serial_comPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_serial_baudRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_serial_log = new System.Windows.Forms.TextBox();
            this.btn_serial_logClear = new System.Windows.Forms.Button();
            this.btn_serial_start = new System.Windows.Forms.Button();
            this.btn_serial_stop = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_webServer_logClear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_webServer_log);
            this.groupBox1.Controls.Add(this.txt_webServer_address);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_webServer_start);
            this.groupBox1.Controls.Add(this.btn_webServer_stop);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка веб-сервера";
            // 
            // btn_webServer_logClear
            // 
            this.btn_webServer_logClear.Location = new System.Drawing.Point(358, 80);
            this.btn_webServer_logClear.Name = "btn_webServer_logClear";
            this.btn_webServer_logClear.Size = new System.Drawing.Size(39, 23);
            this.btn_webServer_logClear.TabIndex = 6;
            this.btn_webServer_logClear.Text = "CL";
            this.btn_webServer_logClear.UseVisualStyleBackColor = true;
            this.btn_webServer_logClear.Click += new System.EventHandler(this.btn_webServer_logClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "События:";
            // 
            // txt_webServer_log
            // 
            this.txt_webServer_log.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_webServer_log.Location = new System.Drawing.Point(10, 92);
            this.txt_webServer_log.Multiline = true;
            this.txt_webServer_log.Name = "txt_webServer_log";
            this.txt_webServer_log.ReadOnly = true;
            this.txt_webServer_log.Size = new System.Drawing.Size(387, 256);
            this.txt_webServer_log.TabIndex = 4;
            // 
            // txt_webServer_address
            // 
            this.txt_webServer_address.Location = new System.Drawing.Point(10, 43);
            this.txt_webServer_address.Name = "txt_webServer_address";
            this.txt_webServer_address.Size = new System.Drawing.Size(387, 22);
            this.txt_webServer_address.TabIndex = 3;
            this.txt_webServer_address.Text = "http://localhost:8081/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес веб-сервера:";
            // 
            // btn_webServer_start
            // 
            this.btn_webServer_start.Location = new System.Drawing.Point(241, 354);
            this.btn_webServer_start.Name = "btn_webServer_start";
            this.btn_webServer_start.Size = new System.Drawing.Size(75, 30);
            this.btn_webServer_start.TabIndex = 1;
            this.btn_webServer_start.Text = "Запуск";
            this.btn_webServer_start.UseVisualStyleBackColor = true;
            this.btn_webServer_start.Click += new System.EventHandler(this.btn_webServer_start_Click);
            // 
            // btn_webServer_stop
            // 
            this.btn_webServer_stop.Enabled = false;
            this.btn_webServer_stop.Location = new System.Drawing.Point(322, 354);
            this.btn_webServer_stop.Name = "btn_webServer_stop";
            this.btn_webServer_stop.Size = new System.Drawing.Size(75, 30);
            this.btn_webServer_stop.TabIndex = 0;
            this.btn_webServer_stop.Text = "Стоп";
            this.btn_webServer_stop.UseVisualStyleBackColor = true;
            this.btn_webServer_stop.Click += new System.EventHandler(this.btn_webServer_stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_serial_stop);
            this.groupBox2.Controls.Add(this.btn_serial_start);
            this.groupBox2.Controls.Add(this.btn_serial_logClear);
            this.groupBox2.Controls.Add(this.txt_serial_log);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_serial_baudRate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_serial_comPort);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(422, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройка Serial интерфейса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "COM порт:";
            // 
            // txt_serial_comPort
            // 
            this.txt_serial_comPort.Location = new System.Drawing.Point(10, 42);
            this.txt_serial_comPort.Name = "txt_serial_comPort";
            this.txt_serial_comPort.Size = new System.Drawing.Size(350, 22);
            this.txt_serial_comPort.TabIndex = 1;
            this.txt_serial_comPort.Text = "COM3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Скорость:";
            // 
            // txt_serial_baudRate
            // 
            this.txt_serial_baudRate.Location = new System.Drawing.Point(10, 89);
            this.txt_serial_baudRate.Name = "txt_serial_baudRate";
            this.txt_serial_baudRate.Size = new System.Drawing.Size(350, 22);
            this.txt_serial_baudRate.TabIndex = 3;
            this.txt_serial_baudRate.Text = "9600";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "События:";
            // 
            // txt_serial_log
            // 
            this.txt_serial_log.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_serial_log.Location = new System.Drawing.Point(10, 139);
            this.txt_serial_log.Multiline = true;
            this.txt_serial_log.Name = "txt_serial_log";
            this.txt_serial_log.ReadOnly = true;
            this.txt_serial_log.Size = new System.Drawing.Size(350, 209);
            this.txt_serial_log.TabIndex = 5;
            // 
            // btn_serial_logClear
            // 
            this.btn_serial_logClear.Location = new System.Drawing.Point(315, 127);
            this.btn_serial_logClear.Name = "btn_serial_logClear";
            this.btn_serial_logClear.Size = new System.Drawing.Size(45, 23);
            this.btn_serial_logClear.TabIndex = 7;
            this.btn_serial_logClear.Text = "CL";
            this.btn_serial_logClear.UseVisualStyleBackColor = true;
            this.btn_serial_logClear.Click += new System.EventHandler(this.btn_serial_logClear_Click);
            // 
            // btn_serial_start
            // 
            this.btn_serial_start.Location = new System.Drawing.Point(204, 354);
            this.btn_serial_start.Name = "btn_serial_start";
            this.btn_serial_start.Size = new System.Drawing.Size(75, 30);
            this.btn_serial_start.TabIndex = 7;
            this.btn_serial_start.Text = "Запуск";
            this.btn_serial_start.UseVisualStyleBackColor = true;
            this.btn_serial_start.Click += new System.EventHandler(this.btn_serial_start_Click);
            // 
            // btn_serial_stop
            // 
            this.btn_serial_stop.Enabled = false;
            this.btn_serial_stop.Location = new System.Drawing.Point(285, 354);
            this.btn_serial_stop.Name = "btn_serial_stop";
            this.btn_serial_stop.Size = new System.Drawing.Size(75, 30);
            this.btn_serial_stop.TabIndex = 7;
            this.btn_serial_stop.Text = "Стоп";
            this.btn_serial_stop.UseVisualStyleBackColor = true;
            this.btn_serial_stop.Click += new System.EventHandler(this.btn_serial_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web -> Serial Retranslator (c) Tumasov Ruslan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_webServer_stop;
        private System.Windows.Forms.TextBox txt_webServer_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_webServer_start;
        private System.Windows.Forms.Button btn_webServer_logClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_webServer_log;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_serial_baudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_serial_comPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_serial_logClear;
        private System.Windows.Forms.TextBox txt_serial_log;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_serial_stop;
        private System.Windows.Forms.Button btn_serial_start;
        private System.IO.Ports.SerialPort serialPort;
    }
}

