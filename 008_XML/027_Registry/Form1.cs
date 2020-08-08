using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace _027_Registry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                // RegistryKey - Инициализация объекта для работы с веткой LocalMachine.
                RegistryKey key = Registry.LocalMachine;

                key = key.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                string temp = (string)key.GetValue("ITEA", "");

                if (temp != "")
                    label3.Text = "программа стоит в автозагрузке";
            }
            catch (Exception e)
            {
                label3.Text = "программа не стоит в автозагрузке";
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// // Установка программы в автозагрузку.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                key = key.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");

                // Путь к данному приложению.
                key.SetValue("ITEA", Application.StartupPath + "\\WindowsFormsApplication2.exe");
                label3.Text = "программа стоит в автозагрузке";
            }
            catch (Exception ex)
            {
                label3.Text = "программа не стоит в автозагрузке";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Удаление программы из автозагрузки.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                key = key.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
                key.DeleteValue("ITEA");
                label3.Text = "программа не стоит в автозагрузке";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
