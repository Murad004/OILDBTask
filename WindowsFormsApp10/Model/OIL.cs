﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10.Model
{
    public class OIL
    {
        public string Name { get; set; }

        public int Price { get; set; }


        public override string ToString()
        {
            return $"{Name} - {Price}";
        }

    }
}
