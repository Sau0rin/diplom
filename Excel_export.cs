using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Excel_export
    {
        public void export (string name)
        {
            switch (name)
            {
                case "Подразделение":
                    string podrazdelenie = @"Select  Подразделение,Инвентарный_номер,Название,Балансовая_стоимость,Группа_износа,Сумма_износа title from oborudovanie inner join otdel on Подразделение = Название_отдела";
                    DB podrazdelenie_conn = new DB();

                    MySqlCommand podrazdelenie_comand = new MySqlCommand(podrazdelenie, podrazdelenie_conn.getConnection()); podrazdelenie_conn.openConnection();
                    DbDataReader podrazdelenie_read = podrazdelenie_comand.ExecuteReader();
                    Microsoft.Office.Interop.Excel.Application podrazdelenie_ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook podrazdelenie_ExcelWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet podrazdelenie_ExcelWorkSheet;
                    //Книга.
                    podrazdelenie_ExcelWorkBook = podrazdelenie_ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                    //Таблица.
                    podrazdelenie_ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)podrazdelenie_ExcelWorkBook.Worksheets.get_Item(1);
                    double qq = 0, qqq = 0;
                    int i = 1;
                    podrazdelenie_ExcelApp.Cells[1] = "Подразделение";
                    podrazdelenie_ExcelApp.Cells[2] = "Инвентарный_номер";
                    podrazdelenie_ExcelApp.Cells[3] = "Название";
                    podrazdelenie_ExcelApp.Cells[4] = "Балансовая_стоимость";
                    podrazdelenie_ExcelApp.Cells[5] = "Группа_износа";
                    podrazdelenie_ExcelApp.Cells[6] = "Сумма_износа";
                    string _cacheVal = "";
                    while (podrazdelenie_read.Read())
                    {
                        if (_cacheVal != podrazdelenie_read[0].ToString())
                        {
                            if (!String.IsNullOrWhiteSpace(_cacheVal))
                            {
                                podrazdelenie_ExcelApp.Cells[i + 2, 4] = "Итоговая сумма";
                                podrazdelenie_ExcelApp.Cells[i + 2, 6] = "Итоговая сумма";
                                podrazdelenie_ExcelApp.Cells[i + 3, 4] = qq;
                                podrazdelenie_ExcelApp.Cells[i + 3, 6] = qqq;
                                qq = 0; qqq = 0;
                                i += 4;
                            }

                            podrazdelenie_ExcelApp.Cells[i + 1, 1] = podrazdelenie_read[0];
                            _cacheVal = podrazdelenie_read[0].ToString();
                        }


                        podrazdelenie_ExcelApp.Cells[i + 1, 2] = podrazdelenie_read[1];
                        podrazdelenie_ExcelApp.Cells[i + 1, 3] = podrazdelenie_read[2];
                        podrazdelenie_ExcelApp.Cells[i + 1, 4] = podrazdelenie_read[3];
                        podrazdelenie_ExcelApp.Cells[i + 1, 5] = podrazdelenie_read[4];
                        podrazdelenie_ExcelApp.Cells[i + 1, 6] = Double.Parse(podrazdelenie_read[5].ToString());
                        qq += Convert.ToDouble(podrazdelenie_read[3]);
                        qqq += Convert.ToDouble(podrazdelenie_read[5]);
                        i++;
                    }
                    podrazdelenie_ExcelApp.Cells[i + 2, 4] = "Итоговая сумма";
                    podrazdelenie_ExcelApp.Cells[i + 2, 6] = "Итоговая сумма";
                    podrazdelenie_ExcelApp.Cells[i + 3, 4] = qq;
                    podrazdelenie_ExcelApp.Cells[i + 3, 6] = qqq;

                    //Вызываем нашу созданную эксельку.
                    podrazdelenie_ExcelApp.Columns.EntireColumn.AutoFit();
                    podrazdelenie_ExcelApp.Visible = true;
                    podrazdelenie_ExcelApp.UserControl = true;
                    podrazdelenie_ExcelApp.Quit();
                    Marshal.ReleaseComObject(podrazdelenie_ExcelWorkBook);
                    Marshal.ReleaseComObject(podrazdelenie_ExcelWorkSheet);
                    Marshal.ReleaseComObject(podrazdelenie_ExcelApp);
                    podrazdelenie_conn.closeConnection();
                    break;

                case "Группа износа":
                    string gruppa_iznosa = @"Select Группа_износа,Название,Балансовая_стоимость,Сумма_износа title from oborudovanie inner join iznos on Группа_износа = Название_группы ";

                    DB gruppa_iznosa_conn = new DB();

                    MySqlCommand gruppa_iznosa_comand = new MySqlCommand(gruppa_iznosa, gruppa_iznosa_conn.getConnection()); gruppa_iznosa_conn.openConnection();
                    DbDataReader gruppa_iznosa_read = gruppa_iznosa_comand.ExecuteReader();

                    Microsoft.Office.Interop.Excel.Application gruppa_iznosa_ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook gruppa_iznosa_ExcelWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet gruppa_iznosa_ExcelWorkSheet;
                    //Книга.
                    gruppa_iznosa_ExcelWorkBook = gruppa_iznosa_ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                    //Таблица.
                    gruppa_iznosa_ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)gruppa_iznosa_ExcelWorkBook.Worksheets.get_Item(1);
                    double ee = 0, eee = 0;
                    int j = 1;
                    gruppa_iznosa_ExcelApp.Cells[1] = "Группа_износа";
                    gruppa_iznosa_ExcelApp.Cells[2] = "Название";
                    gruppa_iznosa_ExcelApp.Cells[3] = "Балансовая_стоимость";
                    gruppa_iznosa_ExcelApp.Cells[4] = "Сумма_износа";
                    _cacheVal = "";
                    while (gruppa_iznosa_read.Read())
                    {
                        if (_cacheVal != gruppa_iznosa_read[0].ToString())
                        {
                            if (!String.IsNullOrWhiteSpace(_cacheVal))
                            {
                                gruppa_iznosa_ExcelApp.Cells[j + 2, 3] = "Итоговая сумма";
                                gruppa_iznosa_ExcelApp.Cells[j + 2, 4] = "Итоговая сумма";
                                gruppa_iznosa_ExcelApp.Cells[j + 3, 3] = ee;
                                gruppa_iznosa_ExcelApp.Cells[j + 3, 4] = eee;
                                ee = 0; eee = 0;
                                j += 4;
                            }

                            gruppa_iznosa_ExcelApp.Cells[j + 1, 1] = gruppa_iznosa_read[0];
                            _cacheVal = gruppa_iznosa_read[0].ToString();
                        }

                        gruppa_iznosa_ExcelApp.Cells[j + 1, 2] = gruppa_iznosa_read[1];
                        gruppa_iznosa_ExcelApp.Cells[j + 1, 3] = gruppa_iznosa_read[2];
                        gruppa_iznosa_ExcelApp.Cells[j + 1, 4] = Double.Parse(gruppa_iznosa_read[3].ToString());
                        ee += Convert.ToDouble(gruppa_iznosa_read[2]);
                        eee += Convert.ToDouble(gruppa_iznosa_read[3]);
                        j++;
                    }
                    gruppa_iznosa_ExcelApp.Columns.EntireColumn.AutoFit();
                    gruppa_iznosa_ExcelApp.Visible = true;
                    gruppa_iznosa_ExcelApp.UserControl = true;
                    gruppa_iznosa_conn.closeConnection();
                    break;

                case "Ответственные лица":
                    string otvetstvennoe_face = @"Select Фамилия,Имя,Отчество,Название,Балансовая_стоимость,Сумма_износа title from otvetstvenai inner join oborudovanie on Табельный_номер = Ответственный ";

                    DB otvetstvennoe_face_conn = new DB();

                    MySqlCommand otvetstvennoe_face_comand = new MySqlCommand(otvetstvennoe_face, otvetstvennoe_face_conn.getConnection()); otvetstvennoe_face_conn.openConnection();
                    DbDataReader otvetstvennoe_face_read = otvetstvennoe_face_comand.ExecuteReader();

                    Microsoft.Office.Interop.Excel.Application otvetstvennoe_face_ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook otvetstvennoe_face_ExcelWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet otvetstvennoe_face_ExcelWorkSheet;
                    //Книга.
                    otvetstvennoe_face_ExcelWorkBook = otvetstvennoe_face_ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                    //Таблица.
                    otvetstvennoe_face_ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)otvetstvennoe_face_ExcelWorkBook.Worksheets.get_Item(1);
                    double rrr = 0, rr = 0;
                    int k = 1;
                    while (otvetstvennoe_face_read.Read())
                    {
                        otvetstvennoe_face_ExcelApp.Cells[1] = "Фамилия";
                        otvetstvennoe_face_ExcelApp.Cells[2] = "Имя";
                        otvetstvennoe_face_ExcelApp.Cells[3] = "Отчество";
                        otvetstvennoe_face_ExcelApp.Cells[4] = "Название";
                        otvetstvennoe_face_ExcelApp.Cells[5] = "Балансовая_стоимость";
                        otvetstvennoe_face_ExcelApp.Cells[6] = "Сумма_износа ";
                        otvetstvennoe_face_ExcelApp.Cells[k + 2, 4] = "Сумма балансовой стоимости";
                        otvetstvennoe_face_ExcelApp.Cells[k + 2, 6] = "Сумма сумм износа";
                        otvetstvennoe_face_ExcelApp.Cells[k + 1, 1] = otvetstvennoe_face_read[0];
                        otvetstvennoe_face_ExcelApp.Cells[k + 1, 2] = otvetstvennoe_face_read[1];
                        otvetstvennoe_face_ExcelApp.Cells[k + 1, 3] = otvetstvennoe_face_read[2];
                        otvetstvennoe_face_ExcelApp.Cells[k + 1, 4] = otvetstvennoe_face_read[3];
                        otvetstvennoe_face_ExcelApp.Cells[k + 1, 5] = otvetstvennoe_face_read[4];
                        otvetstvennoe_face_ExcelApp.Cells[k + 1, 6] = otvetstvennoe_face_read[5];
                        rrr += Convert.ToDouble(otvetstvennoe_face_read[4]);
                        rr += Convert.ToDouble(otvetstvennoe_face_read[5]);
                        k++;
                    }
                    otvetstvennoe_face_ExcelApp.Cells[k + 2, 5] = rrr;
                    otvetstvennoe_face_ExcelApp.Cells[k + 2, 6] = rr;
                    otvetstvennoe_face_ExcelApp.Columns.EntireColumn.AutoFit();
                    otvetstvennoe_face_ExcelApp.Visible = true;
                    otvetstvennoe_face_ExcelApp.UserControl = true;
                    otvetstvennoe_face_conn.closeConnection();
                    break;

                default:
                    MessageBox.Show("Нельзя сформировать");
                    break;
            }
        }
    }
}
