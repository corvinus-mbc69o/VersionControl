using _7gyak_mbc69o.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7gyak_mbc69o.Abstractions
{
    public class CarFactory: IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}
