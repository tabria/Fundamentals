using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace EXCELlentKnowledge
{
    class ExcelKnowledge
    {
        static void Main()
        {

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"E:\Programming\Education\Fundamentals\FilesAndExceptions\EXCELlentKnowledge\bin\Debug\sample_table.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            bool isEnd = false;
            for(int i=1; i<=rowCount; i++)
            {
                if (isEnd)
                {
                    break;
                }
                string text = string.Empty;
                for (int k=1; k<=colCount; k++)
                {
                    if(xlRange.Cells[i, k] != null && xlRange.Cells[i, k].Value2 != null)
                    {
                        text += xlRange.Cells[i, k].Value2.ToString() + "|";
                    }
                    else
                    {
                        isEnd = true;
                        break;
                    }
                }
                var separator = i == 1 ? string.Empty : Environment.NewLine;
                File.AppendAllText("output.txt", separator + text);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorksheet);
            xlWorkbook.Close();
            Marshal.ReleaseComObject(xlWorkbook);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);


        }
    }
}
