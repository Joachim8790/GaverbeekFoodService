using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using De_Gaverbeek.ViewModels;
using System.Net.Mail;
using System.Net;
using De_Gaverbeek.Models;

namespace De_Gaverbeek.Controllers
{
    public class MainController : Controller
    {

        private DeGaverbeekEntities db = new DeGaverbeekEntities();
        // GET: Main
        public ActionResult Index()
        {
            IQueryable<tblPosts> sortedposts =
                from n in db.tblPosts
                 orderby n.PostDatum descending
                 select n;
            ViewBag.sortedPosts = sortedposts;
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(ContactViewModel vm)
        {

            if (ModelState.IsValid)
            {
                try
                {

                    var loginInfo = new NetworkCredential("contactformulierdegaverbeek@gmail.com", "Brauwvir1");
                    var msg = new MailMessage();
                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = loginInfo;
                    msg.From = new MailAddress("contactformulierdegaverbeek@gmail.com");
                    msg.To.Add(new MailAddress("joachim.verschelde@student.vives.be"));
                    msg.Subject = vm.Onderwerp;
                    msg.Body = "<h2>Nieuw bericht van " + vm.Naam + "</h2><br/> <b>Emailadres correspondent:</b> " + vm.Emailadres + "<br/><b>  Onderwerp: </b>" + vm.Onderwerp + "<br/><b> Verstuurd bericht: </b>" + vm.Bericht;
                    msg.IsBodyHtml = true;
                    client.Send(msg);
                    ModelState.Clear();
                    return RedirectToAction("Index","Main");
                }
                catch (Exception ex)
                {

                    return RedirectToAction("Index", "Main");
                }
            }
            else
            {
                return RedirectToAction("Index", "Main");
            }

            
        }
        
    }
}