using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Meow
{
    public partial class MeowMainForm : Form, IObserver
    {
        private MeowFile meowFile;

        public MeowMainForm()
        {
            InitializeComponent();
            txtPattern.Text = @"Timestamp_(\d+)";
            txtReplacement.Text = @"Timestamp_";
        }        

        private void btnMeowTheFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            
            if ((meowFile != null) && (File.Exists(txtFileToMeow.Text))) {
                meowFile.fileName = txtFileToMeow.Text;
                meowFile.meowPattern = txtPattern.Text;
                meowFile.meowReplacement = txtReplacement.Text;
                meowFile.FeedTheCat(cbReplaceOriginal.Checked);
            }
            else
            {
                LogOperation("File does not exist.");
            }            
        }

        private void btnOpenTheFile_Click(object sender, EventArgs e)
        {
            if (meowFile == null)
            {
                meowFile = new MeowFile();
                meowFile.Register(this);
            }

            OpenFileDialog openFileToMeowDialog = new OpenFileDialog();

            if (openFileToMeowDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFileToMeow.Text = openFileToMeowDialog.FileName;               
            }

        }

        public void LogOperation(string logText)
        {
            richTextBox1.AppendText("\r\n" + logText);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
