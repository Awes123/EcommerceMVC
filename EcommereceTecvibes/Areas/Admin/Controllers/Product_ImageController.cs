using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EcommereceTecvibes.Models;

namespace EcommereceTecvibes.Areas.Admin
{
    public class Product_ImageController : Controller
    {
        private EcommerceEntities db = new EcommerceEntities();

        // GET: Admin/Product_Image
        [Authorize]
        public ActionResult Index()
        {
            var product_Image = db.Product_Image.Include(p => p.Product);
            return View(product_Image.ToList());
        }

        public ActionResult ShowPhoto(byte[] bytes)
        {
            byte[] result = bytes;
            return File(result, "image/png");
        }
        // GET: Admin/Product_Image/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Image product_Image = db.Product_Image.Find(id);
            if (product_Image == null)
            {
                return HttpNotFound();
            }
            return View(product_Image);
        }

        // GET: Admin/Product_Image/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "Product_Name");
            return View();
        }

        // POST: Admin/Product_Image/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create(Product_Image product_Image)
        {
            if (ModelState.IsValid)
            {
                Product_Image pi = new Product_Image();
                pi.Product_ID = product_Image.Product_ID;
                var files = Request.Files;
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFileBase file = Request.Files[i];
                    int fileSize = file.ContentLength;
                    string fileName = file.FileName;
                    string mimeType = file.ContentType;
                    System.IO.Stream fileContent = file.InputStream;
                    byte[] bytes;
                    using (BinaryReader br = new BinaryReader(fileContent))
                    {
                        bytes = br.ReadBytes(fileSize);
                    }
                    pi.Image = Path.GetFileName(fileName);
                    pi.ContentType = mimeType;
                    pi.Data = bytes;
                    pi.Date_Created = DateTime.Now;
                    db.Product_Image.Add(pi);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "Product_Name", product_Image.Product_ID);
            return View(product_Image);
        }

        // GET: Admin/Product_Image/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Image product_Image = db.Product_Image.Find(id);
            if (product_Image == null)
            {
                return HttpNotFound();
            }
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "Product_Name", product_Image.Product_ID);
            return View(product_Image);
        }

        // POST: Admin/Product_Image/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "PrdImg_ID,Product_ID,Image,ContentType,Data,Date_Created")] Product_Image product_Image)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_Image).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "Product_Name", product_Image.Product_ID);
            return View(product_Image);
        }

        // GET: Admin/Product_Image/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Image product_Image = db.Product_Image.Find(id);
            if (product_Image == null)
            {
                return HttpNotFound();
            }
            return View(product_Image);
        }

        // POST: Admin/Product_Image/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product_Image product_Image = db.Product_Image.Find(id);
            db.Product_Image.Remove(product_Image);
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
