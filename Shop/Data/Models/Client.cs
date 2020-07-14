namespace Shop.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Client
    {
        public Client()
        {
            Orders = new List<Order>();
        }

        public int Id { get; set; }

        [Required]
        public string BusinessName { get; set; }

        [Required]
        public string Issuer { get; set; } //МОЛ

        [Required]
        public string City { get; set; }

        [Required]
        [StringLength(9)]
        public int UIC { get; set; } //ЕИК

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}
