using System;
using System.IO;
using System.Text;
using LayoutEditor.Common;

namespace LayoutEditor.Utilities
{
    public class BaseCss
    {
        private string htmlContentPath = string.Empty;
        private string configurationContent = string.Empty;
        private string viewContent = string.Empty;
        public string Preview { get; set; }

        public string Name {get; set;}

        public string ConfigurationContent
        {
            get
            {
                if (string.IsNullOrEmpty(configurationContent))
                {
                    using (FileStream fs = new FileStream(htmlContentPath + "Configuration.html", FileMode.Open))
                    {
                        fs.Seek(0,SeekOrigin.Begin);
                        byte[] buff = new byte[fs.Length];
                        int s = fs.Read(buff, 0, buff.Length);

                        if (s > 0)
                        {
                            configurationContent = Encoding.UTF8.GetString(buff);
                        }
                    }
                }
                return configurationContent;
            }
        }

        public string ViewContent
        {
            get
            {
                if (string.IsNullOrEmpty(viewContent))
                {
                    using (FileStream fs = new FileStream(htmlContentPath + "View.html", FileMode.Open))
                    {
                        fs.Seek(0,SeekOrigin.Begin);
                        byte[] buff = new byte[fs.Length];
                        int s = fs.Read(buff, 0, buff.Length);

                        if (s > 0)
                        {
                            viewContent = Encoding.UTF8.GetString(buff);
                        }
                    }
                }
                return viewContent;
            }
        }

        public void Initial(string htmlPath)
        {
            htmlContentPath = htmlPath + "//Views//Elements//BASECSS//" + Name + "//";
        }
    }
}