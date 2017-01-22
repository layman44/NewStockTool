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


        public DataTable GetStock(Enums.StockType stype)
        {
            string downFilePath = "";
            if (stype == Enums.StockType.SH)
            {
                downFilePath = Path.Combine(Tool.Common.Common.BASE_PATH, "tmp", "SH", "stockinfo.txt");
                DownloadFile(stype, downFilePath);
                if (File.Exists(downFilePath))
                {
                    DataTable result = new GetSHStock().GetStock(downFilePath, true);
                    return result;
                }
                return null;

            }
            else
            {
                downFilePath = Path.Combine(Tool.Common.Common.BASE_PATH, "tmp", "SZ", "stockinfo.xlsx");
                DownloadFile(stype, downFilePath);
                string[] sheetNames = ExcelHelper.GetSheetNames(downFilePath);
                if (sheetNames.Length > 0)
                {
                    DataTable result = ExcelHelper.ExcelToDataTable(downFilePath, sheetNames[0], true);
                    return result;
                }
            }

            return null;

        }
    }
}
