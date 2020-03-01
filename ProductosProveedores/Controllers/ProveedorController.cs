using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductosProveedores.Models;

namespace ProductosProveedores.Controllers
{
    public class ProveedorController : Controller
    {
        public IActionResult Agregar(Proveedor p)
        {

            return View(p);
        }

        public ActionResult Eliminar(int id, GestorProveedores gp)
        {
            Proveedor proveedor = gp.ObtenerProveedor(id);
            return View(proveedor);
        }
        //GET
        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            GestorProveedores gp = new GestorProveedores();
            try
            {
                gp.EliminarProveedor(id);
                return RedirectToAction(nameof(HomeController.ManageProduct));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Modificar(int id, GestorProveedores gp)
        {
            Proveedor proveedor = gp.ObtenerProveedor(id);
            return View(proveedor);
        }


        [HttpPost]
        public ActionResult Modificar(int id, Proveedor proveedor, GestorProveedores gp)
        {
            try
            {

                gp.EditarProveedor(id, proveedor);
                return RedirectToAction(nameof(HomeController.ManageProduct));
            }
            catch
            {
                return View(proveedor);
            }
        }
    }
}