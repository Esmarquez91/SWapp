using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExcelDataReader;
using System.Data;
using System.Windows.Forms;

namespace SWapp.Clases
{
    public class Files
    {
        public static string ArchivoXLSX, ArchivoCSV, ArchivoFinal, csvData, AccesoBD;
        public static DataTable dt = new DataTable();
        public static DataTable ss = new DataTable();
        public static DataTable dtcliente = new DataTable();
        public static void ObtenerDirecciones()
        {

            try
            {
                string[] Direcciones = File.ReadAllLines("C:\\SWprogram\\direcciones.txt");
                ArchivoXLSX = Direcciones[0];
                ArchivoCSV = Direcciones[1];
                ArchivoFinal = Direcciones[2];
                AccesoBD = Direcciones[3];
            }
            catch
            {
                //falta el archivo de las direcciones
            }
        }

        public static void ConvertirXLSXtoCSV()
        {
            try
            {
                csvData = "";
                FileStream stream = File.Open(ArchivoXLSX, FileMode.Open, FileAccess.Read);
                IExcelDataReader excelReaderXlsx = ExcelReaderFactory.CreateOpenXmlReader(stream);
                int row = 0;
                while (excelReaderXlsx.Read())
                {
                    if (row >= 0)
                    {
                        var obj0 = excelReaderXlsx.GetValue(0);
                        var obj1 = excelReaderXlsx.GetValue(1);
                        var obj2 = excelReaderXlsx.GetValue(2);
                        var obj3 = excelReaderXlsx.GetValue(3);
                        var obj4 = excelReaderXlsx.GetValue(4);
                        //SE AÑADEN LAS COLUMNAS OLO Y PROTECTION TYPE
                        var obj10 = excelReaderXlsx.GetValue(5);
                        var obj11 = excelReaderXlsx.GetValue(6);
                        //CircuitCAtegory
                        var obj20 = excelReaderXlsx.GetValue(9);
                        //Se reemplazan las posibles comas por puntos. Con el fin de evitar errores al realizar la conversión.
                        string obj5 = string.Format("\"{0}\"", obj0).Replace(',', '.');
                        string obj6 = string.Format("\"{0}\"", obj1).Replace(',', '.');
                        string obj7 = string.Format("\"{0}\"", obj2).Replace(',', '.');
                        string obj8 = string.Format("\"{0}\"", obj3).Replace(',', '.');
                        string obj9 = string.Format("\"{0}\"", obj4).Replace(',', '.');
                        //OLO Y PROTECT
                        string obj12 = string.Format("\"{0}\"", obj10).Replace(',', '.');
                        string obj13 = string.Format("\"{0}\"", obj11).Replace(',', '.');
                        //Circuit Category
                        string obj21 = string.Format("\"{0}\"", obj20).Replace(',', '.');
                        csvData = csvData + obj5 + "," + obj6 + "," + obj7 + "," + obj8 + "," + obj9 + "," + obj12 + "," + obj13 + "," + obj21;
                        csvData += "\n";
                        row++;
                    }
                }

                excelReaderXlsx.Close();

                if (File.Exists(ArchivoXLSX))
                {
                    File.Delete(ArchivoXLSX);
                }

                string output = ArchivoCSV;
                StreamWriter csv = new StreamWriter(output, false);
                csv.Write(csvData);
                csv.Close();
            }
            catch
            {
            }
        }

        public static void BindDataCSV(string filePath)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                if (lines.Length >= 0)
                {
                    string firstLine = lines[0 + 1];
                    string[] headerLabels = firstLine.Split(',');

                    foreach (string headerWord in headerLabels)
                    {
                        try
                        {

                            dt.Columns.Add(new DataColumn(headerWord.TrimEnd('"').TrimStart('"')));
                        }
                        catch
                        {
                            //no se vuelve a llenar la tabla :)
                        }

                    }

                    for (int r = 1 + 1; r < lines.Length; r++)
                    {
                        string[] dataWords = lines[r].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;

                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord.TrimEnd('"').TrimStart('"')] = dataWords[columnIndex++].TrimEnd('"').TrimStart('"');
                        }
                        dt.Rows.Add(dr);
                    }

