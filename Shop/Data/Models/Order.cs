namespace Shop.Data.Models
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Item name: ")]
        public string Item { get; set; }
        
        
        public string Orgin { get; set; } //произход

        [Required]
        [DisplayName("Brand Name: ")]
        public string Brand { get; set; } //производител

        [Required]
        [Range(0.01, 100)]
        public double Scale { get; set; }
    }
}
