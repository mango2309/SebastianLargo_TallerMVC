using System.ComponentModel.DataAnnotations;

namespace SebastianLargo_TallerMVC.Models
{
    public class Burguer
    {
        public int Id { get; set; }

        public int BurgerID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }

        public int Salad1 { get; set; }
        public int Salad12{ get; set; }
    }
}
