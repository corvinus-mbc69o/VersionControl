﻿using _7gyak_mbc69o.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7gyak_mbc69o.Entities
{
    public class BallFactory: IToyFactory
    {
        public Toy CreateNew()
        {
            return new Ball();
        }        
    }
}
