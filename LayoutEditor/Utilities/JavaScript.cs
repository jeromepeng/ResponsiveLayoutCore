using System;
using System.IO;
using System.Text;
using LayoutEditor.Common;

namespace LayoutEditor.Utilities
{
    public class JavaScript : BaseUtility
    {      
        override public void Initial(string htmlPath)
        {
            htmlContentPath = htmlPath + "//Views//Elements//JAVASCRIPT//" + Name + "//";
        }
    }
}