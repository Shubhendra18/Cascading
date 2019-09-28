using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication29.Models
{
    public class TravaliaModel
    {
        public IList<SelectListItem> State { get; set; }
        public IList<SelectListItem> District { get; set; }
    }
}