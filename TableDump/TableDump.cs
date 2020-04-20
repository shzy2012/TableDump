using Newtonsoft.Json.Linq;

using System;
using System.IO;
using System.Text;

/// <summary>
/// 建议把下面的namespace名字改为您的插件名字
/// </summary>
namespace TableDump
{
    /// <summary>
    /// 定义一个插件函数时，必须先在这个interface里面声明
    /// </summary>
    public interface ITableDumpPlugin
    {
        bool Dump(JArray array);
    }

    /// <summary>
    /// 实现插件
    /// </summary>
    public class TableDumpPlugin : ITableDumpPlugin
    {
        private Easylog.Log log = null;

        public TableDumpPlugin()
        {
            log = new Easylog.Log();
        }

        public bool Dump(JArray array)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();

                if (array.Type == JTokenType.Array)
                {
                    foreach (var row in array)
                    {
                        //单行的情况
                        if (((Newtonsoft.Json.Linq.JContainer)row).Count == 1)
                        {
                            string r = row[0].ToString().Replace("\r", ",").Replace("\n\n", ",").Replace("\r\n", ",").Trim();
                            if (!string.IsNullOrWhiteSpace(r))
                            {
                                stringBuilder.AppendLine(r);
                            }
                        }
                        else
                        {
                            //多行的情况
                            stringBuilder.AppendLine(string.Join(",", row));
                        }
                    }
                }
                return Save(stringBuilder);
            }
            catch (Exception ex)
            {
                log.Error("Save", ex);
                return false;
            }
        }


        /// <summary>
        /// 保存 workbook
        /// </summary>
        /// <param name="workbook"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool Save(StringBuilder csvData)
        {
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "auto-save" + DateTime.Now.ToString("yyyyMMdd") + "-r" + new Random().Next(10, 99).ToString() + ".csv");
                //创建目录
                string dir = Path.GetDirectoryName(path);
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                File.WriteAllText(path, csvData.ToString());
                return true;
            }
            catch (Exception ex)
            {
                log.Error("Save", ex);
                return false;
            }
        }
    }
}
