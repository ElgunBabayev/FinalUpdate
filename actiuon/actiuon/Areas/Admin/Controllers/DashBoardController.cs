using actiuon.Areas.Admin.Models;
using actiuon.Controllers;
using actiuon.DAL;
using actiuon.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace actiuon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DashBoardController : Controller
    {
        private readonly AppDbContext dbContext;
        

        public DashBoardController(AppDbContext db) => dbContext = db;
        public async Task<IActionResult> Index()
        {
            DashboardViewModel dvm = new DashboardViewModel();
            dvm.UserCount = await dbContext.Users.CountAsync();
            dvm.PendingCount = await dbContext.Products.Where(x => x.StatusId == 1).CountAsync();

            return View(dvm);
        }

        
    }
}
