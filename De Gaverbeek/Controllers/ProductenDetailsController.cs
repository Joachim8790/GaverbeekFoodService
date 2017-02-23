using System.Collections;
using System.Web.Mvc;


namespace De_Gaverbeek.Controllers
{
    public class ProductenDetailsController : Controller
    {
        // GET: ProductenDetails

        public ActionResult Index(int id)
        {
            ViewBag.ID = id;
            if (id == 0)
            {
                id = 1;
            }

            string[] zuur = {"/Images/gilco.png"}; ;
            string[] zuivel = { "/Images/inex.png", "/Images/debic.png", "/Images/vermeersch.png", "/Images/olympia.png", "/Images/alpro.png" };
            string[] vis = { "/Images/salminvest.png", "/Images/vanafish.png"};
            string[] kruiden = { "/Images/verstegen.png","/Images/stop.png","/Images/isfi.png","/Images/apollo.png" };
            string[] deegwaren = { "/Images/dececco.png", "/Images/honig.png", "/Images/knorr.png", "/Images/barilla.png" };
            string[] bakkerij = { "/Images/panesco.png", "/Images/vandemoortele.png", "/Images/pastridor.png", "/Images/dauphine.png", "/Images/pruve.png", "/Images/diversifoods.png" };
            string[] olie = { "/Images/aveno.png", "/Images/vandemoortele.png", "/Images/elisa.png" };
            string[] beleg = { "/Images/lecoubourg.png", "/Images/hamal.png", "/Images/vh.png" };
            string[] extratext = {""};
            string[][] photos = { zuur, zuivel, vis, kruiden, deegwaren, olie, bakkerij, beleg };
            ViewBag.photos = photos;
            return View();
        }
    }
}