                    dtcliente = dt;
                    DataView vista = new DataView(dt);
                    //dt = vista.ToTable(true, "Supplier ID", "CRM Number", "CRM Name", "CRT", "OLO Name", "Protection Type C", "Circuit Category");
                    dt = vista.ToTable(true, "Supplier ID", "CRM Number", "CRM Name", "CRT", "IP Service Identifier", "Protection Type C", "Circuit Category");
                }

            }
            catch (System.Exception er1)
            {
            }

        }

        public static void BindDataCSV2(string filePath)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                if (lines.Length >= 0)
                {
                    string firstLine = lines[0 + 1];
                    string[] headerLabels = firstLine.Split(',');
                    foreach (string headerWord in headerLabels)
                    {
                        try
                        {
                            dt.Columns.Add(new DataColumn(headerWord.TrimEnd('"').TrimStart('"')));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                    }
                    for (int r = 1 + 1; r < lines.Length; r++)
                    {
                        string[] dataWords = lines[r].Split(',');
                        DataRow dr = dt.NewRow();
                        int columnIndex = 0;

                        foreach (string headerWord in headerLabels)
                        {
                            dr[headerWord.TrimEnd('"').TrimStart('"')] = dataWords[columnIndex++].TrimEnd('"').TrimStart('"');
                        }
                        dt.Rows.Add(dr);
                    }

                    DataView vista = new DataView(dt);
                    dt = vista.ToTable(true, "CRM Number", "CRM Name", "CRT", "IP Service Identifier", "Protection Type C", "Circuit Category");
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        

        public static void ImportarArchivoCSV()
        {
            try
            {
                string FilePath = ArchivoCSV;
                BindDataCSV(FilePath);
                dtcliente.Columns.RemoveAt(0);
            }
            catch
            {
                //No hay direcciones del archivo output.
            }
        }
        public static DataTable ImportarArchivoCSV2()
        {
            string FilePath = ArchivoCSV;
            BindDataCSV(FilePath);
            return dt;
        }

        

        public static void DeleteArchives()
        {
            try
            {
                if (File.Exists(ArchivoCSV))
                {
                    File.Delete(ArchivoCSV);
                }
            }
            catch (System.Exception t)
            {
                MessageBox.Show(t.Message);
            }
        }

        public static void EnviarArchivoFinal(string txtfilepath)
        {
            try
            {
                ss = new DataTable();
                ss.Columns.Add("Rownum");
                ss.Columns.Add("Action");
                ss.Columns.Add("Entity");
                ss.Columns.Add("PlannedWorkId");
                ss.Columns.Add("CircuitId");
                int filas = dt.Rows.Count;
                for (int k = 0; k < filas; k++)
                {
                    DataRow row = ss.NewRow();
                    row["Rownum"] = (k + 1).ToString();
                    row["Action"] = "ADD";
                    row["Entity"] = "AddPwObject";
                    row["PlannedWorkId"] = txtfilepath; //aqui va el tp SW
                    row["CircuitId"] = dt.Rows[k][3].ToString();
                    ss.Rows.Add(row);
                }
            }
            catch
            {
                //Error al enviar el archivo final, direcciones.
            }

        }


        public static string StripHTML(string source)
        {
            try
            {
                string result;
                result = source.Replace("\r", " ");
                result = result.Replace("\n", " ");
                result = result.Replace("\t", string.Empty);

                result = System.Text.RegularExpressions.Regex.Replace(result,
                                                                      @"( )+", " ");

                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*head([^>])*>", "<head>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"(<( )*(/)( )*head( )*>)", "</head>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(<head>).*(</head>)", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*script([^>])*>", "<script>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"(<( )*(/)( )*script( )*>)", "</script>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"(<script>).*(</script>)", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*style([^>])*>", "<style>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"(<( )*(/)( )*style( )*>)", "</style>",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(<style>).*(</style>)", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*td([^>])*>", "\t",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*br( )*>", "\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*li( )*>", "\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*div([^>])*>", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*tr([^>])*>", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<( )*p([^>])*>", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"<[^>]*>", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @" ", " ",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);

                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&bull;", " * ",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&lsaquo;", "<",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&rsaquo;", ">",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&trade;", "(tm)",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&frasl;", "/",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&lt;", "<",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&gt;", ">",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&copy;", "(c)",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&reg;", "(r)",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                // http://hotwired.lycos.com/webmonkey/reference/special_characters/
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         @"&(.{2,6});", string.Empty,
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = result.Replace("\n", "\r");

                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\r)( )+(\r)", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\t)( )+(\t)", "\t\t",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\t)( )+(\r)", "\t\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\r)( )+(\t)", "\r\t",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\r)(\t)+(\r)", "\r\r",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                result = System.Text.RegularExpressions.Regex.Replace(result,
                         "(\r)(\t)+", "\r\t",
                         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                string breaks = "\r\r\r";
                string tabs = "\t\t\t\t\t";
                for (int index = 0; index < result.Length; index++)
                {
                    result = result.Replace(breaks, "\r\r");
                    result = result.Replace(tabs, "\t\t\t\t");
                    breaks = breaks + "\r";
                    tabs = tabs + "\t";
                }
                return result;
            }
            catch
            {
                MessageBox.Show("Error");
                return source;
            }
        }


        public static string GetClientFullName(string ClienteShortName)
        {
            string Result = "Cliente";
            DataTable DTFullName = new DataTable();
            DTFullName.Columns.Add("ClienteFullName");
            DTFullName.Columns.Add("ClienteShortName");
            if(File.Exists("C:\\SWprogram\\Clientes.txt"))
            {
                string[] NombresCliente = File.ReadAllLines("C:\\SWprogram\\Clientes.txt", Encoding.Default);
                //string[] NombresCliente = File.ReadAllLines(SWapp.Properties.Resources.Clientes);
                foreach (string line in NombresCliente)
                {
                    DataRow filaNombreCliente = DTFullName.NewRow();
                    filaNombreCliente["ClienteFullName"] = line.Split(';')[0];
                    filaNombreCliente["ClienteShortName"] = line.Split(';')[1];
                    DTFullName.Rows.Add(filaNombreCliente);
                }

                if (DTFullName.Select("ClienteShortName = '" + ClienteShortName + "'", "ClienteFullName").Count() > 0)
                {
                    Result = DTFullName.Select("ClienteShortName = '" + ClienteShortName + "'", "ClienteFullName")[0][0].ToString();
                }
                else
                {
                    Result = "Cliente No encontrado";
                }
            }
            return Result;
        }

    }
}
