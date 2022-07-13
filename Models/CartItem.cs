using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShoppingDemo2.Models
{
    public class CartItem
    {
        [Key]
       public int Id { get; set; }
        public Product Product { get; internal set; }
        public int Quantity { get; set; }
    }
}