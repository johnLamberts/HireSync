using HireSync.Domain.Entities.IdentityUsers;

namespace HireSync.Domain.Entities;

public class CompanyJob
{
  #region relationships

  public int CompanyId { get; set; }  
  public Company? Company { get; set; }

  public int JobId { get; set; }
  public Job? Job { get; set; }

  public DateTime SetAt { get; set; } = DateTime.Now;
  public DateTime UpdatedAt { get; set; }

  #endregion relationships
}
