﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierProject3157.Areas.Admin.AdminVMClasses
{
    public class ProductVM
    {
        public List<Product> Products { get; set; }

        public Product Product { get; set; }
        public List<Category> Categories { get; set; }




    }
}