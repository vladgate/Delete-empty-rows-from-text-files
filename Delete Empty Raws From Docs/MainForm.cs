using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delete_Empty_Rows_From_Docs
{
    public partial class MainForm : Form, IView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler SelectFileClick;
        public event EventHandler DeleteEmptyRawsClick;
        public string FilePath
        {
            get
            {
                return txtFilePath.Text;
            }

            set
            {
                txtFilePath.Text = value;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            SelectFileClick?.Invoke(sender, e);
        }

        private void btnDeleteEmptyRaws_Click(object sender, EventArgs e)
        {
            DeleteEmptyRawsClick?.Invoke(sender, e);
        }
    }
}
