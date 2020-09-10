using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_Empty_Rows_From_Docs
{
    interface IView
    {
        event EventHandler SelectFileClick;
        event EventHandler DeleteEmptyRawsClick;
        string FilePath { get; set; }
    }
}
