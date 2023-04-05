namespace FileSystemMonitor
{
    partial class FileMonitorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMonitorForm));
            this.PathLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ControlGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FileFilterLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.NotificationsGroup = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ControlGroup.SuspendLayout();
            this.NotificationsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 25);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(200, 16);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Директория для мониторинга";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "С:\\";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(212, 106);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Включить мониторинг";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.MonitoringInput_CheckedChanged);
            // 
            // ControlGroup
            // 
            this.ControlGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlGroup.Controls.Add(this.button1);
            this.ControlGroup.Controls.Add(this.textBox2);
            this.ControlGroup.Controls.Add(this.FileFilterLabel);
            this.ControlGroup.Controls.Add(this.PathLabel);
            this.ControlGroup.Controls.Add(this.textBox1);
            this.ControlGroup.Controls.Add(this.checkBox1);
            this.ControlGroup.Location = new System.Drawing.Point(16, 15);
            this.ControlGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlGroup.Name = "ControlGroup";
            this.ControlGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlGroup.Size = new System.Drawing.Size(1032, 137);
            this.ControlGroup.TabIndex = 0;
            this.ControlGroup.TabStop = false;
            this.ControlGroup.Text = "Настройки мониторинга";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 103);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "*.*";
            // 
            // FileFilterLabel
            // 
            this.FileFilterLabel.AutoSize = true;
            this.FileFilterLabel.Location = new System.Drawing.Point(12, 84);
            this.FileFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileFilterLabel.Name = "FileFilterLabel";
            this.FileFilterLabel.Size = new System.Drawing.Size(110, 16);
            this.FileFilterLabel.TabIndex = 2;
            this.FileFilterLabel.Text = "Фильтр файлов";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 159);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(581, 279);
            this.listBox1.TabIndex = 3;
            // 
            // NotificationsGroup
            // 
            this.NotificationsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationsGroup.Controls.Add(this.checkBox10);
            this.NotificationsGroup.Controls.Add(this.checkBox9);
            this.NotificationsGroup.Controls.Add(this.checkBox8);
            this.NotificationsGroup.Controls.Add(this.checkBox7);
            this.NotificationsGroup.Controls.Add(this.checkBox6);
            this.NotificationsGroup.Controls.Add(this.checkBox5);
            this.NotificationsGroup.Controls.Add(this.checkBox4);
            this.NotificationsGroup.Controls.Add(this.checkBox3);
            this.NotificationsGroup.Controls.Add(this.checkBox2);
            this.NotificationsGroup.Location = new System.Drawing.Point(605, 156);
            this.NotificationsGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NotificationsGroup.Name = "NotificationsGroup";
            this.NotificationsGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NotificationsGroup.Size = new System.Drawing.Size(443, 282);
            this.NotificationsGroup.TabIndex = 1;
            this.NotificationsGroup.TabStop = false;
            this.NotificationsGroup.Text = "События";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(8, 250);
            this.checkBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(278, 20);
            this.checkBox10.TabIndex = 8;
            this.checkBox10.Text = "&Контролировать вложенные каталоги";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(8, 222);
            this.checkBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(279, 20);
            this.checkBox9.TabIndex = 7;
            this.checkBox9.Text = "Изменение размера файла или папки";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(8, 193);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(398, 20);
            this.checkBox8.TabIndex = 6;
            this.checkBox8.Text = "Изменение параметров безопасности файла или папки";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(8, 165);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(267, 20);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.Text = "Последняя запись в файл или папку";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(8, 137);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(282, 20);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "Последнее открытие файла или папки";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(8, 108);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(194, 20);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Изменение имени файла";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(8, 80);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(211, 20);
            this.checkBox4.TabIndex = 2;
            this.checkBox4.Text = "Изменение имени каталога";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(8, 52);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(234, 20);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Время создания файла и папки";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(8, 23);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(276, 20);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Изменение атрибутов файла и папки";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FileMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 453);
            this.Controls.Add(this.NotificationsGroup);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ControlGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FileMonitorForm";
            this.Text = "www.CSharpCoderR.com";
            this.Load += new System.EventHandler(this.FileMonitorForm_Load);
            this.ControlGroup.ResumeLayout(false);
            this.ControlGroup.PerformLayout();
            this.NotificationsGroup.ResumeLayout(false);
            this.NotificationsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox ControlGroup;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label FileFilterLabel;
        private System.Windows.Forms.GroupBox NotificationsGroup;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

