using System;
using LayoutEditor.Utilities;
using Newtonsoft.Json;

namespace LayoutEditor.Models
{
    public class IndexViewModel
    {
        public Elements AllElements { get; set; }

        public IndexViewModel(string data, string rootPath)
        {
            AllElements = JsonConvert.DeserializeObject<Elements>(data);
            foreach (BaseCss baseCss in AllElements.AllBaseCsses)
            {
                baseCss.Initial(rootPath.Substring(0, rootPath.LastIndexOf("\\")));
            }
        }
    }
}