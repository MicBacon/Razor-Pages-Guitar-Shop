using System.ComponentModel.DataAnnotations;

namespace RazorPagesGuitarShop.Models;

public class Guitar
{
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;
    
    [DataType(DataType.Date)]
    public DateTime ManufactureDate { get; set; }

    public string Type { get; set; } = string.Empty;
    public decimal Price { get; set; }
}