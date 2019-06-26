using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UUBO.Models
{
  public class Will
  { 
    [Display (Name = "Testator's Full Name")]
    public string TestFullName { get; set; }

    [Display(Name = "Testator's Address")]
    public string TestAddress { get; set; }

    [Display(Name = "Testator's Phone Number")]
    public string TestPhone { get; set; }

    [Display(Name = "Testator's Home Phone")]
    public string TestHomePhone { get; set; }

    [Display(Name = "Testator's Office Phone")]
    public string TestOffice { get; set; }

    [Display(Name = "Testator's Domicile")]
    public string TestDomicile { get; set; }

    [Display(Name = "Testator's Gender")]
    public Gender TestGender { get; set; }

    [Display(Name = "Testator's Marital Status")]
    public MaritalStatus MaritalStatus { get; set; }

    [Display(Name = "Testator's Number of Children")]
    public int NumChildren { get; set; }

    [Display(Name = "Primary Executor's Name")]
    public string PrimExecName { get; set; }

    [Display(Name = "Primary Executor's Address")]
    public string PrimExecAdd { get; set; }

    [Display(Name = "Primary Executor's Occupation")]
    public string PrimExecOcc { get; set; }

    [Display(Name = "Primary Executor's Phone No")]
    public string PrimExecPhone { get; set; }

    [Display(Name = "Primary Executor's Relationship")]
    public string PrimExecRel { get; set; }

    [Display(Name = "Secondary Executor's Name")]
    public string SecExecName { get; set; }

    [Display(Name = "Secondary Executor's Address")]
    public string SecExecAdd { get; set; }

    [Display(Name = "Secondary Executor's Occupation")]
    public string SecExecOcc { get; set; }

    [Display(Name = "Secondary Executor's Phone No")]
    public string SecExecPhone { get; set; }

    [Display(Name = "Secondary Executor's Relationship")]
    public string SecExecRel { get; set; }

    [Display(Name = "Charging Clause")]
    public bool ChargeClause { get; set; }

    [Display(Name = "Burial/Cremation")]
    public bool Burial { get; set; }

    [Display(Name = "Special Instruction")]
    public string SpecInstruction { get; set; }
    public virtual Children Child { get; set; }
    public virtual Guardian Guard { get; set; }
    public virtual Beneficiary Ben { get; set; }

    [Display(Name = "Details")]
    public string AssetDetails { get; set; }

    [Display(Name = "Beneficiary")]
    public bool AssetBeneficiary { get; set; }

    [Display(Name = "Details")]
    public string SubDetails { get; set; }

    [Display(Name = "Beneficiary")]
    public bool SubBen { get; set; }

    [Display(Name = "Will deposited at/sent to")]
    public string WillAdd { get; set; }

    [Display(Name = "Copy deposited at/sent to")]
    public string WillAddCopy { get; set; }
  }
}
