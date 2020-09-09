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
      /// <returns>Number of affected rows</returns>
      public int DeleteEmptyRaws(string filePath, int encoding)
      {
         if (File.Exists(filePath))
         {
            int counter = 0;
            StringBuilder content = new StringBuilder();
            string source = File.ReadAllText(filePath, Encoding.GetEncoding(encoding));
            string[] ar = source.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
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

            File.WriteAllText(filePath, content.ToString(), Encoding.GetEncoding(encoding));
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
