using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UUBO.Models
{
  public class Beneficiary
  {
    public string Id { get; set; }

    [Display(Name = "Full Name")]
    [Required]
    public string FullName { get; set; }


    [Display(Name = "Address")]
    [Required]
    public string Address { get; set; }

    [Required]
    [Display(Name = "Relationship")]
    public Enum Relationship { get; set; }

    [Required]
    [Display(Name = "Phone")]
    public string Phone { get; set; }


    public virtual Will WillId { get; set; }
  }
}
