using System.ComponentModel.DataAnnotations;

namespace MyCraftShop.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Item Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Required]
        [Display(Name = "Cost Per Item")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost per item must be greater than 0.")]
        public double CostPerItem { get; set; }

        [Display(Name = "Sales Price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Sales price must be a positive value.")]
        public double? SalesPrice { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        [Range(0, double.MaxValue, ErrorMessage = "Quantity must be 0 or greater.")]
        public double Quantity { get; set; }
    }
}
