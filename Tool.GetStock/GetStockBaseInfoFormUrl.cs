using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Common;

namespace Tool.GetStock
{
    public class GetStockBaseInfoFormUrl : IGetStock
    {
        private static Random random = new Random();
        private const string logfilepath = @"D:\log.txt";
        private static List<string> useragent = new List<string>()
        {
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.163 Safari/535.1",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:6.0) Gecko/20100101 Firefox/6.0",
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/534.50 (KHTML, like Gecko) Version/5.1 Safari/534.50",
            "Opera/9.80 (Windows NT 6.1; U; zh-cn) Presto/2.9.168 Version/11.50",
            "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Win64; x64; Trident/5.0; .NET CLR 2.0.50727; SLCC2; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0; InfoPath.3; .NET4.0C; Tablet PC 2.0; .NET4.0E)",
            "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/13.0.782.41 Safari/535.1 QQBrowser/6.9.11079.201"
        };
        private static void DownloadFile(Enums.StockType stype, string downFilePath)
        {
            System.IO.Stream st = null;
            System.IO.Stream so = null;
            try
            {
                string url = stype == Enums.StockType.SH ? Urls.SH_ALL_URL : Urls.SZ_ALL_URL;
                var fileinfo = new FileInfo(downFilePath);
                if (!fileinfo.Directory.Exists) { Directory.CreateDirectory(fileinfo.Directory.FullName); }
                System.Net.HttpWebRequest myrq = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                myrq.UserAgent = useragent[random.Next(5)];
                if (stype == Enums.StockType.SH)
                {
                    myrq.Referer = "http://www.sse.com.cn/assortment/stock/list/share/";
                    myrq.Host = "query.sse.com.cn";
                }
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)myrq.GetResponse();
                if (myrp.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    long totalBytes = myrp.ContentLength;
                    st = myrp.GetResponseStream();
                    so = new System.IO.FileStream(downFilePath, System.IO.FileMode.Create);
                    long totalDownloadedByte = 0;
                    byte[] by = new byte[1024];
                    int osize = st.Read(by, 0, (int)by.Length);
                    while (osize > 0)
                    {
                        totalDownloadedByte = osize + totalDownloadedByte;
                        so.Write(by, 0, osize);
                        osize = st.Read(by, 0, (int)by.Length);
                    }
                    so.Close();
                    st.Close();
                }
            }
            catch (Exception exc)
            {
                File.AppendAllText(logfilepath, exc.ToString());
            }
            finally
            {
                if (st != null)
                {
                    st.Close();
                    st.Dispose();
                }
            }
        }

        public DataSet ExcelToDS(string path)
        {
            string[] sheetNames = GetExcelSheetNames(path);
            if (null == sheetNames || sheetNames.Length == 0) return null;

            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + path + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            strExcel = string.Format("select * from {0}", sheetNames[0]);
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "stocks");
            return ds;
        }

        private String[] GetExcelSheetNames(string excelFile)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;

            try
            {
                // Connection String. Change the excel file to the file you
                // will search.
                string connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'", excelFile);
                // Create connection object by using the preceding connection string.
                objConn = new OleDbConnection(connString);
                // Open connection with the database.
                objConn.Open();
                // Get the data table containg the schema guid.
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt == null)
                {
                    return null;
                }

                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;

                // Add the sheet name to the string array.
                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString();
                    i++;
                }

                // Loop through all of the sheets if you want too...
                for (int j = 0; j < excelSheets.Length; j++)
                {
                    // Query each excel sheet.
                }

                return excelSheets;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // Clean up.
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }

        public DataSet GetStock(Enums.StockType stype)
        {
            string downFilePath = Path.Combine(Tool.Common.Common.BASE_PATH, "tmp", "stockinfo.xlsx");
            DownloadFile(stype, downFilePath);
            DataSet result = ExcelToDS(downFilePath);
            return result;
        }
    }
}
