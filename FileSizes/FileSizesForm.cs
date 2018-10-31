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
            directoryComboBox.Items.Add("Parent Directory");
            directoryComboBox.Items.Add(Directory.GetCurrentDirectory());
            directoryComboBox.Items.AddRange(Directory.GetDirectories(Directory.GetCurrentDirectory()));
            label3.Text = Directory.GetCurrentDirectory();
            foreach (var fileName in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                FileInfo fileInfo = new FileInfo(fileName);
                fileInfoBox.AppendText(String.Format("{0,-30}{1,22:N0}\n", fileInfo.Name, fileInfo.Length));
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (directoryComboBox.SelectedItem.ToString().Equals("Parent Directory"))
            {
                fileInfoBox.Focus();
                directoryComboBox.Items.Clear();
                Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetCurrentDirectory()).ToString());
                directoryComboBox.Items.Add("Parent Directory");
                directoryComboBox.Items.Add(Directory.GetCurrentDirectory());
                directoryComboBox.Items.AddRange(Directory.GetDirectories(Directory.GetCurrentDirectory()));
                label3.Text = Directory.GetCurrentDirectory();
            }
            else
            {
                fileInfoBox.Focus();
                fileInfoBox.Clear();
                Directory.SetCurrentDirectory(directoryComboBox.SelectedItem.ToString());
                directoryComboBox.Items.Clear();
                directoryComboBox.Items.Add("Parent Directory");
                directoryComboBox.Items.Add(Directory.GetCurrentDirectory());
                label3.Text = Directory.GetCurrentDirectory();
                try
                {
                    directoryComboBox.Items.AddRange(Directory.GetDirectories(Directory.GetCurrentDirectory()));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (var fileName in Directory.GetFiles(Directory.GetCurrentDirectory()))
                {
                    FileInfo fileInfo = new FileInfo(fileName);
                    string filename = fileInfo.Name;

                    if (fileInfo.Name.Length > 30)
                    {
                        filename = fileInfo.Name.Substring(0, 26) + fileInfo.Extension; 
                    }

                    fileInfoBox.AppendText(String.Format("{0,-30}{1,22:N0}\n", filename, fileInfo.Length));
                }
            }
        }
    }
}
