using _7gyak_mbc69o.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7gyak_mbc69o.Entities
{
    class Present : Toy
    {
        public SolidBrush Boxcolor { get; private set; }
        public SolidBrush Ribboncolor { get; private set; }
        public Present(Color ribbon, Color box)
        {
            Boxcolor = new SolidBrush(box);
            Ribboncolor = new SolidBrush(ribbon);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(Boxcolor, 0, 0, Width, Height);
            g.FillRectangle(Ribboncolor, Width/2, 0, Width/5, Height);
            g.FillRectangle(Ribboncolor, 0, Height/2, Width, Height/5);
        }
    }
}
