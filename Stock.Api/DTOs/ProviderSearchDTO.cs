namespace Stock.Api.DTOs
{
    public class ProviderSearchDTO
    {
        public string Name { get; set; }
        
        public string Phone { get; set; }

        public string Email { get; set; }

        public ActionDto Condition { get; set; }

        //public List<Product> OfferedProducts { get; set; }
    }
}