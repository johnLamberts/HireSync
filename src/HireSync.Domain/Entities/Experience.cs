
namespace HireSync.Domain.Entities.IdentiyUsers;

public class Experience
{

  #region properties

  public int Id { get; set; }
  public string Title { get; set; } = string.Empty;

  public string Location { get; set; } = string.Empty;

  public DateTime StartDate { get; set; }

  public DateTime EndDate { get; set; }

  public string Description { get; set; } = string.Empty;

  public bool isCurrent { get; set; }

  public DateTime CreatedAt { get; set; }

  public DateTime UpdatedAt { get; set; }

  #endregion


  #region navigation properties


  public int ApplicantId { get; set; }
  public Applicant? Applicant { get; set; }

  #endregion
}
