using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_Empty_Rows_From_Docs
{
   class ProgramLogic
   {
      private readonly string[] _supportedExtensions = new string[] { ".txt", ".html" };

      /// <returns>Number of affected rows</returns>
      public int DeleteEmptyRaws(string filePath)
      {
         if (File.Exists(filePath))
         {
            string ext = Path.GetExtension(filePath);
            if (!_supportedExtensions.Contains(ext))
            {
               throw new NotSupportedException();
            }

            int counter = 0;
            StringBuilder content = new StringBuilder();
            string source = File.ReadAllText(filePath);
            string[] ar = source.Split(new string[] { "\r\n"}, StringSplitOptions.None);
            foreach (string item in ar)
            {
               if (StringHasOnlySpaces(item))
               {
                  counter++;
                  continue;
               }
               else
               {
                  content.Append(item);
                  content.Append(Environment.NewLine);
               }

            }

            File.WriteAllText(filePath, content.ToString());
            return counter;
         }
         else
         {
            throw new FileNotFoundException();
         }
      }

      private bool StringHasOnlySpaces(string s)
      {
         if (s == "")
         {
            return true;
         }

         for (int i = 0; i < s.Length; i++)
         {
            if (s[i] != ' ')
            {
               return false;
            }
         }
         return true;
      }
   }
}
