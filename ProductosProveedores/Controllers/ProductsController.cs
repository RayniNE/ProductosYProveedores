using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductosProveedores.Models;

namespace ProductosProveedores.Controllers
{
    public class ProductsController : Controller
    {

       
        public IActionResult Agregar(Product p)
        {

            return View(p);
        }

        public ActionResult Eliminar(int id, GestorProducts gp)
        {
            Product producto = gp.ObtenerProducto(id);
            return View(producto);
        }
        //GET
        [HttpPost]
        public IActionResult Eliminar(int id )
        {
            GestorProducts gp = new GestorProducts();
            try
            {
                gp.EliminarProducto(id);
                return RedirectToAction(nameof(HomeController.ManageProduct));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Modificar(int id, GestorProducts gp)
        {
            Product producto = gp.ObtenerProducto(id);
            return View(producto);
        }


        [HttpPost]
        public ActionResult Modificar(int id, Product producto, GestorProducts gp)
        {
            try
            {

                gp.EditarProducto(id, producto);
                return RedirectToAction(nameof(HomeController.ManageProduct));
            }
            catch
            {
                return View(producto);
            }
        }
    }
}