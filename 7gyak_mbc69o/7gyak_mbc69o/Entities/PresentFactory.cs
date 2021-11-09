using _7gyak_mbc69o.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7gyak_mbc69o.Entities
{
    public class PresentFactory: IToyFactory
    {
        public Color Boxcolor { get; set; }
        public Color Ribboncolor { get; set; }

        public Toy CreateNew()
        {
            return new Present(Boxcolor, Ribboncolor);
            
        }
    }
}
