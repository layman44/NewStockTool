using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool.Common
{
   public static class JsonHelper
    {
        private static JsonSerializerSettings _jsonSettings;
        public static T FromJson<T>(this string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json, _jsonSettings);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
