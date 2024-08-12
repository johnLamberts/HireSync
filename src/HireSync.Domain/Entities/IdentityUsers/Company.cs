using HireSync.Domain.Entities.IdentiyUsers;

namespace HireSync.Domain.Entities.IdentityUsers;

public class Company : ApplicantUser
{

  public string Name { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  #region relationship
  
  public ICollection<Employer> Employers { get; set; } = [];

  public ICollection<CompanyJob> CompanyJobs { get; set; } = [];
  #endregion
}
