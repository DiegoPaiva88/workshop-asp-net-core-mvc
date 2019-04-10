using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerServices _sellerService;

        public SellersController(SellerServices sellerServices)
        {
            _sellerService = sellerServices;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }


    }
}