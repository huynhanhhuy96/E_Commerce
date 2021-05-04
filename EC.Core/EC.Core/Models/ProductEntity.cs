using System;

namespace EC.Core.Models
{
    public class ProductEntity
    {
        public ProductEntity(string title)
        {
            this.Title = title;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}