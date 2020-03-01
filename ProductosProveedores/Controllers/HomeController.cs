using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductosProveedores.Models;
namespace ProductosProveedores.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ManageProduct(GestorProducts gp, Product p)
        {
            gp.AgregarProducto(p);
            return View(gp);
        }
        public IActionResult ManageProveedor(GestorProveedores gp, Proveedor p)
        {
            gp.AgregarProveedor(p);
            return View(gp);
        }
    }
}