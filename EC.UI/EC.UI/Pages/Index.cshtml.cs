using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Core.Models;
using EC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EC.UI.Pages
{
    public class IndexModel : PageModel
    {
        // private readonly ILogger<IndexModel> _logger;

        // public IndexModel(ILogger<IndexModel> logger)
        // {
        //     _logger = logger;
        // }

        public List<ProductEntity> lst;
        private readonly IProductServices _productServices;
        public IndexModel(IProductServices productServices)
        {
            _productServices = productServices;
        }

        public void OnGet()
        {
            lst = _productServices.GetProductEntities();
        }
    }
}
