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
using System.Drawing;


namespace De_Gaverbeek.Controllers
{
    public class Main1Controller : Controller
    {
        private DeGaverbeekDatabaseEntities1 db = new DeGaverbeekDatabaseEntities1();

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
        public ActionResult IndexPost()
        {
            tblPosts post = new tblPosts();
            if (ModelState.IsValid)
            {

                post.PostDatum = DateTime.Now;


                HttpPostedFileBase file = Request.Files["txtAfbeelding"];
                if (file.FileName.ToLower().EndsWith(".pptx"))
                {
                    System.Diagnostics.Debug.WriteLine("pptx");
                    //if (file != null && file.ContentLength > 0)
                    //{
                    //    using (var fileStream = File.Create(""))
                    //    {
                    //        myOtherObject.InputStream.Seek(0, SeekOrigin.Begin);
                    //        myOtherObject.InputStream.CopyTo(fileStream);
                    //    }

                    //    Application pptxApplication = new Application();
                    //    Presentation pptxPresentation = 

                    //    //    MemoryStream target = new MemoryStream();
                    //    //    file.InputStream.CopyTo(target);
                    //    //    byte[] image = target.ToArray();
                    //    //    tblPosts.PostImage = image;
                    //    //    db.tblPosts.Add(tblPosts);
                    //    //    db.SaveChanges();
                    //    //    return RedirectToAction("Index");
                    //}
                    //else
                    //{
                    //    return View(post);
                    //}
                    return RedirectToAction("Index");

                }
                else
                {
                    if (file.FileName.ToLower().EndsWith(".pdf"))
                    {
                        System.Diagnostics.Debug.WriteLine("pdf");
                        //try
                        //{
                        PdfCommon.Initialize();
                            using (var doc = PdfDocument.Load(file.InputStream))
                            {

                                foreach (var page in doc.Pages)
                                {
                                System.Diagnostics.Debug.WriteLine("test");
                                    int width = (int)page.Width;
                                    int height = (int)page.Height;

                                    using (var bmp = new PdfBitmap(width, height, true))
                                    {
                                        bmp.FillRect(0, 0, width, height, System.Drawing.Color.White);
                                        page.Render(bmp, 0, 0, width, height, Patagames.Pdf.Enums.PageRotate.Normal, Patagames.Pdf.Enums.RenderFlags.FPDF_ANNOT);
                                        using (var stream = new MemoryStream())
                                        {
                                            bmp.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                                            byte[] image = stream.ToArray();
                                            post.PostImage = image;
                                            db.tblPosts.Add(post);
                                            db.SaveChanges();


                                    }

                                    }
                                }

                            return RedirectToAction("Index");
                        }
                            //MemoryStream target = new MemoryStream();
                            //file.InputStream.CopyTo(target);
                            //byte[] pdfbytes = target.ToArray();
                            //var document = PdfDocument.Load(pdfbytes);



                        //}
                        //catch (Exception ex)
                        //{

                        //}
                        //if (file != null && file.ContentLength > 0)
                        //{

                        //    MemoryStream target = new MemoryStream();
                        //    file.InputStream.CopyTo(target);
                        //    byte[] image = target.ToArray();
                        //    tblPosts.PostImage = image;
                        //    db.tblPosts.Add(tblPosts);
                        //    db.SaveChanges();
                        //    return RedirectToAction("Index");
                        //}
                        //else
                        //{
                        //    return View(tblPosts);
                        //}
                    }
                    else
                    {
                            if (file != null && file.ContentLength > 0)
                            {
                                System.Diagnostics.Debug.WriteLine("image");
                                MemoryStream target = new MemoryStream();
                                file.InputStream.CopyTo(target);
                                byte[] image = target.ToArray();
                                post.PostImage = image;
                                db.tblPosts.Add(post);
                                db.SaveChanges();
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                return View(post);
                            }
                        }
                    }

                }

                return View(post);
            }
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
