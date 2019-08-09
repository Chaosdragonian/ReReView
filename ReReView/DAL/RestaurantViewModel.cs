using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReReView.DAL
{
    public class RestaurantViewModel
    {
        public IEnumerable<string> SelectedClass { get; set; }
        public IEnumerable<SelectListItem> restaurants { get; set; }
    }
}