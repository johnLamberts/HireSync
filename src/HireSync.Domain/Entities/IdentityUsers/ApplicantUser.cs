
using Microsoft.AspNetCore.Identity;

namespace HireSync.Domain.Entities.IdentiyUsers;

public class ApplicantUser : IdentityUser<int>
{

  #region Properties

  public string Address { get; set; } = string.Empty;

  public string City { get; set; } = string.Empty;

  public string Country {get; set; } = string.Empty;

  public string ZipCode { get; set; } = string.Empty;

  #endregion

}

