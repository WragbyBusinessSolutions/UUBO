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
    public string Name { get; set; }

    [Display(Name = "Address")]
    public string Address { get; set; }

    [Display(Name = "Email")]
    public string Email { get; set; }

    [Display(Name = "Relationship")]
    public Enum Relationship { get; set; }
  }
}
