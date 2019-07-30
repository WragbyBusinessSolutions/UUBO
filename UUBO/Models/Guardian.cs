using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UUBO.Models
{
  public class Guardian
  {
    public string Id { get; set; }
    public virtual Will WillId { get; set; }

    [Display(Name = "Name")]
    [Required]
    public string Name { get; set; }


    [Display(Name = "Address")]
    [Required]
    public string Address { get; set; }


    [Display(Name = "Email")]
    [Required]
    public string Email { get; set; }


    [Display(Name = "Relationship")]
    [Required]
    public Enum Relationship { get; set; }
  }
}
