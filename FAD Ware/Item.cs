using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FAD_Ware
{
    class Item
    {
        public string Name;
        public string Value;
        public Item(string name, string value)
        {
            Name = name; Value = value;
        }
        public override string ToString()
        {
            // Generates the text shown in the combo box
            return Name;
        }
    }
}
