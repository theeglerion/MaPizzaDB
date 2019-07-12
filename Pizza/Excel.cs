using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Pizza
{
    public class ExcelDB
    {
        public ExcelDB()
        {
            //Empty
        }

        public void Schrieben (string[] array, List<double> list)
        {
            if (array.Count() > 0)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
                    excelapp.Visible = false;

                    string fileName = @"C:\pizza\Bestellung.xlsx";

                    Workbook workbook;
                    workbook = excelapp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

                    Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
                    worksheet.Name = "Positionen";

                    int i = 0;

                    foreach(double d in list)
                    //for (int i = 0; i < array.Count(); i++)
                    {
                        //Range range = worksheet.get_Range("B" + i.ToString() + ":B2");
                        //range.Value = array[i];
                        worksheet.Cells[2 + i, 2].value = array[i];
                        worksheet.Cells[2 + i, 3].value = d;
                        i++;
                    }

                    workbook.SaveAs(fileName);

                    excelapp.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("EXCLE SCHREIBEN: "+ex.Message);
                }
            }
        }
    }
}
