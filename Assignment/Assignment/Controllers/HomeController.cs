using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly QLCuaHangContext _context;
        public HomeController(QLCuaHangContext context, IHostingEnvironment env)
        {
            _context = context;
            this.hostingEnvironment = env;
        }
        //index
        public async Task<IActionResult> Index()
        {
            var qLCuaHangContext = _context.Sanpham.Include(s => s.MaLoaiNavigation);
            return View(await qLCuaHangContext.ToListAsync());
        }
        public async Task<IActionResult> Men()
        {
            return View(await _context.Sanpham.Where(x => x.MaLoai == "B01").ToListAsync());
        }
        public async Task<IActionResult> Women()
        {
            return View(await _context.Sanpham.Where(x => x.MaLoai == "B02").ToListAsync());
        }
        //details
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Sanpham.Where(x => x.MaSp.Equals(id)).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            var other = _context.Sanpham.Where(x => x.MaSp != id).ToList();
            ViewBag.Other = other;
            return View(product);
        }
        //dang ky
        public IActionResult Regis()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Regis(Quanly user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(user);
        }
        //dang nhap
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Quanly user)
        {
            if (ModelState.IsValid)
            {
                using (_context)
                {
                    var obj = _context.Quanly.Where(x => x.UserName.Equals(user.UserName) && x.Pass.Equals(user.Pass)).FirstOrDefault();
                    if (obj != null)
                    {
                        HttpContext.Session.SetString("TK", obj.UserName.ToString());
                        HttpContext.Session.SetString("MK", obj.Pass.ToString());
                        return RedirectToAction("CheckLog");
                    }
                }
            }
            return View(user);
        }
        public IActionResult CheckLog()
        {
            if (HttpContext.Session.GetString("TK") != null)
            {
                return RedirectToAction("Users");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        //gio hang
        public IActionResult Cart()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(sp => sp.sanPham.Gia * sp.soLuong);
            return View();
        }
        // mua hang
        public IActionResult Buy(string id)
        {
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { sanPham = Find(id), soLuong = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].soLuong++;
                }
                else
                {
                    cart.Add(new Item { sanPham = Find(id), soLuong = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Cart");
        }
        // xoa hang
        public IActionResult Remove(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Cart");
        }
        //method
        public Sanpham Find(string id)
        {
            var sp = _context.Sanpham.Find(id);
            return sp;
        }
        private int isExist(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].sanPham.MaSp.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        //user
        public IActionResult Users()
        {
            return View();
        }
        //product
        public IActionResult CreateProducts()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProducts([Bind("MaSp,TenSp,MaLoai,Gia,GiamGia,NgayNhap,Hinh,ImageFile")] Sanpham sp)
        {
            string rootpath = hostingEnvironment.WebRootPath;
            string filename = Path.GetFileName(sp.ImageFile.FileName);
            sp.Hinh = "/Images/" + filename ;
            string path = Path.Combine(rootpath + "/Images/" + filename);
            using (var fs = new FileStream(path, FileMode.Create))
            {
                await sp.ImageFile.CopyToAsync(fs);
            }

            if (ModelState.IsValid)
            {
                _context.Add(sp);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListProducts");
            }
            return View(sp);
        }
        public async Task<IActionResult> ListProducts()
        {
            return View(await _context.Sanpham.ToListAsync());
        }
        public async Task<IActionResult> EditProducts(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Sanpham.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            return View(products);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProducts(string id, [Bind("MaSp,TenSp,MaLoai,Gia,GiamGia,NgayNhap,Hinh,ImageFile")] Sanpham products)
        {
            if (id != products.MaSp)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.MaSp))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ListProducts");
            }
            return View(products);
        }
        private bool ProductsExists(string id)
        {
            return _context.Sanpham.Any(e => e.MaSp == id);
        }
        public async Task<IActionResult> DeleteProducts(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Sanpham.FirstOrDefaultAsync(m => m.MaSp == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("DeleteProducts")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var products = await _context.Sanpham.FindAsync(id);
            _context.Sanpham.Remove(products);
            await _context.SaveChangesAsync();
            return RedirectToAction("ListProducts");
        }
    }
}
