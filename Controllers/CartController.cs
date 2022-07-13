using OnlineShoppingDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingDemo2.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart

        private DataContext db = new DataContext();
        private List<CartItem> items = new List<CartItem>();

        public RedirectToRouteResult Add(Product product)
        {
            CartItem item = items.Where(p => p.Product.Id == product.Id).FirstOrDefault();

            if (item == null)
            {
                items.Add(new CartItem { Product = product});
            }

            return RedirectToAction("Index");
           
        }


        public ActionResult Index()
        {
            return View(db.CartItems.ToList());
        }

      

    }
}