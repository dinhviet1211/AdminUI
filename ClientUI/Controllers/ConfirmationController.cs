using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientUI.Controllers
{
    public class ConfirmationController : Controller
    {
        // GET: ConfirmationController
        [Route("/confirmation")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConfirmationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConfirmationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfirmationController/Create
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

        // GET: ConfirmationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConfirmationController/Edit/5
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

        // GET: ConfirmationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConfirmationController/Delete/5
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
