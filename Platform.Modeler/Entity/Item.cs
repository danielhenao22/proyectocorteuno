using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platform.Modeler.Entity
{
    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Item(string name, int value)
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
