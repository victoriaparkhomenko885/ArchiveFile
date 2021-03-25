using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Ionic.Zlib;
using Ionic.Zip;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> listSelectedFile = new List<string>(); 
        string Password; 
        string ZipName; 
        string DestinationPath; 
        bool status;
        bool zip_flag = false;
        bool flag_check_list = false;
        public static string extension;
        int countfiles = 0;
        public Form1()
        {
            InitializeComponent();
        }

        // Browse Button
        private void add_items_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BrowserTextBox.Enabled = true;
                BrowserTextBox.Text = openFileDialog1.FileName.ToString();
                
                SelectedFileList.Items.Add(openFileDialog1.FileName);
                countfiles++;
                countFile.Text = countfiles.ToString();
                flag_check_list = true;
            }
        }

        //Delete Button
        private void delete_button_click(object sender, EventArgs e)
        {

            if (!SelectedFileList.SelectedIndex.Equals(-1))
            {
                SelectedFileList.Items.RemoveAt(SelectedFileList.SelectedIndex);
                countfiles--;
                countFile.Text = countfiles.ToString();
            }
            else
                MessageBox.Show("Оберіть файл для видалення");
        }

        // Password Check Box
        private void check_for_password(object sender, EventArgs e)
        {
            if (IsPassword.Checked)
            {
                PasswordTextBox.Enabled = true;
                AddPasswordButton.Enabled = true;
            }
            else
            {
                PasswordTextBox.Enabled = false;
                AddPasswordButton.Enabled = false;
            }
        }
        
        private void destination_folder_button(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DestinationTextBox.Enabled = true;
                DestinationTextBox.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        //ZIP Button
        private void ZIPButton_Click(object sender, EventArgs e)
        {
            if (zip_flag == true)
                MessageBox.Show("Ви вже заархівували файли, створіть новий архів!");
            else if (flag_check_list == false)
                MessageBox.Show("Ви не обрали жодного файлу!");
            else
            {
                DateTime curtime = DateTime.Now;
                foreach (object item in SelectedFileList.Items)
                    listSelectedFile.Add(item.ToString());

                DestinationPath = DestinationTextBox.Text;
                ZipName = ZipTextBox.Text;
                status = Zip_Files(listSelectedFile, Password, DestinationPath, ZipName);

                if (status == true)
                {
                    TimeSpan proctime = DateTime.Now - curtime;
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", proctime.Hours, proctime.Minutes, 
                        proctime.Seconds, proctime.Milliseconds / 10);
                    MessageBox.Show("Ви успішно заархівували ваші файли за вказаним пунктом призначення " + DestinationPath + "\n" +
                        "Час виконання архівації: " + elapsedTime);
                    if (checkBox3.Checked == true)
                        foreach (string item in SelectedFileList.Items)
                            File.Delete(item);
                    zip_flag = true;
                }

                else
                    MessageBox.Show("Виникла помилка!");
            }
        }

        public static bool Zip_Files(List<string> listSelectedFile, string Password, string DestinationPath, string ZipName)
        {
            if (listSelectedFile != null)
            {
                using (ZipFile zip = new ZipFile())
                {
                    zip.Password = (Password);
                    foreach (var sFile in listSelectedFile)
                    {
                        zip.AddFile(sFile);
                    }
                    zip.Save(DestinationPath + "\\" + ZipName + extension);

                    return true;
                }
            }
            return false;
        }

        //Password Button
        private void AddPasswordButton_Click(object sender, EventArgs e)
        {
            Password = PasswordTextBox.Text;
            PasswordTextBox.Enabled = false;
        }
        
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            Password = PasswordTextBox.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            extension = ".zip";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            extension = ".rar";
        }

        private void Restart_button(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
