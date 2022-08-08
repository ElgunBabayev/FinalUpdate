using actiuon.DAL;
using actiuon.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
    public class ProductManageController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly UserManager<AppUser> userManager;
        public ProductManageController( AppDbContext _dbContext, UserManager<AppUser> _userManager)
        {
            userManager = _userManager;
            dbContext = _dbContext;
        }
        public async Task<IActionResult> Index()
        {
            List<Product> products = await dbContext.Products.Include("AppUser").Include("Category").Include("Status").ToListAsync();
            
            return View(products);
        }

        public async Task<IActionResult> ChangeStatusConfirmed(int id)
        {
            Product prod = await dbContext.Products.FindAsync(id);
            
            prod.StatusId = 2;
            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "ProductManage");
        }
        public async Task<IActionResult> ChangeStatusDisabled(int id)
        {
            Product prod = await dbContext.Products.FindAsync(id);

            prod.StatusId = 3;
            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "ProductManage");
        }
        public async Task<IActionResult> Delete(int id)
        {
            Product prod = await dbContext.Products.FindAsync(id);
            dbContext.Products.Remove(prod);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "ProductManage");
        }

        //public async Task <IActionResult> ChangeStatus(string id)
        //{
        //    if (string.IsNullOrEmpty(id)) return RedirectToAction("Index", "ProductManage");
        //    Product product = await dbContext.FindByIdAsync(id);
        //}
    }
}
