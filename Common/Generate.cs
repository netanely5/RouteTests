﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Generate
    {
        public static int GenerateA5DigitsNumber()
        {
            Random rnd = new Random();
            int n= rnd.Next(10000, 99999);
            return n;
        }
    }
}
