﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace t2008m_WAD.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}