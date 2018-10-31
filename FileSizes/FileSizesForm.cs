// <author>Eli Armstrong</author>
// <remarks>I pledge my word of honor that I have abided
// by the CSN Academic Integrity Policy while completing
// this assignment.</remarks>
// <file>FileSizesForm.cs</file>
// <date>2018-10-26</date>
// <summary>This class is a GUI that creates a combobox of directories. 
// The current directory's files and their sizes are displayed in a text 
// box.</summary> 
// <remarks>Time taken to develop, write, test and debug
// solution. About 2.5 hours. </remarks>

using System;
using System.IO;
using System.Windows.Forms;

// ----------------------------------------------------------------------------
// The Name Space for FileSizes.
// ----------------------------------------------------------------------------
namespace FileSizes
{
    /// -----------------------------------------------------------------------
    /// <summary>The FileSizesForm partial class with base of Form.</summary>
    /// -----------------------------------------------------------------------
    public partial class FileSizesForm : Form
    {
        /// -------------------------------------------------------------------
        /// <summary>Constructor</summary>
        ///
        /// <remarks>
        /// Calls the InitializeComponent method and updates the UI.
        /// </remarks>
        /// -------------------------------------------------------------------
        public FileSizesForm()
        {
            InitializeComponent();
            UpdateUI();
        }

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method gets called when an option is selected.
        /// Then the current directory is updated and the UI is updated.
        /// </summary>
        /// <param name="sender">The caller of the method.</param>
        /// <param name="e">The event choices that are offered.</param>
        /// -------------------------------------------------------------------
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

        /// -------------------------------------------------------------------
        /// <summary>
        /// This method updates the UI by updating the directory 
        /// combobox and files and sizes of the current directory.
        /// </summary>
        /// -------------------------------------------------------------------
        private void UpdateUI()
        {
            fileInfoBox.Clear();
            directoryComboBox.Items.Clear();
            directoryComboBox.Items.Add("Parent Directory");
            CurrentDirectory.Text = Directory.GetCurrentDirectory();
            directoryComboBox.Items.AddRange(Directory.GetDirectories(Directory.GetCurrentDirectory()));
            foreach (var fileName in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                FileInfo fileInfo = new FileInfo(fileName); // Gets file info.
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
