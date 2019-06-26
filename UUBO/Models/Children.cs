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
    public string Name { get; set; }

    [Display(Name = "Date of Birth")]
    public DateTime DoB { get; set; }

    [Display(Name = "Exclude From Asset")]
    public bool ExcludeFromAsset { get; set; }

    [Display(Name = "Dependent Reason")]
    public string DependentReason { get; set; }
}
}
