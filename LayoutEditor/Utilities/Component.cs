using System;
using System.IO;
using System.Text;
using LayoutEditor.Common;

namespace LayoutEditor.Utilities
{
    public class Component : BaseUtility
    {      
        override public void Initial(string htmlPath)
        {
            htmlContentPath = htmlPath + "//Views//Elements//COMPONENTS//" + Name + "//";
        }
    }
}