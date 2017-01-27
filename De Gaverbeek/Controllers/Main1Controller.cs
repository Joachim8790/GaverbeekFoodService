using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using De_Gaverbeek.Models;
using System.IO;
using Patagames.Pdf.Net;
using System.Collections;

namespace De_Gaverbeek.Controllers
{
    public class Main1Controller : Controller
    {
        private DeGaverbeekEntities db = new DeGaverbeekEntities();

        // GET: Main1
        public ActionResult Index()
        {
            return View(db.tblPosts.ToList());
        }
        // POST: Main1/Index
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        //public ActionResult IndexPost()
        //{
        //    tblPosts post = new tblPosts();
        //    if (ModelState.IsValid)
        //    {
               
        //        post.PostDatum = DateTime.Now;


        //        HttpPostedFileBase file = Request.Files["txtAfbeelding"];
        //        if (file.FileName.ToLower().EndsWith(".pptx"))
        //        {
        //            System.Diagnostics.Debug.WriteLine("pptx");
        //            //if (file != null && file.ContentLength > 0)
        //            //{

        //            //    MemoryStream target = new MemoryStream();
        //            //    file.InputStream.CopyTo(target);
        //            //    byte[] image = target.ToArray();
        //            //    tblPosts.PostImage = image;
        //            //    db.tblPosts.Add(tblPosts);
        //            //    db.SaveChanges();
        //            //    return RedirectToAction("Index");
        //            //}
        //            //else
        //            //{
        //            //    return View(tblPosts);
        //            //}
        //            // verder werkensdfgsdfgsdggsdf
        //        }
        //        else
        //        {
        //            if (file.FileName.ToLower().EndsWith(".pdf"))
        //            {
        //                System.Diagnostics.Debug.WriteLine("pdf");
        //                try
        //                {
        //                    MemoryStream target = new MemoryStream();
        //                    file.InputStream.CopyTo(target);
        //                    byte[] pdfbytes = target.ToArray();
        //                    var document = PdfDocument.Load(pdfbytes);
                            
                            
                            
        //                }
        //                catch()
        //                //if (file != null && file.ContentLength > 0)
        //                //{

        //                //    MemoryStream target = new MemoryStream();
        //                //    file.InputStream.CopyTo(target);
        //                //    byte[] image = target.ToArray();
        //                //    tblPosts.PostImage = image;
        //                //    db.tblPosts.Add(tblPosts);
        //                //    db.SaveChanges();
        //                //    return RedirectToAction("Index");
        //                //}
        //                //else
        //                //{
        //                //    return View(tblPosts);
        //                //}
        //            }
        //            else
        //            {
        //                if (file != null && file.ContentLength > 0)
        //                {
        //                    System.Diagnostics.Debug.WriteLine("image");
        //                    MemoryStream target = new MemoryStream();
        //                    file.InputStream.CopyTo(target);
        //                    byte[] image = target.ToArray();
        //                    post.PostImage = image;
        //                    db.tblPosts.Add(post);
        //                    db.SaveChanges();
        //                    return RedirectToAction("Index");
        //                }
        //                else
        //                {
        //                    return View(post);
        //                }
        //            }
        //        }
                
        //    }

        //    return View(post);
        //}
        // GET: Main1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPosts tblPosts = db.tblPosts.Find(id);
            if (tblPosts == null)
            {
                return HttpNotFound();
            }
            return View(tblPosts);
        }

        // GET: Main1/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

       

        // GET: Main1/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    tblPosts tblPosts = db.tblPosts.Find(id);
        //    if (tblPosts == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tblPosts);
        //}

        // POST: Main1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(tblPosts tblPosts)
        //{
        //    if (ModelState.IsValid)
        //    {



        //        if (tblPosts != null)
        //        {
        //            tblPosts post = new tblPosts();
        //            post = db.tblPosts.Find(tblPosts.PostID);
        //            post.PostText = tblPosts.PostText;
        //            post.PostTitel = tblPosts.PostTitel;

        //            HttpPostedFileBase file = Request.Files["txtAfbeelding"];
        //            if (file != null&&file.ContentLength>0)
        //            {
        //                MemoryStream target = new MemoryStream();
        //                file.InputStream.CopyTo(target);
        //                byte[] image = target.ToArray();
        //                post.PostImage = image;
        //                db.Entry(post).State = EntityState.Modified;
        //                db.SaveChanges();

        //                return RedirectToAction("Index","Main1");
        //            }
        //            else
        //            {
        //                db.Entry(post).State = EntityState.Modified;
        //                db.SaveChanges();
        //                return RedirectToAction("Index");
        //            }

        //        }
        //        else
        //        {
        //            return View(tblPosts);
        //        }




        //    }
        //    else
        //    {
        //        return View(tblPosts);
        //    }

        //}

        // GET: Main1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPosts tblPosts = db.tblPosts.Find(id);
            if (tblPosts == null)
            {
                return HttpNotFound();
            }
            return View(tblPosts);
        }

        // POST: Main1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblPosts tblPosts = db.tblPosts.Find(id);
            db.tblPosts.Remove(tblPosts);
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
