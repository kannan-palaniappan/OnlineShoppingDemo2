﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineShoppingDemo2.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<CartItem> CartItems { get; set; }





    }
}