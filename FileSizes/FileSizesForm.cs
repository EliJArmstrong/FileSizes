using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileSizes
{
    public partial class FileSizesForm : Form
    {



        public FileSizesForm()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (directoryComboBox.SelectedItem.ToString().Equals("Parent Directory"))
                {
                    Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetCurrentDirectory()).ToString());
                }
                else
                {
                    Directory.SetCurrentDirectory(directoryComboBox.SelectedItem.ToString());
                }
                UpdateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateUI()
        {
            fileInfoBox.Clear();
            directoryComboBox.Items.Clear();
            directoryComboBox.Items.Add("Parent Directory");
            CurrentDirectory.Text = Directory.GetCurrentDirectory();
            directoryComboBox.Items.AddRange(Directory.GetDirectories(Directory.GetCurrentDirectory()));
            foreach (var fileName in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                FileInfo fileInfo = new FileInfo(fileName);
                string filename = fileInfo.Name;

                if (fileInfo.Name.Length > 30)
                {
                    filename = fileInfo.Name.Substring(0, 26);
                }

                fileInfoBox.AppendText(String.Format("{0,-30}{1,22:N0}\n", filename, fileInfo.Length));
            }
        }
    }
}
