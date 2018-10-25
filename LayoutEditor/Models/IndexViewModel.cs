using System;
using LayoutEditor.Utilities;
using Newtonsoft.Json;

namespace LayoutEditor.Models
{
    public class IndexViewModel
    {
        public Elements AllElements { get; set; }

        public IndexViewModel(string data)
        {
            AllElements = JsonConvert.DeserializeObject<Elements>(data);
        }
    }
}