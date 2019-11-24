using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace PdfGenerateService.utils
{
    public class Utils
    {
        public static Dictionary<string, string> getFieldValueDict(Object obj)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            Type type = obj.GetType();
            FieldInfo[] fieldInfos = type.GetFields();
            foreach (var f in fieldInfos)
            {
                string fieldName = f.Name;
                string fieldType = f.FieldType.ToString();
                string fieldValue = f.GetValue(obj).ToString();
                data.Add(fieldName, fieldValue);
            }

            return data;
        }
        /**
         * pdf中的key分三类，分别是 ap.xx , m, m.xx
         * 
         * 
         *  对象的key是 Name_fam,  pdf文件中的key是 ap.name giv
         */
        public static string toPdfKey(string dataKey, string prefix)
        {
            string result = prefix + dataKey.Replace("_", " ");

            Console.WriteLine("Utils-ToPdfKey {} => {}", dataKey, result);

            return result;
        }

        /*
         * 将pdf中的可以转化为数据库需要的可以
         * 
         */
        public static string toDataKey(string pdfKey)
        {
            string result = pdfKey.Replace(" ", "_")

            return result;
        }

    }
}
