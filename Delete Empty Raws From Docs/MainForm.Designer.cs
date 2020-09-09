namespace Delete_Empty_Rows_From_Docs
{
    partial class MainForm
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnDeleteEmptyRaws = new System.Windows.Forms.Button();
            this.txtEncoding = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(208, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select file with text";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(226, 14);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(539, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // btnDeleteEmptyRaws
            // 
            this.btnDeleteEmptyRaws.Location = new System.Drawing.Point(13, 42);
            this.btnDeleteEmptyRaws.Name = "btnDeleteEmptyRaws";
            this.btnDeleteEmptyRaws.Size = new System.Drawing.Size(207, 23);
            this.btnDeleteEmptyRaws.TabIndex = 3;
            this.btnDeleteEmptyRaws.Text = "Delete empty raws";
            this.btnDeleteEmptyRaws.UseVisualStyleBackColor = true;
            this.btnDeleteEmptyRaws.Click += new System.EventHandler(this.btnDeleteEmptyRaws_Click);
            // 
            // txtEncoding
            // 
            this.txtEncoding.Location = new System.Drawing.Point(328, 45);
            this.txtEncoding.Name = "txtEncoding";
            this.txtEncoding.Size = new System.Drawing.Size(46, 20);
            this.txtEncoding.TabIndex = 4;
            this.txtEncoding.Text = "1251";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Encoding (number)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 74);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncoding);
            this.Controls.Add(this.btnDeleteEmptyRaws);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnSelectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Delete Empty Raws In Doc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnDeleteEmptyRaws;
        private System.Windows.Forms.TextBox txtEncoding;
        private System.Windows.Forms.Label label1;
    }
}

