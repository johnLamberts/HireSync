using HireSync.Domain.Entities.IdentiyUsers;

namespace HireSync.Domain.Entities;

public class Resume
{

  #region properties

  public int Id { get; set; }

  public byte[] Content { get; set;} = [];

  public string Extension { get; set; } = string.Empty;

  public string FileName { get; set; } = string.Empty;
  
  #endregion properties


  #region relationships

  public int ApplicationId { get; set; }

  public Applicant? Applicant { get; set; }

  #endregion relationships
}
