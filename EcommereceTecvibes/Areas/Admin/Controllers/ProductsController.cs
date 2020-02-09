using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EcommereceTecvibes.Models;

namespace EcommereceTecvibes.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private EcommerceEntities db = new EcommerceEntities();

        // GET: Admin/Products
        [Authorize]
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category);
            return View(products.ToList());
        }

        // GET: Admin/Products/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Admin/Products/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.Category_ID = new SelectList(db.Categories, "Category_ID", "Category1");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                Product products = new Product();
                products.Category_ID = product.Category_ID;
                products.Product_Name = product.Product_Name;
                products.Quantity = product.Quantity;
                products.Unit = product.Unit;
                products.Sale = product.Sale;
                products.Price = product.Price;
                products.Discount = product.Discount;
                products.Final_Price = product.Final_Price;
                products.Status = product.Status;
                products.Description = product.Description;
                products.Date_Created = DateTime.Now;
                db.Products.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Category_ID = new SelectList(db.Categories, "Category_ID", "Category1", product.Category_ID);
            return View(product);
        }

        // GET: Admin/Products/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.Category_ID = new SelectList(db.Categories, "Category_ID", "Category1", product.Category_ID);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                Product products =db.Products.Find(product.Product_ID);
                if (products != null)
                {
                    products.Category_ID = product.Category_ID;
                    products.Product_Name = product.Product_Name;
                    products.Quantity = product.Quantity;
                    products.Unit = product.Unit;
                    products.Sale = product.Sale;
                    products.Price = product.Price;
                    products.Discount = product.Discount;
                    products.Final_Price = product.Final_Price;
                    products.Status = product.Status;
                    products.Description = product.Description;
                    products.Date_Modified = DateTime.Now;
                    db.Entry(products).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Category_ID = new SelectList(db.Categories, "Category_ID", "Category1", product.Category_ID);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Admin/Products/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
