using actiuon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace actiuon.Areas.Admin.Models
{
    public class DashboardViewModel
    {
        public int UserCount{ get; set; }
        public int PendingCount { get; set; }
        public List<Product> Products { get; set; }
    }
}
