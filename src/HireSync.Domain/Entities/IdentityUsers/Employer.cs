using HireSync.Domain.Entities.IdentiyUsers;

namespace HireSync.Domain.Entities.IdentityUsers;

public class Employer : ApplicantUser
{
  #region properties

  public string FirstName { get; set; } = string.Empty;

  public string LastName { get; set; } = string.Empty;

  #endregion

  #region relationships

  public int CompanyId { get; set; }
  public Company? Company { get; set; }

  public ICollection<Job> Jobs { get; set; } = [];


  #endregion relationships
}
