namespace FileSizes
{
    partial class FileSizesForm
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
            this.gradientGroup = new FileSizes.GradientGroup();
            this.CurrentDirectory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileInfoBox = new System.Windows.Forms.TextBox();
            this.directoryComboBox = new System.Windows.Forms.ComboBox();
            this.gradientGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientGroup
            // 
            this.gradientGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientGroup.ColorBottom = System.Drawing.Color.Black;
            this.gradientGroup.ColorTop = System.Drawing.Color.Gray;
            this.gradientGroup.Controls.Add(this.CurrentDirectory);
            this.gradientGroup.Controls.Add(this.label2);
            this.gradientGroup.Controls.Add(this.label1);
            this.gradientGroup.Controls.Add(this.fileInfoBox);
            this.gradientGroup.Controls.Add(this.directoryComboBox);
            this.gradientGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gradientGroup.Location = new System.Drawing.Point(0, -6);
            this.gradientGroup.Name = "gradientGroup";
            this.gradientGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gradientGroup.Size = new System.Drawing.Size(421, 457);
            this.gradientGroup.TabIndex = 0;
            this.gradientGroup.TabStop = false;
            // 
            // CurrentDirectory
            // 
            this.CurrentDirectory.AutoSize = true;
            this.CurrentDirectory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CurrentDirectory.Location = new System.Drawing.Point(16, 39);
            this.CurrentDirectory.Name = "CurrentDirectory";
            this.CurrentDirectory.Size = new System.Drawing.Size(83, 13);
            this.CurrentDirectory.TabIndex = 4;
            this.CurrentDirectory.Text = "CurrentDirectory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(315, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Name";
            // 
            // fileInfoBox
            // 
            this.fileInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInfoBox.Location = new System.Drawing.Point(13, 84);
            this.fileInfoBox.Multiline = true;
            this.fileInfoBox.Name = "fileInfoBox";
            this.fileInfoBox.ReadOnly = true;
            this.fileInfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileInfoBox.Size = new System.Drawing.Size(392, 360);
            this.fileInfoBox.TabIndex = 1;
            this.fileInfoBox.WordWrap = false;
            // 
            // directoryComboBox
            // 
            this.directoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.directoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directoryComboBox.FormattingEnabled = true;
            this.directoryComboBox.Location = new System.Drawing.Point(12, 35);
            this.directoryComboBox.Name = "directoryComboBox";
            this.directoryComboBox.Size = new System.Drawing.Size(393, 21);
            this.directoryComboBox.TabIndex = 0;
            this.directoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // FileSizesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.gradientGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FileSizesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Sizes";
            this.gradientGroup.ResumeLayout(false);
            this.gradientGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FileSizes.GradientGroup gradientGroup;
        private System.Windows.Forms.ComboBox directoryComboBox;
        private System.Windows.Forms.TextBox fileInfoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentDirectory;
    }
}

