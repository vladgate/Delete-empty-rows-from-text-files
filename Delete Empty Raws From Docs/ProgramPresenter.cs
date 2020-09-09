using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delete_Empty_Rows_From_Docs
{
   class ProgramPresenter
   {
      private IView _mainForm;
      private IMessageService _messageService;
      private ProgramLogic _logic;
      public ProgramPresenter(IView mainForm, IMessageService messageService, ProgramLogic logic)
      {
         _mainForm = mainForm;
         _messageService = messageService;
         _logic = logic;
         _mainForm.SelectFileClick += _mainForm_SelectFileClick;
         _mainForm.DeleteEmptyRawsClick += _mainForm_DeleteEmptyRawsClick;
      }
      private void _mainForm_SelectFileClick(object sender, EventArgs e)
      {
         OpenFileDialog dialog = new OpenFileDialog();
         dialog.Filter = "Text flles (*.txt;*.html;*.doc;*.docx)|*.txt;*.html;*.doc;*.docx";
         DialogResult dr = dialog.ShowDialog();
         if (dr == DialogResult.OK)
         {
            _mainForm.FilePath = dialog.FileName;
         }
      }

      private void _mainForm_DeleteEmptyRawsClick(object sender, EventArgs e)
      {
         if (_mainForm.FilePath == "")
         {
            _messageService.ShowMessage("Please, select file!");
            return;
         }

         try
         {
            int affectedRowsCount = _logic.DeleteEmptyRaws(_mainForm.FilePath, Int32.Parse(_mainForm.Encoding));
            if (affectedRowsCount == 0)
            {
               _messageService.ShowMessage("There are no empty rows in the file.");
            }
            else
            {
               _messageService.ShowMessage("Success! Deleted " + affectedRowsCount + " empty row(s).");
            }
         }
         catch (Exception ex)
         {
            _messageService.ShowMessage("Error! " + ex.Message);
         }
      }

   }
}
