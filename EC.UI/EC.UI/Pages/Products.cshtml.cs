using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ProductsModel : PageModel
    {
        [BindProperty]
        public string Title { get; set; }

        public string ThongBao;
        
        private readonly IProductServices _productServices;
        public ProductsModel(IProductServices productServices)
        {
            _productServices = productServices;
        }
        public void OnGet()
        {
        }
        public void OnPostSave()
        {
            if(_productServices.AddProduct(Title))
            {
                ThongBao = $"Thành công: {Title}";
            }
            else
            {
                ThongBao = "Thất Bại";
            }
        }
    }
}
