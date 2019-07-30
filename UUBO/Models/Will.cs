using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UUBO.Models
{
  public class Will
  {

    [Key]
    public string WillId { get; set; }
    //[Display(Name = "Will Name")]
    //public string WillOwner { get; set; }


    [Display(Name = "Testator's Full Name")]
    [Required]
    public string TestFullName { get; set; }

    [Display(Name = "Testator's Address")]
    [Required]
    public string TestAddress { get; set; }

    [Display(Name = "Testator's Phone Number")]
    [Required]
    public string TestPhone { get; set; }

    [Display(Name = "Testator's Home Phone")]
    [Required]
    public string TestHomePhone { get; set; }

    [Display(Name = "Testator's Office Phone")]
    [Required]
    public string TestOffice { get; set; }

    [Display(Name = "Testator's Domicile")]
    [Required]
    public string TestDomicile { get; set; }

    [Display(Name = "Testator's Gender")]
    [Required]
    public Gender TestGender { get; set; }

    [Display(Name = "Testator's Marital Status")]
    [Required]
    public MaritalStatus MaritalStatus { get; set; }

    [Display(Name = "Testator's Number of Children")]
    [Required]
    public int NumChildren { get; set; }

    [Display(Name = "Primary Executor's Name")]
    [Required]
    public string PrimExecName { get; set; }

    [Display(Name = "Primary Executor's Address")]
    [Required]
    public string PrimExecAdd { get; set; }

    [Display(Name = "Primary Executor's Occupation")]
    [Required]
    public string PrimExecOcc { get; set; }

    [Display(Name = "Primary Executor's Phone No")]
    [Required]
    public string PrimExecPhone { get; set; }

    [Display(Name = "Primary Executor's Relationship")]
    [Required]
    public string PrimExecRel { get; set; }

    [Display(Name = "Secondary Executor's Name")]
    [Required]
    public string SecExecName { get; set; }

    [Display(Name = "Secondary Executor's Address")]
    [Required]
    public string SecExecAdd { get; set; }

    [Display(Name = "Secondary Executor's Occupation")]
    [Required]
    public string SecExecOcc { get; set; }

    [Display(Name = "Secondary Executor's Phone No")]
    [Required]
    public string SecExecPhone { get; set; }

    [Display(Name = "Secondary Executor's Relationship")]
    [Required]
    public string SecExecRel { get; set; }

    [Display(Name = "Charging Clause")]
    [Required]
    public bool ChargeClause { get; set; }

    [Display(Name = "Burial/Cremation")]
    [Required]
    public bool Burial { get; set; }

    [Display(Name = "Special Instruction")]
    [Required]
    public string SpecInstruction { get; set; }
    public virtual Children Child { get; set; }
    public virtual Guardian Guard { get; set; }
    public virtual Beneficiary Ben { get; set; }

    [Display(Name = "Details")]
    [Required]
    public string AssetDetails { get; set; }

    [Display(Name = "Beneficiary")]
    [Required]
    public bool AssetBeneficiary { get; set; }

    [Display(Name = "Details")]
    [Required]
    public string SubDetails { get; set; }

    [Display(Name = "Beneficiary")]
    [Required]
    public bool SubBen { get; set; }

    [Display(Name = "Will deposited at/sent to")]
    [Required]
    public string WillAdd { get; set; }

    [Display(Name = "Copy deposited at/sent to")]
    [Required]
    public string WillAddCopy { get; set; }
  }
}
  

