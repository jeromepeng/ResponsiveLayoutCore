using System;
using LayoutEditor.Common;

namespace LayoutEditor.Utilities
{
    public class Grid
    {
        public string Sizes { get; set; }

        public string[] Styles {get; set;}

        /*public Grid(int[] sizes, GridType gridType)
        {
            switch (gridType)
            {
                case GridType.Column:
                {
                    Styles = new string[sizes.Length];
                    for (int i = 0 ; i < sizes.Length ; i++)
                    {
                        Value += sizes[i] + " ";
                        Styles[i] = string.Format(MainStyle, sizes[i]);
                    }
                    Value = Value.Substring(0, Value.Length - 1);
                    break;
                }         
                case GridType.Row:
                {
                    break;                    
                }
                default:
                {
                    break;
                }       
            }
        }*/

    }
}