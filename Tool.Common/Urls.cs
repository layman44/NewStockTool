using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.Common
{
    public static class Urls
    {
        public const string SH_ALL_URL = "http://query.sse.com.cn/security/stock/downloadStockListFile.do?csrcCode=&stockCode=&areaName=&stockType=1";
        public const string SZ_ALL_URL = "http://www.szse.cn/szseWeb/ShowReport.szse?SHOWTYPE=xlsx&CATALOGID=1110&tab1PAGENUM=1&ENCODE=1&TABKEY=tab1";
        public const string SHAREHOLDER_NUM_URL = "https://xueqiu.com/stock/f10/shareholdernum.json?symbol=SZ000993&page=1&size=1000";//股东人数.
    }
}
