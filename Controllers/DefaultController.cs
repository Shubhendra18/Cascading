using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication29.Models;
namespace WebApplication29.Controllers
{
    public class DefaultController : Controller
    {
        TravaliaDBContext da = new TravaliaDBContext();
        public ActionResult Index()
        {
            List<SelectListItem> stateNames = new List<SelectListItem>();
            TravaliaModel tmodel = new TravaliaModel();

            List<StateTable> states = da.StateTables.ToList();
            states.ForEach(x =>
            {
                stateNames.Add(new SelectListItem { Text = x.StateName, Value = x.Id.ToString() });
            });
            tmodel.State = stateNames;
            return View(tmodel);
        }
        [HttpPost]
        public ActionResult GetDistrict(string Id)
        {
            int sid;
            List<SelectListItem> districtNames = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(Id))
            {
                sid = Convert.ToInt32(Id);
                List<DistrictTable> districts = da.DistrictTables.Where(x => x.Sid == sid).ToList();
                districts.ForEach(x =>
                {
                    districtNames.Add(new SelectListItem { Text = x.DistrictName, Value = x.Id.ToString() });
                });
            }
            return Json(districtNames, JsonRequestBehavior.AllowGet);
        }
    }

}