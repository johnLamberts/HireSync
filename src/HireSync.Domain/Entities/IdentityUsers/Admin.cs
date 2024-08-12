using HireSync.Domain.Entities.IdentiyUsers;

namespace HireSync.Domain.Entities.IdentityUsers;

public class Admin : ApplicantUser
{
  
  #region properties

  public string FirstName { get; set; } = string.Empty;

  public string LastName { get; set; } = string.Empty;

  #endregion
}
