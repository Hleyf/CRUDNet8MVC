using System.ComponentModel.DataAnnotations;

namespace CRUDNet8MVC.Models
{
  public class Contact
  {
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage ="Name field is required")]
    public string Name { get; set; }
    
    [Required]
    public string Phone { get; set; }

    [Required]
    public string Email { get; set; }

    public DateTime createdAt { get; set; }
    }
}
