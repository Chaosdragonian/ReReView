using System.Collections.Generic;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReReView.DAL
{
    public partial class RankandrecentViewModel
    {
        public IEnumerable<Restuarant> Rankrestuarants { get; set; }
        public IEnumerable<Review> Recentreviews { get; set; }
    }
}