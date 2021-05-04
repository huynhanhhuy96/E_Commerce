using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EC.Core.Models;
using EC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ProductsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Guid? Id { get; set; }

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
            if (Id.HasValue)
            {
                ProductEntity item = _productServices.GetProductEntitiesByID(Id.Value);
                Title = item.Title;
            }
        }
        public void OnPostSave()
        {
            if (_productServices.AddProduct(Title))
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
