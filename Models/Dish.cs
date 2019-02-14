using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
  public class Dish
  {
    [Key]
    public int DishId{ get; set; }
    [Required]
    public string ChefName{ get; set; }
    [Required]
    public string DishName {get; set;}
    [Required]
    [Range(1, double.MaxValue, ErrorMessage = "Calories must be at least 1")]
    public int Calories{get; set;}
    [Required]
    public int Tastiness{get; set;}
    [Required]
    public string Desc{get; set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
    
  }
}