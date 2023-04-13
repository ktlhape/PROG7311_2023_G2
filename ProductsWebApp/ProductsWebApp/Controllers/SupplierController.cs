using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsWebApp.Models;

namespace ProductsWebApp.Controllers
{
    public class SupplierController : Controller
    {
        List<Supplier> supplierList = new List<Supplier>();
        public SupplierController()
        {
            Populate();
        }
        public void Populate()
        {
            supplierList.Add(new Supplier("S123", "Pepkor", "0145698484"));
            supplierList.Add(new Supplier("S246", "Clover", "0114587499"));
            supplierList.Add(new Supplier("S369", "Coca Cola", "0125937484"));
            supplierList.Add(new Supplier("S789", "Momentum", "0112348985"));
        }
        // GET: SupplierController
        public ActionResult AllSuppliers()
        {
            return View(supplierList);
        }
        public ActionResult Sup()
        {
            return RedirectToAction("AllSuppliers");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VerifyLogin() 
        {
            string username = Request.Form["txtUsername"].ToString();
            string pass = Request.Form["txtPass"].ToString();

            Supplier sp = new Supplier("KabeloT","pass.123");

            if (username.Equals(sp.Username) && 
                pass.Equals(sp.Password))
            {
                return RedirectToAction("AllSuppliers");
            }
            else
            {
                return View("Login");
            }


        
        }

        // GET: SupplierController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SupplierController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SupplierController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SupplierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SupplierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
