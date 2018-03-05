namespace Meow
{
    partial class MeowMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeowMainForm));
            this.btnMeowTheFile = new System.Windows.Forms.Button();
            this.btnOpenTheFile = new System.Windows.Forms.Button();
            this.txtFileToMeow = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbReplaceOriginal = new System.Windows.Forms.CheckBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtReplacement = new System.Windows.Forms.TextBox();
            this.lblIterator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMeowTheFile
            // 
            this.btnMeowTheFile.Location = new System.Drawing.Point(567, 54);
            this.btnMeowTheFile.Name = "btnMeowTheFile";
            this.btnMeowTheFile.Size = new System.Drawing.Size(91, 23);
            this.btnMeowTheFile.TabIndex = 0;
            this.btnMeowTheFile.Text = "Meow";
            this.btnMeowTheFile.UseVisualStyleBackColor = true;
            this.btnMeowTheFile.Click += new System.EventHandler(this.btnMeowTheFile_Click);
            // 
            // btnOpenTheFile
            // 
            this.btnOpenTheFile.Location = new System.Drawing.Point(567, 25);
            this.btnOpenTheFile.Name = "btnOpenTheFile";
            this.btnOpenTheFile.Size = new System.Drawing.Size(91, 23);
            this.btnOpenTheFile.TabIndex = 1;
            this.btnOpenTheFile.Text = "File...";
            this.btnOpenTheFile.UseVisualStyleBackColor = true;
            this.btnOpenTheFile.Click += new System.EventHandler(this.btnOpenTheFile_Click);
            // 
            // txtFileToMeow
            // 
            this.txtFileToMeow.Location = new System.Drawing.Point(12, 28);
            this.txtFileToMeow.Name = "txtFileToMeow";
            this.txtFileToMeow.Size = new System.Drawing.Size(549, 20);
            this.txtFileToMeow.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 160);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(549, 218);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File To Meow:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Regexp Pattern:";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(12, 78);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(410, 20);
            this.txtPattern.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(567, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbReplaceOriginal
            // 
            this.cbReplaceOriginal.AutoSize = true;
            this.cbReplaceOriginal.Location = new System.Drawing.Point(438, 80);
            this.cbReplaceOriginal.Name = "cbReplaceOriginal";
            this.cbReplaceOriginal.Size = new System.Drawing.Size(123, 17);
            this.cbReplaceOriginal.TabIndex = 8;
            this.cbReplaceOriginal.Text = "Replace Original File";
            this.cbReplaceOriginal.UseVisualStyleBackColor = true;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(9, 110);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(73, 13);
            this.lblReplace.TabIndex = 9;
            this.lblReplace.Text = "Replacement:";
            // 
            // txtReplacement
            // 
            this.txtReplacement.Location = new System.Drawing.Point(12, 128);
            this.txtReplacement.Name = "txtReplacement";
            this.txtReplacement.Size = new System.Drawing.Size(254, 20);
            this.txtReplacement.TabIndex = 10;
            // 
            // lblIterator
            // 
            this.lblIterator.AutoSize = true;
            this.lblIterator.Location = new System.Drawing.Point(272, 131);
            this.lblIterator.Name = "lblIterator";
            this.lblIterator.Size = new System.Drawing.Size(48, 13);
            this.lblIterator.TabIndex = 11;
            this.lblIterator.Text = "+ iterator";
            // 
            // MeowMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 384);
            this.Controls.Add(this.lblIterator);
            this.Controls.Add(this.txtReplacement);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.cbReplaceOriginal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtFileToMeow);
            this.Controls.Add(this.btnOpenTheFile);
            this.Controls.Add(this.btnMeowTheFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MeowMainForm";
            this.Text = "Meow Tool 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMeowTheFile;
        private System.Windows.Forms.Button btnOpenTheFile;
        private System.Windows.Forms.TextBox txtFileToMeow;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbReplaceOriginal;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox txtReplacement;
        private System.Windows.Forms.Label lblIterator;
    }
}