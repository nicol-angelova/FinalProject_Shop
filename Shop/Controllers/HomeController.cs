namespace Shop.Controllers
{
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using Shop.Data.Models;
    using Shop.Data.Services;
    using Shop.Models;

    public class HomeController : Controller
    {
        private readonly IOrderService orderService;

        public HomeController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public IActionResult Index()
        {
            var orders = orderService.GetAll();

            return View(orders);
        }

        [HttpGet]
        [Route("Home/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = orderService.GetById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult SaveEdit(Order order)
        {
            orderService.Edit(order);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add([Required]string orderName, [Required]string brand)
        {
            if (ModelState.IsValid)
            {
                orderService.Add(orderName, brand);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
