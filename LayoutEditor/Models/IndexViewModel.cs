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
            if (AllElements != null)
            {
                if (AllElements.AllBaseCsses != null)
                {
                    foreach (BaseCss baseCss in AllElements.AllBaseCsses)
                    {
                        baseCss.Initial(rootPath.Substring(0, rootPath.LastIndexOf("\\")));
                    }
                }
                if (AllElements.AllForms != null)
                {
                    foreach (Forms forms in AllElements.AllForms)
                    {
                        forms.Initial(rootPath.Substring(0, rootPath.LastIndexOf("\\")));
                    }
                }
                if (AllElements.AllComponents != null)
                {
                    foreach (Component component in AllElements.AllComponents)
                    {
                        component.Initial(rootPath.Substring(0, rootPath.LastIndexOf("\\")));
                    }
                }
            }
        }
    }
}