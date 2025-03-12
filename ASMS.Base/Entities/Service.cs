﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMS.Base.Entities
{
    public class Service
    {
        public int Id { get; set; }  
        public string Name { get; set; }  
        public string Description { get; set; }  
        public decimal Price { get; set; }      
        public TimeSpan Duration { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();  
    }
}
