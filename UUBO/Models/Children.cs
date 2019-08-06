using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UUBO.Models
{
  public class Children
  {
    [Key]
    public string Id { get; set; }

    [Display(Name = "Name")]
    [Required]
    public string Name { get; set; }

    [Display(Name = "Date of Birth")]
    [Required]
    public DateTime DoB { get; set; }

    [Display(Name = "Exclude From Asset")]
    [Required]
    public bool ExcludeFromAsset { get; set; }

    [Display(Name = "Dependent Reason")]
    [Required]
    public string DependentReason { get; set; }
}
}
