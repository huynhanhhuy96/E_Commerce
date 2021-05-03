namespace EC.Core.Models
{
    public class ProductEntity
    {
        public ProductEntity(string title)
        {
            this.Title = title;
        }
        public string Id { get; set; }
        public string Title { get; set; }
    }
}