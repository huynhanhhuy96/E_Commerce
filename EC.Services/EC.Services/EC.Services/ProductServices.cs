namespace EC.Services
{
    using System.Collections.Generic;
    using EC.Core.Models;
    using EC.Repo.Context;
    using System.Linq;
    using EC.Services.Interfaces;

    public class ProductServices : IProductServices
    {
        private ECContext _context;

        public ProductServices(ECContext context)
        {
            _context = context;
        }

        public bool AddProduct(string title)
        {
            var item = new ProductEntity(title: title);
            _context.Products.Add(item);
            _context.SaveChanges();

            return true;
        }
        
        public List<ProductEntity> GetProductEntities()
        {
            List<ProductEntity> lstProducts = _context.Products.OrderBy(p=>p.Title).ToList();
            return lstProducts;
        }
    }
}