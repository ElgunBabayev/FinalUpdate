using actiuon.DAL;
using actiuon.Models;
using actiuon.ViewModel;
using actiuon.Utils;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace actiuon.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext dbContext;

        private readonly UserManager<AppUser> userManager;
        private readonly IWebHostEnvironment env;

        public ProductController(AppDbContext db, UserManager<AppUser> _userManager, IWebHostEnvironment _env)
        {
            userManager = _userManager;
            env = _env;
            dbContext = db;
        }

        [Route("Products")]
        public IActionResult Index()
        {
            ProductCategoryViewModel pvm = new ProductCategoryViewModel
            {
                Categories = dbContext.Categories.ToList(),
                Products = dbContext.Products.Include("AppUser").Include("Category").Where(x=>x.StatusId==2).OrderBy(r => Guid.NewGuid()).Where(x => x.EndDate > DateTime.Now).Take(9).ToList()
            };
            return View(pvm);
        }

        [Authorize(Roles = "Member, Admin")]
        [Route("Product/{Id}")]
        public IActionResult Get(int Id)
        {
            return View(dbContext.Products.Include(x => x.Bids).Include(x => x.AppUser).FirstOrDefault(x => x.Id == Id));
        }


        [HttpPost]
        [Route("Product/AddBid")]
        public async Task<IActionResult> AddBid(int message, int prodId)
        {
            Bids bid = new Bids();
            bid.BidingTime = DateTime.Now;
            bid.Message = message;
            bid.UserPhoto = (await userManager.FindByNameAsync(User.Identity.Name)).ProfilePhoto;
            bid.AppUserId = (await userManager.FindByNameAsync(User.Identity.Name)).Id;
            bid.AppUserName = (await userManager.FindByNameAsync(User.Identity.Name)).UserName;
            bid.ProductId = prodId;
            //bid.StatusId = 4;

            await dbContext.AddAsync(bid);
           await  dbContext.SaveChangesAsync();
            return Redirect("/Product/"+prodId);
        }



        [HttpPost]
        [Route("Product/Add")]

        
        public async Task<IActionResult> Add(Product product)
        {

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!ModelState.IsValid) return View();

            if (product.ProdImg.IsImage())
            {
                if (!product.ProdImg.IsValidSize(500))
                {
                    ModelState.AddModelError("Image", "Fayl maksimum 500kb ola biler.");
                    return View();
                }

                product.Image = await product.ProdImg.Upload(env.WebRootPath, @"img\");
                product.AppUserId = (await userManager.FindByNameAsync(User.Identity.Name)).Id;
                product.StatusId = 1;
                await dbContext.Products.AddAsync(product);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Index", "MyDashboard");
            }
            return RedirectToAction("Index", "MyDashboard");

        }







    }
}
