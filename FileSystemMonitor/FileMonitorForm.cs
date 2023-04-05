using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileSystemMonitor
{
    public partial class FileMonitorForm : Form
    {

        public FileMonitorForm()
        {
            InitializeComponent();
        }

        private void FileMonitorForm_Load(object sender, EventArgs e)
        {
            //Задаем объект, используемый для маршалинга вызовов обработчика
            //событий, инициированных в результате изменения каталога.
            fileSystemWatcher1.SynchronizingObject = this;
            //Событие возникающее при изменении файла или каталога в заданном пути.
            fileSystemWatcher1.Changed += new FileSystemEventHandler(LogFileSystemChanges);
            //Событие возникающее при создании файла или каталога в заданном пути.
            fileSystemWatcher1.Created += new FileSystemEventHandler(LogFileSystemChanges);
            //Событие возникающее при удалении файла или каталога в заданном пути.
            fileSystemWatcher1.Deleted += new FileSystemEventHandler(LogFileSystemChanges);
            //Событие возникающее при переименовании файла или каталога в заданном пути.
            fileSystemWatcher1.Renamed += new RenamedEventHandler(LogFileSystemRenaming);
            //Событие возникающее при переполнении внутреннего буфера.
            fileSystemWatcher1.Error += new ErrorEventHandler(LogBufferError);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создание класса для вывода окна выбора директории
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //Выводим диалоговое окно для выбора каталога.
            // Данный класс возвращает следующие значения:
            // 1) Объект System.Windows.Forms.DialogResult.OK, 
            //    если пользователь нажимает кнопку 
            //    ОК в диалоговом окне;
            // 2) Объект System.Windows.Forms.DialogResult.Cancel,  
            //    если пользователь закрывает диалоговое окно.
            DialogResult result = fbd.ShowDialog();

            //Если пользователь выбрал директорию
            //и нажал ОК, то выводим путь в textBox1
            if (result == DialogResult.OK)
            {
                //Вывод пути к  
                //выбранной директории 
                 textBox1.Text = fbd.SelectedPath;
            }
        }

        void LogBufferError(object sender, ErrorEventArgs e)
        {
            string log = string.Format("{0:G} | Переполнен внутренний буфер", DateTime.Now);
            //Добавляем новую запись события.
            listBox1.Items.Add(log);
            //Выбираем последнюю добавленную запись.
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        void LogFileSystemRenaming(object sender, RenamedEventArgs e)
        {
            string log = string.Format("{0:G} | {1} | Переименован файл {2}", DateTime.Now, e.FullPath, e.OldName);
            //Добавляем новую запись события.
            listBox1.Items.Add(log);
            //Выбираем последнюю добавленную запись.
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        void LogFileSystemChanges(object sender, FileSystemEventArgs e)
        {
            string log = string.Format("{0:G} | {1} | {2}", DateTime.Now, e.FullPath, e.ChangeType);
            //Добавляем новую запись события.
            listBox1.Items.Add(log);
            //Выбираем последнюю добавленную запись.
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void MonitoringInput_CheckedChanged(object sender, EventArgs e)
        {
            //Получаем путь к выбранному каталогу.
            string monitoredFolder = textBox1.Text;
            //Определяем, указывает ли заданный путь 
            //на существующий каталог на диске.
            bool folderExists = Directory.Exists(monitoredFolder);
            
            //Проверка существования директории.
            if (folderExists)
            {
                //Задаем путь отслеживаемого каталога.
                fileSystemWatcher1.Path = monitoredFolder;

                //Задаем строку фильтра, используемую для определения файлов,
                //контролируемых в каталоге. 
                //По умолчанию используется "*.*" (отслеживаются все файлы).       
                fileSystemWatcher1.Filter = textBox2.Text;

                //Задаем значение, показывающее необходимость контроля вложенных
                //каталогов по указанному пути.
                fileSystemWatcher1.IncludeSubdirectories = checkBox10.Checked;

                //Отслеживаемые изменения.
                NotifyFilters notificationFilters = new NotifyFilters();
                //Атрибуты файла и папки.
                if (checkBox2.Checked) notificationFilters = notificationFilters 
                    | NotifyFilters.Attributes;
                //Время создания файла и папки.
                if (checkBox3.Checked) notificationFilters = notificationFilters
                    | NotifyFilters.CreationTime;
                //Имя каталога.
                if (checkBox4.Checked) notificationFilters = notificationFilters
                    | NotifyFilters.DirectoryName;
                //Имя файла
                if (checkBox5.Checked) notificationFilters = notificationFilters
                    | NotifyFilters.FileName;
                //Дата последнего открытия файла или папки.
                if (checkBox6.Checked) notificationFilters = notificationFilters
                    | NotifyFilters.LastAccess;
                //Дата последней записи в файл или папку.
                if (checkBox7.Checked) notificationFilters = notificationFilters
                    | NotifyFilters.LastWrite;
                //Параметры безопасности файла или папки.
                if (checkBox8.Checked) notificationFilters = notificationFilters
                    | NotifyFilters.Security;
                //Размер файла или папки.
                if (checkBox9.Checked) notificationFilters = notificationFilters
                    | NotifyFilters.Size;
                //Задаем тип отслеживаемых изменений.
                fileSystemWatcher1.NotifyFilter = notificationFilters;

                //Задаем значение, определяющее, доступен ли данный компонент.
                fileSystemWatcher1.EnableRaisingEvents = checkBox1.Checked;
            }
            else if (checkBox1.Checked)
            {
                MessageBox.Show(this, "Выбранная директория не существует!", "Мониторинг", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Выключаем мониторинг при ошибке.
                checkBox1.Checked = false;
            }
            //После запуске мониторинга, блогируем элементы управления.
            textBox1.Enabled = textBox2.Enabled = 
                NotificationsGroup.Enabled = !checkBox1.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
