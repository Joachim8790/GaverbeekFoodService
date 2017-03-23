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
            string[] zuurwebsites = { "http://gilco.eu/" };

            string[] zuivel = { "/Images/inex.png", "/Images/debic.png", "/Images/vermeersch.png", "/Images/olympia.png", "/Images/alpro.png" };
            string[] zuivelwebsites = { "http://www.inex.be/", "http://www.debic.com/", "http://www.lactispurnatur.be/", "http://www.olympiadairy.be/", "https://www.alpro.com/" };

            string[] vis = { "/Images/salminvest.png", "/Images/vanafish.png"};
            string[] viswebsites = { "http://www.salminvestgroup.be/", "http://vanafish.be/" };

            string[] kruiden = { "/Images/verstegen.png", "/Images/stop.png", "/Images/isfi.png", "/Images/apollo.png" };
            string[] kruidenwebsites = { "https://www.verstegen.eu/", "http://www.stopspices.be/", "http://www.isfi-spices.be/", "https://apollofood.nl/" };

            string[] deegwaren = { "/Images/dececco.png", "/Images/honig.png", "/Images/knorr.png", "/Images/barilla.png" };
            string[] deegwarenwebsites = { "http://www.dececco.it/", "http://www.honig.nl/", "http://www.knorr.be/", "http://www.barilla.be/" };

            string[] bakkerij = { "/Images/panesco.png", "/Images/vandemoortele.png", "/Images/pastridor.png", "/Images/dauphine.png", "/Images/pruve.png", "/Images/diversifoods.png" };
            string[] bakkerijwebsites = { "http://www.panescofood.com/", "http://www.vandemoortele.com/", "http://www.lantmannen-unibake.com/", "http://www.dauphinebakery.com/", "https://www.smildebakery.nl/", "http://www.diversifoods.com/" };

            string[] olie = { "/Images/aveno.png", "/Images/vandemoortele.png", "/Images/elisa.png" };
            string[] oliewebsites = { "http://aveno.be/", "http://www.vandemoortele.com/", "#" };

            string[] beleg = { "/Images/lecoubourg.png", "/Images/hamal.png", "/Images/vh.png" };
            string[] belegwebsites = { "http://www.lecobourg.be/", "http://www.hamalsignature.com/", "http://www.hamalsignature.com/" };
            string[] extratext = {""};

            string[][] photos = { zuur, zuivel, vis, kruiden, deegwaren, olie, bakkerij, beleg,zuurwebsites,zuivelwebsites,viswebsites,kruidenwebsites,deegwarenwebsites,oliewebsites,bakkerijwebsites,belegwebsites };
            ViewBag.photos = photos;
            return View();
        }
    }
}