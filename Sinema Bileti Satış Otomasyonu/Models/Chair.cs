﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Bileti.Models
{
    public class Chair
    {
        public Chair(string _row, string _number)
        {
            row = _row;
            number = _number;
        }
        public string row { get; set; }
        public string number { get; set; }
        public bool status { get; set; } // dolu mu boş mu
    }
}
