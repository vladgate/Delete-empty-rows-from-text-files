﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delete_Empty_Rows_From_Docs
{
   public class MessageService : IMessageService
   {
      public void ShowMessage(string message)
      {
         MessageBox.Show(message);
      }
   }
}
