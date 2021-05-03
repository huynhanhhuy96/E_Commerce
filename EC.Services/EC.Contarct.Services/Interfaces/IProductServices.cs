namespace EC.Services.Interfaces
{
    using System.Collections.Generic;
    using EC.Core.Models;
    public interface IProductServices
    {
        bool AddProduct(string title);
        List<ProductEntity> GetProductEntities();
    }
}