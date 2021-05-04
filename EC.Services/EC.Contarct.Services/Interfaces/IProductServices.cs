namespace EC.Services.Interfaces
{
    using System;
    using System.Collections.Generic;
    using EC.Core.Models;
    public interface IProductServices
    {
        bool AddProduct(string title);
        List<ProductEntity> GetProductEntities();
        ProductEntity GetProductEntitiesByID(Guid id);
    }
}