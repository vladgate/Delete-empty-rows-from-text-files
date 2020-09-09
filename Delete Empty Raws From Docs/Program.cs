using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delete_Empty_Rows_From_Docs
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         ProgramLogic logic = new ProgramLogic();
         IView mainform = new MainForm();
         IMessageService messageService = new MessageService();
         ProgramPresenter presenter = new ProgramPresenter(mainform, messageService, logic);
         Application.Run(mainform as MainForm);
      }
   }
}
