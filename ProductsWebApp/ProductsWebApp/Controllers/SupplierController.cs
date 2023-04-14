using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsWebApp.Models;
using System;

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
        [HttpPost]
        public ActionResult CreateNew()
        {
            string supId = Request.Form["txtID"].ToString();
            string name = Request.Form["txtName"].ToString();
            string phone = Request.Form["txtPhone"].ToString();
            string usernamne = Request.Form["txtUsername"].ToString();
            string pass = Request.Form["txtPass"].ToString();

            Supplier ss = new Supplier(supId, name, phone);
            ss.Username = usernamne;
            ss.Password = pass;
            supplierList.Add(ss);

            return View("AllSuppliers",supplierList);
        }

        // POST: SupplierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            string supID = collection["txtID"].ToString();
            string name = collection["txtName"].ToString();
            string phone = collection["txtPhone"].ToString();
            string usernamne = collection["txtUsername"].ToString();
            string pass = collection["txtPass"].ToString();

            Supplier ss = new Supplier(supID, name, phone);
            ss.Username = usernamne;
            ss.Password = pass;
            supplierList.Add(ss);

            return View("AllSuppliers", supplierList);

        }

        // GET: SupplierController/Edit/5
        public ActionResult Edit(string? id)
        {
            /*we need to find the supplier with the matching id from 
             * the list and send the found object to the view*/
           
            var st = supplierList.Find(s => s.SupplierID.Equals(id));

            return View(st);
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
