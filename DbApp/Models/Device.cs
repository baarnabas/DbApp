﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbApp.Models
{
    public class Device
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public User User { get; set; }
    }
}
